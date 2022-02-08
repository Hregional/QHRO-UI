﻿
namespace UI
{
    partial class RequestSurgery
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iconButtonSearchNames = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxpatientData = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelsecondSurname = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.labelhistoryNumber = new System.Windows.Forms.Label();
            this.textBoxhistoryNumber = new System.Windows.Forms.TextBox();
            this.textBoxsecondSurname = new System.Windows.Forms.TextBox();
            this.textBoxfirstName = new System.Windows.Forms.TextBox();
            this.textBoxsecondName = new System.Windows.Forms.TextBox();
            this.textBoxfirstSurname = new System.Windows.Forms.TextBox();
            this.labelsecondName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.labelfirstName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.labelfirstSurname = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProcedure = new System.Windows.Forms.TextBox();
            this.iconButtonRequest = new FontAwesome.Sharp.IconButton();
            this.iconButtonCreateAndRequest = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxDocsData = new System.Windows.Forms.GroupBox();
            this.listViewDoctors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.iconButtonAddDoctor = new FontAwesome.Sharp.IconButton();
            this.iconButtonDeleteDoctor = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBoxpatientData.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBoxDocsData.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.27596F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.72404F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 303F));
            this.tableLayoutPanel1.Controls.Add(this.iconButtonSearchNames, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.iconPictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSearch, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(305, 212);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1109, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // iconButtonSearchNames
            // 
            this.iconButtonSearchNames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonSearchNames.BackColor = System.Drawing.Color.White;
            this.iconButtonSearchNames.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonSearchNames.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonSearchNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSearchNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSearchNames.ForeColor = System.Drawing.Color.Black;
            this.iconButtonSearchNames.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButtonSearchNames.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonSearchNames.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSearchNames.IconSize = 30;
            this.iconButtonSearchNames.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSearchNames.Location = new System.Drawing.Point(808, 2);
            this.iconButtonSearchNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonSearchNames.Name = "iconButtonSearchNames";
            this.iconButtonSearchNames.Size = new System.Drawing.Size(298, 39);
            this.iconButtonSearchNames.TabIndex = 30;
            this.iconButtonSearchNames.Text = "Buscar";
            this.iconButtonSearchNames.UseVisualStyleBackColor = false;
            this.iconButtonSearchNames.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 36;
            this.iconPictureBox1.Location = new System.Drawing.Point(44, 4);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 36);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(93, 7);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(697, 30);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.Text = "Buscar paciente por No. Historia";
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            this.textBoxSearch.Enter += new System.EventHandler(this.textBoxSearch_Enter);
            this.textBoxSearch.Leave += new System.EventHandler(this.textBoxSearch_Leave);
            // 
            // groupBoxpatientData
            // 
            this.groupBoxpatientData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxpatientData.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxpatientData.Enabled = false;
            this.groupBoxpatientData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxpatientData.Location = new System.Drawing.Point(15, 294);
            this.groupBoxpatientData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxpatientData.Name = "groupBoxpatientData";
            this.groupBoxpatientData.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxpatientData.Size = new System.Drawing.Size(1459, 278);
            this.groupBoxpatientData.TabIndex = 24;
            this.groupBoxpatientData.TabStop = false;
            this.groupBoxpatientData.Text = "Datos del paciente";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.18349F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.75841F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.09756F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.17073F));
            this.tableLayoutPanel3.Controls.Add(this.labelsecondSurname, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelAge, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxAge, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxhistoryNumber, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxsecondSurname, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBoxfirstName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxsecondName, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.textBoxfirstSurname, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelsecondName, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.labelGender, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxGender, 3, 2);
            this.tableLayoutPanel3.Controls.Add(this.labelID, 2, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(47, 30);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1367, 238);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelsecondSurname
            // 
            this.labelsecondSurname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelsecondSurname.AutoSize = true;
            this.labelsecondSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsecondSurname.Location = new System.Drawing.Point(692, 11);
            this.labelsecondSurname.Name = "labelsecondSurname";
            this.labelsecondSurname.Size = new System.Drawing.Size(164, 25);
            this.labelsecondSurname.TabIndex = 5;
            this.labelsecondSurname.Text = "Segundo apellido";
            // 
            // labelAge
            // 
            this.labelAge.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAge.Location = new System.Drawing.Point(798, 58);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(58, 25);
            this.labelAge.TabIndex = 16;
            this.labelAge.Text = "Edad";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(862, 55);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.MaxLength = 3;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(502, 30);
            this.textBoxAge.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.labelhistoryNumber);
            this.panel1.Location = new System.Drawing.Point(67, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 39);
            this.panel1.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(68, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(18, 24);
            this.label22.TabIndex = 23;
            this.label22.Text = "*";
            // 
            // labelhistoryNumber
            // 
            this.labelhistoryNumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelhistoryNumber.AutoSize = true;
            this.labelhistoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhistoryNumber.Location = new System.Drawing.Point(87, 7);
            this.labelhistoryNumber.Name = "labelhistoryNumber";
            this.labelhistoryNumber.Size = new System.Drawing.Size(104, 25);
            this.labelhistoryNumber.TabIndex = 10;
            this.labelhistoryNumber.Text = "No historia";
            // 
            // textBoxhistoryNumber
            // 
            this.textBoxhistoryNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxhistoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxhistoryNumber.Location = new System.Drawing.Point(278, 8);
            this.textBoxhistoryNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxhistoryNumber.MaxLength = 20;
            this.textBoxhistoryNumber.Name = "textBoxhistoryNumber";
            this.textBoxhistoryNumber.Size = new System.Drawing.Size(359, 30);
            this.textBoxhistoryNumber.TabIndex = 0;
            // 
            // textBoxsecondSurname
            // 
            this.textBoxsecondSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsecondSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsecondSurname.Location = new System.Drawing.Point(862, 8);
            this.textBoxsecondSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxsecondSurname.MaxLength = 20;
            this.textBoxsecondSurname.Name = "textBoxsecondSurname";
            this.textBoxsecondSurname.Size = new System.Drawing.Size(502, 30);
            this.textBoxsecondSurname.TabIndex = 5;
            // 
            // textBoxfirstName
            // 
            this.textBoxfirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfirstName.Location = new System.Drawing.Point(278, 55);
            this.textBoxfirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxfirstName.MaxLength = 20;
            this.textBoxfirstName.Name = "textBoxfirstName";
            this.textBoxfirstName.Size = new System.Drawing.Size(359, 30);
            this.textBoxfirstName.TabIndex = 1;
            // 
            // textBoxsecondName
            // 
            this.textBoxsecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxsecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxsecondName.Location = new System.Drawing.Point(278, 102);
            this.textBoxsecondName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxsecondName.MaxLength = 20;
            this.textBoxsecondName.Name = "textBoxsecondName";
            this.textBoxsecondName.Size = new System.Drawing.Size(359, 30);
            this.textBoxsecondName.TabIndex = 2;
            // 
            // textBoxfirstSurname
            // 
            this.textBoxfirstSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxfirstSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxfirstSurname.Location = new System.Drawing.Point(278, 198);
            this.textBoxfirstSurname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxfirstSurname.MaxLength = 20;
            this.textBoxfirstSurname.Name = "textBoxfirstSurname";
            this.textBoxfirstSurname.Size = new System.Drawing.Size(359, 30);
            this.textBoxfirstSurname.TabIndex = 4;
            // 
            // labelsecondName
            // 
            this.labelsecondName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelsecondName.AutoSize = true;
            this.labelsecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsecondName.Location = new System.Drawing.Point(109, 105);
            this.labelsecondName.Name = "labelsecondName";
            this.labelsecondName.Size = new System.Drawing.Size(163, 25);
            this.labelsecondName.TabIndex = 2;
            this.labelsecondName.Text = "Segundo nombre";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.labelfirstName);
            this.panel2.Location = new System.Drawing.Point(67, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 39);
            this.panel2.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(32, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "*";
            // 
            // labelfirstName
            // 
            this.labelfirstName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelfirstName.AutoSize = true;
            this.labelfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstName.Location = new System.Drawing.Point(51, 9);
            this.labelfirstName.Name = "labelfirstName";
            this.labelfirstName.Size = new System.Drawing.Size(139, 25);
            this.labelfirstName.TabIndex = 1;
            this.labelfirstName.Text = "Primer nombre";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.labelfirstSurname);
            this.panel3.Location = new System.Drawing.Point(101, 193);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 39);
            this.panel3.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(5, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "*";
            // 
            // labelfirstSurname
            // 
            this.labelfirstSurname.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelfirstSurname.AutoSize = true;
            this.labelfirstSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfirstSurname.Location = new System.Drawing.Point(20, 7);
            this.labelfirstSurname.Name = "labelfirstSurname";
            this.labelfirstSurname.Size = new System.Drawing.Size(140, 25);
            this.labelfirstSurname.TabIndex = 4;
            this.labelfirstSurname.Text = "Primer apellido";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(779, 105);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(77, 25);
            this.labelGender.TabIndex = 8;
            this.labelGender.Text = "Género";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxGender.Location = new System.Drawing.Point(862, 101);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(502, 33);
            this.comboBoxGender.TabIndex = 11;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(643, 188);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(213, 25);
            this.labelID.TabIndex = 18;
            this.labelID.Text = "label10";
            this.labelID.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5618F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.4382F));
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDiagnosis, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(21, 23);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(814, 75);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Location = new System.Drawing.Point(3, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 39);
            this.panel4.TabIndex = 29;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(14, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 24);
            this.label21.TabIndex = 23;
            this.label21.Text = "*";
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(38, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(114, 25);
            this.label24.TabIndex = 10;
            this.label24.Text = "Diagnostico";
            // 
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDiagnosis.Enabled = false;
            this.textBoxDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiagnosis.Location = new System.Drawing.Point(251, 2);
            this.textBoxDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDiagnosis.MaxLength = 150;
            this.textBoxDiagnosis.Multiline = true;
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(560, 71);
            this.textBoxDiagnosis.TabIndex = 7;
            this.textBoxDiagnosis.TextChanged += new System.EventHandler(this.textBoxDiagnosis_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel6);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(843, 225);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.5618F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.4382F));
            this.tableLayoutPanel6.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxProcedure, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(21, 116);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(814, 75);
            this.tableLayoutPanel6.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 39);
            this.panel5.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Procedimiento";
            // 
            // textBoxProcedure
            // 
            this.textBoxProcedure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProcedure.Enabled = false;
            this.textBoxProcedure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProcedure.Location = new System.Drawing.Point(251, 2);
            this.textBoxProcedure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProcedure.MaxLength = 150;
            this.textBoxProcedure.Multiline = true;
            this.textBoxProcedure.Name = "textBoxProcedure";
            this.textBoxProcedure.Size = new System.Drawing.Size(560, 71);
            this.textBoxProcedure.TabIndex = 7;
            // 
            // iconButtonRequest
            // 
            this.iconButtonRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonRequest.BackColor = System.Drawing.Color.White;
            this.iconButtonRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonRequest.Enabled = false;
            this.iconButtonRequest.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonRequest.ForeColor = System.Drawing.Color.Black;
            this.iconButtonRequest.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonRequest.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonRequest.IconSize = 30;
            this.iconButtonRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonRequest.Location = new System.Drawing.Point(1479, 519);
            this.iconButtonRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonRequest.Name = "iconButtonRequest";
            this.iconButtonRequest.Size = new System.Drawing.Size(221, 49);
            this.iconButtonRequest.TabIndex = 28;
            this.iconButtonRequest.Text = "Solicitar cirugía";
            this.iconButtonRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonRequest.UseVisualStyleBackColor = false;
            this.iconButtonRequest.Visible = false;
            this.iconButtonRequest.Click += new System.EventHandler(this.iconButtonRequest_Click);
            // 
            // iconButtonCreateAndRequest
            // 
            this.iconButtonCreateAndRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButtonCreateAndRequest.BackColor = System.Drawing.Color.White;
            this.iconButtonCreateAndRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButtonCreateAndRequest.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonCreateAndRequest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonCreateAndRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonCreateAndRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonCreateAndRequest.ForeColor = System.Drawing.Color.Black;
            this.iconButtonCreateAndRequest.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonCreateAndRequest.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonCreateAndRequest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonCreateAndRequest.IconSize = 30;
            this.iconButtonCreateAndRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonCreateAndRequest.Location = new System.Drawing.Point(1492, 203);
            this.iconButtonCreateAndRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonCreateAndRequest.Name = "iconButtonCreateAndRequest";
            this.iconButtonCreateAndRequest.Size = new System.Drawing.Size(221, 49);
            this.iconButtonCreateAndRequest.TabIndex = 27;
            this.iconButtonCreateAndRequest.Text = "Crear y solicitar";
            this.iconButtonCreateAndRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonCreateAndRequest.UseVisualStyleBackColor = false;
            this.iconButtonCreateAndRequest.Visible = false;
            this.iconButtonCreateAndRequest.Click += new System.EventHandler(this.iconButtonCreateAndRequest_Click);
            // 
            // groupBoxDocsData
            // 
            this.groupBoxDocsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDocsData.Controls.Add(this.listViewDoctors);
            this.groupBoxDocsData.Controls.Add(this.iconButtonAddDoctor);
            this.groupBoxDocsData.Controls.Add(this.iconButtonDeleteDoctor);
            this.groupBoxDocsData.Enabled = false;
            this.groupBoxDocsData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDocsData.Location = new System.Drawing.Point(4, 4);
            this.groupBoxDocsData.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDocsData.Name = "groupBoxDocsData";
            this.groupBoxDocsData.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDocsData.Size = new System.Drawing.Size(589, 216);
            this.groupBoxDocsData.TabIndex = 39;
            this.groupBoxDocsData.TabStop = false;
            this.groupBoxDocsData.Text = "Doctores asignados";
            // 
            // listViewDoctors
            // 
            this.listViewDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewDoctors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewDoctors.HideSelection = false;
            this.listViewDoctors.Location = new System.Drawing.Point(9, 31);
            this.listViewDoctors.Margin = new System.Windows.Forms.Padding(4);
            this.listViewDoctors.MultiSelect = false;
            this.listViewDoctors.Name = "listViewDoctors";
            this.listViewDoctors.Size = new System.Drawing.Size(569, 114);
            this.listViewDoctors.TabIndex = 35;
            this.listViewDoctors.UseCompatibleStateImageBehavior = false;
            this.listViewDoctors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 200;
            // 
            // iconButtonAddDoctor
            // 
            this.iconButtonAddDoctor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButtonAddDoctor.BackColor = System.Drawing.Color.White;
            this.iconButtonAddDoctor.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonAddDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonAddDoctor.ForeColor = System.Drawing.Color.Black;
            this.iconButtonAddDoctor.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.iconButtonAddDoctor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonAddDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonAddDoctor.IconSize = 30;
            this.iconButtonAddDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonAddDoctor.Location = new System.Drawing.Point(403, 152);
            this.iconButtonAddDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonAddDoctor.Name = "iconButtonAddDoctor";
            this.iconButtonAddDoctor.Size = new System.Drawing.Size(177, 47);
            this.iconButtonAddDoctor.TabIndex = 28;
            this.iconButtonAddDoctor.Text = "Seleccionar";
            this.iconButtonAddDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonAddDoctor.UseVisualStyleBackColor = false;
            this.iconButtonAddDoctor.Click += new System.EventHandler(this.iconButtonAddDoctor_Click);
            // 
            // iconButtonDeleteDoctor
            // 
            this.iconButtonDeleteDoctor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconButtonDeleteDoctor.BackColor = System.Drawing.Color.White;
            this.iconButtonDeleteDoctor.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.iconButtonDeleteDoctor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(173)))), ((int)(((byte)(221)))));
            this.iconButtonDeleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonDeleteDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonDeleteDoctor.ForeColor = System.Drawing.Color.Black;
            this.iconButtonDeleteDoctor.IconChar = FontAwesome.Sharp.IconChar.MinusCircle;
            this.iconButtonDeleteDoctor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(120)))));
            this.iconButtonDeleteDoctor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonDeleteDoctor.IconSize = 30;
            this.iconButtonDeleteDoctor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonDeleteDoctor.Location = new System.Drawing.Point(239, 153);
            this.iconButtonDeleteDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButtonDeleteDoctor.Name = "iconButtonDeleteDoctor";
            this.iconButtonDeleteDoctor.Size = new System.Drawing.Size(159, 47);
            this.iconButtonDeleteDoctor.TabIndex = 34;
            this.iconButtonDeleteDoctor.Text = "Eliminar";
            this.iconButtonDeleteDoctor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonDeleteDoctor.UseVisualStyleBackColor = false;
            this.iconButtonDeleteDoctor.Click += new System.EventHandler(this.iconButtonDeleteDoctor_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.groupBoxDocsData, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(855, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(597, 224);
            this.tableLayoutPanel4.TabIndex = 30;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.46295F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.53705F));
            this.tableLayoutPanel5.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(16, 578);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1457, 233);
            this.tableLayoutPanel5.TabIndex = 31;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(947, 857);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(105, 116);
            this.listBox1.TabIndex = 32;
            this.listBox1.Visible = false;
            // 
            // RequestSurgery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1715, 1100);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.iconButtonRequest);
            this.Controls.Add(this.iconButtonCreateAndRequest);
            this.Controls.Add(this.groupBoxpatientData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequestSurgery";
            this.Text = "RequestSurgery";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBoxpatientData.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBoxDocsData.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxpatientData;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelsecondSurname;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelhistoryNumber;
        private System.Windows.Forms.TextBox textBoxhistoryNumber;
        private System.Windows.Forms.TextBox textBoxsecondSurname;
        private System.Windows.Forms.TextBox textBoxfirstName;
        private System.Windows.Forms.TextBox textBoxsecondName;
        private System.Windows.Forms.TextBox textBoxfirstSurname;
        private System.Windows.Forms.Label labelsecondName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelfirstName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelfirstSurname;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label labelID;
        private FontAwesome.Sharp.IconButton iconButtonRequest;
        private FontAwesome.Sharp.IconButton iconButtonCreateAndRequest;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton iconButtonSearchNames;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBoxDocsData;
        private System.Windows.Forms.ListView listViewDoctors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private FontAwesome.Sharp.IconButton iconButtonAddDoctor;
        private FontAwesome.Sharp.IconButton iconButtonDeleteDoctor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProcedure;
    }
}