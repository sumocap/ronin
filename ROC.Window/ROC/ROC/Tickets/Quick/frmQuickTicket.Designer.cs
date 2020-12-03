namespace ROC
{
	partial class frmQuickTicket
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuickTicket));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			DataGridViewEx.DGVBasePrinter dgvBasePrinter1 = new DataGridViewEx.DGVBasePrinter();
			System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
			System.Drawing.StringFormat stringFormat2 = new System.Drawing.StringFormat();
			System.Drawing.StringFormat stringFormat3 = new System.Drawing.StringFormat();
			System.Drawing.StringFormat stringFormat4 = new System.Drawing.StringFormat();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.CaptionBar = new FormEx.VistaWindowCaptionBar();
			this.toolStripTraderInfo = new System.Windows.Forms.ToolStrip();
			this.lblTradeFor = new System.Windows.Forms.ToolStripLabel();
			this.cmdTradeFor = new System.Windows.Forms.ToolStripDropDownButton();
			this.lblLocalAccountAcrn = new System.Windows.Forms.ToolStripLabel();
			this.cmdAccount = new System.Windows.Forms.ToolStripDropDownButton();
			this.cmdSettings = new System.Windows.Forms.ToolStripDropDownButton();
			this.itemSaveAsDefault = new System.Windows.Forms.ToolStripMenuItem();
			this.itemResetToSystemDefault = new System.Windows.Forms.ToolStripMenuItem();
			this.panelTicker = new System.Windows.Forms.Panel();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.dspClosePrice = new LabelEx.LabelBase();
			this.lblClosePrice = new System.Windows.Forms.Label();
			this.dspHighPrice = new LabelEx.LabelBase();
			this.lblHighPrice = new System.Windows.Forms.Label();
			this.dspLowPrice = new LabelEx.LabelBase();
			this.lblLowPrice = new System.Windows.Forms.Label();
			this.dspTradeVolume = new LabelEx.LabelBase();
			this.lblTradeVolume = new System.Windows.Forms.Label();
			this.lblSecurityStatus = new LabelEx.LabelVista();
			this.lblMarketDataError = new LabelEx.LabelVista();
			this.panelMiddle = new System.Windows.Forms.Panel();
			this.dspVolume = new LabelEx.LabelBase();
			this.lblVolume = new System.Windows.Forms.Label();
			this.dspPctChange = new LabelEx.LabelBase();
			this.lblPctChange = new System.Windows.Forms.Label();
			this.dspNetChange = new LabelEx.LabelBase();
			this.lblNetChange = new System.Windows.Forms.Label();
			this.panelUpper = new System.Windows.Forms.Panel();
			this.dspAskSize = new LabelEx.LabelBase();
			this.lblAskSize = new System.Windows.Forms.Label();
			this.dspAskPrice = new LabelEx.LabelBase();
			this.lblAskPrice = new System.Windows.Forms.Label();
			this.dspBidSize = new LabelEx.LabelBase();
			this.lblBidSize = new System.Windows.Forms.Label();
			this.dspBidPrice = new LabelEx.LabelBase();
			this.lblBidPrice = new System.Windows.Forms.Label();
			this.panelSymbolTrade = new System.Windows.Forms.Panel();
			this.dspTradedPrice = new LabelEx.LabelBase();
			this.picTradeTick = new System.Windows.Forms.PictureBox();
			this.cboSymbolDetails = new System.Windows.Forms.ComboBox();
			this.panelOrderInfo = new System.Windows.Forms.Panel();
			this.panelOrderInfoMsg = new System.Windows.Forms.Panel();
			this.lblDoNotTranslate = new LabelEx.LabelVista();
			this.dspOrderMsg = new System.Windows.Forms.RichTextBox();
			this.panelOrderInfoUpper = new System.Windows.Forms.Panel();
			this.panelShortLender = new System.Windows.Forms.Panel();
			this.cboShortLenders = new System.Windows.Forms.ComboBox();
			this.lblShortLender = new System.Windows.Forms.Label();
			this.panelStopLimitOffset = new System.Windows.Forms.Panel();
			this.numStopLimitOffset = new NumericUpDownEx.NumericUpDownBase();
			this.lblStopLimitOffset = new System.Windows.Forms.Label();
			this.panelExchange = new System.Windows.Forms.Panel();
			this.cboExchange = new System.Windows.Forms.ComboBox();
			this.lblExchange = new System.Windows.Forms.Label();
			this.panelDuration = new System.Windows.Forms.Panel();
			this.cboDuration = new System.Windows.Forms.ComboBox();
			this.lblDuration = new System.Windows.Forms.Label();
			this.panelStopPrice = new System.Windows.Forms.Panel();
			this.dspStopPrice = new System.Windows.Forms.TextBox();
			this.dspStopPriceTickSize = new LabelEx.LabelBase();
			this.lblStopPriceX = new LabelEx.LabelBase();
			this.dspStopPriceIncrement = new LabelEx.LabelBase();
			this.numStopPrice = new NumericUpDownEx.NumericUpDownBase();
			this.lblStopPrice = new System.Windows.Forms.Label();
			this.panelLimitPrice = new System.Windows.Forms.Panel();
			this.dspLimitPrice = new System.Windows.Forms.TextBox();
			this.dspLimitPriceTickSize = new LabelEx.LabelBase();
			this.lblLimitPriceX = new LabelEx.LabelBase();
			this.dspLimitPriceIncrement = new LabelEx.LabelBase();
			this.numLimitPrice = new NumericUpDownEx.NumericUpDownBase();
			this.lblLimitPrice = new System.Windows.Forms.Label();
			this.panelOrderTypes = new System.Windows.Forms.Panel();
			this.cboOrder = new System.Windows.Forms.ComboBox();
			this.lblOrderType = new System.Windows.Forms.Label();
			this.panelShares = new System.Windows.Forms.Panel();
			this.dspQuantityIncrement = new LabelEx.LabelBase();
			this.numQuantity = new NumericUpDownEx.NumericUpDownBase();
			this.lblQuantity = new System.Windows.Forms.Label();
			this.panelCommands = new System.Windows.Forms.Panel();
			this.cmdShort = new ButtonEx.VistaButton();
			this.cmdSell = new ButtonEx.VistaButton();
			this.cmdBuy = new ButtonEx.VistaButton();
			this.panelManagerQuick = new PanelEx.PanelManager();
			this.managedPanelStock = new PanelEx.ManagedPanel();
			this.managedPanelBook = new PanelEx.ManagedPanel();
			this.dspNetOpen = new LabelEx.LabelVista();
			this.dspSellOpenQty = new LabelEx.LabelVista();
			this.dspBuyOpenQty = new LabelEx.LabelVista();
			this.cmdCenterLow = new ButtonEx.VistaButton();
			this.cmdCenterTrade = new ButtonEx.VistaButton();
			this.cmdCenterHigh = new ButtonEx.VistaButton();
			this.cmdCancelAllSell = new ButtonEx.VistaButton();
			this.cmdCancelAll = new ButtonEx.VistaButton();
			this.cmdCancelAllBuy = new ButtonEx.VistaButton();
			this.imageListTradeTick = new System.Windows.Forms.ImageList(this.components);
			this.rocQuickListBook = new DataGridViewEx.ROCQuickList();
			this.panelCommandsEx = new System.Windows.Forms.Panel();
			this.toolStripTraderInfo.SuspendLayout();
			this.panelTicker.SuspendLayout();
			this.panelBottom.SuspendLayout();
			this.panelMiddle.SuspendLayout();
			this.panelUpper.SuspendLayout();
			this.panelSymbolTrade.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picTradeTick)).BeginInit();
			this.panelOrderInfo.SuspendLayout();
			this.panelOrderInfoMsg.SuspendLayout();
			this.panelOrderInfoUpper.SuspendLayout();
			this.panelShortLender.SuspendLayout();
			this.panelStopLimitOffset.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStopLimitOffset)).BeginInit();
			this.panelExchange.SuspendLayout();
			this.panelDuration.SuspendLayout();
			this.panelStopPrice.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStopPrice)).BeginInit();
			this.panelLimitPrice.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLimitPrice)).BeginInit();
			this.panelOrderTypes.SuspendLayout();
			this.panelShares.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
			this.panelCommands.SuspendLayout();
			this.panelManagerQuick.SuspendLayout();
			this.managedPanelBook.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rocQuickListBook)).BeginInit();
			this.SuspendLayout();
			// 
			// CaptionBar
			// 
			this.CaptionBar.BackColor = System.Drawing.Color.Transparent;
			this.CaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.CaptionBar.Location = new System.Drawing.Point(0, 0);
			this.CaptionBar.Name = "CaptionBar";
			this.CaptionBar.ShowDisplay = true;
			this.CaptionBar.ShowFit = true;
			this.CaptionBar.ShowShowAll = true;
			this.CaptionBar.Size = new System.Drawing.Size(362, 26);
			this.CaptionBar.TabIndex = 0;
			this.CaptionBar.TabStop = false;
			// 
			// toolStripTraderInfo
			// 
			this.toolStripTraderInfo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStripTraderInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTradeFor,
            this.cmdTradeFor,
            this.lblLocalAccountAcrn,
            this.cmdAccount,
            this.cmdSettings});
			this.toolStripTraderInfo.Location = new System.Drawing.Point(0, 26);
			this.toolStripTraderInfo.Name = "toolStripTraderInfo";
			this.toolStripTraderInfo.ShowItemToolTips = false;
			this.toolStripTraderInfo.Size = new System.Drawing.Size(362, 25);
			this.toolStripTraderInfo.TabIndex = 0;
			this.toolStripTraderInfo.Text = "UserInfo";
			// 
			// lblTradeFor
			// 
			this.lblTradeFor.ForeColor = System.Drawing.Color.DimGray;
			this.lblTradeFor.Name = "lblTradeFor";
			this.lblTradeFor.Size = new System.Drawing.Size(43, 22);
			this.lblTradeFor.Text = "Trader:";
			// 
			// cmdTradeFor
			// 
			this.cmdTradeFor.AutoToolTip = false;
			this.cmdTradeFor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmdTradeFor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdTradeFor.Image = ((System.Drawing.Image)(resources.GetObject("cmdTradeFor.Image")));
			this.cmdTradeFor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdTradeFor.Name = "cmdTradeFor";
			this.cmdTradeFor.Size = new System.Drawing.Size(41, 22);
			this.cmdTradeFor.Text = "N/A";
			// 
			// lblLocalAccountAcrn
			// 
			this.lblLocalAccountAcrn.ForeColor = System.Drawing.Color.DimGray;
			this.lblLocalAccountAcrn.Name = "lblLocalAccountAcrn";
			this.lblLocalAccountAcrn.Size = new System.Drawing.Size(50, 22);
			this.lblLocalAccountAcrn.Text = "Account:";
			// 
			// cmdAccount
			// 
			this.cmdAccount.AutoToolTip = false;
			this.cmdAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmdAccount.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdAccount.Image = ((System.Drawing.Image)(resources.GetObject("cmdAccount.Image")));
			this.cmdAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdAccount.Name = "cmdAccount";
			this.cmdAccount.Size = new System.Drawing.Size(41, 22);
			this.cmdAccount.Text = "N/A";
			// 
			// cmdSettings
			// 
			this.cmdSettings.AutoToolTip = false;
			this.cmdSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.cmdSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSaveAsDefault,
            this.itemResetToSystemDefault});
			this.cmdSettings.Image = ((System.Drawing.Image)(resources.GetObject("cmdSettings.Image")));
			this.cmdSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cmdSettings.Name = "cmdSettings";
			this.cmdSettings.Size = new System.Drawing.Size(59, 22);
			this.cmdSettings.Text = "Settings";
			// 
			// itemSaveAsDefault
			// 
			this.itemSaveAsDefault.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.itemSaveAsDefault.Name = "itemSaveAsDefault";
			this.itemSaveAsDefault.Size = new System.Drawing.Size(225, 22);
			this.itemSaveAsDefault.Text = "Save As Default";
			this.itemSaveAsDefault.Click += new System.EventHandler(this.itemSaveAsDefault_Click);
			// 
			// itemResetToSystemDefault
			// 
			this.itemResetToSystemDefault.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.itemResetToSystemDefault.Name = "itemResetToSystemDefault";
			this.itemResetToSystemDefault.Size = new System.Drawing.Size(225, 22);
			this.itemResetToSystemDefault.Text = "Reset To System Default";
			this.itemResetToSystemDefault.Click += new System.EventHandler(this.itemResetToSystemDefault_Click);
			// 
			// panelTicker
			// 
			this.panelTicker.BackColor = System.Drawing.Color.Black;
			this.panelTicker.Controls.Add(this.panelBottom);
			this.panelTicker.Controls.Add(this.panelMiddle);
			this.panelTicker.Controls.Add(this.panelUpper);
			this.panelTicker.Controls.Add(this.panelSymbolTrade);
			this.panelTicker.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTicker.ForeColor = System.Drawing.Color.Gainsboro;
			this.panelTicker.Location = new System.Drawing.Point(0, 51);
			this.panelTicker.Name = "panelTicker";
			this.panelTicker.Size = new System.Drawing.Size(362, 45);
			this.panelTicker.TabIndex = 0;
			// 
			// panelBottom
			// 
			this.panelBottom.AutoSize = true;
			this.panelBottom.Controls.Add(this.dspClosePrice);
			this.panelBottom.Controls.Add(this.lblClosePrice);
			this.panelBottom.Controls.Add(this.dspHighPrice);
			this.panelBottom.Controls.Add(this.lblHighPrice);
			this.panelBottom.Controls.Add(this.dspLowPrice);
			this.panelBottom.Controls.Add(this.lblLowPrice);
			this.panelBottom.Controls.Add(this.dspTradeVolume);
			this.panelBottom.Controls.Add(this.lblTradeVolume);
			this.panelBottom.Controls.Add(this.lblSecurityStatus);
			this.panelBottom.Controls.Add(this.lblMarketDataError);
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelBottom.Location = new System.Drawing.Point(91, 30);
			this.panelBottom.MinimumSize = new System.Drawing.Size(270, 15);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(271, 15);
			this.panelBottom.TabIndex = 0;
			// 
			// dspClosePrice
			// 
			this.dspClosePrice.AutoColor = false;
			this.dspClosePrice.AutoSize = true;
			this.dspClosePrice.DefaultColor = System.Drawing.Color.White;
			this.dspClosePrice.DefaultText = "0.00";
			this.dspClosePrice.DisplayFactor = 1;
			this.dspClosePrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspClosePrice.DownColor = System.Drawing.Color.Red;
			this.dspClosePrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspClosePrice.Is64Th = false;
			this.dspClosePrice.IsCurrency = false;
			this.dspClosePrice.IsFraction = true;
			this.dspClosePrice.IsPercent = false;
			this.dspClosePrice.Location = new System.Drawing.Point(202, 0);
			this.dspClosePrice.MaxDecimal = 2;
			this.dspClosePrice.Name = "dspClosePrice";
			this.dspClosePrice.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.dspClosePrice.Size = new System.Drawing.Size(31, 14);
			this.dspClosePrice.TabIndex = 0;
			this.dspClosePrice.Text = "0.00";
			this.dspClosePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspClosePrice.TickSize = 0.01;
			this.dspClosePrice.UpColor = System.Drawing.Color.LimeGreen;
			this.dspClosePrice.Value = "";
			this.dspClosePrice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Price_MouseDown);
			this.dspClosePrice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Price_MouseUp);
			// 
			// lblClosePrice
			// 
			this.lblClosePrice.AutoSize = true;
			this.lblClosePrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblClosePrice.ForeColor = System.Drawing.Color.Khaki;
			this.lblClosePrice.Location = new System.Drawing.Point(185, 0);
			this.lblClosePrice.MaximumSize = new System.Drawing.Size(17, 14);
			this.lblClosePrice.MinimumSize = new System.Drawing.Size(17, 14);
			this.lblClosePrice.Name = "lblClosePrice";
			this.lblClosePrice.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblClosePrice.Size = new System.Drawing.Size(17, 14);
			this.lblClosePrice.TabIndex = 0;
			this.lblClosePrice.Text = "pr";
			this.lblClosePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dspHighPrice
			// 
			this.dspHighPrice.AutoColor = false;
			this.dspHighPrice.AutoSize = true;
			this.dspHighPrice.DefaultColor = System.Drawing.Color.White;
			this.dspHighPrice.DefaultText = "0.00";
			this.dspHighPrice.DisplayFactor = 1;
			this.dspHighPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspHighPrice.DownColor = System.Drawing.Color.Red;
			this.dspHighPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspHighPrice.Is64Th = false;
			this.dspHighPrice.IsCurrency = false;
			this.dspHighPrice.IsFraction = true;
			this.dspHighPrice.IsPercent = false;
			this.dspHighPrice.Location = new System.Drawing.Point(154, 0);
			this.dspHighPrice.MaxDecimal = 2;
			this.dspHighPrice.Name = "dspHighPrice";
			this.dspHighPrice.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.dspHighPrice.Size = new System.Drawing.Size(31, 14);
			this.dspHighPrice.TabIndex = 0;
			this.dspHighPrice.Text = "0.00";
			this.dspHighPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspHighPrice.TickSize = 0.01;
			this.dspHighPrice.UpColor = System.Drawing.Color.LimeGreen;
			this.dspHighPrice.Value = "";
			this.dspHighPrice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Price_MouseDown);
			this.dspHighPrice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Price_MouseUp);
			// 
			// lblHighPrice
			// 
			this.lblHighPrice.AutoSize = true;
			this.lblHighPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblHighPrice.ForeColor = System.Drawing.Color.Khaki;
			this.lblHighPrice.Location = new System.Drawing.Point(139, 0);
			this.lblHighPrice.MaximumSize = new System.Drawing.Size(15, 14);
			this.lblHighPrice.MinimumSize = new System.Drawing.Size(15, 14);
			this.lblHighPrice.Name = "lblHighPrice";
			this.lblHighPrice.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblHighPrice.Size = new System.Drawing.Size(15, 14);
			this.lblHighPrice.TabIndex = 0;
			this.lblHighPrice.Text = "hi";
			this.lblHighPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dspLowPrice
			// 
			this.dspLowPrice.AutoColor = false;
			this.dspLowPrice.AutoSize = true;
			this.dspLowPrice.DefaultColor = System.Drawing.Color.White;
			this.dspLowPrice.DefaultText = "0.00";
			this.dspLowPrice.DisplayFactor = 1;
			this.dspLowPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspLowPrice.DownColor = System.Drawing.Color.Red;
			this.dspLowPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspLowPrice.Is64Th = false;
			this.dspLowPrice.IsCurrency = false;
			this.dspLowPrice.IsFraction = true;
			this.dspLowPrice.IsPercent = false;
			this.dspLowPrice.Location = new System.Drawing.Point(108, 0);
			this.dspLowPrice.MaxDecimal = 2;
			this.dspLowPrice.Name = "dspLowPrice";
			this.dspLowPrice.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.dspLowPrice.Size = new System.Drawing.Size(31, 14);
			this.dspLowPrice.TabIndex = 0;
			this.dspLowPrice.Text = "0.00";
			this.dspLowPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspLowPrice.TickSize = 0.01;
			this.dspLowPrice.UpColor = System.Drawing.Color.LimeGreen;
			this.dspLowPrice.Value = "";
			this.dspLowPrice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Price_MouseDown);
			this.dspLowPrice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Price_MouseUp);
			// 
			// lblLowPrice
			// 
			this.lblLowPrice.AutoSize = true;
			this.lblLowPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblLowPrice.ForeColor = System.Drawing.Color.Khaki;
			this.lblLowPrice.Location = new System.Drawing.Point(93, 0);
			this.lblLowPrice.MaximumSize = new System.Drawing.Size(15, 14);
			this.lblLowPrice.MinimumSize = new System.Drawing.Size(15, 14);
			this.lblLowPrice.Name = "lblLowPrice";
			this.lblLowPrice.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblLowPrice.Size = new System.Drawing.Size(15, 14);
			this.lblLowPrice.TabIndex = 0;
			this.lblLowPrice.Text = "lo";
			this.lblLowPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dspTradeVolume
			// 
			this.dspTradeVolume.AutoColor = false;
			this.dspTradeVolume.AutoSize = true;
			this.dspTradeVolume.DefaultColor = System.Drawing.Color.White;
			this.dspTradeVolume.DefaultText = "0";
			this.dspTradeVolume.DisplayFactor = 1;
			this.dspTradeVolume.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspTradeVolume.DownColor = System.Drawing.Color.Red;
			this.dspTradeVolume.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspTradeVolume.Is64Th = false;
			this.dspTradeVolume.IsCurrency = false;
			this.dspTradeVolume.IsFraction = false;
			this.dspTradeVolume.IsPercent = false;
			this.dspTradeVolume.Location = new System.Drawing.Point(79, 0);
			this.dspTradeVolume.MaxDecimal = 0;
			this.dspTradeVolume.Name = "dspTradeVolume";
			this.dspTradeVolume.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.dspTradeVolume.Size = new System.Drawing.Size(14, 14);
			this.dspTradeVolume.TabIndex = 0;
			this.dspTradeVolume.Text = "0";
			this.dspTradeVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspTradeVolume.TickSize = 0.01;
			this.dspTradeVolume.UpColor = System.Drawing.Color.LimeGreen;
			this.dspTradeVolume.Value = "";
			// 
			// lblTradeVolume
			// 
			this.lblTradeVolume.AutoSize = true;
			this.lblTradeVolume.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblTradeVolume.ForeColor = System.Drawing.Color.Khaki;
			this.lblTradeVolume.Location = new System.Drawing.Point(57, 0);
			this.lblTradeVolume.MaximumSize = new System.Drawing.Size(22, 14);
			this.lblTradeVolume.MinimumSize = new System.Drawing.Size(22, 14);
			this.lblTradeVolume.Name = "lblTradeVolume";
			this.lblTradeVolume.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblTradeVolume.Size = new System.Drawing.Size(22, 14);
			this.lblTradeVolume.TabIndex = 0;
			this.lblTradeVolume.Text = "tv";
			this.lblTradeVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblSecurityStatus
			// 
			this.lblSecurityStatus.AutoColor = false;
			this.lblSecurityStatus.AutoSize = true;
			this.lblSecurityStatus.BlinkBackColor = System.Drawing.Color.Black;
			this.lblSecurityStatus.BlinkForeColorColor = System.Drawing.Color.Gold;
			this.lblSecurityStatus.BlinkInnerBorderColor = System.Drawing.Color.Black;
			this.lblSecurityStatus.BlinkOuterBorderColor = System.Drawing.Color.Black;
			this.lblSecurityStatus.DefaultColor = System.Drawing.Color.White;
			this.lblSecurityStatus.DefaultText = "No Market Data";
			this.lblSecurityStatus.DisplayFactor = 1;
			this.lblSecurityStatus.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblSecurityStatus.DownColor = System.Drawing.Color.Red;
			this.lblSecurityStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSecurityStatus.Is64Th = false;
			this.lblSecurityStatus.IsCurrency = false;
			this.lblSecurityStatus.IsFraction = false;
			this.lblSecurityStatus.IsPercent = false;
			this.lblSecurityStatus.Location = new System.Drawing.Point(26, 0);
			this.lblSecurityStatus.MaxDecimal = 7;
			this.lblSecurityStatus.Name = "lblSecurityStatus";
			this.lblSecurityStatus.OuterBorderColor = System.Drawing.Color.Black;
			this.lblSecurityStatus.Size = new System.Drawing.Size(31, 13);
			this.lblSecurityStatus.TabIndex = 3;
			this.lblSecurityStatus.Text = "STA";
			this.lblSecurityStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblSecurityStatus.TickSize = 0.01;
			this.lblSecurityStatus.UpColor = System.Drawing.Color.LimeGreen;
			this.lblSecurityStatus.Value = "";
			this.lblSecurityStatus.Visible = false;
			// 
			// lblMarketDataError
			// 
			this.lblMarketDataError.AutoColor = false;
			this.lblMarketDataError.AutoSize = true;
			this.lblMarketDataError.BlinkBackColor = System.Drawing.Color.Black;
			this.lblMarketDataError.BlinkForeColorColor = System.Drawing.Color.Red;
			this.lblMarketDataError.BlinkInnerBorderColor = System.Drawing.Color.Black;
			this.lblMarketDataError.BlinkOuterBorderColor = System.Drawing.Color.Black;
			this.lblMarketDataError.DefaultColor = System.Drawing.Color.White;
			this.lblMarketDataError.DefaultText = "No Market Data";
			this.lblMarketDataError.DisplayFactor = 1;
			this.lblMarketDataError.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblMarketDataError.DownColor = System.Drawing.Color.Red;
			this.lblMarketDataError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMarketDataError.Is64Th = false;
			this.lblMarketDataError.IsCurrency = false;
			this.lblMarketDataError.IsFraction = false;
			this.lblMarketDataError.IsPercent = false;
			this.lblMarketDataError.Location = new System.Drawing.Point(0, 0);
			this.lblMarketDataError.MaxDecimal = 7;
			this.lblMarketDataError.Name = "lblMarketDataError";
			this.lblMarketDataError.OuterBorderColor = System.Drawing.Color.Black;
			this.lblMarketDataError.Size = new System.Drawing.Size(26, 13);
			this.lblMarketDataError.TabIndex = 0;
			this.lblMarketDataError.Text = "MD";
			this.lblMarketDataError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblMarketDataError.TickSize = 0.01;
			this.lblMarketDataError.UpColor = System.Drawing.Color.LimeGreen;
			this.lblMarketDataError.Value = "";
			this.lblMarketDataError.Visible = false;
			// 
			// panelMiddle
			// 
			this.panelMiddle.AutoSize = true;
			this.panelMiddle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelMiddle.Controls.Add(this.dspVolume);
			this.panelMiddle.Controls.Add(this.lblVolume);
			this.panelMiddle.Controls.Add(this.dspPctChange);
			this.panelMiddle.Controls.Add(this.lblPctChange);
			this.panelMiddle.Controls.Add(this.dspNetChange);
			this.panelMiddle.Controls.Add(this.lblNetChange);
			this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelMiddle.Location = new System.Drawing.Point(91, 15);
			this.panelMiddle.MinimumSize = new System.Drawing.Size(270, 15);
			this.panelMiddle.Name = "panelMiddle";
			this.panelMiddle.Size = new System.Drawing.Size(271, 15);
			this.panelMiddle.TabIndex = 0;
			// 
			// dspVolume
			// 
			this.dspVolume.AutoColor = false;
			this.dspVolume.AutoSize = true;
			this.dspVolume.DefaultColor = System.Drawing.Color.White;
			this.dspVolume.DefaultText = "0";
			this.dspVolume.DisplayFactor = 1;
			this.dspVolume.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspVolume.DownColor = System.Drawing.Color.Red;
			this.dspVolume.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspVolume.Is64Th = false;
			this.dspVolume.IsCurrency = false;
			this.dspVolume.IsFraction = false;
			this.dspVolume.IsPercent = false;
			this.dspVolume.Location = new System.Drawing.Point(141, 0);
			this.dspVolume.MaxDecimal = 0;
			this.dspVolume.Name = "dspVolume";
			this.dspVolume.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.dspVolume.Size = new System.Drawing.Size(14, 14);
			this.dspVolume.TabIndex = 0;
			this.dspVolume.Text = "0";
			this.dspVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspVolume.TickSize = 0.01;
			this.dspVolume.UpColor = System.Drawing.Color.LimeGreen;
			this.dspVolume.Value = "";
			// 
			// lblVolume
			// 
			this.lblVolume.AutoSize = true;
			this.lblVolume.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblVolume.ForeColor = System.Drawing.Color.Khaki;
			this.lblVolume.Location = new System.Drawing.Point(119, 0);
			this.lblVolume.MaximumSize = new System.Drawing.Size(22, 14);
			this.lblVolume.MinimumSize = new System.Drawing.Size(22, 14);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblVolume.Size = new System.Drawing.Size(22, 14);
			this.lblVolume.TabIndex = 0;
			this.lblVolume.Text = "vol";
			this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dspPctChange
			// 
			this.dspPctChange.AutoColor = true;
			this.dspPctChange.AutoSize = true;
			this.dspPctChange.DefaultColor = System.Drawing.Color.White;
			this.dspPctChange.DefaultText = "0.00%";
			this.dspPctChange.DisplayFactor = 1;
			this.dspPctChange.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspPctChange.DownColor = System.Drawing.Color.Red;
			this.dspPctChange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspPctChange.Is64Th = false;
			this.dspPctChange.IsCurrency = false;
			this.dspPctChange.IsFraction = false;
			this.dspPctChange.IsPercent = true;
			this.dspPctChange.Location = new System.Drawing.Point(75, 0);
			this.dspPctChange.MaxDecimal = 2;
			this.dspPctChange.Name = "dspPctChange";
			this.dspPctChange.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.dspPctChange.Size = new System.Drawing.Size(44, 14);
			this.dspPctChange.TabIndex = 0;
			this.dspPctChange.Text = "0.00%";
			this.dspPctChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspPctChange.TickSize = 0.01;
			this.dspPctChange.UpColor = System.Drawing.Color.LimeGreen;
			this.dspPctChange.Value = "";
			// 
			// lblPctChange
			// 
			this.lblPctChange.AutoSize = true;
			this.lblPctChange.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblPctChange.ForeColor = System.Drawing.Color.Khaki;
			this.lblPctChange.Location = new System.Drawing.Point(53, 0);
			this.lblPctChange.MaximumSize = new System.Drawing.Size(22, 14);
			this.lblPctChange.MinimumSize = new System.Drawing.Size(22, 14);
			this.lblPctChange.Name = "lblPctChange";
			this.lblPctChange.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblPctChange.Size = new System.Drawing.Size(22, 14);
			this.lblPctChange.TabIndex = 0;
			this.lblPctChange.Text = "pct";
			this.lblPctChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dspNetChange
			// 
			this.dspNetChange.AutoColor = true;
			this.dspNetChange.AutoSize = true;
			this.dspNetChange.DefaultColor = System.Drawing.Color.White;
			this.dspNetChange.DefaultText = "0.00";
			this.dspNetChange.DisplayFactor = 1;
			this.dspNetChange.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspNetChange.DownColor = System.Drawing.Color.Red;
			this.dspNetChange.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspNetChange.Is64Th = false;
			this.dspNetChange.IsCurrency = false;
			this.dspNetChange.IsFraction = true;
			this.dspNetChange.IsPercent = false;
			this.dspNetChange.Location = new System.Drawing.Point(22, 0);
			this.dspNetChange.MaxDecimal = 2;
			this.dspNetChange.Name = "dspNetChange";
			this.dspNetChange.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.dspNetChange.Size = new System.Drawing.Size(31, 14);
			this.dspNetChange.TabIndex = 0;
			this.dspNetChange.Text = "0.00";
			this.dspNetChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspNetChange.TickSize = 0.01;
			this.dspNetChange.UpColor = System.Drawing.Color.LimeGreen;
			this.dspNetChange.Value = "";
			// 
			// lblNetChange
			// 
			this.lblNetChange.AutoSize = true;
			this.lblNetChange.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblNetChange.ForeColor = System.Drawing.Color.Khaki;
			this.lblNetChange.Location = new System.Drawing.Point(0, 0);
			this.lblNetChange.MaximumSize = new System.Drawing.Size(22, 14);
			this.lblNetChange.MinimumSize = new System.Drawing.Size(22, 14);
			this.lblNetChange.Name = "lblNetChange";
			this.lblNetChange.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblNetChange.Size = new System.Drawing.Size(22, 14);
			this.lblNetChange.TabIndex = 0;
			this.lblNetChange.Text = "net";
			this.lblNetChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panelUpper
			// 
			this.panelUpper.AutoSize = true;
			this.panelUpper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelUpper.Controls.Add(this.dspAskSize);
			this.panelUpper.Controls.Add(this.lblAskSize);
			this.panelUpper.Controls.Add(this.dspAskPrice);
			this.panelUpper.Controls.Add(this.lblAskPrice);
			this.panelUpper.Controls.Add(this.dspBidSize);
			this.panelUpper.Controls.Add(this.lblBidSize);
			this.panelUpper.Controls.Add(this.dspBidPrice);
			this.panelUpper.Controls.Add(this.lblBidPrice);
			this.panelUpper.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelUpper.Location = new System.Drawing.Point(91, 0);
			this.panelUpper.MinimumSize = new System.Drawing.Size(270, 15);
			this.panelUpper.Name = "panelUpper";
			this.panelUpper.Size = new System.Drawing.Size(271, 15);
			this.panelUpper.TabIndex = 0;
			// 
			// dspAskSize
			// 
			this.dspAskSize.AutoColor = false;
			this.dspAskSize.AutoSize = true;
			this.dspAskSize.DefaultColor = System.Drawing.Color.White;
			this.dspAskSize.DefaultText = "0";
			this.dspAskSize.DisplayFactor = 1;
			this.dspAskSize.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspAskSize.DownColor = System.Drawing.Color.Red;
			this.dspAskSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspAskSize.Is64Th = false;
			this.dspAskSize.IsCurrency = false;
			this.dspAskSize.IsFraction = false;
			this.dspAskSize.IsPercent = false;
			this.dspAskSize.Location = new System.Drawing.Point(155, 0);
			this.dspAskSize.MaxDecimal = 7;
			this.dspAskSize.Name = "dspAskSize";
			this.dspAskSize.Size = new System.Drawing.Size(13, 13);
			this.dspAskSize.TabIndex = 0;
			this.dspAskSize.Text = "0";
			this.dspAskSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspAskSize.TickSize = 0.01;
			this.dspAskSize.UpColor = System.Drawing.Color.LimeGreen;
			this.dspAskSize.Value = "";
			// 
			// lblAskSize
			// 
			this.lblAskSize.AutoSize = true;
			this.lblAskSize.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblAskSize.ForeColor = System.Drawing.Color.Khaki;
			this.lblAskSize.Location = new System.Drawing.Point(138, 0);
			this.lblAskSize.MaximumSize = new System.Drawing.Size(17, 14);
			this.lblAskSize.MinimumSize = new System.Drawing.Size(17, 14);
			this.lblAskSize.Name = "lblAskSize";
			this.lblAskSize.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblAskSize.Size = new System.Drawing.Size(17, 14);
			this.lblAskSize.TabIndex = 0;
			this.lblAskSize.Text = "sz";
			this.lblAskSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dspAskPrice
			// 
			this.dspAskPrice.AutoColor = false;
			this.dspAskPrice.AutoSize = true;
			this.dspAskPrice.DefaultColor = System.Drawing.Color.White;
			this.dspAskPrice.DefaultText = "0.00";
			this.dspAskPrice.DisplayFactor = 1;
			this.dspAskPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspAskPrice.DownColor = System.Drawing.Color.Red;
			this.dspAskPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspAskPrice.Is64Th = false;
			this.dspAskPrice.IsCurrency = false;
			this.dspAskPrice.IsFraction = true;
			this.dspAskPrice.IsPercent = false;
			this.dspAskPrice.Location = new System.Drawing.Point(107, 0);
			this.dspAskPrice.MaxDecimal = 2;
			this.dspAskPrice.Name = "dspAskPrice";
			this.dspAskPrice.Size = new System.Drawing.Size(31, 13);
			this.dspAskPrice.TabIndex = 0;
			this.dspAskPrice.Text = "0.00";
			this.dspAskPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspAskPrice.TickSize = 0.01;
			this.dspAskPrice.UpColor = System.Drawing.Color.LimeGreen;
			this.dspAskPrice.Value = "";
			this.dspAskPrice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Price_MouseDown);
			this.dspAskPrice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Price_MouseUp);
			// 
			// lblAskPrice
			// 
			this.lblAskPrice.AutoSize = true;
			this.lblAskPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblAskPrice.ForeColor = System.Drawing.Color.Khaki;
			this.lblAskPrice.Location = new System.Drawing.Point(83, 0);
			this.lblAskPrice.MaximumSize = new System.Drawing.Size(24, 14);
			this.lblAskPrice.MinimumSize = new System.Drawing.Size(24, 14);
			this.lblAskPrice.Name = "lblAskPrice";
			this.lblAskPrice.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblAskPrice.Size = new System.Drawing.Size(24, 14);
			this.lblAskPrice.TabIndex = 0;
			this.lblAskPrice.Text = "ask";
			this.lblAskPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dspBidSize
			// 
			this.dspBidSize.AutoColor = false;
			this.dspBidSize.AutoSize = true;
			this.dspBidSize.DefaultColor = System.Drawing.Color.White;
			this.dspBidSize.DefaultText = "0";
			this.dspBidSize.DisplayFactor = 1;
			this.dspBidSize.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspBidSize.DownColor = System.Drawing.Color.Red;
			this.dspBidSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspBidSize.Is64Th = false;
			this.dspBidSize.IsCurrency = false;
			this.dspBidSize.IsFraction = false;
			this.dspBidSize.IsPercent = false;
			this.dspBidSize.Location = new System.Drawing.Point(70, 0);
			this.dspBidSize.MaxDecimal = 7;
			this.dspBidSize.Name = "dspBidSize";
			this.dspBidSize.Size = new System.Drawing.Size(13, 13);
			this.dspBidSize.TabIndex = 0;
			this.dspBidSize.Text = "0";
			this.dspBidSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspBidSize.TickSize = 0.01;
			this.dspBidSize.UpColor = System.Drawing.Color.LimeGreen;
			this.dspBidSize.Value = "";
			// 
			// lblBidSize
			// 
			this.lblBidSize.AutoSize = true;
			this.lblBidSize.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblBidSize.ForeColor = System.Drawing.Color.Khaki;
			this.lblBidSize.Location = new System.Drawing.Point(53, 0);
			this.lblBidSize.MaximumSize = new System.Drawing.Size(17, 14);
			this.lblBidSize.MinimumSize = new System.Drawing.Size(17, 14);
			this.lblBidSize.Name = "lblBidSize";
			this.lblBidSize.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblBidSize.Size = new System.Drawing.Size(17, 14);
			this.lblBidSize.TabIndex = 0;
			this.lblBidSize.Text = "sz";
			this.lblBidSize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dspBidPrice
			// 
			this.dspBidPrice.AutoColor = false;
			this.dspBidPrice.AutoSize = true;
			this.dspBidPrice.DefaultColor = System.Drawing.Color.White;
			this.dspBidPrice.DefaultText = "0.00";
			this.dspBidPrice.DisplayFactor = 1;
			this.dspBidPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspBidPrice.DownColor = System.Drawing.Color.Red;
			this.dspBidPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspBidPrice.Is64Th = false;
			this.dspBidPrice.IsCurrency = false;
			this.dspBidPrice.IsFraction = true;
			this.dspBidPrice.IsPercent = false;
			this.dspBidPrice.Location = new System.Drawing.Point(22, 0);
			this.dspBidPrice.MaxDecimal = 2;
			this.dspBidPrice.Name = "dspBidPrice";
			this.dspBidPrice.Size = new System.Drawing.Size(31, 13);
			this.dspBidPrice.TabIndex = 0;
			this.dspBidPrice.Text = "0.00";
			this.dspBidPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspBidPrice.TickSize = 0.01;
			this.dspBidPrice.UpColor = System.Drawing.Color.LimeGreen;
			this.dspBidPrice.Value = "";
			this.dspBidPrice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Price_MouseDown);
			this.dspBidPrice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Price_MouseUp);
			// 
			// lblBidPrice
			// 
			this.lblBidPrice.AutoSize = true;
			this.lblBidPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblBidPrice.ForeColor = System.Drawing.Color.Khaki;
			this.lblBidPrice.Location = new System.Drawing.Point(0, 0);
			this.lblBidPrice.MaximumSize = new System.Drawing.Size(22, 14);
			this.lblBidPrice.MinimumSize = new System.Drawing.Size(22, 14);
			this.lblBidPrice.Name = "lblBidPrice";
			this.lblBidPrice.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
			this.lblBidPrice.Size = new System.Drawing.Size(22, 14);
			this.lblBidPrice.TabIndex = 0;
			this.lblBidPrice.Text = "bid";
			this.lblBidPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panelSymbolTrade
			// 
			this.panelSymbolTrade.Controls.Add(this.dspTradedPrice);
			this.panelSymbolTrade.Controls.Add(this.picTradeTick);
			this.panelSymbolTrade.Controls.Add(this.cboSymbolDetails);
			this.panelSymbolTrade.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelSymbolTrade.Location = new System.Drawing.Point(0, 0);
			this.panelSymbolTrade.Name = "panelSymbolTrade";
			this.panelSymbolTrade.Size = new System.Drawing.Size(91, 45);
			this.panelSymbolTrade.TabIndex = 0;
			// 
			// dspTradedPrice
			// 
			this.dspTradedPrice.AutoColor = false;
			this.dspTradedPrice.AutoSize = true;
			this.dspTradedPrice.DefaultColor = System.Drawing.Color.White;
			this.dspTradedPrice.DefaultText = "0.00";
			this.dspTradedPrice.DisplayFactor = 1;
			this.dspTradedPrice.Dock = System.Windows.Forms.DockStyle.Right;
			this.dspTradedPrice.DownColor = System.Drawing.Color.Red;
			this.dspTradedPrice.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspTradedPrice.Is64Th = false;
			this.dspTradedPrice.IsCurrency = false;
			this.dspTradedPrice.IsFraction = true;
			this.dspTradedPrice.IsPercent = false;
			this.dspTradedPrice.Location = new System.Drawing.Point(32, 22);
			this.dspTradedPrice.MaxDecimal = 7;
			this.dspTradedPrice.Name = "dspTradedPrice";
			this.dspTradedPrice.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.dspTradedPrice.Size = new System.Drawing.Size(36, 19);
			this.dspTradedPrice.TabIndex = 0;
			this.dspTradedPrice.Text = "0.00";
			this.dspTradedPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.dspTradedPrice.TickSize = 0.01;
			this.dspTradedPrice.UpColor = System.Drawing.Color.LimeGreen;
			this.dspTradedPrice.Value = "";
			this.dspTradedPrice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Price_MouseDown);
			this.dspTradedPrice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Price_MouseUp);
			// 
			// picTradeTick
			// 
			this.picTradeTick.Dock = System.Windows.Forms.DockStyle.Right;
			this.picTradeTick.Location = new System.Drawing.Point(68, 22);
			this.picTradeTick.MaximumSize = new System.Drawing.Size(23, 23);
			this.picTradeTick.MinimumSize = new System.Drawing.Size(23, 23);
			this.picTradeTick.Name = "picTradeTick";
			this.picTradeTick.Padding = new System.Windows.Forms.Padding(1);
			this.picTradeTick.Size = new System.Drawing.Size(23, 23);
			this.picTradeTick.TabIndex = 0;
			this.picTradeTick.TabStop = false;
			// 
			// cboSymbolDetails
			// 
			this.cboSymbolDetails.BackColor = System.Drawing.Color.Black;
			this.cboSymbolDetails.Dock = System.Windows.Forms.DockStyle.Top;
			this.cboSymbolDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboSymbolDetails.ForeColor = System.Drawing.Color.Gold;
			this.cboSymbolDetails.FormattingEnabled = true;
			this.cboSymbolDetails.Location = new System.Drawing.Point(0, 0);
			this.cboSymbolDetails.Name = "cboSymbolDetails";
			this.cboSymbolDetails.Size = new System.Drawing.Size(91, 22);
			this.cboSymbolDetails.TabIndex = 0;
			this.cboSymbolDetails.TabStop = false;
			this.cboSymbolDetails.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboSymbolDetails_KeyUp);
			this.cboSymbolDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboSymbolDetails_KeyDown);
			// 
			// panelOrderInfo
			// 
			this.panelOrderInfo.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panelOrderInfo.Controls.Add(this.panelOrderInfoMsg);
			this.panelOrderInfo.Controls.Add(this.panelOrderInfoUpper);
			this.panelOrderInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelOrderInfo.Location = new System.Drawing.Point(0, 96);
			this.panelOrderInfo.Name = "panelOrderInfo";
			this.panelOrderInfo.Size = new System.Drawing.Size(362, 80);
			this.panelOrderInfo.TabIndex = 0;
			// 
			// panelOrderInfoMsg
			// 
			this.panelOrderInfoMsg.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panelOrderInfoMsg.Controls.Add(this.lblDoNotTranslate);
			this.panelOrderInfoMsg.Controls.Add(this.dspOrderMsg);
			this.panelOrderInfoMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelOrderInfoMsg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panelOrderInfoMsg.Location = new System.Drawing.Point(0, 55);
			this.panelOrderInfoMsg.Name = "panelOrderInfoMsg";
			this.panelOrderInfoMsg.Padding = new System.Windows.Forms.Padding(4);
			this.panelOrderInfoMsg.Size = new System.Drawing.Size(362, 25);
			this.panelOrderInfoMsg.TabIndex = 0;
			// 
			// lblDoNotTranslate
			// 
			this.lblDoNotTranslate.AutoColor = false;
			this.lblDoNotTranslate.BlinkBackColor = System.Drawing.Color.Black;
			this.lblDoNotTranslate.BlinkForeColorColor = System.Drawing.Color.Red;
			this.lblDoNotTranslate.BlinkInnerBorderColor = System.Drawing.Color.Black;
			this.lblDoNotTranslate.BlinkOuterBorderColor = System.Drawing.Color.Black;
			this.lblDoNotTranslate.DefaultColor = System.Drawing.Color.White;
			this.lblDoNotTranslate.DefaultText = "Please use CME electronic symbol";
			this.lblDoNotTranslate.DisplayFactor = 1;
			this.lblDoNotTranslate.Dock = System.Windows.Forms.DockStyle.Left;
			this.lblDoNotTranslate.DownColor = System.Drawing.Color.Red;
			this.lblDoNotTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDoNotTranslate.Is64Th = false;
			this.lblDoNotTranslate.IsCurrency = false;
			this.lblDoNotTranslate.IsFraction = false;
			this.lblDoNotTranslate.IsPercent = false;
			this.lblDoNotTranslate.Location = new System.Drawing.Point(4, 4);
			this.lblDoNotTranslate.MaxDecimal = 7;
			this.lblDoNotTranslate.Name = "lblDoNotTranslate";
			this.lblDoNotTranslate.OuterBorderColor = System.Drawing.Color.Black;
			this.lblDoNotTranslate.Size = new System.Drawing.Size(208, 17);
			this.lblDoNotTranslate.TabIndex = 2;
			this.lblDoNotTranslate.Text = "Please use CME electronic symbol";
			this.lblDoNotTranslate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblDoNotTranslate.TickSize = 0.01;
			this.lblDoNotTranslate.UpColor = System.Drawing.Color.LimeGreen;
			this.lblDoNotTranslate.Value = "";
			this.lblDoNotTranslate.Visible = false;
			// 
			// dspOrderMsg
			// 
			this.dspOrderMsg.BackColor = System.Drawing.Color.White;
			this.dspOrderMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dspOrderMsg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dspOrderMsg.ForeColor = System.Drawing.Color.Black;
			this.dspOrderMsg.Location = new System.Drawing.Point(4, 4);
			this.dspOrderMsg.Multiline = false;
			this.dspOrderMsg.Name = "dspOrderMsg";
			this.dspOrderMsg.ReadOnly = true;
			this.dspOrderMsg.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.dspOrderMsg.Size = new System.Drawing.Size(354, 17);
			this.dspOrderMsg.TabIndex = 0;
			this.dspOrderMsg.TabStop = false;
			this.dspOrderMsg.Text = "";
			// 
			// panelOrderInfoUpper
			// 
			this.panelOrderInfoUpper.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panelOrderInfoUpper.Controls.Add(this.panelShortLender);
			this.panelOrderInfoUpper.Controls.Add(this.panelStopLimitOffset);
			this.panelOrderInfoUpper.Controls.Add(this.panelExchange);
			this.panelOrderInfoUpper.Controls.Add(this.panelDuration);
			this.panelOrderInfoUpper.Controls.Add(this.panelStopPrice);
			this.panelOrderInfoUpper.Controls.Add(this.panelLimitPrice);
			this.panelOrderInfoUpper.Controls.Add(this.panelOrderTypes);
			this.panelOrderInfoUpper.Controls.Add(this.panelShares);
			this.panelOrderInfoUpper.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelOrderInfoUpper.Location = new System.Drawing.Point(0, 0);
			this.panelOrderInfoUpper.Name = "panelOrderInfoUpper";
			this.panelOrderInfoUpper.Size = new System.Drawing.Size(362, 55);
			this.panelOrderInfoUpper.TabIndex = 0;
			// 
			// panelShortLender
			// 
			this.panelShortLender.Controls.Add(this.cboShortLenders);
			this.panelShortLender.Controls.Add(this.lblShortLender);
			this.panelShortLender.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelShortLender.Location = new System.Drawing.Point(445, 0);
			this.panelShortLender.MinimumSize = new System.Drawing.Size(79, 55);
			this.panelShortLender.Name = "panelShortLender";
			this.panelShortLender.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
			this.panelShortLender.Size = new System.Drawing.Size(79, 55);
			this.panelShortLender.TabIndex = 0;
			this.panelShortLender.Visible = false;
			// 
			// cboShortLenders
			// 
			this.cboShortLenders.BackColor = System.Drawing.Color.White;
			this.cboShortLenders.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboShortLenders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboShortLenders.ForeColor = System.Drawing.Color.Black;
			this.cboShortLenders.FormattingEnabled = true;
			this.cboShortLenders.Location = new System.Drawing.Point(2, 18);
			this.cboShortLenders.Name = "cboShortLenders";
			this.cboShortLenders.Size = new System.Drawing.Size(75, 21);
			this.cboShortLenders.TabIndex = 0;
			this.cboShortLenders.TabStop = false;
			this.cboShortLenders.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboShortLenders_KeyUp);
			this.cboShortLenders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboShortLenders_KeyDown);
			this.cboShortLenders.TextChanged += new System.EventHandler(this.Ticket_ValueChanged);
			// 
			// lblShortLender
			// 
			this.lblShortLender.AutoSize = true;
			this.lblShortLender.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblShortLender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblShortLender.Location = new System.Drawing.Point(2, 3);
			this.lblShortLender.Name = "lblShortLender";
			this.lblShortLender.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblShortLender.Size = new System.Drawing.Size(73, 15);
			this.lblShortLender.TabIndex = 0;
			this.lblShortLender.Text = "Short Lenders";
			// 
			// panelStopLimitOffset
			// 
			this.panelStopLimitOffset.Controls.Add(this.numStopLimitOffset);
			this.panelStopLimitOffset.Controls.Add(this.lblStopLimitOffset);
			this.panelStopLimitOffset.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelStopLimitOffset.Location = new System.Drawing.Point(361, 0);
			this.panelStopLimitOffset.MinimumSize = new System.Drawing.Size(59, 55);
			this.panelStopLimitOffset.Name = "panelStopLimitOffset";
			this.panelStopLimitOffset.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
			this.panelStopLimitOffset.Size = new System.Drawing.Size(84, 55);
			this.panelStopLimitOffset.TabIndex = 1;
			this.panelStopLimitOffset.Visible = false;
			// 
			// numStopLimitOffset
			// 
			this.numStopLimitOffset.BackColor = System.Drawing.Color.White;
			this.numStopLimitOffset.Dock = System.Windows.Forms.DockStyle.Top;
			this.numStopLimitOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numStopLimitOffset.ForeColor = System.Drawing.Color.Black;
			this.numStopLimitOffset.Location = new System.Drawing.Point(2, 18);
			this.numStopLimitOffset.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.numStopLimitOffset.Name = "numStopLimitOffset";
			this.numStopLimitOffset.Size = new System.Drawing.Size(80, 21);
			this.numStopLimitOffset.TabIndex = 1;
			this.numStopLimitOffset.TabStop = false;
			this.numStopLimitOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblStopLimitOffset
			// 
			this.lblStopLimitOffset.AutoSize = true;
			this.lblStopLimitOffset.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblStopLimitOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStopLimitOffset.Location = new System.Drawing.Point(2, 3);
			this.lblStopLimitOffset.Name = "lblStopLimitOffset";
			this.lblStopLimitOffset.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblStopLimitOffset.Size = new System.Drawing.Size(78, 15);
			this.lblStopLimitOffset.TabIndex = 0;
			this.lblStopLimitOffset.Text = "StopLimitOffset";
			// 
			// panelExchange
			// 
			this.panelExchange.Controls.Add(this.cboExchange);
			this.panelExchange.Controls.Add(this.lblExchange);
			this.panelExchange.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelExchange.Location = new System.Drawing.Point(301, 0);
			this.panelExchange.MinimumSize = new System.Drawing.Size(60, 55);
			this.panelExchange.Name = "panelExchange";
			this.panelExchange.Padding = new System.Windows.Forms.Padding(2, 3, 2, 2);
			this.panelExchange.Size = new System.Drawing.Size(60, 55);
			this.panelExchange.TabIndex = 0;
			// 
			// cboExchange
			// 
			this.cboExchange.BackColor = System.Drawing.Color.WhiteSmoke;
			this.cboExchange.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cboExchange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboExchange.ForeColor = System.Drawing.Color.Black;
			this.cboExchange.FormattingEnabled = true;
			this.cboExchange.Location = new System.Drawing.Point(2, 18);
			this.cboExchange.Name = "cboExchange";
			this.cboExchange.Size = new System.Drawing.Size(56, 21);
			this.cboExchange.TabIndex = 0;
			this.cboExchange.TabStop = false;
			this.cboExchange.SelectedIndexChanged += new System.EventHandler(this.Ticket_ValueChanged);
			this.cboExchange.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
			// 
			// lblExchange
			// 
			this.lblExchange.AutoSize = true;
			this.lblExchange.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblExchange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblExchange.Location = new System.Drawing.Point(2, 3);
			this.lblExchange.Name = "lblExchange";
			this.lblExchange.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblExchange.Size = new System.Drawing.Size(55, 15);
			this.lblExchange.TabIndex = 0;
			this.lblExchange.Text = "Exchange";
			// 
			// panelDuration
			// 
			this.panelDuration.Controls.Add(this.cboDuration);
			this.panelDuration.Controls.Add(this.lblDuration);
			this.panelDuration.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelDuration.Location = new System.Drawing.Point(245, 0);
			this.panelDuration.MinimumSize = new System.Drawing.Size(56, 55);
			this.panelDuration.Name = "panelDuration";
			this.panelDuration.Padding = new System.Windows.Forms.Padding(2);
			this.panelDuration.Size = new System.Drawing.Size(56, 55);
			this.panelDuration.TabIndex = 0;
			// 
			// cboDuration
			// 
			this.cboDuration.BackColor = System.Drawing.Color.White;
			this.cboDuration.Dock = System.Windows.Forms.DockStyle.Top;
			this.cboDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboDuration.ForeColor = System.Drawing.Color.Black;
			this.cboDuration.FormattingEnabled = true;
			this.cboDuration.Location = new System.Drawing.Point(2, 17);
			this.cboDuration.MinimumSize = new System.Drawing.Size(50, 0);
			this.cboDuration.Name = "cboDuration";
			this.cboDuration.Size = new System.Drawing.Size(52, 21);
			this.cboDuration.TabIndex = 0;
			this.cboDuration.TabStop = false;
			this.cboDuration.SelectedIndexChanged += new System.EventHandler(this.Ticket_ValueChanged);
			this.cboDuration.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
			// 
			// lblDuration
			// 
			this.lblDuration.AutoSize = true;
			this.lblDuration.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDuration.Location = new System.Drawing.Point(2, 2);
			this.lblDuration.Name = "lblDuration";
			this.lblDuration.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblDuration.Size = new System.Drawing.Size(47, 15);
			this.lblDuration.TabIndex = 0;
			this.lblDuration.Text = "Duration";
			// 
			// panelStopPrice
			// 
			this.panelStopPrice.Controls.Add(this.dspStopPrice);
			this.panelStopPrice.Controls.Add(this.dspStopPriceTickSize);
			this.panelStopPrice.Controls.Add(this.lblStopPriceX);
			this.panelStopPrice.Controls.Add(this.dspStopPriceIncrement);
			this.panelStopPrice.Controls.Add(this.numStopPrice);
			this.panelStopPrice.Controls.Add(this.lblStopPrice);
			this.panelStopPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelStopPrice.Location = new System.Drawing.Point(180, 0);
			this.panelStopPrice.MinimumSize = new System.Drawing.Size(65, 55);
			this.panelStopPrice.Name = "panelStopPrice";
			this.panelStopPrice.Padding = new System.Windows.Forms.Padding(2);
			this.panelStopPrice.Size = new System.Drawing.Size(65, 55);
			this.panelStopPrice.TabIndex = 0;
			this.panelStopPrice.Click += new System.EventHandler(this.PriceSelection_Click);
			// 
			// dspStopPrice
			// 
			this.dspStopPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dspStopPrice.BackColor = System.Drawing.Color.White;
			this.dspStopPrice.Location = new System.Drawing.Point(2, 17);
			this.dspStopPrice.Name = "dspStopPrice";
			this.dspStopPrice.ReadOnly = true;
			this.dspStopPrice.Size = new System.Drawing.Size(43, 20);
			this.dspStopPrice.TabIndex = 0;
			this.dspStopPrice.TabStop = false;
			this.dspStopPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.dspStopPrice.WordWrap = false;
			this.dspStopPrice.MouseLeave += new System.EventHandler(this.dspStopPrice_Leave);
			this.dspStopPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dspStopPrice_KeyDown);
			this.dspStopPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
			// 
			// dspStopPriceTickSize
			// 
			this.dspStopPriceTickSize.AutoColor = false;
			this.dspStopPriceTickSize.AutoSize = true;
			this.dspStopPriceTickSize.BackColor = System.Drawing.Color.Transparent;
			this.dspStopPriceTickSize.DefaultColor = System.Drawing.Color.White;
			this.dspStopPriceTickSize.DefaultText = "0.01";
			this.dspStopPriceTickSize.DisplayFactor = 1;
			this.dspStopPriceTickSize.Dock = System.Windows.Forms.DockStyle.Right;
			this.dspStopPriceTickSize.DownColor = System.Drawing.Color.Red;
			this.dspStopPriceTickSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspStopPriceTickSize.ForeColor = System.Drawing.Color.Gainsboro;
			this.dspStopPriceTickSize.Is64Th = false;
			this.dspStopPriceTickSize.IsCurrency = false;
			this.dspStopPriceTickSize.IsFraction = true;
			this.dspStopPriceTickSize.IsPercent = false;
			this.dspStopPriceTickSize.Location = new System.Drawing.Point(12, 38);
			this.dspStopPriceTickSize.MaxDecimal = 7;
			this.dspStopPriceTickSize.Name = "dspStopPriceTickSize";
			this.dspStopPriceTickSize.Size = new System.Drawing.Size(27, 12);
			this.dspStopPriceTickSize.TabIndex = 0;
			this.dspStopPriceTickSize.Text = "0.01";
			this.dspStopPriceTickSize.TickSize = 0.01;
			this.dspStopPriceTickSize.UpColor = System.Drawing.Color.LimeGreen;
			this.dspStopPriceTickSize.Value = "";
			this.dspStopPriceTickSize.Click += new System.EventHandler(this.PriceSelection_Click);
			// 
			// lblStopPriceX
			// 
			this.lblStopPriceX.AutoColor = false;
			this.lblStopPriceX.AutoSize = true;
			this.lblStopPriceX.BackColor = System.Drawing.Color.Transparent;
			this.lblStopPriceX.DefaultColor = System.Drawing.Color.White;
			this.lblStopPriceX.DefaultText = "0.01";
			this.lblStopPriceX.DisplayFactor = 1;
			this.lblStopPriceX.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblStopPriceX.DownColor = System.Drawing.Color.Red;
			this.lblStopPriceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStopPriceX.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblStopPriceX.Is64Th = false;
			this.lblStopPriceX.IsCurrency = false;
			this.lblStopPriceX.IsFraction = false;
			this.lblStopPriceX.IsPercent = false;
			this.lblStopPriceX.Location = new System.Drawing.Point(39, 38);
			this.lblStopPriceX.MaxDecimal = 7;
			this.lblStopPriceX.Name = "lblStopPriceX";
			this.lblStopPriceX.Size = new System.Drawing.Size(11, 12);
			this.lblStopPriceX.TabIndex = 0;
			this.lblStopPriceX.Text = "x";
			this.lblStopPriceX.TickSize = 0.01;
			this.lblStopPriceX.UpColor = System.Drawing.Color.LimeGreen;
			this.lblStopPriceX.Value = "";
			this.lblStopPriceX.Click += new System.EventHandler(this.PriceSelection_Click);
			// 
			// dspStopPriceIncrement
			// 
			this.dspStopPriceIncrement.AutoColor = false;
			this.dspStopPriceIncrement.AutoSize = true;
			this.dspStopPriceIncrement.BackColor = System.Drawing.SystemColors.ControlText;
			this.dspStopPriceIncrement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dspStopPriceIncrement.DefaultColor = System.Drawing.Color.White;
			this.dspStopPriceIncrement.DefaultText = "100";
			this.dspStopPriceIncrement.DisplayFactor = 1;
			this.dspStopPriceIncrement.Dock = System.Windows.Forms.DockStyle.Right;
			this.dspStopPriceIncrement.DownColor = System.Drawing.Color.Red;
			this.dspStopPriceIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspStopPriceIncrement.ForeColor = System.Drawing.Color.Gainsboro;
			this.dspStopPriceIncrement.Is64Th = false;
			this.dspStopPriceIncrement.IsCurrency = false;
			this.dspStopPriceIncrement.IsFraction = false;
			this.dspStopPriceIncrement.IsPercent = false;
			this.dspStopPriceIncrement.Location = new System.Drawing.Point(50, 38);
			this.dspStopPriceIncrement.MaxDecimal = 0;
			this.dspStopPriceIncrement.Name = "dspStopPriceIncrement";
			this.dspStopPriceIncrement.Size = new System.Drawing.Size(13, 14);
			this.dspStopPriceIncrement.TabIndex = 0;
			this.dspStopPriceIncrement.Text = "1";
			this.dspStopPriceIncrement.TickSize = 0.01;
			this.dspStopPriceIncrement.UpColor = System.Drawing.Color.LimeGreen;
			this.dspStopPriceIncrement.Value = "";
			this.dspStopPriceIncrement.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dspStopPriceIncrement_MouseClick);
			// 
			// numStopPrice
			// 
			this.numStopPrice.BackColor = System.Drawing.Color.White;
			this.numStopPrice.DecimalPlaces = 2;
			this.numStopPrice.Dock = System.Windows.Forms.DockStyle.Top;
			this.numStopPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numStopPrice.ForeColor = System.Drawing.Color.Black;
			this.numStopPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numStopPrice.Location = new System.Drawing.Point(2, 17);
			this.numStopPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.numStopPrice.Name = "numStopPrice";
			this.numStopPrice.Size = new System.Drawing.Size(61, 21);
			this.numStopPrice.TabIndex = 0;
			this.numStopPrice.TabStop = false;
			this.numStopPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numStopPrice.ValueChanged += new System.EventHandler(this.Ticket_ValueChanged);
			this.numStopPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
			// 
			// lblStopPrice
			// 
			this.lblStopPrice.AutoSize = true;
			this.lblStopPrice.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblStopPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStopPrice.Location = new System.Drawing.Point(2, 2);
			this.lblStopPrice.Name = "lblStopPrice";
			this.lblStopPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblStopPrice.Size = new System.Drawing.Size(56, 15);
			this.lblStopPrice.TabIndex = 0;
			this.lblStopPrice.Text = "Stop Price";
			this.lblStopPrice.Click += new System.EventHandler(this.PriceSelection_Click);
			// 
			// panelLimitPrice
			// 
			this.panelLimitPrice.BackColor = System.Drawing.Color.CornflowerBlue;
			this.panelLimitPrice.Controls.Add(this.dspLimitPrice);
			this.panelLimitPrice.Controls.Add(this.dspLimitPriceTickSize);
			this.panelLimitPrice.Controls.Add(this.lblLimitPriceX);
			this.panelLimitPrice.Controls.Add(this.dspLimitPriceIncrement);
			this.panelLimitPrice.Controls.Add(this.numLimitPrice);
			this.panelLimitPrice.Controls.Add(this.lblLimitPrice);
			this.panelLimitPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelLimitPrice.Location = new System.Drawing.Point(115, 0);
			this.panelLimitPrice.MinimumSize = new System.Drawing.Size(65, 55);
			this.panelLimitPrice.Name = "panelLimitPrice";
			this.panelLimitPrice.Padding = new System.Windows.Forms.Padding(2);
			this.panelLimitPrice.Size = new System.Drawing.Size(65, 55);
			this.panelLimitPrice.TabIndex = 0;
			this.panelLimitPrice.Click += new System.EventHandler(this.PriceSelection_Click);
			// 
			// dspLimitPrice
			// 
			this.dspLimitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dspLimitPrice.BackColor = System.Drawing.Color.White;
			this.dspLimitPrice.Location = new System.Drawing.Point(2, 17);
			this.dspLimitPrice.Name = "dspLimitPrice";
			this.dspLimitPrice.Size = new System.Drawing.Size(43, 20);
			this.dspLimitPrice.TabIndex = 0;
			this.dspLimitPrice.TabStop = false;
			this.dspLimitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.dspLimitPrice.WordWrap = false;
			this.dspLimitPrice.MouseLeave += new System.EventHandler(this.dspLimitPrice_Leave);
			this.dspLimitPrice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dspLimitPrice_KeyDown);
			this.dspLimitPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
			// 
			// dspLimitPriceTickSize
			// 
			this.dspLimitPriceTickSize.AutoColor = false;
			this.dspLimitPriceTickSize.AutoSize = true;
			this.dspLimitPriceTickSize.BackColor = System.Drawing.Color.Transparent;
			this.dspLimitPriceTickSize.DefaultColor = System.Drawing.Color.White;
			this.dspLimitPriceTickSize.DefaultText = "0.01";
			this.dspLimitPriceTickSize.DisplayFactor = 1;
			this.dspLimitPriceTickSize.Dock = System.Windows.Forms.DockStyle.Right;
			this.dspLimitPriceTickSize.DownColor = System.Drawing.Color.Red;
			this.dspLimitPriceTickSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspLimitPriceTickSize.ForeColor = System.Drawing.Color.Gainsboro;
			this.dspLimitPriceTickSize.Is64Th = false;
			this.dspLimitPriceTickSize.IsCurrency = false;
			this.dspLimitPriceTickSize.IsFraction = true;
			this.dspLimitPriceTickSize.IsPercent = false;
			this.dspLimitPriceTickSize.Location = new System.Drawing.Point(12, 38);
			this.dspLimitPriceTickSize.MaxDecimal = 7;
			this.dspLimitPriceTickSize.Name = "dspLimitPriceTickSize";
			this.dspLimitPriceTickSize.Size = new System.Drawing.Size(27, 12);
			this.dspLimitPriceTickSize.TabIndex = 0;
			this.dspLimitPriceTickSize.Text = "0.01";
			this.dspLimitPriceTickSize.TickSize = 0.01;
			this.dspLimitPriceTickSize.UpColor = System.Drawing.Color.LimeGreen;
			this.dspLimitPriceTickSize.Value = "";
			this.dspLimitPriceTickSize.Click += new System.EventHandler(this.PriceSelection_Click);
			// 
			// lblLimitPriceX
			// 
			this.lblLimitPriceX.AutoColor = false;
			this.lblLimitPriceX.AutoSize = true;
			this.lblLimitPriceX.BackColor = System.Drawing.Color.Transparent;
			this.lblLimitPriceX.DefaultColor = System.Drawing.Color.White;
			this.lblLimitPriceX.DefaultText = "0.01";
			this.lblLimitPriceX.DisplayFactor = 1;
			this.lblLimitPriceX.Dock = System.Windows.Forms.DockStyle.Right;
			this.lblLimitPriceX.DownColor = System.Drawing.Color.Red;
			this.lblLimitPriceX.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLimitPriceX.ForeColor = System.Drawing.Color.Gainsboro;
			this.lblLimitPriceX.Is64Th = false;
			this.lblLimitPriceX.IsCurrency = false;
			this.lblLimitPriceX.IsFraction = false;
			this.lblLimitPriceX.IsPercent = false;
			this.lblLimitPriceX.Location = new System.Drawing.Point(39, 38);
			this.lblLimitPriceX.MaxDecimal = 7;
			this.lblLimitPriceX.Name = "lblLimitPriceX";
			this.lblLimitPriceX.Size = new System.Drawing.Size(11, 12);
			this.lblLimitPriceX.TabIndex = 0;
			this.lblLimitPriceX.Text = "x";
			this.lblLimitPriceX.TickSize = 0.01;
			this.lblLimitPriceX.UpColor = System.Drawing.Color.LimeGreen;
			this.lblLimitPriceX.Value = "";
			this.lblLimitPriceX.Click += new System.EventHandler(this.PriceSelection_Click);
			// 
			// dspLimitPriceIncrement
			// 
			this.dspLimitPriceIncrement.AutoColor = false;
			this.dspLimitPriceIncrement.AutoSize = true;
			this.dspLimitPriceIncrement.BackColor = System.Drawing.SystemColors.ControlText;
			this.dspLimitPriceIncrement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dspLimitPriceIncrement.DefaultColor = System.Drawing.Color.White;
			this.dspLimitPriceIncrement.DefaultText = "100";
			this.dspLimitPriceIncrement.DisplayFactor = 1;
			this.dspLimitPriceIncrement.Dock = System.Windows.Forms.DockStyle.Right;
			this.dspLimitPriceIncrement.DownColor = System.Drawing.Color.Red;
			this.dspLimitPriceIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspLimitPriceIncrement.ForeColor = System.Drawing.Color.Gainsboro;
			this.dspLimitPriceIncrement.Is64Th = false;
			this.dspLimitPriceIncrement.IsCurrency = false;
			this.dspLimitPriceIncrement.IsFraction = false;
			this.dspLimitPriceIncrement.IsPercent = false;
			this.dspLimitPriceIncrement.Location = new System.Drawing.Point(50, 38);
			this.dspLimitPriceIncrement.MaxDecimal = 0;
			this.dspLimitPriceIncrement.Name = "dspLimitPriceIncrement";
			this.dspLimitPriceIncrement.Size = new System.Drawing.Size(13, 14);
			this.dspLimitPriceIncrement.TabIndex = 0;
			this.dspLimitPriceIncrement.Text = "1";
			this.dspLimitPriceIncrement.TickSize = 0.01;
			this.dspLimitPriceIncrement.UpColor = System.Drawing.Color.LimeGreen;
			this.dspLimitPriceIncrement.Value = "";
			this.dspLimitPriceIncrement.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dspLimitPriceIncrement_MouseClick);
			// 
			// numLimitPrice
			// 
			this.numLimitPrice.BackColor = System.Drawing.Color.White;
			this.numLimitPrice.DecimalPlaces = 2;
			this.numLimitPrice.Dock = System.Windows.Forms.DockStyle.Top;
			this.numLimitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numLimitPrice.ForeColor = System.Drawing.Color.Black;
			this.numLimitPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numLimitPrice.Location = new System.Drawing.Point(2, 17);
			this.numLimitPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.numLimitPrice.Name = "numLimitPrice";
			this.numLimitPrice.Size = new System.Drawing.Size(61, 21);
			this.numLimitPrice.TabIndex = 0;
			this.numLimitPrice.TabStop = false;
			this.numLimitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numLimitPrice.ValueChanged += new System.EventHandler(this.Ticket_ValueChanged);
			this.numLimitPrice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
			// 
			// lblLimitPrice
			// 
			this.lblLimitPrice.AutoSize = true;
			this.lblLimitPrice.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblLimitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLimitPrice.Location = new System.Drawing.Point(2, 2);
			this.lblLimitPrice.Name = "lblLimitPrice";
			this.lblLimitPrice.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblLimitPrice.Size = new System.Drawing.Size(55, 15);
			this.lblLimitPrice.TabIndex = 0;
			this.lblLimitPrice.Text = "Limit Price";
			this.lblLimitPrice.Click += new System.EventHandler(this.PriceSelection_Click);
			// 
			// panelOrderTypes
			// 
			this.panelOrderTypes.Controls.Add(this.cboOrder);
			this.panelOrderTypes.Controls.Add(this.lblOrderType);
			this.panelOrderTypes.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelOrderTypes.Location = new System.Drawing.Point(53, 0);
			this.panelOrderTypes.MinimumSize = new System.Drawing.Size(62, 55);
			this.panelOrderTypes.Name = "panelOrderTypes";
			this.panelOrderTypes.Padding = new System.Windows.Forms.Padding(2);
			this.panelOrderTypes.Size = new System.Drawing.Size(62, 55);
			this.panelOrderTypes.TabIndex = 0;
			// 
			// cboOrder
			// 
			this.cboOrder.BackColor = System.Drawing.Color.White;
			this.cboOrder.Dock = System.Windows.Forms.DockStyle.Top;
			this.cboOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboOrder.DropDownWidth = 106;
			this.cboOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cboOrder.ForeColor = System.Drawing.Color.Black;
			this.cboOrder.FormattingEnabled = true;
			this.cboOrder.Location = new System.Drawing.Point(2, 17);
			this.cboOrder.Name = "cboOrder";
			this.cboOrder.Size = new System.Drawing.Size(58, 21);
			this.cboOrder.TabIndex = 0;
			this.cboOrder.TabStop = false;
			this.cboOrder.SelectedIndexChanged += new System.EventHandler(this.Ticket_ValueChanged);
			this.cboOrder.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
			// 
			// lblOrderType
			// 
			this.lblOrderType.AutoSize = true;
			this.lblOrderType.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblOrderType.Location = new System.Drawing.Point(2, 2);
			this.lblOrderType.Name = "lblOrderType";
			this.lblOrderType.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblOrderType.Size = new System.Drawing.Size(33, 15);
			this.lblOrderType.TabIndex = 0;
			this.lblOrderType.Text = "Order";
			// 
			// panelShares
			// 
			this.panelShares.Controls.Add(this.dspQuantityIncrement);
			this.panelShares.Controls.Add(this.numQuantity);
			this.panelShares.Controls.Add(this.lblQuantity);
			this.panelShares.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelShares.Location = new System.Drawing.Point(0, 0);
			this.panelShares.MinimumSize = new System.Drawing.Size(53, 55);
			this.panelShares.Name = "panelShares";
			this.panelShares.Padding = new System.Windows.Forms.Padding(2);
			this.panelShares.Size = new System.Drawing.Size(53, 55);
			this.panelShares.TabIndex = 0;
			// 
			// dspQuantityIncrement
			// 
			this.dspQuantityIncrement.AutoColor = false;
			this.dspQuantityIncrement.AutoSize = true;
			this.dspQuantityIncrement.BackColor = System.Drawing.SystemColors.ControlText;
			this.dspQuantityIncrement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dspQuantityIncrement.DefaultColor = System.Drawing.Color.White;
			this.dspQuantityIncrement.DefaultText = "100";
			this.dspQuantityIncrement.DisplayFactor = 1;
			this.dspQuantityIncrement.Dock = System.Windows.Forms.DockStyle.Right;
			this.dspQuantityIncrement.DownColor = System.Drawing.Color.Red;
			this.dspQuantityIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspQuantityIncrement.ForeColor = System.Drawing.Color.Gainsboro;
			this.dspQuantityIncrement.Is64Th = false;
			this.dspQuantityIncrement.IsCurrency = false;
			this.dspQuantityIncrement.IsFraction = false;
			this.dspQuantityIncrement.IsPercent = false;
			this.dspQuantityIncrement.Location = new System.Drawing.Point(26, 38);
			this.dspQuantityIncrement.MaxDecimal = 0;
			this.dspQuantityIncrement.Name = "dspQuantityIncrement";
			this.dspQuantityIncrement.Size = new System.Drawing.Size(25, 14);
			this.dspQuantityIncrement.TabIndex = 0;
			this.dspQuantityIncrement.Text = "100";
			this.dspQuantityIncrement.TickSize = 0.01;
			this.dspQuantityIncrement.UpColor = System.Drawing.Color.LimeGreen;
			this.dspQuantityIncrement.Value = "";
			this.dspQuantityIncrement.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dspQuantityIncrement_MouseClick);
			// 
			// numQuantity
			// 
			this.numQuantity.BackColor = System.Drawing.Color.White;
			this.numQuantity.Dock = System.Windows.Forms.DockStyle.Top;
			this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.numQuantity.ForeColor = System.Drawing.Color.Black;
			this.numQuantity.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numQuantity.Location = new System.Drawing.Point(2, 17);
			this.numQuantity.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
			this.numQuantity.Name = "numQuantity";
			this.numQuantity.Size = new System.Drawing.Size(49, 21);
			this.numQuantity.TabIndex = 0;
			this.numQuantity.TabStop = false;
			this.numQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numQuantity.ValueChanged += new System.EventHandler(this.Ticket_ValueChanged);
			this.numQuantity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Control_KeyUp);
			// 
			// lblQuantity
			// 
			this.lblQuantity.AutoSize = true;
			this.lblQuantity.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuantity.Location = new System.Drawing.Point(2, 2);
			this.lblQuantity.Name = "lblQuantity";
			this.lblQuantity.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			this.lblQuantity.Size = new System.Drawing.Size(23, 15);
			this.lblQuantity.TabIndex = 0;
			this.lblQuantity.Text = "Qty";
			// 
			// panelCommands
			// 
			this.panelCommands.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panelCommands.Controls.Add(this.cmdShort);
			this.panelCommands.Controls.Add(this.cmdSell);
			this.panelCommands.Controls.Add(this.cmdBuy);
			this.panelCommands.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCommands.Location = new System.Drawing.Point(0, 176);
			this.panelCommands.MinimumSize = new System.Drawing.Size(241, 24);
			this.panelCommands.Name = "panelCommands";
			this.panelCommands.Padding = new System.Windows.Forms.Padding(2);
			this.panelCommands.Size = new System.Drawing.Size(362, 24);
			this.panelCommands.TabIndex = 0;
			// 
			// cmdShort
			// 
			this.cmdShort.BackColor = System.Drawing.Color.Orchid;
			this.cmdShort.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmdShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdShort.ForeColor = System.Drawing.Color.Black;
			this.cmdShort.Location = new System.Drawing.Point(120, 2);
			this.cmdShort.MinimumSize = new System.Drawing.Size(100, 20);
			this.cmdShort.Name = "cmdShort";
			this.cmdShort.Size = new System.Drawing.Size(122, 20);
			this.cmdShort.TabIndex = 0;
			this.cmdShort.TabStop = false;
			this.cmdShort.Text = "SHORT";
			this.cmdShort.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdShort.UserSplitSize = 20;
			this.cmdShort.Visible = false;
			this.cmdShort.Click += new System.EventHandler(this.cmdShort_Click);
			// 
			// cmdSell
			// 
			this.cmdSell.BackColor = System.Drawing.Color.Red;
			this.cmdSell.Dock = System.Windows.Forms.DockStyle.Right;
			this.cmdSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdSell.ForeColor = System.Drawing.Color.Black;
			this.cmdSell.Location = new System.Drawing.Point(242, 2);
			this.cmdSell.MinimumSize = new System.Drawing.Size(100, 20);
			this.cmdSell.Name = "cmdSell";
			this.cmdSell.Size = new System.Drawing.Size(118, 20);
			this.cmdSell.TabIndex = 0;
			this.cmdSell.TabStop = false;
			this.cmdSell.Text = "SELL";
			this.cmdSell.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdSell.UserSplitSize = 20;
			this.cmdSell.Click += new System.EventHandler(this.cmdSell_Click);
			// 
			// cmdBuy
			// 
			this.cmdBuy.BackColor = System.Drawing.Color.LimeGreen;
			this.cmdBuy.Dock = System.Windows.Forms.DockStyle.Left;
			this.cmdBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdBuy.ForeColor = System.Drawing.Color.Black;
			this.cmdBuy.Location = new System.Drawing.Point(2, 2);
			this.cmdBuy.MinimumSize = new System.Drawing.Size(100, 20);
			this.cmdBuy.Name = "cmdBuy";
			this.cmdBuy.Size = new System.Drawing.Size(118, 20);
			this.cmdBuy.TabIndex = 0;
			this.cmdBuy.TabStop = false;
			this.cmdBuy.Text = "BUY";
			this.cmdBuy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.cmdBuy.UserSplitSize = 20;
			this.cmdBuy.Click += new System.EventHandler(this.cmdBuy_Click);
			// 
			// panelManagerQuick
			// 
			this.panelManagerQuick.Controls.Add(this.managedPanelStock);
			this.panelManagerQuick.Controls.Add(this.managedPanelBook);
			this.panelManagerQuick.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelManagerQuick.Location = new System.Drawing.Point(0, 224);
			this.panelManagerQuick.MinimumSize = new System.Drawing.Size(241, 24);
			this.panelManagerQuick.Name = "panelManagerQuick";
			this.panelManagerQuick.Padding = new System.Windows.Forms.Padding(2);
			this.panelManagerQuick.SelectedIndex = 1;
			this.panelManagerQuick.SelectedPanel = this.managedPanelBook;
			this.panelManagerQuick.Size = new System.Drawing.Size(362, 24);
			this.panelManagerQuick.TabIndex = 0;
			this.panelManagerQuick.TabStop = false;
			// 
			// managedPanelStock
			// 
			this.managedPanelStock.BackColor = System.Drawing.Color.LightSteelBlue;
			this.managedPanelStock.Location = new System.Drawing.Point(0, 0);
			this.managedPanelStock.Name = "managedPanelStock";
			this.managedPanelStock.Size = new System.Drawing.Size(0, 0);
			this.managedPanelStock.Text = "managedPanelSSF";
			// 
			// managedPanelBook
			// 
			this.managedPanelBook.BackColor = System.Drawing.Color.LightSteelBlue;
			this.managedPanelBook.Controls.Add(this.dspNetOpen);
			this.managedPanelBook.Controls.Add(this.dspSellOpenQty);
			this.managedPanelBook.Controls.Add(this.dspBuyOpenQty);
			this.managedPanelBook.Controls.Add(this.cmdCenterLow);
			this.managedPanelBook.Controls.Add(this.cmdCenterTrade);
			this.managedPanelBook.Controls.Add(this.cmdCenterHigh);
			this.managedPanelBook.Controls.Add(this.cmdCancelAllSell);
			this.managedPanelBook.Controls.Add(this.cmdCancelAll);
			this.managedPanelBook.Controls.Add(this.cmdCancelAllBuy);
			this.managedPanelBook.Location = new System.Drawing.Point(0, 0);
			this.managedPanelBook.Name = "managedPanelBook";
			this.managedPanelBook.Padding = new System.Windows.Forms.Padding(2);
			this.managedPanelBook.Size = new System.Drawing.Size(362, 24);
			this.managedPanelBook.Text = "managedPanelBook";
			// 
			// dspNetOpen
			// 
			this.dspNetOpen.AutoColor = true;
			this.dspNetOpen.DefaultColor = System.Drawing.Color.White;
			this.dspNetOpen.DefaultText = "0";
			this.dspNetOpen.DisplayFactor = 1;
			this.dspNetOpen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dspNetOpen.DownColor = System.Drawing.Color.Red;
			this.dspNetOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspNetOpen.Is64Th = false;
			this.dspNetOpen.IsCurrency = false;
			this.dspNetOpen.IsFraction = false;
			this.dspNetOpen.IsPercent = false;
			this.dspNetOpen.Location = new System.Drawing.Point(120, 2);
			this.dspNetOpen.MaxDecimal = 0;
			this.dspNetOpen.MinimumSize = new System.Drawing.Size(31, 20);
			this.dspNetOpen.Name = "dspNetOpen";
			this.dspNetOpen.Size = new System.Drawing.Size(122, 20);
			this.dspNetOpen.TabIndex = 0;
			this.dspNetOpen.Text = "0";
			this.dspNetOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.dspNetOpen.TickSize = 0.01;
			this.dspNetOpen.UpColor = System.Drawing.Color.LimeGreen;
			this.dspNetOpen.Value = "";
			// 
			// dspSellOpenQty
			// 
			this.dspSellOpenQty.AutoColor = false;
			this.dspSellOpenQty.BackColor = System.Drawing.Color.Red;
			this.dspSellOpenQty.DefaultColor = System.Drawing.Color.White;
			this.dspSellOpenQty.DefaultText = "0";
			this.dspSellOpenQty.DisplayFactor = 1;
			this.dspSellOpenQty.Dock = System.Windows.Forms.DockStyle.Right;
			this.dspSellOpenQty.DownColor = System.Drawing.Color.Red;
			this.dspSellOpenQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspSellOpenQty.Is64Th = false;
			this.dspSellOpenQty.IsCurrency = false;
			this.dspSellOpenQty.IsFraction = false;
			this.dspSellOpenQty.IsPercent = false;
			this.dspSellOpenQty.Location = new System.Drawing.Point(242, 2);
			this.dspSellOpenQty.MaxDecimal = 0;
			this.dspSellOpenQty.MinimumSize = new System.Drawing.Size(38, 20);
			this.dspSellOpenQty.Name = "dspSellOpenQty";
			this.dspSellOpenQty.Size = new System.Drawing.Size(58, 20);
			this.dspSellOpenQty.TabIndex = 0;
			this.dspSellOpenQty.Text = "0";
			this.dspSellOpenQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.dspSellOpenQty.TickSize = 0.01;
			this.dspSellOpenQty.UpColor = System.Drawing.Color.LimeGreen;
			this.dspSellOpenQty.Value = "";
			// 
			// dspBuyOpenQty
			// 
			this.dspBuyOpenQty.AutoColor = false;
			this.dspBuyOpenQty.BackColor = System.Drawing.Color.LimeGreen;
			this.dspBuyOpenQty.DefaultColor = System.Drawing.Color.White;
			this.dspBuyOpenQty.DefaultText = "0";
			this.dspBuyOpenQty.DisplayFactor = 1;
			this.dspBuyOpenQty.Dock = System.Windows.Forms.DockStyle.Left;
			this.dspBuyOpenQty.DownColor = System.Drawing.Color.Red;
			this.dspBuyOpenQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dspBuyOpenQty.Is64Th = false;
			this.dspBuyOpenQty.IsCurrency = false;
			this.dspBuyOpenQty.IsFraction = false;
			this.dspBuyOpenQty.IsPercent = false;
			this.dspBuyOpenQty.Location = new System.Drawing.Point(62, 2);
			this.dspBuyOpenQty.MaxDecimal = 0;
			this.dspBuyOpenQty.MinimumSize = new System.Drawing.Size(38, 20);
			this.dspBuyOpenQty.Name = "dspBuyOpenQty";
			this.dspBuyOpenQty.Size = new System.Drawing.Size(58, 20);
			this.dspBuyOpenQty.TabIndex = 0;
			this.dspBuyOpenQty.Text = "0";
			this.dspBuyOpenQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.dspBuyOpenQty.TickSize = 0.01;
			this.dspBuyOpenQty.UpColor = System.Drawing.Color.LimeGreen;
			this.dspBuyOpenQty.Value = "";
			// 
			// cmdCenterLow
			// 
			this.cmdCenterLow.AutoSize = true;
			this.cmdCenterLow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cmdCenterLow.BackColor = System.Drawing.Color.Red;
			this.cmdCenterLow.BackgroundImage = global::ROC.Properties.Resources.ToLow;
			this.cmdCenterLow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cmdCenterLow.Dock = System.Windows.Forms.DockStyle.Right;
			this.cmdCenterLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCenterLow.ForeColor = System.Drawing.Color.DarkBlue;
			this.cmdCenterLow.ImageIndex = 3;
			this.cmdCenterLow.Location = new System.Drawing.Point(300, 2);
			this.cmdCenterLow.MaximumSize = new System.Drawing.Size(20, 20);
			this.cmdCenterLow.MinimumSize = new System.Drawing.Size(20, 20);
			this.cmdCenterLow.Name = "cmdCenterLow";
			this.cmdCenterLow.Size = new System.Drawing.Size(20, 20);
			this.cmdCenterLow.TabIndex = 0;
			this.cmdCenterLow.TabStop = false;
			this.cmdCenterLow.Click += new System.EventHandler(this.cmdCenterLow_Click);
			// 
			// cmdCenterTrade
			// 
			this.cmdCenterTrade.AutoSize = true;
			this.cmdCenterTrade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cmdCenterTrade.BackColor = System.Drawing.Color.Silver;
			this.cmdCenterTrade.BackgroundImage = global::ROC.Properties.Resources.ToCenter;
			this.cmdCenterTrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cmdCenterTrade.Dock = System.Windows.Forms.DockStyle.Right;
			this.cmdCenterTrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCenterTrade.ForeColor = System.Drawing.Color.DarkBlue;
			this.cmdCenterTrade.ImageIndex = 3;
			this.cmdCenterTrade.Location = new System.Drawing.Point(320, 2);
			this.cmdCenterTrade.MaximumSize = new System.Drawing.Size(20, 20);
			this.cmdCenterTrade.MinimumSize = new System.Drawing.Size(20, 20);
			this.cmdCenterTrade.Name = "cmdCenterTrade";
			this.cmdCenterTrade.Size = new System.Drawing.Size(20, 20);
			this.cmdCenterTrade.TabIndex = 0;
			this.cmdCenterTrade.TabStop = false;
			this.cmdCenterTrade.Click += new System.EventHandler(this.cmdCenterTrade_Click);
			// 
			// cmdCenterHigh
			// 
			this.cmdCenterHigh.AutoSize = true;
			this.cmdCenterHigh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cmdCenterHigh.BackColor = System.Drawing.Color.LimeGreen;
			this.cmdCenterHigh.BackgroundImage = global::ROC.Properties.Resources.ToHigh;
			this.cmdCenterHigh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cmdCenterHigh.Dock = System.Windows.Forms.DockStyle.Right;
			this.cmdCenterHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCenterHigh.ForeColor = System.Drawing.Color.DarkBlue;
			this.cmdCenterHigh.ImageIndex = 3;
			this.cmdCenterHigh.Location = new System.Drawing.Point(340, 2);
			this.cmdCenterHigh.MaximumSize = new System.Drawing.Size(20, 20);
			this.cmdCenterHigh.MinimumSize = new System.Drawing.Size(20, 20);
			this.cmdCenterHigh.Name = "cmdCenterHigh";
			this.cmdCenterHigh.Size = new System.Drawing.Size(20, 20);
			this.cmdCenterHigh.TabIndex = 0;
			this.cmdCenterHigh.TabStop = false;
			this.cmdCenterHigh.Click += new System.EventHandler(this.cmdCenterHigh_Click);
			// 
			// cmdCancelAllSell
			// 
			this.cmdCancelAllSell.AutoSize = true;
			this.cmdCancelAllSell.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cmdCancelAllSell.BackColor = System.Drawing.Color.Red;
			this.cmdCancelAllSell.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCancelAllSell.BackgroundImage")));
			this.cmdCancelAllSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cmdCancelAllSell.Dock = System.Windows.Forms.DockStyle.Left;
			this.cmdCancelAllSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancelAllSell.ForeColor = System.Drawing.Color.DarkBlue;
			this.cmdCancelAllSell.ImageIndex = 3;
			this.cmdCancelAllSell.InnerBorderColor = System.Drawing.Color.Blue;
			this.cmdCancelAllSell.Location = new System.Drawing.Point(42, 2);
			this.cmdCancelAllSell.MaximumSize = new System.Drawing.Size(20, 20);
			this.cmdCancelAllSell.MinimumSize = new System.Drawing.Size(20, 20);
			this.cmdCancelAllSell.Name = "cmdCancelAllSell";
			this.cmdCancelAllSell.Size = new System.Drawing.Size(20, 20);
			this.cmdCancelAllSell.TabIndex = 0;
			this.cmdCancelAllSell.TabStop = false;
			this.cmdCancelAllSell.Click += new System.EventHandler(this.cmdCancelAllSell_Click);
			// 
			// cmdCancelAll
			// 
			this.cmdCancelAll.AutoSize = true;
			this.cmdCancelAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cmdCancelAll.BackColor = System.Drawing.Color.Silver;
			this.cmdCancelAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCancelAll.BackgroundImage")));
			this.cmdCancelAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cmdCancelAll.Dock = System.Windows.Forms.DockStyle.Left;
			this.cmdCancelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancelAll.ForeColor = System.Drawing.Color.DarkBlue;
			this.cmdCancelAll.ImageIndex = 3;
			this.cmdCancelAll.Location = new System.Drawing.Point(22, 2);
			this.cmdCancelAll.MaximumSize = new System.Drawing.Size(20, 20);
			this.cmdCancelAll.MinimumSize = new System.Drawing.Size(20, 20);
			this.cmdCancelAll.Name = "cmdCancelAll";
			this.cmdCancelAll.Size = new System.Drawing.Size(20, 20);
			this.cmdCancelAll.TabIndex = 0;
			this.cmdCancelAll.TabStop = false;
			this.cmdCancelAll.Click += new System.EventHandler(this.cmdCancelAll_Click);
			// 
			// cmdCancelAllBuy
			// 
			this.cmdCancelAllBuy.AutoSize = true;
			this.cmdCancelAllBuy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.cmdCancelAllBuy.BackColor = System.Drawing.Color.LimeGreen;
			this.cmdCancelAllBuy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cmdCancelAllBuy.BackgroundImage")));
			this.cmdCancelAllBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.cmdCancelAllBuy.Dock = System.Windows.Forms.DockStyle.Left;
			this.cmdCancelAllBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmdCancelAllBuy.ForeColor = System.Drawing.Color.DarkBlue;
			this.cmdCancelAllBuy.ImageIndex = 3;
			this.cmdCancelAllBuy.Location = new System.Drawing.Point(2, 2);
			this.cmdCancelAllBuy.MaximumSize = new System.Drawing.Size(20, 20);
			this.cmdCancelAllBuy.MinimumSize = new System.Drawing.Size(20, 20);
			this.cmdCancelAllBuy.Name = "cmdCancelAllBuy";
			this.cmdCancelAllBuy.Size = new System.Drawing.Size(20, 20);
			this.cmdCancelAllBuy.TabIndex = 0;
			this.cmdCancelAllBuy.TabStop = false;
			this.cmdCancelAllBuy.Click += new System.EventHandler(this.cmdCancelAllBuy_Click);
			// 
			// imageListTradeTick
			// 
			this.imageListTradeTick.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTradeTick.ImageStream")));
			this.imageListTradeTick.TransparentColor = System.Drawing.Color.Transparent;
			this.imageListTradeTick.Images.SetKeyName(0, "UpGreen.png");
			this.imageListTradeTick.Images.SetKeyName(1, "Blank.png");
			this.imageListTradeTick.Images.SetKeyName(2, "DownRed.png");
			this.imageListTradeTick.Images.SetKeyName(3, "Cancel.png");
			// 
			// rocQuickListBook
			// 
			this.rocQuickListBook.askBookPrices = ((System.Collections.Generic.List<double>)(resources.GetObject("rocQuickListBook.askBookPrices")));
			this.rocQuickListBook.AskColor = System.Drawing.Color.Red;
			this.rocQuickListBook.AskPrice = 0;
			this.rocQuickListBook.AutoCenterOnTraded = false;
			this.rocQuickListBook.AutoCenterRange = ((long)(3));
			this.rocQuickListBook.bidBookPrices = ((System.Collections.Generic.List<double>)(resources.GetObject("rocQuickListBook.bidBookPrices")));
			this.rocQuickListBook.BidColor = System.Drawing.Color.LimeGreen;
			this.rocQuickListBook.BidPrice = 0;
			this.rocQuickListBook.BlueDefault = 228;
			this.rocQuickListBook.BuyCancel = false;
			this.rocQuickListBook.BuyReplace = false;
			this.rocQuickListBook.BuySelected = false;
			this.rocQuickListBook.BuyStopSelected = false;
			this.rocQuickListBook.ClearBuyStopLimit = false;
			this.rocQuickListBook.ClearSellStopLimit = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.rocQuickListBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.rocQuickListBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.rocQuickListBook.DefaultCellStyle = dataGridViewCellStyle2;
			new BindingListEx.ROCBindingList<string>().Add("");
			this.rocQuickListBook.DisplayFactors = ((System.Collections.Generic.Dictionary<string, double>)(resources.GetObject("rocQuickListBook.DisplayFactors")));
			this.rocQuickListBook.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rocQuickListBook.EndReplacePrice = 0;
			this.rocQuickListBook.GreenDefault = 243;
			this.rocQuickListBook.GridKeys = ((System.Collections.Generic.List<string>)(resources.GetObject("rocQuickListBook.GridKeys")));
			this.rocQuickListBook.HasFlagChange = false;
			this.rocQuickListBook.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(243)))), ((int)(((byte)(228)))));
			this.rocQuickListBook.HighPrice = 0;
			this.rocQuickListBook.Importing = false;
			this.rocQuickListBook.LastFilter = "";
			this.rocQuickListBook.LastSort = "Price DESC";
			this.rocQuickListBook.Location = new System.Drawing.Point(0, 248);
			this.rocQuickListBook.LowPrice = 0;
			this.rocQuickListBook.Name = "rocQuickListBook";
			this.rocQuickListBook.PriceBook = 0;
			this.rocQuickListBook.PriceSelected = false;
			dgvBasePrinter1.BlackWhite = true;
			dgvBasePrinter1.CellAlignment = System.Drawing.StringAlignment.Near;
			dgvBasePrinter1.CellFormatFlags = ((System.Drawing.StringFormatFlags)((System.Drawing.StringFormatFlags.LineLimit | System.Drawing.StringFormatFlags.NoClip)));
			dgvBasePrinter1.DocName = null;
			dgvBasePrinter1.Footer = null;
			dgvBasePrinter1.FooterAlignment = System.Drawing.StringAlignment.Center;
			dgvBasePrinter1.FooterColor = System.Drawing.Color.Black;
			dgvBasePrinter1.FooterFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			stringFormat1.Alignment = System.Drawing.StringAlignment.Center;
			stringFormat1.FormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.NoWrap | System.Drawing.StringFormatFlags.LineLimit)
						| System.Drawing.StringFormatFlags.NoClip)));
			stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
			stringFormat1.LineAlignment = System.Drawing.StringAlignment.Center;
			stringFormat1.Trimming = System.Drawing.StringTrimming.Word;
			dgvBasePrinter1.FooterFormat = stringFormat1;
			dgvBasePrinter1.FooterFormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.NoWrap | System.Drawing.StringFormatFlags.LineLimit)
						| System.Drawing.StringFormatFlags.NoClip)));
			dgvBasePrinter1.FooterSpacing = 0F;
			dgvBasePrinter1.HeaderCellAlignment = System.Drawing.StringAlignment.Near;
			dgvBasePrinter1.HeaderCellFormatFlags = ((System.Drawing.StringFormatFlags)((System.Drawing.StringFormatFlags.LineLimit | System.Drawing.StringFormatFlags.NoClip)));
			dgvBasePrinter1.Owner = null;
			dgvBasePrinter1.PageNumberAlignment = System.Drawing.StringAlignment.Center;
			dgvBasePrinter1.PageNumberColor = System.Drawing.Color.Black;
			dgvBasePrinter1.PageNumberFont = new System.Drawing.Font("Tahoma", 8F);
			stringFormat2.Alignment = System.Drawing.StringAlignment.Center;
			stringFormat2.FormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.NoWrap | System.Drawing.StringFormatFlags.LineLimit)
						| System.Drawing.StringFormatFlags.NoClip)));
			stringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
			stringFormat2.LineAlignment = System.Drawing.StringAlignment.Center;
			stringFormat2.Trimming = System.Drawing.StringTrimming.Word;
			dgvBasePrinter1.PageNumberFormat = stringFormat2;
			dgvBasePrinter1.PageNumberFormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.NoWrap | System.Drawing.StringFormatFlags.LineLimit)
						| System.Drawing.StringFormatFlags.NoClip)));
			dgvBasePrinter1.PageNumberInHeader = false;
			dgvBasePrinter1.PageNumberOnSeparateLine = true;
			dgvBasePrinter1.PageNumbers = true;
			dgvBasePrinter1.PageSeparator = " of ";
			dgvBasePrinter1.PageText = "Page ";
			dgvBasePrinter1.PartText = " - Part ";
			dgvBasePrinter1.PorportionalColumns = false;
			dgvBasePrinter1.PreviewDialogIcon = null;
			dgvBasePrinter1.PrinterName = null;
			dgvBasePrinter1.PrintMargins = new System.Drawing.Printing.Margins(60, 60, 40, 40);
			dgvBasePrinter1.PrintPreviewZoom = 1;
			dgvBasePrinter1.ShowTotalPageNumber = true;
			dgvBasePrinter1.SubTitle = null;
			dgvBasePrinter1.SubTitleAlignment = System.Drawing.StringAlignment.Center;
			dgvBasePrinter1.SubTitleColor = System.Drawing.Color.Black;
			dgvBasePrinter1.SubTitleFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			stringFormat3.Alignment = System.Drawing.StringAlignment.Center;
			stringFormat3.FormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.NoWrap | System.Drawing.StringFormatFlags.LineLimit)
						| System.Drawing.StringFormatFlags.NoClip)));
			stringFormat3.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
			stringFormat3.LineAlignment = System.Drawing.StringAlignment.Center;
			stringFormat3.Trimming = System.Drawing.StringTrimming.Word;
			dgvBasePrinter1.SubTitleFormat = stringFormat3;
			dgvBasePrinter1.SubTitleFormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.NoWrap | System.Drawing.StringFormatFlags.LineLimit)
						| System.Drawing.StringFormatFlags.NoClip)));
			dgvBasePrinter1.TableAlignment = DataGridViewEx.DGVBasePrinter.Alignment.NotSet;
			dgvBasePrinter1.Title = null;
			dgvBasePrinter1.TitleAlignment = System.Drawing.StringAlignment.Center;
			dgvBasePrinter1.TitleColor = System.Drawing.Color.Black;
			dgvBasePrinter1.TitleFont = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
			stringFormat4.Alignment = System.Drawing.StringAlignment.Center;
			stringFormat4.FormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.NoWrap | System.Drawing.StringFormatFlags.LineLimit)
						| System.Drawing.StringFormatFlags.NoClip)));
			stringFormat4.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
			stringFormat4.LineAlignment = System.Drawing.StringAlignment.Center;
			stringFormat4.Trimming = System.Drawing.StringTrimming.Word;
			dgvBasePrinter1.TitleFormat = stringFormat4;
			dgvBasePrinter1.TitleFormatFlags = ((System.Drawing.StringFormatFlags)(((System.Drawing.StringFormatFlags.NoWrap | System.Drawing.StringFormatFlags.LineLimit)
						| System.Drawing.StringFormatFlags.NoClip)));
			this.rocQuickListBook.Printer = dgvBasePrinter1;
			this.rocQuickListBook.Processing = false;
			this.rocQuickListBook.Qty = ((long)(0));
			this.rocQuickListBook.ReadyForTickTable = false;
			this.rocQuickListBook.RedDefault = 233;
			this.rocQuickListBook.RefreshAggragation = true;
			this.rocQuickListBook.RefreshSharedRows = false;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.rocQuickListBook.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.rocQuickListBook.SelectedForeColor = System.Drawing.Color.LightBlue;
			this.rocQuickListBook.SelectedStopLimitBackColor = System.Drawing.Color.DarkGray;
			this.rocQuickListBook.SellCancel = false;
			this.rocQuickListBook.SellReplace = false;
			this.rocQuickListBook.SellSelected = false;
			this.rocQuickListBook.SellStopSelected = false;
			this.rocQuickListBook.ShouldScrollToLastRow = false;
			this.rocQuickListBook.ShowBuyStopLimit = false;
			this.rocQuickListBook.ShowColumnMenu = false;
			this.rocQuickListBook.ShowQtyMenu = false;
			this.rocQuickListBook.ShowSellStopLimit = false;
			this.rocQuickListBook.Size = new System.Drawing.Size(362, 494);
			this.rocQuickListBook.StartReplacePrice = 0;
			this.rocQuickListBook.StopPriceBook = 0;
			new BindingListEx.ROCBindingList<string>().Add("");
			this.rocQuickListBook.TabIndex = 0;
			this.rocQuickListBook.TabStop = false;
			this.rocQuickListBook.TickSize = 0;
			this.rocQuickListBook.TickSizes = ((System.Collections.Generic.Dictionary<string, double>)(resources.GetObject("rocQuickListBook.TickSizes")));
			this.rocQuickListBook.TradePrice = 0;
			this.rocQuickListBook.TradeTick = "";
			// 
			// panelCommandsEx
			// 
			this.panelCommandsEx.BackColor = System.Drawing.Color.LightSteelBlue;
			this.panelCommandsEx.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCommandsEx.Location = new System.Drawing.Point(0, 200);
			this.panelCommandsEx.MinimumSize = new System.Drawing.Size(261, 24);
			this.panelCommandsEx.Name = "panelCommandsEx";
			this.panelCommandsEx.Padding = new System.Windows.Forms.Padding(2);
			this.panelCommandsEx.Size = new System.Drawing.Size(362, 24);
			this.panelCommandsEx.TabIndex = 0;
			this.panelCommandsEx.Visible = false;
			// 
			// frmQuickTicket
			// 
			this.Animate = false;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Caption = "QUICK TICKET";
			this.ClientSize = new System.Drawing.Size(362, 742);
			this.Controls.Add(this.rocQuickListBook);
			this.Controls.Add(this.panelManagerQuick);
			this.Controls.Add(this.panelCommandsEx);
			this.Controls.Add(this.panelCommands);
			this.Controls.Add(this.panelOrderInfo);
			this.Controls.Add(this.panelTicker);
			this.Controls.Add(this.toolStripTraderInfo);
			this.Controls.Add(this.CaptionBar);
			this.MaximumSize = new System.Drawing.Size(700, 2480);
			this.MinimumSize = new System.Drawing.Size(300, 500);
			this.Name = "frmQuickTicket";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.toolStripTraderInfo.ResumeLayout(false);
			this.toolStripTraderInfo.PerformLayout();
			this.panelTicker.ResumeLayout(false);
			this.panelTicker.PerformLayout();
			this.panelBottom.ResumeLayout(false);
			this.panelBottom.PerformLayout();
			this.panelMiddle.ResumeLayout(false);
			this.panelMiddle.PerformLayout();
			this.panelUpper.ResumeLayout(false);
			this.panelUpper.PerformLayout();
			this.panelSymbolTrade.ResumeLayout(false);
			this.panelSymbolTrade.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picTradeTick)).EndInit();
			this.panelOrderInfo.ResumeLayout(false);
			this.panelOrderInfoMsg.ResumeLayout(false);
			this.panelOrderInfoUpper.ResumeLayout(false);
			this.panelShortLender.ResumeLayout(false);
			this.panelShortLender.PerformLayout();
			this.panelStopLimitOffset.ResumeLayout(false);
			this.panelStopLimitOffset.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStopLimitOffset)).EndInit();
			this.panelExchange.ResumeLayout(false);
			this.panelExchange.PerformLayout();
			this.panelDuration.ResumeLayout(false);
			this.panelDuration.PerformLayout();
			this.panelStopPrice.ResumeLayout(false);
			this.panelStopPrice.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numStopPrice)).EndInit();
			this.panelLimitPrice.ResumeLayout(false);
			this.panelLimitPrice.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numLimitPrice)).EndInit();
			this.panelOrderTypes.ResumeLayout(false);
			this.panelOrderTypes.PerformLayout();
			this.panelShares.ResumeLayout(false);
			this.panelShares.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
			this.panelCommands.ResumeLayout(false);
			this.panelManagerQuick.ResumeLayout(false);
			this.managedPanelBook.ResumeLayout(false);
			this.managedPanelBook.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rocQuickListBook)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private FormEx.VistaWindowCaptionBar CaptionBar;
		private System.Windows.Forms.ToolStrip toolStripTraderInfo;
		private System.Windows.Forms.ToolStripLabel lblTradeFor;
		protected internal System.Windows.Forms.ToolStripDropDownButton cmdTradeFor;
		private System.Windows.Forms.ToolStripLabel lblLocalAccountAcrn;
		protected internal System.Windows.Forms.ToolStripDropDownButton cmdAccount;
		private System.Windows.Forms.ToolStripDropDownButton cmdSettings;
		private System.Windows.Forms.ToolStripMenuItem itemSaveAsDefault;
		private System.Windows.Forms.ToolStripMenuItem itemResetToSystemDefault;
		private System.Windows.Forms.Panel panelTicker;
		private System.Windows.Forms.Panel panelBottom;
		private LabelEx.LabelBase dspClosePrice;
		private System.Windows.Forms.Label lblClosePrice;
		private LabelEx.LabelBase dspHighPrice;
		private System.Windows.Forms.Label lblHighPrice;
		private LabelEx.LabelBase dspLowPrice;
		private System.Windows.Forms.Label lblLowPrice;
		private System.Windows.Forms.Panel panelMiddle;
		private LabelEx.LabelBase dspPctChange;
		private System.Windows.Forms.Label lblPctChange;
		private LabelEx.LabelBase dspNetChange;
		private System.Windows.Forms.Label lblNetChange;
		private System.Windows.Forms.Panel panelUpper;
		private LabelEx.LabelBase dspAskSize;
		private System.Windows.Forms.Label lblAskSize;
		private LabelEx.LabelBase dspAskPrice;
		private System.Windows.Forms.Label lblAskPrice;
		private LabelEx.LabelBase dspBidSize;
		private System.Windows.Forms.Label lblBidSize;
		private LabelEx.LabelBase dspBidPrice;
		private System.Windows.Forms.Label lblBidPrice;
		private System.Windows.Forms.Panel panelSymbolTrade;
		private LabelEx.LabelBase dspTradedPrice;
		private System.Windows.Forms.PictureBox picTradeTick;
		protected internal System.Windows.Forms.ComboBox cboSymbolDetails;
		private System.Windows.Forms.Panel panelOrderInfo;
		private System.Windows.Forms.Panel panelOrderInfoMsg;
		private System.Windows.Forms.Panel panelOrderInfoUpper;
		private System.Windows.Forms.Panel panelExchange;
		protected internal System.Windows.Forms.ComboBox cboExchange;
		protected internal System.Windows.Forms.Label lblExchange;
		private System.Windows.Forms.Panel panelDuration;
		private System.Windows.Forms.ComboBox cboDuration;
		private System.Windows.Forms.Label lblDuration;
		private System.Windows.Forms.Panel panelStopPrice;
		private LabelEx.LabelBase dspStopPriceTickSize;
		private LabelEx.LabelBase lblStopPriceX;
		private LabelEx.LabelBase dspStopPriceIncrement;
		public NumericUpDownEx.NumericUpDownBase numStopPrice;
		private System.Windows.Forms.Label lblStopPrice;
		private System.Windows.Forms.Panel panelLimitPrice;
		private LabelEx.LabelBase dspLimitPriceTickSize;
		private LabelEx.LabelBase lblLimitPriceX;
		private LabelEx.LabelBase dspLimitPriceIncrement;
		public NumericUpDownEx.NumericUpDownBase numLimitPrice;
		private System.Windows.Forms.Label lblLimitPrice;
		private System.Windows.Forms.Panel panelOrderTypes;
		private System.Windows.Forms.ComboBox cboOrder;
		private System.Windows.Forms.Label lblOrderType;
		private System.Windows.Forms.Panel panelShares;
		private LabelEx.LabelBase dspQuantityIncrement;
		public NumericUpDownEx.NumericUpDownBase numQuantity;
		private System.Windows.Forms.Label lblQuantity;
		private System.Windows.Forms.Panel panelCommands;
		private ButtonEx.VistaButton cmdSell;
		private ButtonEx.VistaButton cmdBuy;
		private PanelEx.PanelManager panelManagerQuick;
		private PanelEx.ManagedPanel managedPanelBook;
		private PanelEx.ManagedPanel managedPanelStock;
		private System.Windows.Forms.ImageList imageListTradeTick;
		private System.Windows.Forms.Label lblTradeVolume;
		private LabelEx.LabelBase dspVolume;
		private System.Windows.Forms.Label lblVolume;
		private LabelEx.LabelBase dspTradeVolume;
		private DataGridViewEx.ROCQuickList rocQuickListBook;
		private ButtonEx.VistaButton cmdCancelAllBuy;
		private ButtonEx.VistaButton cmdCancelAllSell;
		private ButtonEx.VistaButton cmdCancelAll;
		private ButtonEx.VistaButton cmdCenterLow;
		private ButtonEx.VistaButton cmdCenterHigh;
		private ButtonEx.VistaButton cmdCenterTrade;
		private LabelEx.LabelVista dspNetOpen;
		private LabelEx.LabelVista dspSellOpenQty;
		private LabelEx.LabelVista dspBuyOpenQty;
		private LabelEx.LabelVista lblMarketDataError;
		private System.Windows.Forms.RichTextBox dspOrderMsg;
		protected internal System.Windows.Forms.Panel panelCommandsEx;
		private System.Windows.Forms.Panel panelShortLender;
		protected internal System.Windows.Forms.ComboBox cboShortLenders;
		private System.Windows.Forms.Label lblShortLender;
		private ButtonEx.VistaButton cmdShort;
		private System.Windows.Forms.TextBox dspLimitPrice;
		private System.Windows.Forms.TextBox dspStopPrice;
		private LabelEx.LabelVista lblSecurityStatus;
		private System.Windows.Forms.Panel panelStopLimitOffset;
		public NumericUpDownEx.NumericUpDownBase numStopLimitOffset;
		private System.Windows.Forms.Label lblStopLimitOffset;
		private LabelEx.LabelVista lblDoNotTranslate;
	}
}