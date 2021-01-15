using System;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace FormEx
{
	public class DockWindow : NativeWindow
	{
		private static Dictionary<IntPtr, Form> GlobalStickyWindows = new Dictionary<IntPtr, Form>();

		#region ResizeDir
		private enum ResizeDir
		{
			Top = 2,
			Bottom = 4,
			Left = 8,
			Right = 16
		};
		#endregion

		#region Message Processor
		// Internal Message Processor
		private delegate bool ProcessMessage(ref Message m);
		private ProcessMessage MessageProcessor;

		// Messages processors based on type
		private ProcessMessage DefaultMessageProcessor;
		private ProcessMessage MoveMessageProcessor;
		private ProcessMessage ResizeMessageProcessor;
		#endregion

		#region Internal properties
		// Move stuff
		private bool movingForm;
		private Point formOffsetPoint;	// calculated offset rect to be added !! (min distances in all directions!!)
		private Point offsetPoint;		// primary offset

		// Resize stuff
		private bool resizingForm;
		private ResizeDir resizeDirection;
		private Rectangle formOffsetRect;		// calculated rect to fix the size
		private Point mousePoint;			// mouse position

		// General Stuff
		private Form originalForm;		// the form
		private Rectangle formRect;			// form bounds
		private Rectangle formOriginalRect;	// bounds before last operation started
		#endregion

		// public properties
		private static int stickGap = 20;		// distance to stick
		private bool stickOnResize;
		private bool stickOnMove;
		private bool stickToScreen;
		private bool stickToOther;

		#region Public operations and properties

		/// <summary>
		/// Distance in pixels betwen two forms or a form and the screen where the sticking should start
		/// Default value = 20
		/// </summary>
		public int StickGap
		{
			get { return stickGap; }
			set { stickGap = value; }
		}
		/// <summary>
		/// Allow the form to stick while resizing
		/// Default value = true
		/// </summary>
		public bool StickOnResize
		{
			get { return stickOnResize; }
			set { stickOnResize = value; }
		}
		/// <summary>
		/// Allow the form to stick while moving
		/// Default value = true
		/// </summary>
		public bool StickOnMove
		{
			get { return stickOnMove; }
			set { stickOnMove = value; }
		}
		/// <summary>
		/// Allow sticking to Screen Margins
		/// Default value = true
		/// </summary>
		public bool StickToScreen
		{
			get { return stickToScreen; }
			set { stickToScreen = value; }
		}
		/// <summary>
		/// Allow sticking to other StickWindows
		/// Default value = true
		/// </summary>
		public bool StickToOther
		{
			get { return stickToOther; }
			set { stickToOther = value; }
		}

		/// <summary>
		/// Register a new form as an external reference form.
		/// All Sticky windows will try to stick to the external references
		/// Use this to register your MainFrame so the child windows try to stick to it, when your MainFrame is NOT a sticky window
		/// </summary>
		/// <param name="frmExternal">External window that will be used as reference</param>
		public static void RegisterExternalReferenceForm(Form frmExternal)
		{
			if (!GlobalStickyWindows.ContainsKey(frmExternal.Handle))
			{
				GlobalStickyWindows.Add(frmExternal.Handle, frmExternal);
			}
		}
		/// <summary>
		/// Unregister a form from the external references.
		/// <see cref="RegisterExternalReferenceForm"/>
		/// </summary>
		/// <param name="frmExternal">External window that will was used as reference</param>
		public static void UnregisterExternalReferenceForm(Form frmExternal)
		{
			GlobalStickyWindows.Remove(frmExternal.Handle);
		}

		#endregion

		#region StickyWindow Constructor
		/// <summary>
		/// Make the form Sticky
		/// </summary>
		/// <param name="form">Form to be made sticky</param>
		public DockWindow(Form form)
		{
			resizingForm = false;
			movingForm = false;

			originalForm = form;

			formRect = Rectangle.Empty;
			formOffsetRect = Rectangle.Empty;

			formOffsetPoint = Point.Empty;
			offsetPoint = Point.Empty;
			mousePoint = Point.Empty;

			stickOnMove = true;
			stickOnResize = true;
			stickToScreen = true;
			stickToOther = true;

			DefaultMessageProcessor = new ProcessMessage(DefaultMsgProcessor);
			MoveMessageProcessor = new ProcessMessage(MoveMsgProcessor);
			ResizeMessageProcessor = new ProcessMessage(ResizeMsgProcessor);
			MessageProcessor = DefaultMessageProcessor;

			AssignHandle(originalForm.Handle);
		}
		#endregion

		#region OnHandleChange
		[System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
		protected override void OnHandleChange()
		{
			if ((int)this.Handle != 0)
			{
				if (!GlobalStickyWindows.ContainsKey(this.Handle))
				{
					GlobalStickyWindows.Add(this.Handle, this.originalForm);
				}
			}
			else
			{
				GlobalStickyWindows.Remove(this.Handle);
			}
		}
		#endregion

		#region WndProc

		[System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
		protected override void WndProc(ref Message m)
		{
			if (!MessageProcessor(ref m))
				base.WndProc(ref m);
		}

		#endregion

		#region DefaultMsgProcessor
		private bool DefaultMsgProcessor(ref Message m)
		{
			//Debug.Print(m.Msg + ": " + m.ToString());
			switch (m.Msg)
			{
				case DockWindowHelper.WM.WM_NCLBUTTONDOWN:
					{
						originalForm.Activate();
						mousePoint.X = (short)DockWindowHelper.Bit.LoWord((int)m.LParam);
						mousePoint.Y = (short)DockWindowHelper.Bit.HiWord((int)m.LParam);
						if (OnNCLButtonDown((int)m.WParam, mousePoint))
						{
							//m.Result = new IntPtr ( (resizingForm || movingForm) ? 1 : 0 );
							m.Result = (IntPtr)((resizingForm || movingForm) ? 1 : 0);
							return true;
						}
						break;
					}
				case DockWindowHelper.WM.WM_LBUTTONDOWN:
					{
						//System.Diagnostics.Debug.Print("WM_LBUTTONDOWN");

						if (!originalForm.ControlBox && originalForm.Text == "")
						{
							originalForm.Activate();
							DockWindowHelper.ReleaseCapture();
							DockWindowHelper.SendMessage(Handle, DockWindowHelper.WM.WM_NCLBUTTONDOWN, DockWindowHelper.WM.WM_HTCAPTION, (int)m.LParam);
						}
						break;
					}
				case DockWindowHelper.WM.WM_MOUSEMOVE:
					{
						originalForm.Activate();
						break;
					}
			}

			return false;
		}

		#endregion

		#region OnNCLButtonDown

		private bool OnNCLButtonDown(int iHitTest, Point point)
		{
			Rectangle rParent = originalForm.Bounds;
			offsetPoint = point;

			switch (iHitTest)
			{
				case DockWindowHelper.HT.HTCAPTION:
					// request for move
					if (stickOnMove)
					{
						if (originalForm.ControlBox || originalForm.Text != "")
						{
							offsetPoint.Offset(-rParent.Left, -rParent.Top);
						}
						StartMove();
						return true;
					}
					else
					{
						return false;	// leave default processing
					}
				// requests for resize
				case DockWindowHelper.HT.HTTOPLEFT:
					return StartResize(ResizeDir.Top | ResizeDir.Left);
				case DockWindowHelper.HT.HTTOP:
					return StartResize(ResizeDir.Top);
				case DockWindowHelper.HT.HTTOPRIGHT:
					return StartResize(ResizeDir.Top | ResizeDir.Right);
				case DockWindowHelper.HT.HTRIGHT:
					return StartResize(ResizeDir.Right);
				case DockWindowHelper.HT.HTBOTTOMRIGHT:
					return StartResize(ResizeDir.Bottom | ResizeDir.Right);
				case DockWindowHelper.HT.HTBOTTOM:
					return StartResize(ResizeDir.Bottom);
				case DockWindowHelper.HT.HTBOTTOMLEFT:
					return StartResize(ResizeDir.Bottom | ResizeDir.Left);
				case DockWindowHelper.HT.HTLEFT:
					return StartResize(ResizeDir.Left);
			}

			return false;
		}

		#endregion

		#region ResizeOperations
		private bool StartResize(ResizeDir resDir)
		{
			if (stickOnResize)
			{
				resizeDirection = resDir;
				formRect = originalForm.Bounds;
				formOriginalRect = originalForm.Bounds;	// save the old bounds

				if (!originalForm.Capture)	// start capturing messages
					originalForm.Capture = true;

				MessageProcessor = ResizeMessageProcessor;

				return true;	// catch the message
			}
			else
				return false;	// leave default processing !
		}
		private bool ResizeMsgProcessor(ref Message m)
		{
			if (!originalForm.Capture)
			{
				Cancel();
				return false;
			}

			switch (m.Msg)
			{
				case DockWindowHelper.WM.WM_LBUTTONUP:
					{	// ok, resize finished !!!
						EndResize();
						break;
					}
				case DockWindowHelper.WM.WM_MOUSEMOVE:
					{
						mousePoint.X = (short)DockWindowHelper.Bit.LoWord((int)m.LParam);
						mousePoint.Y = (short)DockWindowHelper.Bit.HiWord((int)m.LParam);
						Resize(mousePoint);
						break;
					}
				case DockWindowHelper.WM.WM_KEYDOWN:
					{
						if ((int)m.WParam == DockWindowHelper.VK.VK_ESCAPE)
						{
							originalForm.Bounds = formOriginalRect;	// set back old size
							Cancel();
						}
						break;
					}
			}

			return false;
		}
		private void EndResize()
		{
			Cancel();
		}
		#endregion

		#region Resize Computing
		private void Resize(Point p)
		{
			p = originalForm.PointToScreen(p);
			Screen activeScr = Screen.FromPoint(p);
			formRect = originalForm.Bounds;

			int iRight = formRect.Right;
			int iBottom = formRect.Bottom;

			// no normalize required
			// first strech the window to the new position
			if ((resizeDirection & ResizeDir.Left) == ResizeDir.Left)
			{
				formRect.Width = formRect.X - p.X + formRect.Width;
				formRect.X = iRight - formRect.Width;
			}
			if ((resizeDirection & ResizeDir.Right) == ResizeDir.Right)
				formRect.Width = p.X - formRect.Left;

			if ((resizeDirection & ResizeDir.Top) == ResizeDir.Top)
			{
				formRect.Height = formRect.Height - p.Y + formRect.Top;
				formRect.Y = iBottom - formRect.Height;
			}
			if ((resizeDirection & ResizeDir.Bottom) == ResizeDir.Bottom)
				formRect.Height = p.Y - formRect.Top;

			// this is the real new position
			// now, try to snap it to different objects (first to screen)

			// CARE !!! We use "Width" and "Height" as Bottom & Right!! (C++ style)
			//formOffsetRect = new Rectangle ( stickGap + 1, stickGap + 1, 0, 0 );
			formOffsetRect.X = stickGap + 1;
			formOffsetRect.Y = stickGap + 1;
			formOffsetRect.Height = 0;
			formOffsetRect.Width = 0;

			if (stickToScreen)
				Resize_Stick(activeScr.WorkingArea, false);

			if (stickToOther)
			{
				// now try to stick to other forms
				foreach (KeyValuePair<IntPtr, Form> entry in GlobalStickyWindows)
				{
					Form sw = entry.Value;
					if (sw != this.originalForm)
						Resize_Stick(sw.Bounds, true);
				}
			}

			// Fix (clear) the values that were not updated to stick
			if (formOffsetRect.X == stickGap + 1)
				formOffsetRect.X = 0;
			if (formOffsetRect.Width == stickGap + 1)
				formOffsetRect.Width = 0;
			if (formOffsetRect.Y == stickGap + 1)
				formOffsetRect.Y = 0;
			if (formOffsetRect.Height == stickGap + 1)
				formOffsetRect.Height = 0;

			// compute the new form size
			if ((resizeDirection & ResizeDir.Left) == ResizeDir.Left)
			{	// left resize requires special handling of X & Width acording to MinSize and MinWindowTrackSize
				int iNewWidth = formRect.Width + formOffsetRect.Width + formOffsetRect.X;

				if (originalForm.MaximumSize.Width != 0)
					iNewWidth = Math.Min(iNewWidth, originalForm.MaximumSize.Width);

				iNewWidth = Math.Min(iNewWidth, SystemInformation.MaxWindowTrackSize.Width);
				iNewWidth = Math.Max(iNewWidth, originalForm.MinimumSize.Width);
				iNewWidth = Math.Max(iNewWidth, SystemInformation.MinWindowTrackSize.Width);

				formRect.X = iRight - iNewWidth;
				formRect.Width = iNewWidth;
			}
			else
			{	// other resizes
				formRect.Width += formOffsetRect.Width + formOffsetRect.X;
			}

			if ((resizeDirection & ResizeDir.Top) == ResizeDir.Top)
			{
				int iNewHeight = formRect.Height + formOffsetRect.Height + formOffsetRect.Y;

				if (originalForm.MaximumSize.Height != 0)
					iNewHeight = Math.Min(iNewHeight, originalForm.MaximumSize.Height);

				iNewHeight = Math.Min(iNewHeight, SystemInformation.MaxWindowTrackSize.Height);
				iNewHeight = Math.Max(iNewHeight, originalForm.MinimumSize.Height);
				iNewHeight = Math.Max(iNewHeight, SystemInformation.MinWindowTrackSize.Height);

				formRect.Y = iBottom - iNewHeight;
				formRect.Height = iNewHeight;
			}
			else
			{	// all other resizing are fine 
				formRect.Height += formOffsetRect.Height + formOffsetRect.Y;
			}

			// Done !!
			originalForm.Bounds = formRect;
		}

		private void Resize_Stick(Rectangle toRect, bool bInsideStick)
		{
			if (formRect.Right >= (toRect.Left - stickGap) && formRect.Left <= (toRect.Right + stickGap))
			{
				if ((resizeDirection & ResizeDir.Top) == ResizeDir.Top)
				{
					if (Math.Abs(formRect.Top - toRect.Bottom) <= Math.Abs(formOffsetRect.Top) && bInsideStick)
						formOffsetRect.Y = formRect.Top - toRect.Bottom;	// snap top to bottom
					else if (Math.Abs(formRect.Top - toRect.Top) <= Math.Abs(formOffsetRect.Top))
						formOffsetRect.Y = formRect.Top - toRect.Top;		// snap top to top
				}

				if ((resizeDirection & ResizeDir.Bottom) == ResizeDir.Bottom)
				{
					if (Math.Abs(formRect.Bottom - toRect.Top) <= Math.Abs(formOffsetRect.Bottom) && bInsideStick)
						formOffsetRect.Height = toRect.Top - formRect.Bottom;	// snap Bottom to top
					else if (Math.Abs(formRect.Bottom - toRect.Bottom) <= Math.Abs(formOffsetRect.Bottom))
						formOffsetRect.Height = toRect.Bottom - formRect.Bottom;	// snap bottom to bottom
				}
			}

			if (formRect.Bottom >= (toRect.Top - stickGap) && formRect.Top <= (toRect.Bottom + stickGap))
			{
				if ((resizeDirection & ResizeDir.Right) == ResizeDir.Right)
				{
					if (Math.Abs(formRect.Right - toRect.Left) <= Math.Abs(formOffsetRect.Right) && bInsideStick)
						formOffsetRect.Width = toRect.Left - formRect.Right;		// Stick right to left
					else if (Math.Abs(formRect.Right - toRect.Right) <= Math.Abs(formOffsetRect.Right))
						formOffsetRect.Width = toRect.Right - formRect.Right;	// Stick right to right
				}

				if ((resizeDirection & ResizeDir.Left) == ResizeDir.Left)
				{
					if (Math.Abs(formRect.Left - toRect.Right) <= Math.Abs(formOffsetRect.Left) && bInsideStick)
						formOffsetRect.X = formRect.Left - toRect.Right;		// Stick left to right
					else if (Math.Abs(formRect.Left - toRect.Left) <= Math.Abs(formOffsetRect.Left))
						formOffsetRect.X = formRect.Left - toRect.Left;		// Stick left to left
				}
			}
		}
		#endregion

		#region Move Operations
		private void StartMove()
		{
			formRect = originalForm.Bounds;
			formOriginalRect = originalForm.Bounds;	// save original position

			if (!originalForm.Capture)	// start capturing messages
				originalForm.Capture = true;

			MessageProcessor = MoveMessageProcessor;
		}

		private bool MoveMsgProcessor(ref Message m)
		{	// internal message loop
			if (!originalForm.Capture)
			{
				Cancel();
				return false;
			}

			switch (m.Msg)
			{
				case DockWindowHelper.WM.WM_LBUTTONUP:
					{	// ok, move finished !!!
						EndMove();
						break;
					}
				case DockWindowHelper.WM.WM_MOUSEMOVE:
					{
						mousePoint.X = (short)DockWindowHelper.Bit.LoWord((int)m.LParam);
						mousePoint.Y = (short)DockWindowHelper.Bit.HiWord((int)m.LParam);
						Move(mousePoint);
						break;
					}
				case DockWindowHelper.WM.WM_KEYDOWN:
					{
						if ((int)m.WParam == DockWindowHelper.VK.VK_ESCAPE)
						{
							originalForm.Bounds = formOriginalRect;	// set back old size
							Cancel();
						}
						break;
					}
			}

			return false;
		}
		private void EndMove()
		{
			Cancel();
		}
		#endregion

		#region Move Computing
		private void Move(Point p)
		{
			p = originalForm.PointToScreen(p);
			Screen activeScr = Screen.FromPoint(p);	// get the screen from the point !!

			if (!activeScr.WorkingArea.Contains(p))
			{
				p.X = NormalizeInside(p.X, activeScr.WorkingArea.Left, activeScr.WorkingArea.Right);
				p.Y = NormalizeInside(p.Y, activeScr.WorkingArea.Top, activeScr.WorkingArea.Bottom);
			}

			p.Offset(-offsetPoint.X, -offsetPoint.Y);

			// p is the exact location of the frame - so we can play with it
			// to detect the new position acording to different bounds
			formRect.Location = p;	// this is the new positon of the form

			formOffsetPoint.X = stickGap + 1;	// (more than) maximum gaps
			formOffsetPoint.Y = stickGap + 1;

			if (stickToScreen)
				Move_Stick(activeScr.WorkingArea, false);

			// Now try to snap to other windows
			if (stickToOther)
			{
				foreach (KeyValuePair<IntPtr, Form> entry in GlobalStickyWindows)
				{
					Form sw = entry.Value;
					if (sw != this.originalForm)
						Move_Stick(sw.Bounds, true);
				}
			}

			if (formOffsetPoint.X == stickGap + 1)
				formOffsetPoint.X = 0;
			if (formOffsetPoint.Y == stickGap + 1)
				formOffsetPoint.Y = 0;

			formRect.Offset(formOffsetPoint);

			originalForm.Bounds = formRect;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="calculatedOffset">Calculate positon of the offset (snap distance)</param>
		/// <param name="toRect">Rect to try to snap to</param>
		/// <param name="bInsideStick">Allow snapping on the inside (eg: window to screen)</param>
		private void Move_Stick(Rectangle toRect, bool bInsideStick)
		{
			// compare distance from toRect to formRect
			// and then with the found distances, compare the most closed position
			if (formRect.Bottom >= (toRect.Top - stickGap) && formRect.Top <= (toRect.Bottom + stickGap))
			{
				if (bInsideStick)
				{
					if ((Math.Abs(formRect.Left - toRect.Right) <= Math.Abs(formOffsetPoint.X)))
					{	// left 2 right
						formOffsetPoint.X = toRect.Right - formRect.Left;
					}
					if ((Math.Abs(formRect.Left + formRect.Width - toRect.Left) <= Math.Abs(formOffsetPoint.X)))
					{	// right 2 left
						formOffsetPoint.X = toRect.Left - formRect.Width - formRect.Left;
					}
				}

				if (Math.Abs(formRect.Left - toRect.Left) <= Math.Abs(formOffsetPoint.X))
				{	// snap left 2 left
					formOffsetPoint.X = toRect.Left - formRect.Left;
				}
				if (Math.Abs(formRect.Left + formRect.Width - toRect.Left - toRect.Width) <= Math.Abs(formOffsetPoint.X))
				{	// snap right 2 right
					formOffsetPoint.X = toRect.Left + toRect.Width - formRect.Width - formRect.Left;
				}
			}
			if (formRect.Right >= (toRect.Left - stickGap) && formRect.Left <= (toRect.Right + stickGap))
			{
				if (bInsideStick)
				{
					if (Math.Abs(formRect.Top - toRect.Bottom) <= Math.Abs(formOffsetPoint.Y) && bInsideStick)
					{	// Stick Top to Bottom
						formOffsetPoint.Y = toRect.Bottom - formRect.Top;
					}
					if (Math.Abs(formRect.Top + formRect.Height - toRect.Top) <= Math.Abs(formOffsetPoint.Y) && bInsideStick)
					{	// snap Bottom to Top
						formOffsetPoint.Y = toRect.Top - formRect.Height - formRect.Top;
					}
				}

				// try to snap top 2 top also
				if (Math.Abs(formRect.Top - toRect.Top) <= Math.Abs(formOffsetPoint.Y))
				{	// top 2 top
					formOffsetPoint.Y = toRect.Top - formRect.Top;
				}
				if (Math.Abs(formRect.Top + formRect.Height - toRect.Top - toRect.Height) <= Math.Abs(formOffsetPoint.Y))
				{	// bottom 2 bottom
					formOffsetPoint.Y = toRect.Top + toRect.Height - formRect.Height - formRect.Top;
				}
			}
		}
		#endregion

		#region Utilities
		private int NormalizeInside(int iP1, int iM1, int iM2)
		{
			if (iP1 <= iM1)
				return iM1;
			else
				if (iP1 >= iM2)
					return iM2;
			return iP1;
		}
		#endregion

		#region Cancel
		private void Cancel()
		{
			originalForm.Capture = false;
			movingForm = false;
			resizingForm = false;
			MessageProcessor = DefaultMessageProcessor;
		}
		#endregion
	}
}
