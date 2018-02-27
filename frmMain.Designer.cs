namespace VendingMachine
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCoins = new System.Windows.Forms.GroupBox();
            this.nudHalfDollar = new System.Windows.Forms.NumericUpDown();
            this.nudQuarter = new System.Windows.Forms.NumericUpDown();
            this.nudDime = new System.Windows.Forms.NumericUpDown();
            this.nudNickel = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnHalfDollor = new System.Windows.Forms.Button();
            this.btnQuarter = new System.Windows.Forms.Button();
            this.btnDime = new System.Windows.Forms.Button();
            this.btnNickel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblChangeReceived = new System.Windows.Forms.Label();
            this.btnTakeYourChange = new System.Windows.Forms.Button();
            this.grpAmountInserted = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAmountInserted = new System.Windows.Forms.Label();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.grpDrinkSelections = new System.Windows.Forms.GroupBox();
            this.nudAWRootBeer = new System.Windows.Forms.NumericUpDown();
            this.nud7UP = new System.Windows.Forms.NumericUpDown();
            this.nudDrPepper = new System.Windows.Forms.NumericUpDown();
            this.nudPepsi = new System.Windows.Forms.NumericUpDown();
            this.nudCoke = new System.Windows.Forms.NumericUpDown();
            this.lblAWRootBeerSalePrice = new System.Windows.Forms.Label();
            this.lbl7UPSalePrice = new System.Windows.Forms.Label();
            this.lblDrPepperSalePrice = new System.Windows.Forms.Label();
            this.lblPepsiSalePrice = new System.Windows.Forms.Label();
            this.lblCokeSalePrice = new System.Windows.Forms.Label();
            this.btnAWRootBeer = new System.Windows.Forms.Button();
            this.btn7UP = new System.Windows.Forms.Button();
            this.btnDrPepper = new System.Windows.Forms.Button();
            this.btnPepsi = new System.Windows.Forms.Button();
            this.btnCoke = new System.Windows.Forms.Button();
            this.timerChange = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCoinBalance = new System.Windows.Forms.TextBox();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpCoins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHalfDollar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuarter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNickel)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpAmountInserted.SuspendLayout();
            this.grpDrinkSelections.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAWRootBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud7UP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrPepper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPepsi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoke)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.grpCoins);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.grpAmountInserted);
            this.groupBox1.Controls.Add(this.grpDrinkSelections);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(982, 725);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // grpCoins
            // 
            this.grpCoins.Controls.Add(this.nudHalfDollar);
            this.grpCoins.Controls.Add(this.nudQuarter);
            this.grpCoins.Controls.Add(this.nudDime);
            this.grpCoins.Controls.Add(this.nudNickel);
            this.grpCoins.Controls.Add(this.label11);
            this.grpCoins.Controls.Add(this.label12);
            this.grpCoins.Controls.Add(this.label13);
            this.grpCoins.Controls.Add(this.label14);
            this.grpCoins.Controls.Add(this.btnHalfDollor);
            this.grpCoins.Controls.Add(this.btnQuarter);
            this.grpCoins.Controls.Add(this.btnDime);
            this.grpCoins.Controls.Add(this.btnNickel);
            this.grpCoins.Location = new System.Drawing.Point(78, 272);
            this.grpCoins.Name = "grpCoins";
            this.grpCoins.Size = new System.Drawing.Size(651, 211);
            this.grpCoins.TabIndex = 15;
            this.grpCoins.TabStop = false;
            // 
            // nudHalfDollar
            // 
            this.nudHalfDollar.BackColor = System.Drawing.Color.White;
            this.nudHalfDollar.Enabled = false;
            this.nudHalfDollar.ForeColor = System.Drawing.Color.Black;
            this.nudHalfDollar.Location = new System.Drawing.Point(516, 174);
            this.nudHalfDollar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudHalfDollar.Name = "nudHalfDollar";
            this.nudHalfDollar.ReadOnly = true;
            this.nudHalfDollar.Size = new System.Drawing.Size(120, 22);
            this.nudHalfDollar.TabIndex = 14;
            this.nudHalfDollar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHalfDollar.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // nudQuarter
            // 
            this.nudQuarter.BackColor = System.Drawing.Color.White;
            this.nudQuarter.Enabled = false;
            this.nudQuarter.ForeColor = System.Drawing.Color.Black;
            this.nudQuarter.Location = new System.Drawing.Point(351, 174);
            this.nudQuarter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQuarter.Name = "nudQuarter";
            this.nudQuarter.ReadOnly = true;
            this.nudQuarter.Size = new System.Drawing.Size(120, 22);
            this.nudQuarter.TabIndex = 13;
            this.nudQuarter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudQuarter.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // nudDime
            // 
            this.nudDime.BackColor = System.Drawing.Color.White;
            this.nudDime.Enabled = false;
            this.nudDime.ForeColor = System.Drawing.Color.Black;
            this.nudDime.Location = new System.Drawing.Point(186, 174);
            this.nudDime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDime.Name = "nudDime";
            this.nudDime.ReadOnly = true;
            this.nudDime.Size = new System.Drawing.Size(120, 22);
            this.nudDime.TabIndex = 12;
            this.nudDime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDime.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // nudNickel
            // 
            this.nudNickel.BackColor = System.Drawing.Color.White;
            this.nudNickel.Enabled = false;
            this.nudNickel.ForeColor = System.Drawing.Color.Black;
            this.nudNickel.Location = new System.Drawing.Point(23, 174);
            this.nudNickel.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNickel.Name = "nudNickel";
            this.nudNickel.ReadOnly = true;
            this.nudNickel.Size = new System.Drawing.Size(120, 22);
            this.nudNickel.TabIndex = 11;
            this.nudNickel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNickel.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(513, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 23);
            this.label11.TabIndex = 8;
            this.label11.Text = "50¢";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(348, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 23);
            this.label12.TabIndex = 7;
            this.label12.Text = "25¢";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(183, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 23);
            this.label13.TabIndex = 6;
            this.label13.Text = "10¢";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(18, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 23);
            this.label14.TabIndex = 5;
            this.label14.Text = "5¢";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHalfDollor
            // 
            this.btnHalfDollor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHalfDollor.BackgroundImage")));
            this.btnHalfDollor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHalfDollor.Location = new System.Drawing.Point(513, 18);
            this.btnHalfDollor.Name = "btnHalfDollor";
            this.btnHalfDollor.Size = new System.Drawing.Size(125, 125);
            this.btnHalfDollor.TabIndex = 3;
            this.btnHalfDollor.TabStop = false;
            this.btnHalfDollor.UseVisualStyleBackColor = true;
            this.btnHalfDollor.Click += new System.EventHandler(this.btnHalfDollor_Click);
            // 
            // btnQuarter
            // 
            this.btnQuarter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuarter.BackgroundImage")));
            this.btnQuarter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuarter.Location = new System.Drawing.Point(348, 18);
            this.btnQuarter.Name = "btnQuarter";
            this.btnQuarter.Size = new System.Drawing.Size(125, 125);
            this.btnQuarter.TabIndex = 2;
            this.btnQuarter.TabStop = false;
            this.btnQuarter.UseVisualStyleBackColor = true;
            this.btnQuarter.Click += new System.EventHandler(this.btnQuarter_Click);
            // 
            // btnDime
            // 
            this.btnDime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDime.BackgroundImage")));
            this.btnDime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDime.Location = new System.Drawing.Point(183, 18);
            this.btnDime.Name = "btnDime";
            this.btnDime.Size = new System.Drawing.Size(125, 125);
            this.btnDime.TabIndex = 1;
            this.btnDime.TabStop = false;
            this.btnDime.UseVisualStyleBackColor = true;
            this.btnDime.Click += new System.EventHandler(this.btnDime_Click);
            // 
            // btnNickel
            // 
            this.btnNickel.BackColor = System.Drawing.Color.Transparent;
            this.btnNickel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNickel.BackgroundImage")));
            this.btnNickel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNickel.Location = new System.Drawing.Point(18, 18);
            this.btnNickel.Name = "btnNickel";
            this.btnNickel.Size = new System.Drawing.Size(125, 125);
            this.btnNickel.TabIndex = 0;
            this.btnNickel.TabStop = false;
            this.btnNickel.UseVisualStyleBackColor = false;
            this.btnNickel.Click += new System.EventHandler(this.btnNickel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblChangeReceived);
            this.groupBox2.Controls.Add(this.btnTakeYourChange);
            this.groupBox2.Location = new System.Drawing.Point(747, 502);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(156, 211);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Change Received";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblChangeReceived
            // 
            this.lblChangeReceived.BackColor = System.Drawing.Color.Black;
            this.lblChangeReceived.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblChangeReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeReceived.ForeColor = System.Drawing.Color.Yellow;
            this.lblChangeReceived.Location = new System.Drawing.Point(16, 43);
            this.lblChangeReceived.Name = "lblChangeReceived";
            this.lblChangeReceived.Size = new System.Drawing.Size(121, 76);
            this.lblChangeReceived.TabIndex = 11;
            this.lblChangeReceived.Text = "0.00";
            this.lblChangeReceived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTakeYourChange
            // 
            this.btnTakeYourChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeYourChange.Location = new System.Drawing.Point(16, 122);
            this.btnTakeYourChange.Name = "btnTakeYourChange";
            this.btnTakeYourChange.Size = new System.Drawing.Size(121, 76);
            this.btnTakeYourChange.TabIndex = 12;
            this.btnTakeYourChange.Text = "Take Your Change";
            this.btnTakeYourChange.UseVisualStyleBackColor = true;
            this.btnTakeYourChange.Click += new System.EventHandler(this.btnTakeYourChange_Click);
            // 
            // grpAmountInserted
            // 
            this.grpAmountInserted.Controls.Add(this.label7);
            this.grpAmountInserted.Controls.Add(this.lblAmountInserted);
            this.grpAmountInserted.Controls.Add(this.btnCancelSale);
            this.grpAmountInserted.Location = new System.Drawing.Point(747, 272);
            this.grpAmountInserted.Name = "grpAmountInserted";
            this.grpAmountInserted.Size = new System.Drawing.Size(156, 211);
            this.grpAmountInserted.TabIndex = 13;
            this.grpAmountInserted.TabStop = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 22);
            this.label7.TabIndex = 14;
            this.label7.Text = "Amount Inserted";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAmountInserted
            // 
            this.lblAmountInserted.BackColor = System.Drawing.Color.Black;
            this.lblAmountInserted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAmountInserted.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountInserted.ForeColor = System.Drawing.Color.Yellow;
            this.lblAmountInserted.Location = new System.Drawing.Point(16, 43);
            this.lblAmountInserted.Name = "lblAmountInserted";
            this.lblAmountInserted.Size = new System.Drawing.Size(121, 76);
            this.lblAmountInserted.TabIndex = 11;
            this.lblAmountInserted.Text = "0.00";
            this.lblAmountInserted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSale.Location = new System.Drawing.Point(16, 122);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(121, 76);
            this.btnCancelSale.TabIndex = 12;
            this.btnCancelSale.Text = "Cancel Sale";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // grpDrinkSelections
            // 
            this.grpDrinkSelections.Controls.Add(this.nudAWRootBeer);
            this.grpDrinkSelections.Controls.Add(this.nud7UP);
            this.grpDrinkSelections.Controls.Add(this.nudDrPepper);
            this.grpDrinkSelections.Controls.Add(this.nudPepsi);
            this.grpDrinkSelections.Controls.Add(this.nudCoke);
            this.grpDrinkSelections.Controls.Add(this.lblAWRootBeerSalePrice);
            this.grpDrinkSelections.Controls.Add(this.lbl7UPSalePrice);
            this.grpDrinkSelections.Controls.Add(this.lblDrPepperSalePrice);
            this.grpDrinkSelections.Controls.Add(this.lblPepsiSalePrice);
            this.grpDrinkSelections.Controls.Add(this.lblCokeSalePrice);
            this.grpDrinkSelections.Controls.Add(this.btnAWRootBeer);
            this.grpDrinkSelections.Controls.Add(this.btn7UP);
            this.grpDrinkSelections.Controls.Add(this.btnDrPepper);
            this.grpDrinkSelections.Controls.Add(this.btnPepsi);
            this.grpDrinkSelections.Controls.Add(this.btnCoke);
            this.grpDrinkSelections.Location = new System.Drawing.Point(78, 21);
            this.grpDrinkSelections.Name = "grpDrinkSelections";
            this.grpDrinkSelections.Size = new System.Drawing.Size(825, 235);
            this.grpDrinkSelections.TabIndex = 10;
            this.grpDrinkSelections.TabStop = false;
            // 
            // nudAWRootBeer
            // 
            this.nudAWRootBeer.BackColor = System.Drawing.Color.White;
            this.nudAWRootBeer.Enabled = false;
            this.nudAWRootBeer.ForeColor = System.Drawing.Color.Black;
            this.nudAWRootBeer.Location = new System.Drawing.Point(678, 189);
            this.nudAWRootBeer.Name = "nudAWRootBeer";
            this.nudAWRootBeer.ReadOnly = true;
            this.nudAWRootBeer.Size = new System.Drawing.Size(120, 22);
            this.nudAWRootBeer.TabIndex = 15;
            this.nudAWRootBeer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAWRootBeer.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // nud7UP
            // 
            this.nud7UP.BackColor = System.Drawing.Color.White;
            this.nud7UP.Enabled = false;
            this.nud7UP.ForeColor = System.Drawing.Color.Black;
            this.nud7UP.Location = new System.Drawing.Point(516, 189);
            this.nud7UP.Name = "nud7UP";
            this.nud7UP.ReadOnly = true;
            this.nud7UP.Size = new System.Drawing.Size(120, 22);
            this.nud7UP.TabIndex = 14;
            this.nud7UP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud7UP.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // nudDrPepper
            // 
            this.nudDrPepper.BackColor = System.Drawing.Color.White;
            this.nudDrPepper.Enabled = false;
            this.nudDrPepper.ForeColor = System.Drawing.Color.Black;
            this.nudDrPepper.Location = new System.Drawing.Point(351, 189);
            this.nudDrPepper.Name = "nudDrPepper";
            this.nudDrPepper.ReadOnly = true;
            this.nudDrPepper.Size = new System.Drawing.Size(120, 22);
            this.nudDrPepper.TabIndex = 13;
            this.nudDrPepper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDrPepper.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // nudPepsi
            // 
            this.nudPepsi.BackColor = System.Drawing.Color.White;
            this.nudPepsi.Enabled = false;
            this.nudPepsi.ForeColor = System.Drawing.Color.Black;
            this.nudPepsi.Location = new System.Drawing.Point(186, 189);
            this.nudPepsi.Name = "nudPepsi";
            this.nudPepsi.ReadOnly = true;
            this.nudPepsi.Size = new System.Drawing.Size(120, 22);
            this.nudPepsi.TabIndex = 12;
            this.nudPepsi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPepsi.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // nudCoke
            // 
            this.nudCoke.BackColor = System.Drawing.Color.White;
            this.nudCoke.Enabled = false;
            this.nudCoke.ForeColor = System.Drawing.Color.Black;
            this.nudCoke.Location = new System.Drawing.Point(23, 189);
            this.nudCoke.Name = "nudCoke";
            this.nudCoke.ReadOnly = true;
            this.nudCoke.Size = new System.Drawing.Size(120, 22);
            this.nudCoke.TabIndex = 11;
            this.nudCoke.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.nudCoke, "Total Cokes Available");
            this.nudCoke.Value = new decimal(new int[] {
            72,
            0,
            0,
            0});
            // 
            // lblAWRootBeerSalePrice
            // 
            this.lblAWRootBeerSalePrice.Location = new System.Drawing.Point(678, 145);
            this.lblAWRootBeerSalePrice.Name = "lblAWRootBeerSalePrice";
            this.lblAWRootBeerSalePrice.Size = new System.Drawing.Size(125, 23);
            this.lblAWRootBeerSalePrice.TabIndex = 9;
            this.lblAWRootBeerSalePrice.Text = "$1.50";
            this.lblAWRootBeerSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl7UPSalePrice
            // 
            this.lbl7UPSalePrice.Location = new System.Drawing.Point(513, 145);
            this.lbl7UPSalePrice.Name = "lbl7UPSalePrice";
            this.lbl7UPSalePrice.Size = new System.Drawing.Size(125, 23);
            this.lbl7UPSalePrice.TabIndex = 8;
            this.lbl7UPSalePrice.Text = "$1.50";
            this.lbl7UPSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDrPepperSalePrice
            // 
            this.lblDrPepperSalePrice.Location = new System.Drawing.Point(348, 145);
            this.lblDrPepperSalePrice.Name = "lblDrPepperSalePrice";
            this.lblDrPepperSalePrice.Size = new System.Drawing.Size(125, 23);
            this.lblDrPepperSalePrice.TabIndex = 7;
            this.lblDrPepperSalePrice.Text = "$1.50";
            this.lblDrPepperSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPepsiSalePrice
            // 
            this.lblPepsiSalePrice.Location = new System.Drawing.Point(183, 145);
            this.lblPepsiSalePrice.Name = "lblPepsiSalePrice";
            this.lblPepsiSalePrice.Size = new System.Drawing.Size(125, 23);
            this.lblPepsiSalePrice.TabIndex = 6;
            this.lblPepsiSalePrice.Text = "$1.50";
            this.lblPepsiSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCokeSalePrice
            // 
            this.lblCokeSalePrice.Location = new System.Drawing.Point(18, 145);
            this.lblCokeSalePrice.Name = "lblCokeSalePrice";
            this.lblCokeSalePrice.Size = new System.Drawing.Size(125, 23);
            this.lblCokeSalePrice.TabIndex = 5;
            this.lblCokeSalePrice.Text = "$1.50";
            this.lblCokeSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAWRootBeer
            // 
            this.btnAWRootBeer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAWRootBeer.BackgroundImage")));
            this.btnAWRootBeer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAWRootBeer.Location = new System.Drawing.Point(678, 18);
            this.btnAWRootBeer.Name = "btnAWRootBeer";
            this.btnAWRootBeer.Size = new System.Drawing.Size(125, 125);
            this.btnAWRootBeer.TabIndex = 4;
            this.btnAWRootBeer.TabStop = false;
            this.btnAWRootBeer.UseVisualStyleBackColor = true;
            this.btnAWRootBeer.Click += new System.EventHandler(this.btnAWRootBeer_Click);
            this.btnAWRootBeer.MouseHover += new System.EventHandler(this.btnAWRootBeer_MouseHover);
            // 
            // btn7UP
            // 
            this.btn7UP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn7UP.BackgroundImage")));
            this.btn7UP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7UP.Location = new System.Drawing.Point(513, 18);
            this.btn7UP.Name = "btn7UP";
            this.btn7UP.Size = new System.Drawing.Size(125, 125);
            this.btn7UP.TabIndex = 3;
            this.btn7UP.TabStop = false;
            this.btn7UP.UseVisualStyleBackColor = true;
            this.btn7UP.Click += new System.EventHandler(this.btn7UP_Click);
            this.btn7UP.MouseHover += new System.EventHandler(this.btn7UP_MouseHover);
            // 
            // btnDrPepper
            // 
            this.btnDrPepper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDrPepper.BackgroundImage")));
            this.btnDrPepper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrPepper.Location = new System.Drawing.Point(348, 18);
            this.btnDrPepper.Name = "btnDrPepper";
            this.btnDrPepper.Size = new System.Drawing.Size(125, 125);
            this.btnDrPepper.TabIndex = 2;
            this.btnDrPepper.TabStop = false;
            this.btnDrPepper.UseVisualStyleBackColor = true;
            this.btnDrPepper.Click += new System.EventHandler(this.btnDrPepper_Click);
            this.btnDrPepper.MouseHover += new System.EventHandler(this.btnDrPepper_MouseHover);
            // 
            // btnPepsi
            // 
            this.btnPepsi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPepsi.BackgroundImage")));
            this.btnPepsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPepsi.Location = new System.Drawing.Point(183, 18);
            this.btnPepsi.Name = "btnPepsi";
            this.btnPepsi.Size = new System.Drawing.Size(125, 125);
            this.btnPepsi.TabIndex = 1;
            this.btnPepsi.TabStop = false;
            this.btnPepsi.UseVisualStyleBackColor = true;
            this.btnPepsi.Click += new System.EventHandler(this.btnPepsi_Click);
            this.btnPepsi.MouseHover += new System.EventHandler(this.btnPepsi_MouseHover);
            // 
            // btnCoke
            // 
            this.btnCoke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoke.BackgroundImage")));
            this.btnCoke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoke.Location = new System.Drawing.Point(18, 18);
            this.btnCoke.Name = "btnCoke";
            this.btnCoke.Size = new System.Drawing.Size(125, 125);
            this.btnCoke.TabIndex = 0;
            this.btnCoke.TabStop = false;
            this.toolTip.SetToolTip(this.btnCoke, "Total Cokes Available");
            this.btnCoke.UseVisualStyleBackColor = true;
            this.btnCoke.Click += new System.EventHandler(this.btnCoke_Click);
            this.btnCoke.MouseHover += new System.EventHandler(this.btnCoke_MouseHover);
            // 
            // timerChange
            // 
            this.timerChange.Enabled = true;
            this.timerChange.Tick += new System.EventHandler(this.timerChange_Tick);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 100;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 100;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Beginning Coin Balance:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(13, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total Sales for This Session:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCoinBalance
            // 
            this.txtCoinBalance.Enabled = false;
            this.txtCoinBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCoinBalance.Location = new System.Drawing.Point(214, 29);
            this.txtCoinBalance.Name = "txtCoinBalance";
            this.txtCoinBalance.Size = new System.Drawing.Size(84, 22);
            this.txtCoinBalance.TabIndex = 19;
            this.txtCoinBalance.TabStop = false;
            this.txtCoinBalance.Text = "$0.00";
            this.txtCoinBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Enabled = false;
            this.txtTotalSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSales.Location = new System.Drawing.Point(214, 55);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.Size = new System.Drawing.Size(84, 22);
            this.txtTotalSales.TabIndex = 20;
            this.txtTotalSales.TabStop = false;
            this.txtTotalSales.Text = "$0.00";
            this.txtTotalSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtTotalSales);
            this.groupBox3.Controls.Add(this.txtCoinBalance);
            this.groupBox3.Location = new System.Drawing.Point(78, 502);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 94);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vending Machine Sample Application";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grpCoins.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudHalfDollar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuarter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNickel)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.grpAmountInserted.ResumeLayout(false);
            this.grpDrinkSelections.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAWRootBeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud7UP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrPepper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPepsi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoke)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCoke;
        private System.Windows.Forms.Button btnPepsi;
        private System.Windows.Forms.GroupBox grpDrinkSelections;
        private System.Windows.Forms.Label lblAWRootBeerSalePrice;
        private System.Windows.Forms.Label lbl7UPSalePrice;
        private System.Windows.Forms.Label lblDrPepperSalePrice;
        private System.Windows.Forms.Label lblPepsiSalePrice;
        private System.Windows.Forms.Label lblCokeSalePrice;
        private System.Windows.Forms.Button btnAWRootBeer;
        private System.Windows.Forms.Button btn7UP;
        private System.Windows.Forms.Button btnDrPepper;
        private System.Windows.Forms.NumericUpDown nudCoke;
        private System.Windows.Forms.NumericUpDown nudAWRootBeer;
        private System.Windows.Forms.NumericUpDown nud7UP;
        private System.Windows.Forms.NumericUpDown nudDrPepper;
        private System.Windows.Forms.NumericUpDown nudPepsi;
        private System.Windows.Forms.GroupBox grpAmountInserted;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAmountInserted;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblChangeReceived;
        private System.Windows.Forms.Button btnTakeYourChange;
        private System.Windows.Forms.GroupBox grpCoins;
        private System.Windows.Forms.NumericUpDown nudHalfDollar;
        private System.Windows.Forms.NumericUpDown nudQuarter;
        private System.Windows.Forms.NumericUpDown nudDime;
        private System.Windows.Forms.NumericUpDown nudNickel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnHalfDollor;
        private System.Windows.Forms.Button btnQuarter;
        private System.Windows.Forms.Button btnDime;
        private System.Windows.Forms.Button btnNickel;
        private System.Windows.Forms.Timer timerChange;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.TextBox txtCoinBalance;
    }
}

