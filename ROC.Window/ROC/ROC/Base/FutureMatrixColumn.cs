using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

using LabelEx;

namespace ROC
{
	public partial class FutureMatrixColumn : UserControl
	{
		#region - Local Variables -

		private int _matrixRange = 0;
		private int _matrixInterval = 1;

		private string _baseSymbol;
		private DateTime _expiration;

		private LabelBase dspExpDate;

		#endregion

		#region - Properties -

		private List<FutureMatrixObjects> _futuresMatrixObjects;
		[Browsable(false)]
		public List<FutureMatrixObjects> FuturesMatrixObjects
		{
			get
			{
				if (_futuresMatrixObjects == null)
				{
					_futuresMatrixObjects = new List<FutureMatrixObjects>();
				}
				return _futuresMatrixObjects;
			}
		}

		private Dictionary<string, int> _futuresMatrixObjectsLookupList;
		[Browsable(false)]
		public Dictionary<string, int> FuturesMatrixObjectsLookupList
		{
			get
			{
				if (_futuresMatrixObjectsLookupList == null)
				{
					_futuresMatrixObjectsLookupList = new Dictionary<string, int>();
				}
				return _futuresMatrixObjectsLookupList;
			}
		}

		private int _matrixHeight = 0;
		[Browsable(false)]
		public int MatrixHeight
		{
			get
			{
				return _matrixHeight;
			}
		}

		private int _matrixWidth = 0;
		[Browsable(false)]
		public int MatrixWidth
		{
			get
			{
				return _matrixWidth; 
			}
		}

		#endregion

		#region - Future Month Code -

		private static Dictionary<int, string> _futureDateCodeByMonth;
		[Browsable(false)]
		internal static Dictionary<int, string> FutureDateCodeByMonth
		{
			get
			{
				if (_futureDateCodeByMonth == null) {
					_futureDateCodeByMonth = new Dictionary<int, string>() {
						{ 1, "F" },
						{ 2, "G" },
						{ 3, "H" },
						{ 4, "J" },
						{ 5, "K" },
						{ 6, "M" },
						{ 7, "N" },
						{ 8, "Q" },
						{ 9, "U" },
						{ 10, "V" },
						{ 11, "X" },
						{ 12, "Z" }
					};
				}
				return _futureDateCodeByMonth;
			}
		}

		private static Dictionary<string, int> _futureDateCodeByCode;
		[Browsable(false)]
		internal static Dictionary<string, int> FutureDateCodeByCode
		{
			get
			{
				if (_futureDateCodeByCode == null) {
					_futureDateCodeByCode = new Dictionary<string, int>() {
						{ "F", 1 },
						{ "G", 2 },
						{ "H", 3 },
						{ "J", 4 },
						{ "K", 5 },
						{ "M", 6 },
						{ "N", 7 },
						{ "Q", 8 },
						{ "U", 9 },
						{ "V", 10 },
						{ "X", 11 },
						{ "Z", 12 }
					};
				}
				return _futureDateCodeByCode;
			}
		}

		private static string ConvertToFutureDateCode(DateTime expDate)
		{
			if (FutureDateCodeByMonth.TryGetValue(expDate.Month, out string value))
			{
				return value + expDate.Year.ToString().Substring(3, 1);
			}

			return "";
		}

		#endregion

		#region - Constructor -

		public FutureMatrixColumn(int matrixRange, int matrixInterval, string baseSymbol, DateTime expiration)
		{
			InitializeComponent();

			Initialize(matrixRange, matrixInterval, baseSymbol, expiration);
		}

		private void Initialize(int matrixRange, int matrixInterval, string baseSymbol, DateTime expiration)
		{
			_matrixHeight = Height;
			_matrixWidth = Width;

			_matrixRange = matrixRange;
			if (matrixInterval > 0)
			{
				_matrixInterval = matrixInterval;
			}

			_baseSymbol = baseSymbol;
			_expiration = expiration;

			BackColor = FutureMatrixColor.ShiftColor(BackColor, _matrixRange / _matrixInterval);
		}

		#endregion

		#region - Control Load -

		protected override void OnLoad(EventArgs e)
		{
			DisplayClear();
			DiplayItems();
			//DisplayColumnHeader();
			base.OnLoad(e);
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			base.OnVisibleChanged(e);

			if (Visible)
			{
				for (int index = _futuresMatrixObjects.Count - 1; index >= 0; index--)
				{
					_futuresMatrixObjects[index].Visible = true;
				}
			}
		}

		#endregion

		#region - Display -

		private void DisplayClear()
		{
			Controls.Clear();
		}

		private void DisplayColumnHeader()
		{
			dspExpDate = new LabelBase();
			dspExpDate.Text = _expiration.ToString("MMM yy");

			Controls.Add(dspExpDate);
			dspExpDate.BorderStyle = BorderStyle.Fixed3D;
			dspExpDate.AutoSize = false;
			dspExpDate.TextAlign = ContentAlignment.MiddleCenter;
			dspExpDate.Dock = DockStyle.Top;
			dspExpDate.ForeColor = Color.Gold;
			dspExpDate.Visible = true;
		}

		private void DiplayItems()
		{
			_futuresMatrixObjects = new List<FutureMatrixObjects>();
			_futuresMatrixObjectsLookupList = new Dictionary<string, int>();

			string tempSymbol = "";
			for (int index = 0; index < _matrixRange; index++)
			{
				switch (index)
				{
					case 0:
						tempSymbol = _baseSymbol + ConvertToFutureDateCode(_expiration);
						break;
					default:
						tempSymbol = string.Format("{0}{1}-{0}{2}", _baseSymbol, ConvertToFutureDateCode(_expiration), ConvertToFutureDateCode(_expiration.AddMonths(index)));
						break;
				}
				_futuresMatrixObjects.Add(new FutureMatrixObjects(tempSymbol, BackColor, _expiration));
				_futuresMatrixObjectsLookupList.Add(tempSymbol, index);

				index = index + _matrixInterval - 1;
			}

			for (int index = _futuresMatrixObjects.Count - 1; index >= 0; index--)
			{
				Controls.Add(_futuresMatrixObjects[index]);
				_futuresMatrixObjects[index].Dock = DockStyle.Top;
				_futuresMatrixObjects[index].Enabled = false;
			}
		}

		#endregion

		#region - Fit -

		public void Fit()
		{
			_matrixHeight = _futuresMatrixObjects[_futuresMatrixObjects.Count - 1].Bottom;
		}

		#endregion
	}
}
