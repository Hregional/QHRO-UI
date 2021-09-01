﻿
namespace UI
{
    partial class Doctors
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonNew = new FontAwesome.Sharp.IconButton();
            this.buttonSave = new FontAwesome.Sharp.IconButton();
            this.buttonUpdate = new FontAwesome.Sharp.IconButton();
            this.buttonList = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelID = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCui = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSecondLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textFirstLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textThirdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textSecondName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 498);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1527, 447);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonNew
            // 
            this.buttonNew.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonNew.IconColor = System.Drawing.Color.Black;
            this.buttonNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonNew.Location = new System.Drawing.Point(320, 364);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(180, 87);
            this.buttonNew.TabIndex = 17;
            this.buttonNew.Text = "Nuevo";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonSave.IconColor = System.Drawing.Color.Black;
            this.buttonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSave.Location = new System.Drawing.Point(571, 364);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(180, 87);
            this.buttonSave.TabIndex = 16;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonUpdate.IconColor = System.Drawing.Color.Black;
            this.buttonUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUpdate.Location = new System.Drawing.Point(840, 364);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(180, 87);
            this.buttonUpdate.TabIndex = 15;
            this.buttonUpdate.Text = "Editar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonList
            // 
            this.buttonList.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonList.IconColor = System.Drawing.Color.Black;
            this.buttonList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonList.Location = new System.Drawing.Point(1120, 364);
            this.buttonList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(180, 87);
            this.buttonList.TabIndex = 14;
            this.buttonList.Text = "Listar";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelID);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textCui);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textSecondLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textFirstLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textThirdName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textSecondName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textFirstName);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(37, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1445, 261);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 238);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(54, 17);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "label10";
            this.labelID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboStatus);
            this.groupBox2.Location = new System.Drawing.Point(1159, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 123);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            this.groupBox2.Visible = false;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "",
            "Activo",
            "Inactivo"});
            this.comboStatus.Location = new System.Drawing.Point(31, 55);
            this.comboStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(208, 24);
            this.comboStatus.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(483, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Cui";
            // 
            // textCui
            // 
            this.textCui.Location = new System.Drawing.Point(487, 119);
            this.textCui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textCui.Name = "textCui";
            this.textCui.Size = new System.Drawing.Size(211, 22);
            this.textCui.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefono";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(251, 119);
            this.textPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(211, 22);
            this.textPhone.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 100);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correo";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(12, 119);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(211, 22);
            this.textEmail.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(947, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Segundo Apellido";
            // 
            // textSecondLastName
            // 
            this.textSecondLastName.Location = new System.Drawing.Point(951, 57);
            this.textSecondLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSecondLastName.Name = "textSecondLastName";
            this.textSecondLastName.Size = new System.Drawing.Size(211, 22);
            this.textSecondLastName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Primer Apellido";
            // 
            // textFirstLastName
            // 
            this.textFirstLastName.Location = new System.Drawing.Point(719, 57);
            this.textFirstLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFirstLastName.Name = "textFirstLastName";
            this.textFirstLastName.Size = new System.Drawing.Size(211, 22);
            this.textFirstLastName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tercer Nombre";
            // 
            // textThirdName
            // 
            this.textThirdName.Location = new System.Drawing.Point(487, 57);
            this.textThirdName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textThirdName.Name = "textThirdName";
            this.textThirdName.Size = new System.Drawing.Size(211, 22);
            this.textThirdName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo Nombre";
            // 
            // textSecondName
            // 
            this.textSecondName.Location = new System.Drawing.Point(251, 57);
            this.textSecondName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSecondName.Name = "textSecondName";
            this.textSecondName.Size = new System.Drawing.Size(211, 22);
            this.textSecondName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primer Nombre";
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(12, 57);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(211, 22);
            this.textFirstName.TabIndex = 0;
            // 
            // Doctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 996);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Doctors";
            this.Text = "Doctors";
            this.Load += new System.EventHandler(this.Doctors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton buttonNew;
        private FontAwesome.Sharp.IconButton buttonSave;
        private FontAwesome.Sharp.IconButton buttonUpdate;
        private FontAwesome.Sharp.IconButton buttonList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textCui;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSecondLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textFirstLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textThirdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textSecondName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFirstName;
    }
}