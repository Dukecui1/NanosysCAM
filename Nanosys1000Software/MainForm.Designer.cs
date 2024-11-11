namespace Nanosys1000Software
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)   ///用于释放占用的资源
        {
            if (disposing && (components != null))
            {
                components.Dispose();    ///判断 disposing 是否为 true 且 components 不为空，如果满足条件，则释放 components 中托管的资源。
            }
            base.Dispose(disposing);    ///调用基类的 Dispose 方法，以确保基类的资源也被正确释放。
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()   ///初始化 components 容器，用于存储和管理所有UI组件。
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNCToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.programListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.光学普适方程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.离散点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.tuRadioButton1 = new System.Windows.Forms.RadioButton();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.aoRadioButton3 = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.inputPhi_button2 = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.R_numericUpDown7 = new System.Windows.Forms.NumericUpDown();
            this.label44 = new System.Windows.Forms.Label();
            this.centerZ_numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label43 = new System.Windows.Forms.Label();
            this.centerX_numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.label42 = new System.Windows.Forms.Label();
            this.circle_button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.spline_button = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label40 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.inputData_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label45 = new System.Windows.Forms.Label();
            this.comboBoxG54 = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.numericUpDown_endx = new System.Windows.Forms.NumericUpDown();
            this.label37 = new System.Windows.Forms.Label();
            this.numericUpDown_startx = new System.Windows.Forms.NumericUpDown();
            this.label55 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.daojuEndX_numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label21 = new System.Windows.Forms.Label();
            this.daojuStartX_numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.numericUpDown_step = new System.Windows.Forms.NumericUpDown();
            this.nUDGrindingSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_speed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_feedrate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_r = new System.Windows.Forms.NumericUpDown();
            this.label54 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.programListButton1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.circleRadioButton2 = new System.Windows.Forms.RadioButton();
            this.linearRadioButton1 = new System.Windows.Forms.RadioButton();
            this.streightErrorCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label28 = new System.Windows.Forms.Label();
            this.partXcenterNumericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.pvErrorCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label26 = new System.Windows.Forms.Label();
            this.XcenterNumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.openErrorButton1 = new System.Windows.Forms.Button();
            this.errorFiletextBox1 = new System.Windows.Forms.TextBox();
            this.button_Create = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonBeTyler = new System.Windows.Forms.RadioButton();
            this.radioButtonBeUV3P = new System.Windows.Forms.RadioButton();
            this.textBoxCMPFilePath5 = new System.Windows.Forms.TextBox();
            this.textBoxCMPFilePath4 = new System.Windows.Forms.TextBox();
            this.buttonOpenCMPFile5 = new System.Windows.Forms.Button();
            this.textBoxCMPFilePath3 = new System.Windows.Forms.TextBox();
            this.buttonOpenCMPFile4 = new System.Windows.Forms.Button();
            this.textBoxCMPFilePath2 = new System.Windows.Forms.TextBox();
            this.buttonOpenCMPFile3 = new System.Windows.Forms.Button();
            this.textBoxCMPFilePath1 = new System.Windows.Forms.TextBox();
            this.buttonOpenCMPFile2 = new System.Windows.Forms.Button();
            this.checkBoxCMP5 = new System.Windows.Forms.CheckBox();
            this.checkBoxCMP4 = new System.Windows.Forms.CheckBox();
            this.buttonOpenCMPFile1 = new System.Windows.Forms.Button();
            this.checkBoxCMP3 = new System.Windows.Forms.CheckBox();
            this.checkBoxCMP2 = new System.Windows.Forms.CheckBox();
            this.checkBoxCMP1 = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxExt = new System.Windows.Forms.CheckBox();
            this.tbExtFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenExt = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.numericUpDownNumPerRnd = new System.Windows.Forms.NumericUpDown();
            this.buttonCreatNCC = new System.Windows.Forms.Button();
            this.radioButtonDXS = new System.Windows.Forms.RadioButton();
            this.cbBeCMode = new System.Windows.Forms.CheckBox();
            this.tbCFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenCFile = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R_numericUpDown7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerZ_numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerX_numericUpDown5)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_endx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daojuEndX_numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daojuStartX_numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_step)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGrindingSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_feedrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partXcenterNumericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XcenterNumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPerRnd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.createNCToolStripMenuItem,
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1324, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.fileToolStripMenuItem.Text = "文件(&F)";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.openToolStripMenuItem.Text = "打开误差数据";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openErrorButton1_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saveToolStripMenuItem.Text = "保存曲线图形";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.button_saveFigure_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(192, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Nanosys1000Software.Properties.Resources.EXIT16;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.exitToolStripMenuItem.Text = "退出";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton_close_Click);
            // 
            // createNCToolStripMenuItem
            // 
            this.createNCToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNCToolStripMenuItem1,
            this.programListToolStripMenuItem});
            this.createNCToolStripMenuItem.Name = "createNCToolStripMenuItem";
            this.createNCToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.createNCToolStripMenuItem.Text = "&NC程序";
            // 
            // createNCToolStripMenuItem1
            // 
            this.createNCToolStripMenuItem1.Image = global::Nanosys1000Software.Properties.Resources.paly32;
            this.createNCToolStripMenuItem1.Name = "createNCToolStripMenuItem1";
            this.createNCToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.createNCToolStripMenuItem1.Text = "生成NC";
            this.createNCToolStripMenuItem1.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // programListToolStripMenuItem
            // 
            this.programListToolStripMenuItem.Enabled = false;
            this.programListToolStripMenuItem.Image = global::Nanosys1000Software.Properties.Resources.ok32;
            this.programListToolStripMenuItem.Name = "programListToolStripMenuItem";
            this.programListToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.programListToolStripMenuItem.Text = "NC程序列表";
            this.programListToolStripMenuItem.Click += new System.EventHandler(this.programListButton1_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.光学普适方程ToolStripMenuItem,
            this.离散点ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.toolStripMenuItem1.Text = "曲线类型";
            this.toolStripMenuItem1.Visible = false;
            // 
            // 光学普适方程ToolStripMenuItem
            // 
            this.光学普适方程ToolStripMenuItem.Checked = true;
            this.光学普适方程ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.光学普适方程ToolStripMenuItem.Name = "光学普适方程ToolStripMenuItem";
            this.光学普适方程ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.光学普适方程ToolStripMenuItem.Text = "光学普适方程";
            this.光学普适方程ToolStripMenuItem.Click += new System.EventHandler(this.光学普适方程ToolStripMenuItem_Click);
            // 
            // 离散点ToolStripMenuItem
            // 
            this.离散点ToolStripMenuItem.Name = "离散点ToolStripMenuItem";
            this.离散点ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.离散点ToolStripMenuItem.Text = "离散点云";
            this.离散点ToolStripMenuItem.Click += new System.EventHandler(this.离散点ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.helpToolStripMenuItem.Text = "帮助(&H)";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Image = global::Nanosys1000Software.Properties.Resources.help16;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(214, 22);
            this.helpToolStripMenuItem1.Text = "帮助说明";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(211, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Nanosys1000Software.Properties.Resources.home16;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.aboutToolStripMenuItem.Text = "关于 Nanosys300 APT ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel1,
            this.toolStripStatusLabel2,
            this.timeLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 799);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1324, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel1
            // 
            this.statusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(1157, 17);
            this.statusLabel1.Spring = true;
            this.statusLabel1.Text = "就绪";
            this.statusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel2.Image = global::Nanosys1000Software.Properties.Resources.clock3e;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            // 
            // timeLabel3
            // 
            this.timeLabel3.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel3.Name = "timeLabel3";
            this.timeLabel3.Size = new System.Drawing.Size(131, 17);
            this.timeLabel3.Text = "toolStripStatusLabel3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox40);
            this.groupBox1.Controls.Add(this.textBox38);
            this.groupBox1.Controls.Add(this.textBox36);
            this.groupBox1.Controls.Add(this.textBox34);
            this.groupBox1.Controls.Add(this.textBox32);
            this.groupBox1.Controls.Add(this.tuRadioButton1);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.aoRadioButton3);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.textBox20);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.textBox18);
            this.groupBox1.Controls.Add(this.textBox12);
            this.groupBox1.Controls.Add(this.textBox16);
            this.groupBox1.Controls.Add(this.textBox30);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox28);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox26);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox24);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox22);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label48);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label47);
            this.groupBox1.Controls.Add(this.label33);
            this.groupBox1.Controls.Add(this.label46);
            this.groupBox1.Controls.Add(this.label53);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label52);
            this.groupBox1.Controls.Add(this.label31);
            this.groupBox1.Controls.Add(this.label51);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label50);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label49);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(416, 487);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "曲线参数";
            // 
            // textBox40
            // 
            this.textBox40.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox40.ForeColor = System.Drawing.Color.Maroon;
            this.textBox40.Location = new System.Drawing.Point(220, 453);
            this.textBox40.Margin = new System.Windows.Forms.Padding(4);
            this.textBox40.Name = "textBox40";
            this.textBox40.Size = new System.Drawing.Size(99, 21);
            this.textBox40.TabIndex = 73;
            this.textBox40.Text = "0";
            this.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox38
            // 
            this.textBox38.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox38.ForeColor = System.Drawing.Color.Maroon;
            this.textBox38.Location = new System.Drawing.Point(220, 424);
            this.textBox38.Margin = new System.Windows.Forms.Padding(4);
            this.textBox38.Name = "textBox38";
            this.textBox38.Size = new System.Drawing.Size(99, 21);
            this.textBox38.TabIndex = 72;
            this.textBox38.Text = "0";
            this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox36
            // 
            this.textBox36.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox36.ForeColor = System.Drawing.Color.Maroon;
            this.textBox36.Location = new System.Drawing.Point(220, 395);
            this.textBox36.Margin = new System.Windows.Forms.Padding(4);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(99, 21);
            this.textBox36.TabIndex = 71;
            this.textBox36.Text = "0";
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox34
            // 
            this.textBox34.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox34.ForeColor = System.Drawing.Color.Maroon;
            this.textBox34.Location = new System.Drawing.Point(220, 366);
            this.textBox34.Margin = new System.Windows.Forms.Padding(4);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(99, 21);
            this.textBox34.TabIndex = 70;
            this.textBox34.Text = "0";
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox32
            // 
            this.textBox32.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox32.ForeColor = System.Drawing.Color.Maroon;
            this.textBox32.Location = new System.Drawing.Point(220, 337);
            this.textBox32.Margin = new System.Windows.Forms.Padding(4);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(99, 21);
            this.textBox32.TabIndex = 69;
            this.textBox32.Text = "0";
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tuRadioButton1
            // 
            this.tuRadioButton1.AutoSize = true;
            this.tuRadioButton1.Location = new System.Drawing.Point(187, 133);
            this.tuRadioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.tuRadioButton1.Name = "tuRadioButton1";
            this.tuRadioButton1.Size = new System.Drawing.Size(57, 20);
            this.tuRadioButton1.TabIndex = 1;
            this.tuRadioButton1.Text = "凸面";
            this.tuRadioButton1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 8;
            this.numericUpDown2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown2.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDown2.Location = new System.Drawing.Point(221, 165);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(99, 21);
            this.numericUpDown2.TabIndex = 68;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // aoRadioButton3
            // 
            this.aoRadioButton3.AutoSize = true;
            this.aoRadioButton3.Checked = true;
            this.aoRadioButton3.Location = new System.Drawing.Point(33, 133);
            this.aoRadioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.aoRadioButton3.Name = "aoRadioButton3";
            this.aoRadioButton3.Size = new System.Drawing.Size(57, 20);
            this.aoRadioButton3.TabIndex = 0;
            this.aoRadioButton3.TabStop = true;
            this.aoRadioButton3.Text = "凹面";
            this.aoRadioButton3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 12;
            this.numericUpDown1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDown1.Location = new System.Drawing.Point(68, 165);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 21);
            this.numericUpDown1.TabIndex = 67;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(185, 169);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(23, 16);
            this.label34.TabIndex = 66;
            this.label34.Text = "K:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(32, 169);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(23, 16);
            this.label35.TabIndex = 65;
            this.label35.Text = "C:";
            // 
            // textBox20
            // 
            this.textBox20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox20.ForeColor = System.Drawing.Color.Maroon;
            this.textBox20.Location = new System.Drawing.Point(69, 453);
            this.textBox20.Margin = new System.Windows.Forms.Padding(4);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(99, 21);
            this.textBox20.TabIndex = 63;
            this.textBox20.Text = "0";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox14.ForeColor = System.Drawing.Color.Maroon;
            this.textBox14.Location = new System.Drawing.Point(69, 366);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(99, 21);
            this.textBox14.TabIndex = 63;
            this.textBox14.Text = "0";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox18
            // 
            this.textBox18.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox18.ForeColor = System.Drawing.Color.Maroon;
            this.textBox18.Location = new System.Drawing.Point(69, 424);
            this.textBox18.Margin = new System.Windows.Forms.Padding(4);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(99, 21);
            this.textBox18.TabIndex = 61;
            this.textBox18.Text = "0";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox12.ForeColor = System.Drawing.Color.Maroon;
            this.textBox12.Location = new System.Drawing.Point(69, 337);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(99, 21);
            this.textBox12.TabIndex = 61;
            this.textBox12.Text = "0";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox16
            // 
            this.textBox16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox16.ForeColor = System.Drawing.Color.Maroon;
            this.textBox16.Location = new System.Drawing.Point(68, 395);
            this.textBox16.Margin = new System.Windows.Forms.Padding(4);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(99, 21);
            this.textBox16.TabIndex = 59;
            this.textBox16.Text = "0";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox30
            // 
            this.textBox30.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox30.ForeColor = System.Drawing.Color.Maroon;
            this.textBox30.Location = new System.Drawing.Point(220, 308);
            this.textBox30.Margin = new System.Windows.Forms.Padding(4);
            this.textBox30.Name = "textBox30";
            this.textBox30.Size = new System.Drawing.Size(99, 21);
            this.textBox30.TabIndex = 59;
            this.textBox30.Text = "0";
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.ForeColor = System.Drawing.Color.Maroon;
            this.textBox10.Location = new System.Drawing.Point(68, 308);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(99, 21);
            this.textBox10.TabIndex = 59;
            this.textBox10.Text = "0";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox28
            // 
            this.textBox28.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox28.ForeColor = System.Drawing.Color.Maroon;
            this.textBox28.Location = new System.Drawing.Point(220, 279);
            this.textBox28.Margin = new System.Windows.Forms.Padding(4);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(99, 21);
            this.textBox28.TabIndex = 57;
            this.textBox28.Text = "0";
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox8.ForeColor = System.Drawing.Color.Maroon;
            this.textBox8.Location = new System.Drawing.Point(68, 279);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(99, 21);
            this.textBox8.TabIndex = 57;
            this.textBox8.Text = "0";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox26
            // 
            this.textBox26.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox26.ForeColor = System.Drawing.Color.Maroon;
            this.textBox26.Location = new System.Drawing.Point(220, 250);
            this.textBox26.Margin = new System.Windows.Forms.Padding(4);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(99, 21);
            this.textBox26.TabIndex = 55;
            this.textBox26.Text = "0";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox6.ForeColor = System.Drawing.Color.Maroon;
            this.textBox6.Location = new System.Drawing.Point(68, 250);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(99, 21);
            this.textBox6.TabIndex = 55;
            this.textBox6.Text = "0";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox24
            // 
            this.textBox24.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox24.ForeColor = System.Drawing.Color.Maroon;
            this.textBox24.Location = new System.Drawing.Point(221, 221);
            this.textBox24.Margin = new System.Windows.Forms.Padding(4);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(99, 21);
            this.textBox24.TabIndex = 53;
            this.textBox24.Text = "0";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.ForeColor = System.Drawing.Color.Maroon;
            this.textBox4.Location = new System.Drawing.Point(69, 221);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(99, 21);
            this.textBox4.TabIndex = 53;
            this.textBox4.Text = "0";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox22
            // 
            this.textBox22.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox22.ForeColor = System.Drawing.Color.Maroon;
            this.textBox22.Location = new System.Drawing.Point(221, 194);
            this.textBox22.Margin = new System.Windows.Forms.Padding(4);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(99, 21);
            this.textBox22.TabIndex = 51;
            this.textBox22.Text = "0";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(69, 194);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(99, 21);
            this.textBox2.TabIndex = 51;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 428);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "A38:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 371);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "A34:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 400);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "A36:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 457);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "A40:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(33, 458);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(39, 16);
            this.label48.TabIndex = 45;
            this.label48.Text = "A20:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(352, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(33, 428);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(39, 16);
            this.label47.TabIndex = 39;
            this.label47.Text = "A18:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(33, 371);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(39, 16);
            this.label33.TabIndex = 45;
            this.label33.Text = "A14:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(32, 400);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(39, 16);
            this.label46.TabIndex = 37;
            this.label46.Text = "A16:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(184, 313);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(39, 16);
            this.label53.TabIndex = 37;
            this.label53.Text = "A30:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "A12:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(184, 284);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(39, 16);
            this.label52.TabIndex = 21;
            this.label52.Text = "A28:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(32, 313);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(39, 16);
            this.label31.TabIndex = 37;
            this.label31.Text = "A10:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(185, 255);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(39, 16);
            this.label51.TabIndex = 17;
            this.label51.Text = "A26:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 284);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "A8:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(185, 226);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(39, 16);
            this.label50.TabIndex = 13;
            this.label50.Text = "A24:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 255);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "A6:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(185, 199);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(39, 16);
            this.label49.TabIndex = 9;
            this.label49.Text = "A22:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "A4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "A2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 342);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "A32:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.inputPhi_button2);
            this.groupBox8.Controls.Add(this.groupBox10);
            this.groupBox8.Controls.Add(this.richTextBox1);
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.inputData_button);
            this.groupBox8.Location = new System.Drawing.Point(12, 31);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(416, 357);
            this.groupBox8.TabIndex = 69;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "离散点云";
            this.groupBox8.Visible = false;
            // 
            // inputPhi_button2
            // 
            this.inputPhi_button2.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.inputPhi_button2.Location = new System.Drawing.Point(220, 24);
            this.inputPhi_button2.Margin = new System.Windows.Forms.Padding(4);
            this.inputPhi_button2.Name = "inputPhi_button2";
            this.inputPhi_button2.Size = new System.Drawing.Size(165, 52);
            this.inputPhi_button2.TabIndex = 45;
            this.inputPhi_button2.Text = "导入斜率点云";
            this.inputPhi_button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inputPhi_button2.UseVisualStyleBackColor = true;
            this.inputPhi_button2.Click += new System.EventHandler(this.inputPhi_button2_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.R_numericUpDown7);
            this.groupBox10.Controls.Add(this.label44);
            this.groupBox10.Controls.Add(this.centerZ_numericUpDown6);
            this.groupBox10.Controls.Add(this.label43);
            this.groupBox10.Controls.Add(this.centerX_numericUpDown5);
            this.groupBox10.Controls.Add(this.label42);
            this.groupBox10.Controls.Add(this.circle_button2);
            this.groupBox10.Enabled = false;
            this.groupBox10.Location = new System.Drawing.Point(213, 140);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(172, 209);
            this.groupBox10.TabIndex = 43;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "圆拟合参数";
            // 
            // R_numericUpDown7
            // 
            this.R_numericUpDown7.DecimalPlaces = 6;
            this.R_numericUpDown7.Location = new System.Drawing.Point(91, 102);
            this.R_numericUpDown7.Margin = new System.Windows.Forms.Padding(4);
            this.R_numericUpDown7.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.R_numericUpDown7.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.R_numericUpDown7.Name = "R_numericUpDown7";
            this.R_numericUpDown7.ReadOnly = true;
            this.R_numericUpDown7.Size = new System.Drawing.Size(68, 26);
            this.R_numericUpDown7.TabIndex = 10;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(63, 109);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(23, 16);
            this.label44.TabIndex = 9;
            this.label44.Text = "R:";
            // 
            // centerZ_numericUpDown6
            // 
            this.centerZ_numericUpDown6.DecimalPlaces = 6;
            this.centerZ_numericUpDown6.Location = new System.Drawing.Point(91, 66);
            this.centerZ_numericUpDown6.Margin = new System.Windows.Forms.Padding(4);
            this.centerZ_numericUpDown6.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.centerZ_numericUpDown6.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.centerZ_numericUpDown6.Name = "centerZ_numericUpDown6";
            this.centerZ_numericUpDown6.ReadOnly = true;
            this.centerZ_numericUpDown6.Size = new System.Drawing.Size(68, 26);
            this.centerZ_numericUpDown6.TabIndex = 8;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(15, 71);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(71, 16);
            this.label43.TabIndex = 7;
            this.label43.Text = "centerZ:";
            // 
            // centerX_numericUpDown5
            // 
            this.centerX_numericUpDown5.DecimalPlaces = 6;
            this.centerX_numericUpDown5.Location = new System.Drawing.Point(91, 27);
            this.centerX_numericUpDown5.Margin = new System.Windows.Forms.Padding(4);
            this.centerX_numericUpDown5.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.centerX_numericUpDown5.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.centerX_numericUpDown5.Name = "centerX_numericUpDown5";
            this.centerX_numericUpDown5.ReadOnly = true;
            this.centerX_numericUpDown5.Size = new System.Drawing.Size(68, 26);
            this.centerX_numericUpDown5.TabIndex = 6;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(17, 30);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(71, 16);
            this.label42.TabIndex = 5;
            this.label42.Text = "centerX:";
            // 
            // circle_button2
            // 
            this.circle_button2.Image = global::Nanosys1000Software.Properties.Resources.paly32;
            this.circle_button2.Location = new System.Drawing.Point(18, 136);
            this.circle_button2.Margin = new System.Windows.Forms.Padding(4);
            this.circle_button2.Name = "circle_button2";
            this.circle_button2.Size = new System.Drawing.Size(136, 53);
            this.circle_button2.TabIndex = 4;
            this.circle_button2.Text = "圆拟合";
            this.circle_button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.circle_button2.UseVisualStyleBackColor = true;
            this.circle_button2.Click += new System.EventHandler(this.circle_button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 84);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(361, 41);
            this.richTextBox1.TabIndex = 44;
            this.richTextBox1.Text = "";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.spline_button);
            this.groupBox9.Controls.Add(this.numericUpDown4);
            this.groupBox9.Controls.Add(this.label40);
            this.groupBox9.Controls.Add(this.numericUpDown3);
            this.groupBox9.Controls.Add(this.label41);
            this.groupBox9.Enabled = false;
            this.groupBox9.Location = new System.Drawing.Point(24, 148);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox9.Size = new System.Drawing.Size(181, 201);
            this.groupBox9.TabIndex = 42;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "样条拟合参数";
            // 
            // spline_button
            // 
            this.spline_button.Image = global::Nanosys1000Software.Properties.Resources.paly32;
            this.spline_button.Location = new System.Drawing.Point(20, 128);
            this.spline_button.Margin = new System.Windows.Forms.Padding(4);
            this.spline_button.Name = "spline_button";
            this.spline_button.Size = new System.Drawing.Size(136, 53);
            this.spline_button.TabIndex = 4;
            this.spline_button.Text = "样条拟合";
            this.spline_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.spline_button.UseVisualStyleBackColor = true;
            this.spline_button.Click += new System.EventHandler(this.spline_button_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.DecimalPlaces = 10;
            this.numericUpDown4.Location = new System.Drawing.Point(97, 85);
            this.numericUpDown4.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(69, 26);
            this.numericUpDown4.TabIndex = 2;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(41, 41);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(55, 16);
            this.label40.TabIndex = 1;
            this.label40.Text = "阶次：";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(97, 39);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(69, 26);
            this.numericUpDown3.TabIndex = 0;
            this.numericUpDown3.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(9, 88);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(87, 16);
            this.label41.TabIndex = 3;
            this.label41.Text = "允许公差：";
            // 
            // inputData_button
            // 
            this.inputData_button.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.inputData_button.Location = new System.Drawing.Point(24, 24);
            this.inputData_button.Margin = new System.Windows.Forms.Padding(4);
            this.inputData_button.Name = "inputData_button";
            this.inputData_button.Size = new System.Drawing.Size(165, 52);
            this.inputData_button.TabIndex = 0;
            this.inputData_button.Text = "导入数据点云";
            this.inputData_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.inputData_button.UseVisualStyleBackColor = true;
            this.inputData_button.Click += new System.EventHandler(this.inputData_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.comboBoxG54);
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label39);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.numericUpDown_endx);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.numericUpDown_startx);
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.daojuEndX_numericUpDown3);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.daojuStartX_numericUpDown4);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.numericUpDown_step);
            this.groupBox2.Controls.Add(this.nUDGrindingSpeed);
            this.groupBox2.Controls.Add(this.numericUpDown_speed);
            this.groupBox2.Controls.Add(this.numericUpDown_feedrate);
            this.groupBox2.Controls.Add(this.numericUpDown_r);
            this.groupBox2.Controls.Add(this.label54);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(805, 526);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(503, 202);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "工艺参数";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label45.Location = new System.Drawing.Point(8, 159);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(71, 16);
            this.label45.TabIndex = 38;
            this.label45.Text = "坐标系：";
            // 
            // comboBoxG54
            // 
            this.comboBoxG54.FormattingEnabled = true;
            this.comboBoxG54.Items.AddRange(new object[] {
            "G54",
            "G55",
            "G56",
            "G57",
            "G58",
            "G59"});
            this.comboBoxG54.Location = new System.Drawing.Point(108, 156);
            this.comboBoxG54.Name = "comboBoxG54";
            this.comboBoxG54.Size = new System.Drawing.Size(100, 24);
            this.comboBoxG54.TabIndex = 37;
            this.comboBoxG54.Text = "G54";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label36.Location = new System.Drawing.Point(8, 98);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(95, 16);
            this.label36.TabIndex = 31;
            this.label36.Text = "工件起始X：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(446, 95);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 16);
            this.label23.TabIndex = 30;
            this.label23.Text = "mm";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label39.Location = new System.Drawing.Point(8, 129);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(95, 16);
            this.label39.TabIndex = 36;
            this.label39.Text = "程序起始X：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(214, 95);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(23, 16);
            this.label22.TabIndex = 29;
            this.label22.Text = "mm";
            // 
            // numericUpDown_endx
            // 
            this.numericUpDown_endx.DecimalPlaces = 3;
            this.numericUpDown_endx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_endx.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDown_endx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_endx.Location = new System.Drawing.Point(344, 89);
            this.numericUpDown_endx.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_endx.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_endx.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDown_endx.Name = "numericUpDown_endx";
            this.numericUpDown_endx.Size = new System.Drawing.Size(99, 26);
            this.numericUpDown_endx.TabIndex = 26;
            this.numericUpDown_endx.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label37.Location = new System.Drawing.Point(445, 128);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(23, 16);
            this.label37.TabIndex = 35;
            this.label37.Text = "mm";
            // 
            // numericUpDown_startx
            // 
            this.numericUpDown_startx.DecimalPlaces = 3;
            this.numericUpDown_startx.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_startx.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDown_startx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_startx.Location = new System.Drawing.Point(108, 89);
            this.numericUpDown_startx.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_startx.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown_startx.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDown_startx.Name = "numericUpDown_startx";
            this.numericUpDown_startx.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown_startx.TabIndex = 25;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label55.Location = new System.Drawing.Point(447, 164);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(47, 16);
            this.label55.TabIndex = 32;
            this.label55.Text = "r/min";
            this.label55.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(208, 61);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(47, 16);
            this.label25.TabIndex = 32;
            this.label25.Text = "r/min";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(258, 129);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "结束X:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(258, 95);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(55, 16);
            this.label17.TabIndex = 17;
            this.label17.Text = "结束X:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label38.Location = new System.Drawing.Point(214, 129);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(23, 16);
            this.label38.TabIndex = 34;
            this.label38.Text = "mm";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(443, 60);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 16);
            this.label24.TabIndex = 31;
            this.label24.Text = "mm/min";
            // 
            // daojuEndX_numericUpDown3
            // 
            this.daojuEndX_numericUpDown3.BackColor = System.Drawing.Color.White;
            this.daojuEndX_numericUpDown3.DecimalPlaces = 3;
            this.daojuEndX_numericUpDown3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daojuEndX_numericUpDown3.ForeColor = System.Drawing.Color.Maroon;
            this.daojuEndX_numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.daojuEndX_numericUpDown3.Location = new System.Drawing.Point(343, 123);
            this.daojuEndX_numericUpDown3.Margin = new System.Windows.Forms.Padding(4);
            this.daojuEndX_numericUpDown3.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.daojuEndX_numericUpDown3.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.daojuEndX_numericUpDown3.Name = "daojuEndX_numericUpDown3";
            this.daojuEndX_numericUpDown3.ReadOnly = true;
            this.daojuEndX_numericUpDown3.Size = new System.Drawing.Size(99, 26);
            this.daojuEndX_numericUpDown3.TabIndex = 33;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label21.Location = new System.Drawing.Point(444, 27);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 16);
            this.label21.TabIndex = 28;
            this.label21.Text = "mm";
            // 
            // daojuStartX_numericUpDown4
            // 
            this.daojuStartX_numericUpDown4.BackColor = System.Drawing.Color.White;
            this.daojuStartX_numericUpDown4.DecimalPlaces = 3;
            this.daojuStartX_numericUpDown4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.daojuStartX_numericUpDown4.ForeColor = System.Drawing.Color.Maroon;
            this.daojuStartX_numericUpDown4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.daojuStartX_numericUpDown4.Location = new System.Drawing.Point(108, 123);
            this.daojuStartX_numericUpDown4.Margin = new System.Windows.Forms.Padding(4);
            this.daojuStartX_numericUpDown4.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.daojuStartX_numericUpDown4.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.daojuStartX_numericUpDown4.Name = "daojuStartX_numericUpDown4";
            this.daojuStartX_numericUpDown4.ReadOnly = true;
            this.daojuStartX_numericUpDown4.Size = new System.Drawing.Size(100, 26);
            this.daojuStartX_numericUpDown4.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(212, 27);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 16);
            this.label20.TabIndex = 27;
            this.label20.Text = "mm";
            // 
            // numericUpDown_step
            // 
            this.numericUpDown_step.DecimalPlaces = 3;
            this.numericUpDown_step.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_step.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDown_step.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_step.Location = new System.Drawing.Point(343, 21);
            this.numericUpDown_step.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_step.Name = "numericUpDown_step";
            this.numericUpDown_step.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown_step.TabIndex = 24;
            this.numericUpDown_step.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // nUDGrindingSpeed
            // 
            this.nUDGrindingSpeed.DecimalPlaces = 1;
            this.nUDGrindingSpeed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nUDGrindingSpeed.ForeColor = System.Drawing.Color.Maroon;
            this.nUDGrindingSpeed.Location = new System.Drawing.Point(342, 157);
            this.nUDGrindingSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.nUDGrindingSpeed.Maximum = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            this.nUDGrindingSpeed.Name = "nUDGrindingSpeed";
            this.nUDGrindingSpeed.Size = new System.Drawing.Size(100, 26);
            this.nUDGrindingSpeed.TabIndex = 23;
            this.nUDGrindingSpeed.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUDGrindingSpeed.Visible = false;
            // 
            // numericUpDown_speed
            // 
            this.numericUpDown_speed.DecimalPlaces = 1;
            this.numericUpDown_speed.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_speed.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDown_speed.Location = new System.Drawing.Point(108, 55);
            this.numericUpDown_speed.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_speed.Maximum = new decimal(new int[] {
            10001,
            0,
            0,
            0});
            this.numericUpDown_speed.Name = "numericUpDown_speed";
            this.numericUpDown_speed.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown_speed.TabIndex = 23;
            this.numericUpDown_speed.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDown_feedrate
            // 
            this.numericUpDown_feedrate.DecimalPlaces = 1;
            this.numericUpDown_feedrate.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_feedrate.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDown_feedrate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown_feedrate.Location = new System.Drawing.Point(343, 55);
            this.numericUpDown_feedrate.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_feedrate.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown_feedrate.Name = "numericUpDown_feedrate";
            this.numericUpDown_feedrate.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown_feedrate.TabIndex = 22;
            this.numericUpDown_feedrate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_r
            // 
            this.numericUpDown_r.DecimalPlaces = 3;
            this.numericUpDown_r.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDown_r.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDown_r.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_r.Location = new System.Drawing.Point(108, 21);
            this.numericUpDown_r.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_r.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_r.Name = "numericUpDown_r";
            this.numericUpDown_r.Size = new System.Drawing.Size(100, 26);
            this.numericUpDown_r.TabIndex = 21;
            this.numericUpDown_r.Value = new decimal(new int[] {
            563,
            0,
            0,
            196608});
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label54.Location = new System.Drawing.Point(258, 164);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(79, 16);
            this.label54.TabIndex = 13;
            this.label54.Text = "磨轴转速:";
            this.label54.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(258, 31);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 16);
            this.label18.TabIndex = 19;
            this.label18.Text = "步长:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(8, 66);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 16);
            this.label15.TabIndex = 13;
            this.label15.Text = "主轴转速:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(258, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "进给速度:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(8, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 9;
            this.label14.Text = "刀具半径:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Image = global::Nanosys1000Software.Properties.Resources.EXIT16;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1187, 736);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 49);
            this.button1.TabIndex = 36;
            this.button1.Text = "退出系统";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.toolStripButton_close_Click);
            // 
            // programListButton1
            // 
            this.programListButton1.Enabled = false;
            this.programListButton1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.programListButton1.ForeColor = System.Drawing.Color.Brown;
            this.programListButton1.Image = global::Nanosys1000Software.Properties.Resources.property32;
            this.programListButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.programListButton1.Location = new System.Drawing.Point(1002, 736);
            this.programListButton1.Margin = new System.Windows.Forms.Padding(4);
            this.programListButton1.Name = "programListButton1";
            this.programListButton1.Size = new System.Drawing.Size(117, 49);
            this.programListButton1.TabIndex = 35;
            this.programListButton1.Text = "程序列表";
            this.programListButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.programListButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.programListButton1.UseVisualStyleBackColor = true;
            this.programListButton1.Click += new System.EventHandler(this.programListButton1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.circleRadioButton2);
            this.groupBox4.Controls.Add(this.linearRadioButton1);
            this.groupBox4.Controls.Add(this.streightErrorCheckBox1);
            this.groupBox4.Controls.Add(this.label28);
            this.groupBox4.Controls.Add(this.partXcenterNumericUpDown2);
            this.groupBox4.Controls.Add(this.pvErrorCheckBox1);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.XcenterNumericUpDown1);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label29);
            this.groupBox4.Controls.Add(this.openErrorButton1);
            this.groupBox4.Controls.Add(this.errorFiletextBox1);
            this.groupBox4.Location = new System.Drawing.Point(2000, 45);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(240, 407);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hide";
            // 
            // circleRadioButton2
            // 
            this.circleRadioButton2.AutoSize = true;
            this.circleRadioButton2.Location = new System.Drawing.Point(136, 19);
            this.circleRadioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.circleRadioButton2.Name = "circleRadioButton2";
            this.circleRadioButton2.Size = new System.Drawing.Size(89, 20);
            this.circleRadioButton2.TabIndex = 1;
            this.circleRadioButton2.Text = "圆弧插补";
            this.circleRadioButton2.UseVisualStyleBackColor = true;
            // 
            // linearRadioButton1
            // 
            this.linearRadioButton1.AutoSize = true;
            this.linearRadioButton1.Checked = true;
            this.linearRadioButton1.Location = new System.Drawing.Point(15, 19);
            this.linearRadioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.linearRadioButton1.Name = "linearRadioButton1";
            this.linearRadioButton1.Size = new System.Drawing.Size(89, 20);
            this.linearRadioButton1.TabIndex = 0;
            this.linearRadioButton1.TabStop = true;
            this.linearRadioButton1.Text = "线性插补";
            this.linearRadioButton1.UseVisualStyleBackColor = true;
            // 
            // streightErrorCheckBox1
            // 
            this.streightErrorCheckBox1.AutoSize = true;
            this.streightErrorCheckBox1.Location = new System.Drawing.Point(55, 65);
            this.streightErrorCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.streightErrorCheckBox1.Name = "streightErrorCheckBox1";
            this.streightErrorCheckBox1.Size = new System.Drawing.Size(170, 20);
            this.streightErrorCheckBox1.TabIndex = 36;
            this.streightErrorCheckBox1.Text = "导轨垂直度误差补偿";
            this.streightErrorCheckBox1.UseVisualStyleBackColor = true;
            this.streightErrorCheckBox1.Visible = false;
            this.streightErrorCheckBox1.CheckedChanged += new System.EventHandler(this.streightErrorCheckBox1_CheckedChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(-15, 104);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(135, 16);
            this.label28.TabIndex = 33;
            this.label28.Text = "垂直度数据X中心:";
            this.label28.Visible = false;
            // 
            // partXcenterNumericUpDown2
            // 
            this.partXcenterNumericUpDown2.DecimalPlaces = 5;
            this.partXcenterNumericUpDown2.Enabled = false;
            this.partXcenterNumericUpDown2.ForeColor = System.Drawing.Color.Maroon;
            this.partXcenterNumericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.partXcenterNumericUpDown2.Location = new System.Drawing.Point(117, 99);
            this.partXcenterNumericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.partXcenterNumericUpDown2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.partXcenterNumericUpDown2.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.partXcenterNumericUpDown2.Name = "partXcenterNumericUpDown2";
            this.partXcenterNumericUpDown2.Size = new System.Drawing.Size(113, 26);
            this.partXcenterNumericUpDown2.TabIndex = 34;
            this.partXcenterNumericUpDown2.Value = new decimal(new int[] {
            38485,
            0,
            0,
            131072});
            this.partXcenterNumericUpDown2.Visible = false;
            // 
            // pvErrorCheckBox1
            // 
            this.pvErrorCheckBox1.AutoSize = true;
            this.pvErrorCheckBox1.Location = new System.Drawing.Point(55, 149);
            this.pvErrorCheckBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pvErrorCheckBox1.Name = "pvErrorCheckBox1";
            this.pvErrorCheckBox1.Size = new System.Drawing.Size(154, 20);
            this.pvErrorCheckBox1.TabIndex = 37;
            this.pvErrorCheckBox1.Text = "工件面形误差补偿";
            this.pvErrorCheckBox1.UseVisualStyleBackColor = true;
            this.pvErrorCheckBox1.Visible = false;
            this.pvErrorCheckBox1.CheckedChanged += new System.EventHandler(this.pvErrorCheckBox1_CheckedChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(3, 181);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 16);
            this.label26.TabIndex = 30;
            this.label26.Text = "Z中心:";
            this.label26.Visible = false;
            // 
            // XcenterNumericUpDown1
            // 
            this.XcenterNumericUpDown1.DecimalPlaces = 5;
            this.XcenterNumericUpDown1.Enabled = false;
            this.XcenterNumericUpDown1.ForeColor = System.Drawing.Color.Maroon;
            this.XcenterNumericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.XcenterNumericUpDown1.Location = new System.Drawing.Point(71, 179);
            this.XcenterNumericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.XcenterNumericUpDown1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.XcenterNumericUpDown1.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.XcenterNumericUpDown1.Name = "XcenterNumericUpDown1";
            this.XcenterNumericUpDown1.Size = new System.Drawing.Size(113, 26);
            this.XcenterNumericUpDown1.TabIndex = 31;
            this.XcenterNumericUpDown1.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(192, 181);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 16);
            this.label19.TabIndex = 32;
            this.label19.Text = "mm";
            this.label19.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(-13, 223);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(119, 16);
            this.label29.TabIndex = 38;
            this.label29.Text = "误差数据文件：";
            this.label29.Visible = false;
            // 
            // openErrorButton1
            // 
            this.openErrorButton1.Enabled = false;
            this.openErrorButton1.ForeColor = System.Drawing.Color.Brown;
            this.openErrorButton1.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.openErrorButton1.Location = new System.Drawing.Point(145, 215);
            this.openErrorButton1.Margin = new System.Windows.Forms.Padding(4);
            this.openErrorButton1.Name = "openErrorButton1";
            this.openErrorButton1.Size = new System.Drawing.Size(87, 33);
            this.openErrorButton1.TabIndex = 39;
            this.openErrorButton1.Text = "打开";
            this.openErrorButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.openErrorButton1.UseVisualStyleBackColor = true;
            this.openErrorButton1.Visible = false;
            this.openErrorButton1.Click += new System.EventHandler(this.openErrorButton1_Click);
            // 
            // errorFiletextBox1
            // 
            this.errorFiletextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.errorFiletextBox1.Location = new System.Drawing.Point(36, 219);
            this.errorFiletextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.errorFiletextBox1.Name = "errorFiletextBox1";
            this.errorFiletextBox1.ReadOnly = true;
            this.errorFiletextBox1.Size = new System.Drawing.Size(100, 26);
            this.errorFiletextBox1.TabIndex = 40;
            this.errorFiletextBox1.Visible = false;
            // 
            // button_Create
            // 
            this.button_Create.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Create.ForeColor = System.Drawing.Color.Brown;
            this.button_Create.Image = global::Nanosys1000Software.Properties.Resources.paly32;
            this.button_Create.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Create.Location = new System.Drawing.Point(816, 736);
            this.button_Create.Margin = new System.Windows.Forms.Padding(4);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(115, 49);
            this.button_Create.TabIndex = 5;
            this.button_Create.Text = "生成NC";
            this.button_Create.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.Title = "x(mm)";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Maroon;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.Title = "z(mm)";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Maroon;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 85F;
            chartArea1.InnerPlotPosition.Width = 85F;
            chartArea1.InnerPlotPosition.X = 12F;
            chartArea1.InnerPlotPosition.Y = 3F;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(4, 4);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Fuchsia;
            series1.Legend = "Legend1";
            series1.LegendText = "工件曲线";
            series1.Name = "Series1";
            dataPoint1.IsEmpty = true;
            dataPoint1.MarkerSize = 2;
            series1.Points.Add(dataPoint1);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "编程曲线";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(809, 402);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisX.Title = "x(mm)";
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.Maroon;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MinorTickMark.Enabled = true;
            chartArea2.AxisY.Title = "z(mm)";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.Maroon;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            chartArea2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 85F;
            chartArea2.InnerPlotPosition.Width = 85F;
            chartArea2.InnerPlotPosition.X = 12F;
            chartArea2.InnerPlotPosition.Y = 3F;
            chartArea2.Name = "ChartArea3";
            this.chart3.ChartAreas.Add(chartArea2);
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.DockedToChartArea = "ChartArea3";
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            legend2.Name = "Legend3";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(3, 3);
            this.chart3.Margin = new System.Windows.Forms.Padding(4);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea3";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend3";
            series3.LegendText = "补偿曲线";
            series3.Name = "Series1";
            dataPoint2.IsEmpty = true;
            series3.Points.Add(dataPoint2);
            series4.ChartArea = "ChartArea3";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Yellow;
            series4.Legend = "Legend3";
            series4.LegendText = "补偿散点";
            series4.Name = "Series2";
            dataPoint3.IsEmpty = true;
            series4.Points.Add(dataPoint3);
            this.chart3.Series.Add(series3);
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(811, 404);
            this.chart3.TabIndex = 76;
            this.chart3.Text = "chart3";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.tabControl1);
            this.groupBox6.Location = new System.Drawing.Point(445, 31);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(863, 487);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "图形数据区";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(8, 26);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 440);
            this.tabControl1.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(817, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "曲线图形";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(817, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "数据列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(809, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "X(mm)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Z(mm)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.chart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(817, 410);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "补偿曲线";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonBeTyler);
            this.groupBox3.Controls.Add(this.radioButtonBeUV3P);
            this.groupBox3.Controls.Add(this.textBoxCMPFilePath5);
            this.groupBox3.Controls.Add(this.textBoxCMPFilePath4);
            this.groupBox3.Controls.Add(this.buttonOpenCMPFile5);
            this.groupBox3.Controls.Add(this.textBoxCMPFilePath3);
            this.groupBox3.Controls.Add(this.buttonOpenCMPFile4);
            this.groupBox3.Controls.Add(this.textBoxCMPFilePath2);
            this.groupBox3.Controls.Add(this.buttonOpenCMPFile3);
            this.groupBox3.Controls.Add(this.textBoxCMPFilePath1);
            this.groupBox3.Controls.Add(this.buttonOpenCMPFile2);
            this.groupBox3.Controls.Add(this.checkBoxCMP5);
            this.groupBox3.Controls.Add(this.checkBoxCMP4);
            this.groupBox3.Controls.Add(this.buttonOpenCMPFile1);
            this.groupBox3.Controls.Add(this.checkBoxCMP3);
            this.groupBox3.Controls.Add(this.checkBoxCMP2);
            this.groupBox3.Controls.Add(this.checkBoxCMP1);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(445, 526);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(350, 262);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "补偿设置";
            // 
            // radioButtonBeTyler
            // 
            this.radioButtonBeTyler.AutoSize = true;
            this.radioButtonBeTyler.Location = new System.Drawing.Point(163, 25);
            this.radioButtonBeTyler.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonBeTyler.Name = "radioButtonBeTyler";
            this.radioButtonBeTyler.Size = new System.Drawing.Size(169, 20);
            this.radioButtonBeTyler.TabIndex = 42;
            this.radioButtonBeTyler.Text = "TAYLOR PGI误差补偿";
            this.radioButtonBeTyler.UseVisualStyleBackColor = true;
            this.radioButtonBeTyler.CheckedChanged += new System.EventHandler(this.radioButtonBeUV3P_CheckedChanged);
            // 
            // radioButtonBeUV3P
            // 
            this.radioButtonBeUV3P.AutoSize = true;
            this.radioButtonBeUV3P.Checked = true;
            this.radioButtonBeUV3P.Location = new System.Drawing.Point(33, 27);
            this.radioButtonBeUV3P.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonBeUV3P.Name = "radioButtonBeUV3P";
            this.radioButtonBeUV3P.Size = new System.Drawing.Size(121, 20);
            this.radioButtonBeUV3P.TabIndex = 41;
            this.radioButtonBeUV3P.TabStop = true;
            this.radioButtonBeUV3P.Text = "UA3P误差补偿";
            this.radioButtonBeUV3P.UseVisualStyleBackColor = true;
            this.radioButtonBeUV3P.CheckedChanged += new System.EventHandler(this.radioButtonBeUV3P_CheckedChanged);
            // 
            // textBoxCMPFilePath5
            // 
            this.textBoxCMPFilePath5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCMPFilePath5.Location = new System.Drawing.Point(122, 216);
            this.textBoxCMPFilePath5.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCMPFilePath5.Name = "textBoxCMPFilePath5";
            this.textBoxCMPFilePath5.ReadOnly = true;
            this.textBoxCMPFilePath5.Size = new System.Drawing.Size(123, 26);
            this.textBoxCMPFilePath5.TabIndex = 40;
            // 
            // textBoxCMPFilePath4
            // 
            this.textBoxCMPFilePath4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCMPFilePath4.Location = new System.Drawing.Point(122, 179);
            this.textBoxCMPFilePath4.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCMPFilePath4.Name = "textBoxCMPFilePath4";
            this.textBoxCMPFilePath4.ReadOnly = true;
            this.textBoxCMPFilePath4.Size = new System.Drawing.Size(123, 26);
            this.textBoxCMPFilePath4.TabIndex = 40;
            // 
            // buttonOpenCMPFile5
            // 
            this.buttonOpenCMPFile5.Enabled = false;
            this.buttonOpenCMPFile5.ForeColor = System.Drawing.Color.Brown;
            this.buttonOpenCMPFile5.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.buttonOpenCMPFile5.Location = new System.Drawing.Point(253, 213);
            this.buttonOpenCMPFile5.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenCMPFile5.Name = "buttonOpenCMPFile5";
            this.buttonOpenCMPFile5.Size = new System.Drawing.Size(87, 33);
            this.buttonOpenCMPFile5.TabIndex = 39;
            this.buttonOpenCMPFile5.Text = "打开";
            this.buttonOpenCMPFile5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOpenCMPFile5.UseVisualStyleBackColor = true;
            this.buttonOpenCMPFile5.Click += new System.EventHandler(this.buttonOpenFileUV3P_Click);
            // 
            // textBoxCMPFilePath3
            // 
            this.textBoxCMPFilePath3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCMPFilePath3.Location = new System.Drawing.Point(122, 143);
            this.textBoxCMPFilePath3.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCMPFilePath3.Name = "textBoxCMPFilePath3";
            this.textBoxCMPFilePath3.ReadOnly = true;
            this.textBoxCMPFilePath3.Size = new System.Drawing.Size(123, 26);
            this.textBoxCMPFilePath3.TabIndex = 40;
            // 
            // buttonOpenCMPFile4
            // 
            this.buttonOpenCMPFile4.Enabled = false;
            this.buttonOpenCMPFile4.ForeColor = System.Drawing.Color.Brown;
            this.buttonOpenCMPFile4.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.buttonOpenCMPFile4.Location = new System.Drawing.Point(253, 175);
            this.buttonOpenCMPFile4.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenCMPFile4.Name = "buttonOpenCMPFile4";
            this.buttonOpenCMPFile4.Size = new System.Drawing.Size(87, 33);
            this.buttonOpenCMPFile4.TabIndex = 39;
            this.buttonOpenCMPFile4.Text = "打开";
            this.buttonOpenCMPFile4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOpenCMPFile4.UseVisualStyleBackColor = true;
            this.buttonOpenCMPFile4.Click += new System.EventHandler(this.buttonOpenFileUV3P_Click);
            // 
            // textBoxCMPFilePath2
            // 
            this.textBoxCMPFilePath2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCMPFilePath2.Location = new System.Drawing.Point(122, 104);
            this.textBoxCMPFilePath2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCMPFilePath2.Name = "textBoxCMPFilePath2";
            this.textBoxCMPFilePath2.ReadOnly = true;
            this.textBoxCMPFilePath2.Size = new System.Drawing.Size(123, 26);
            this.textBoxCMPFilePath2.TabIndex = 40;
            // 
            // buttonOpenCMPFile3
            // 
            this.buttonOpenCMPFile3.Enabled = false;
            this.buttonOpenCMPFile3.ForeColor = System.Drawing.Color.Brown;
            this.buttonOpenCMPFile3.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.buttonOpenCMPFile3.Location = new System.Drawing.Point(253, 139);
            this.buttonOpenCMPFile3.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenCMPFile3.Name = "buttonOpenCMPFile3";
            this.buttonOpenCMPFile3.Size = new System.Drawing.Size(87, 33);
            this.buttonOpenCMPFile3.TabIndex = 39;
            this.buttonOpenCMPFile3.Text = "打开";
            this.buttonOpenCMPFile3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOpenCMPFile3.UseVisualStyleBackColor = true;
            this.buttonOpenCMPFile3.Click += new System.EventHandler(this.buttonOpenFileUV3P_Click);
            // 
            // textBoxCMPFilePath1
            // 
            this.textBoxCMPFilePath1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxCMPFilePath1.Location = new System.Drawing.Point(122, 64);
            this.textBoxCMPFilePath1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCMPFilePath1.Name = "textBoxCMPFilePath1";
            this.textBoxCMPFilePath1.ReadOnly = true;
            this.textBoxCMPFilePath1.Size = new System.Drawing.Size(123, 26);
            this.textBoxCMPFilePath1.TabIndex = 40;
            // 
            // buttonOpenCMPFile2
            // 
            this.buttonOpenCMPFile2.Enabled = false;
            this.buttonOpenCMPFile2.ForeColor = System.Drawing.Color.Brown;
            this.buttonOpenCMPFile2.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.buttonOpenCMPFile2.Location = new System.Drawing.Point(253, 100);
            this.buttonOpenCMPFile2.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenCMPFile2.Name = "buttonOpenCMPFile2";
            this.buttonOpenCMPFile2.Size = new System.Drawing.Size(87, 33);
            this.buttonOpenCMPFile2.TabIndex = 39;
            this.buttonOpenCMPFile2.Text = "打开";
            this.buttonOpenCMPFile2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOpenCMPFile2.UseVisualStyleBackColor = true;
            this.buttonOpenCMPFile2.Click += new System.EventHandler(this.buttonOpenFileUV3P_Click);
            // 
            // checkBoxCMP5
            // 
            this.checkBoxCMP5.AutoSize = true;
            this.checkBoxCMP5.Location = new System.Drawing.Point(15, 224);
            this.checkBoxCMP5.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCMP5.Name = "checkBoxCMP5";
            this.checkBoxCMP5.Size = new System.Drawing.Size(98, 20);
            this.checkBoxCMP5.TabIndex = 37;
            this.checkBoxCMP5.Text = "第5次补偿";
            this.checkBoxCMP5.UseVisualStyleBackColor = true;
            this.checkBoxCMP5.CheckedChanged += new System.EventHandler(this.checkBoxUV3P_CheckedChanged);
            // 
            // checkBoxCMP4
            // 
            this.checkBoxCMP4.AutoSize = true;
            this.checkBoxCMP4.Location = new System.Drawing.Point(15, 187);
            this.checkBoxCMP4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCMP4.Name = "checkBoxCMP4";
            this.checkBoxCMP4.Size = new System.Drawing.Size(98, 20);
            this.checkBoxCMP4.TabIndex = 37;
            this.checkBoxCMP4.Text = "第4次补偿";
            this.checkBoxCMP4.UseVisualStyleBackColor = true;
            this.checkBoxCMP4.CheckedChanged += new System.EventHandler(this.checkBoxUV3P_CheckedChanged);
            // 
            // buttonOpenCMPFile1
            // 
            this.buttonOpenCMPFile1.Enabled = false;
            this.buttonOpenCMPFile1.ForeColor = System.Drawing.Color.Brown;
            this.buttonOpenCMPFile1.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.buttonOpenCMPFile1.Location = new System.Drawing.Point(253, 60);
            this.buttonOpenCMPFile1.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenCMPFile1.Name = "buttonOpenCMPFile1";
            this.buttonOpenCMPFile1.Size = new System.Drawing.Size(87, 33);
            this.buttonOpenCMPFile1.TabIndex = 39;
            this.buttonOpenCMPFile1.Text = "打开";
            this.buttonOpenCMPFile1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOpenCMPFile1.UseVisualStyleBackColor = true;
            this.buttonOpenCMPFile1.Click += new System.EventHandler(this.buttonOpenFileUV3P_Click);
            // 
            // checkBoxCMP3
            // 
            this.checkBoxCMP3.AutoSize = true;
            this.checkBoxCMP3.Location = new System.Drawing.Point(15, 151);
            this.checkBoxCMP3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCMP3.Name = "checkBoxCMP3";
            this.checkBoxCMP3.Size = new System.Drawing.Size(98, 20);
            this.checkBoxCMP3.TabIndex = 37;
            this.checkBoxCMP3.Text = "第3次补偿";
            this.checkBoxCMP3.UseVisualStyleBackColor = true;
            this.checkBoxCMP3.CheckedChanged += new System.EventHandler(this.checkBoxUV3P_CheckedChanged);
            // 
            // checkBoxCMP2
            // 
            this.checkBoxCMP2.AutoSize = true;
            this.checkBoxCMP2.Location = new System.Drawing.Point(15, 112);
            this.checkBoxCMP2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCMP2.Name = "checkBoxCMP2";
            this.checkBoxCMP2.Size = new System.Drawing.Size(98, 20);
            this.checkBoxCMP2.TabIndex = 37;
            this.checkBoxCMP2.Text = "第2次补偿";
            this.checkBoxCMP2.UseVisualStyleBackColor = true;
            this.checkBoxCMP2.CheckedChanged += new System.EventHandler(this.checkBoxUV3P_CheckedChanged);
            // 
            // checkBoxCMP1
            // 
            this.checkBoxCMP1.AutoSize = true;
            this.checkBoxCMP1.Location = new System.Drawing.Point(15, 72);
            this.checkBoxCMP1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCMP1.Name = "checkBoxCMP1";
            this.checkBoxCMP1.Size = new System.Drawing.Size(98, 20);
            this.checkBoxCMP1.TabIndex = 37;
            this.checkBoxCMP1.Text = "第1次补偿";
            this.checkBoxCMP1.UseVisualStyleBackColor = true;
            this.checkBoxCMP1.CheckedChanged += new System.EventHandler(this.checkBoxUV3P_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(820, 64);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 16);
            this.label27.TabIndex = 35;
            this.label27.Text = "mm";
            this.label27.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxExt);
            this.groupBox5.Controls.Add(this.tbExtFilePath);
            this.groupBox5.Controls.Add(this.btnOpenExt);
            this.groupBox5.Location = new System.Drawing.Point(12, 529);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(416, 64);
            this.groupBox5.TabIndex = 70;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "延伸加工";
            // 
            // checkBoxExt
            // 
            this.checkBoxExt.AutoSize = true;
            this.checkBoxExt.Location = new System.Drawing.Point(17, 25);
            this.checkBoxExt.Name = "checkBoxExt";
            this.checkBoxExt.Size = new System.Drawing.Size(90, 20);
            this.checkBoxExt.TabIndex = 71;
            this.checkBoxExt.Text = "延伸加工";
            this.checkBoxExt.UseVisualStyleBackColor = true;
            // 
            // tbExtFilePath
            // 
            this.tbExtFilePath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbExtFilePath.Location = new System.Drawing.Point(119, 23);
            this.tbExtFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbExtFilePath.Name = "tbExtFilePath";
            this.tbExtFilePath.ReadOnly = true;
            this.tbExtFilePath.Size = new System.Drawing.Size(169, 26);
            this.tbExtFilePath.TabIndex = 40;
            // 
            // btnOpenExt
            // 
            this.btnOpenExt.ForeColor = System.Drawing.Color.Brown;
            this.btnOpenExt.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.btnOpenExt.Location = new System.Drawing.Point(304, 20);
            this.btnOpenExt.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenExt.Name = "btnOpenExt";
            this.btnOpenExt.Size = new System.Drawing.Size(104, 33);
            this.btnOpenExt.TabIndex = 39;
            this.btnOpenExt.Text = "打开";
            this.btnOpenExt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenExt.UseVisualStyleBackColor = true;
            this.btnOpenExt.Click += new System.EventHandler(this.btnOpenExt_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label57);
            this.groupBox7.Controls.Add(this.label56);
            this.groupBox7.Controls.Add(this.numericUpDownNumPerRnd);
            this.groupBox7.Controls.Add(this.buttonCreatNCC);
            this.groupBox7.Controls.Add(this.radioButtonDXS);
            this.groupBox7.Controls.Add(this.cbBeCMode);
            this.groupBox7.Controls.Add(this.tbCFilePath);
            this.groupBox7.Controls.Add(this.btnOpenCFile);
            this.groupBox7.Location = new System.Drawing.Point(12, 599);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(416, 189);
            this.groupBox7.TabIndex = 71;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "C轴加工";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label57.Location = new System.Drawing.Point(304, 33);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(71, 16);
            this.label57.TabIndex = 75;
            this.label57.Text = "        ";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label56.Location = new System.Drawing.Point(110, 35);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(79, 16);
            this.label56.TabIndex = 74;
            this.label56.Text = "每圈细分:";
            // 
            // numericUpDownNumPerRnd
            // 
            this.numericUpDownNumPerRnd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownNumPerRnd.ForeColor = System.Drawing.Color.Maroon;
            this.numericUpDownNumPerRnd.Location = new System.Drawing.Point(196, 31);
            this.numericUpDownNumPerRnd.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownNumPerRnd.Maximum = new decimal(new int[] {
            360000,
            0,
            0,
            0});
            this.numericUpDownNumPerRnd.Name = "numericUpDownNumPerRnd";
            this.numericUpDownNumPerRnd.Size = new System.Drawing.Size(100, 26);
            this.numericUpDownNumPerRnd.TabIndex = 72;
            this.numericUpDownNumPerRnd.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // buttonCreatNCC
            // 
            this.buttonCreatNCC.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCreatNCC.ForeColor = System.Drawing.Color.Brown;
            this.buttonCreatNCC.Image = global::Nanosys1000Software.Properties.Resources.paly32;
            this.buttonCreatNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreatNCC.Location = new System.Drawing.Point(304, 120);
            this.buttonCreatNCC.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreatNCC.Name = "buttonCreatNCC";
            this.buttonCreatNCC.Size = new System.Drawing.Size(104, 38);
            this.buttonCreatNCC.TabIndex = 73;
            this.buttonCreatNCC.Text = "生成";
            this.buttonCreatNCC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCreatNCC.UseVisualStyleBackColor = true;
            this.buttonCreatNCC.Click += new System.EventHandler(this.buttonCreatNCC_Click);
            // 
            // radioButtonDXS
            // 
            this.radioButtonDXS.AutoSize = true;
            this.radioButtonDXS.Checked = true;
            this.radioButtonDXS.Location = new System.Drawing.Point(17, 72);
            this.radioButtonDXS.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonDXS.Name = "radioButtonDXS";
            this.radioButtonDXS.Size = new System.Drawing.Size(73, 20);
            this.radioButtonDXS.TabIndex = 72;
            this.radioButtonDXS.TabStop = true;
            this.radioButtonDXS.Text = "多项式";
            this.radioButtonDXS.UseVisualStyleBackColor = true;
            // 
            // cbBeCMode
            // 
            this.cbBeCMode.AutoSize = true;
            this.cbBeCMode.Location = new System.Drawing.Point(17, 33);
            this.cbBeCMode.Name = "cbBeCMode";
            this.cbBeCMode.Size = new System.Drawing.Size(82, 20);
            this.cbBeCMode.TabIndex = 71;
            this.cbBeCMode.Text = "C轴加工";
            this.cbBeCMode.UseVisualStyleBackColor = true;
            // 
            // tbCFilePath
            // 
            this.tbCFilePath.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbCFilePath.Location = new System.Drawing.Point(119, 70);
            this.tbCFilePath.Margin = new System.Windows.Forms.Padding(4);
            this.tbCFilePath.Name = "tbCFilePath";
            this.tbCFilePath.ReadOnly = true;
            this.tbCFilePath.Size = new System.Drawing.Size(169, 26);
            this.tbCFilePath.TabIndex = 40;
            // 
            // btnOpenCFile
            // 
            this.btnOpenCFile.ForeColor = System.Drawing.Color.Brown;
            this.btnOpenCFile.Image = global::Nanosys1000Software.Properties.Resources.open16;
            this.btnOpenCFile.Location = new System.Drawing.Point(304, 66);
            this.btnOpenCFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenCFile.Name = "btnOpenCFile";
            this.btnOpenCFile.Size = new System.Drawing.Size(104, 33);
            this.btnOpenCFile.TabIndex = 39;
            this.btnOpenCFile.Text = "打开";
            this.btnOpenCFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOpenCFile.UseVisualStyleBackColor = true;
            this.btnOpenCFile.Click += new System.EventHandler(this.btnOpenCFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1324, 821);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.programListButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.groupBox8);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nanosys-T300超精密机床CAM软件";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.R_numericUpDown7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerZ_numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.centerX_numericUpDown5)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_endx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daojuEndX_numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daojuStartX_numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_step)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDGrindingSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_feedrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_r)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partXcenterNumericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XcenterNumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumPerRnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem createNCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createNCToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.NumericUpDown numericUpDown_r;
        private System.Windows.Forms.NumericUpDown numericUpDown_endx;
        private System.Windows.Forms.NumericUpDown numericUpDown_startx;
        private System.Windows.Forms.NumericUpDown numericUpDown_step;
        private System.Windows.Forms.NumericUpDown numericUpDown_speed;
        private System.Windows.Forms.NumericUpDown numericUpDown_feedrate;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.ToolStripMenuItem programListToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel timeLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.NumericUpDown partXcenterNumericUpDown2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown XcenterNumericUpDown1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox errorFiletextBox1;
        private System.Windows.Forms.Button openErrorButton1;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox pvErrorCheckBox1;
        private System.Windows.Forms.CheckBox streightErrorCheckBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton circleRadioButton2;
        private System.Windows.Forms.RadioButton linearRadioButton1;
        private System.Windows.Forms.RadioButton tuRadioButton1;
        private System.Windows.Forms.RadioButton aoRadioButton3;
        private System.Windows.Forms.Button programListButton1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.NumericUpDown daojuEndX_numericUpDown3;
        private System.Windows.Forms.NumericUpDown daojuStartX_numericUpDown4;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 光学普适方程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 离散点ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button inputData_button;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button spline_button;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button circle_button2;
        private System.Windows.Forms.NumericUpDown R_numericUpDown7;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.NumericUpDown centerZ_numericUpDown6;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.NumericUpDown centerX_numericUpDown5;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button inputPhi_button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox textBoxCMPFilePath1;
        private System.Windows.Forms.Button buttonOpenCMPFile1;
        private System.Windows.Forms.CheckBox checkBoxCMP1;
        private System.Windows.Forms.RadioButton radioButtonBeTyler;
        private System.Windows.Forms.RadioButton radioButtonBeUV3P;
        private System.Windows.Forms.TextBox textBoxCMPFilePath5;
        private System.Windows.Forms.TextBox textBoxCMPFilePath4;
        private System.Windows.Forms.Button buttonOpenCMPFile5;
        private System.Windows.Forms.TextBox textBoxCMPFilePath3;
        private System.Windows.Forms.Button buttonOpenCMPFile4;
        private System.Windows.Forms.TextBox textBoxCMPFilePath2;
        private System.Windows.Forms.Button buttonOpenCMPFile3;
        private System.Windows.Forms.Button buttonOpenCMPFile2;
        private System.Windows.Forms.CheckBox checkBoxCMP5;
        private System.Windows.Forms.CheckBox checkBoxCMP4;
        private System.Windows.Forms.CheckBox checkBoxCMP3;
        private System.Windows.Forms.CheckBox checkBoxCMP2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox comboBoxG54;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox30;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.NumericUpDown nUDGrindingSpeed;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.CheckBox checkBoxExt;
        private System.Windows.Forms.TextBox tbExtFilePath;
        private System.Windows.Forms.Button btnOpenExt;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbBeCMode;
        private System.Windows.Forms.TextBox tbCFilePath;
        private System.Windows.Forms.Button btnOpenCFile;
        private System.Windows.Forms.RadioButton radioButtonDXS;
        private System.Windows.Forms.Button buttonCreatNCC;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.NumericUpDown numericUpDownNumPerRnd;
        private System.Windows.Forms.TextBox textBox40;
        private System.Windows.Forms.TextBox textBox38;
        private System.Windows.Forms.TextBox textBox36;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

