using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CSVEx;
using LabelEx;
using MarketData;

namespace ROC
{
	[ToolboxItem(false)]
	public partial class menuFullOrderModification : BaseUserControl, INotifyPropertyChanged
	{
		#region - INotifyPropertyChanged Members -

		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void onPropertyChanged(PropertyChangedEventArgs e)
		{
			if (PropertyChanged != null)
			{
				PropertyChanged(this, e);
			}
		}

		#endregion

		#region - Local Variable -

		private MenuOrderModification _menu;
		
		private NumericUpDown _crrentPriceObj;

		#endregion

		public string OrderID => (_menu == null) ? "" : _menu.CurrentOrder.Tag;

		public long Side => (_menu == null) ? CSVFieldIDs.SideCodes.None : _menu.CurrentOrder.Side;

		public string NewShare => numQuantity.Value.ToString();

		public string DeltaShare
		{
			get
			{
				decimal delta = numQuantity.Value - _menu.InitialLeaveQty;
				return (delta == 0) ? "" : delta.ToString();
			}
		}

		public string NewPrice => (numLimitPrice.Value == 0) ? "" : numLimitPrice.Value.ToString();

		public string NewStopPrice => (numStopPrice.Value == 0) ? "" : numStopPrice.Value.ToString();

		public string NewPegPrice => (numPegPrice.Value == 0) ? "" : numPegPrice.Value.ToString();

		public string NewDuration => (_menu == null) ? CSVFieldIDs.TIFCodes.Day.ToString() : _menu.NewDuration;

		public menuFullOrderModification(
			string orderID,
			decimal qtyIncrement,
			decimal showIncrement,
			decimal limitPriceIncrement,
			decimal stopPriceIncrement,
			decimal pegPriceIncrement)
		{
			InitializeComponent();

			_menu = new MenuOrderModification(this);
			_menu.Initialize(orderID, qtyIncrement, showIncrement, limitPriceIncrement, stopPriceIncrement, pegPriceIncrement);

			_crrentPriceObj = numLimitPrice;
		}

		public void UpdateOrderModificationTicketByProcess(bool updateIM, Market deltas)
		{
			_menu.UpdateOrderModificationTicketByProcess(updateIM, deltas);
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			onPropertyChanged(new PropertyChangedEventArgs("Cancel"));
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			onPropertyChanged(new PropertyChangedEventArgs("Close"));
		}

		private void cmdReplace_Click(object sender, EventArgs e)
		{
			onPropertyChanged(new PropertyChangedEventArgs("Replace"));
		}

		private void cmdCancelAll_Click(object sender, EventArgs e)
		{
			onPropertyChanged(new PropertyChangedEventArgs("CancelAll"));
		}

		private void cmdCancelAllOf_Click(object sender, EventArgs e)
		{
			onPropertyChanged(new PropertyChangedEventArgs("CancelAllOf"));
		}

		private void LimitPriceChanged(object sender, EventArgs e)
		{
			_menu.SetOptionPriceIncrement(numLimitPrice, dspLimitPriceTickSize);
		}

		private void StopPriceChanged(object sender, EventArgs e)
		{
			_menu.SetOptionPriceIncrement(numStopPrice, dspStopPriceTickSize);
		}

		#region - Price Event -

		private void PriceSelection_Click(object sender, EventArgs e)
		{
			try
			{
				if (((Control)sender).Name.ToUpper().Contains("LIMITPRICE"))
				{
					SelectLimitPrice();
				}
				else if (((Control)sender).Name.ToUpper().Contains("STOPPRICE"))
				{
					SelectStopPrice();
				}
			}
			catch (Exception ex)
			{
				GLOBAL.HROC.AddToException(ex);
			}
		}

		private void Price_MouseDown(object sender, MouseEventArgs e)
		{
			try
			{
				((LabelBase)sender).ForeColor = Color.LimeGreen;
				if (((LabelBase)sender).Value != null && ((LabelBase)sender).Value.ToString() != "")
				{
					_crrentPriceObj.Value = Convert.ToDecimal(((LabelBase)sender).Value);
				}

				TogglePriceSelection();
			}
			catch (Exception ex)
			{
				GLOBAL.HROC.AddToException(ex);
			}
		}

		private void Price_MouseUp(object sender, MouseEventArgs e)
		{
			try
			{
				((LabelBase)sender).ForeColor = Color.Gainsboro;
			}
			catch (Exception ex)
			{
				GLOBAL.HROC.AddToException(ex);
			}
		}

		private void TogglePriceSelection()
		{
			if (panelLimitPrice.Enabled && panelStopPrice.Enabled)
			{
				if (_crrentPriceObj.Name.ToUpper().Contains("LIMITPRICE"))
				{
					SelectStopPrice();
				}
				else
				{
					SelectLimitPrice();
				}
			}
		}

		private void SelectLimitPrice()
		{
			_crrentPriceObj = numLimitPrice;
			panelLimitPrice.BackColor = Color.CornflowerBlue;
			panelStopPrice.BackColor = Color.Transparent;
		}

		private void SelectStopPrice()
		{
			_crrentPriceObj = numStopPrice;
			panelLimitPrice.BackColor = Color.Transparent;
			panelStopPrice.BackColor = Color.CornflowerBlue;
		}

		#endregion
	}
}
