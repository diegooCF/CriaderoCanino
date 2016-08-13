namespace View.CUD
{
    partial class FrmCreateDog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.txtFormalName = new System.Windows.Forms.TextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cboSpecie = new System.Windows.Forms.ComboBox();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chkBirthDate = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre / Alias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Formal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Especie:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Género:";
            // 
            // txtRealName
            // 
            this.txtRealName.Location = new System.Drawing.Point(89, 10);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(147, 20);
            this.txtRealName.TabIndex = 0;
            // 
            // txtFormalName
            // 
            this.txtFormalName.Location = new System.Drawing.Point(89, 36);
            this.txtFormalName.Name = "txtFormalName";
            this.txtFormalName.Size = new System.Drawing.Size(147, 20);
            this.txtFormalName.TabIndex = 1;
            this.txtFormalName.Tag = "";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Enabled = false;
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(120, 94);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(116, 20);
            this.dtpBirthDate.TabIndex = 2;
            // 
            // cboSpecie
            // 
            this.cboSpecie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpecie.FormattingEnabled = true;
            this.cboSpecie.Location = new System.Drawing.Point(89, 26);
            this.cboSpecie.Name = "cboSpecie";
            this.cboSpecie.Size = new System.Drawing.Size(147, 21);
            this.cboSpecie.TabIndex = 0;
            this.cboSpecie.SelectedIndexChanged += new System.EventHandler(this.cboSpecie_SelectedIndexChanged);
            // 
            // cboColor
            // 
            this.cboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(89, 53);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(147, 21);
            this.cboColor.TabIndex = 1;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.cboGender.Location = new System.Drawing.Point(89, 80);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(147, 21);
            this.cboGender.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboGender);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboColor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboSpecie);
            this.groupBox1.Location = new System.Drawing.Point(15, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 124);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caracteristicas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkBirthDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpBirthDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFormalName);
            this.panel1.Controls.Add(this.txtRealName);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 143);
            this.panel1.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(189, 291);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "&Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(108, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chkBirthDate
            // 
            this.chkBirthDate.AutoSize = true;
            this.chkBirthDate.Location = new System.Drawing.Point(6, 71);
            this.chkBirthDate.Name = "chkBirthDate";
            this.chkBirthDate.Size = new System.Drawing.Size(162, 17);
            this.chkBirthDate.TabIndex = 3;
            this.chkBirthDate.Text = "Agregar fecha de nacimiento";
            this.chkBirthDate.UseVisualStyleBackColor = true;
            this.chkBirthDate.CheckedChanged += new System.EventHandler(this.chkBirthDate_CheckedChanged);
            // 
            // FrmCreateDog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 327);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCreateDog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registrar nuevo canino";
            this.Load += new System.EventHandler(this.FrmCreateDog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.TextBox txtFormalName;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cboSpecie;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox chkBirthDate;
    }
}