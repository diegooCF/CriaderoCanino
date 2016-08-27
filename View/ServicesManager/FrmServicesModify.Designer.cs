namespace View.ServicesManager
{
    partial class FrmServicesModify
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.cboMale = new System.Windows.Forms.ComboBox();
            this.cboZeal = new System.Windows.Forms.ComboBox();
            this.cboFemale = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentFemale = new System.Windows.Forms.Label();
            this.lblCurrentMale = new System.Windows.Forms.Label();
            this.lblCurrentZeal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 205);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModify.Location = new System.Drawing.Point(129, 205);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 23);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Aceptar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // cboMale
            // 
            this.cboMale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMale.FormattingEnabled = true;
            this.cboMale.Items.AddRange(new object[] {
            "Seleccione macho"});
            this.cboMale.Location = new System.Drawing.Point(15, 164);
            this.cboMale.Name = "cboMale";
            this.cboMale.Size = new System.Drawing.Size(194, 21);
            this.cboMale.TabIndex = 11;
            // 
            // cboZeal
            // 
            this.cboZeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZeal.FormattingEnabled = true;
            this.cboZeal.Location = new System.Drawing.Point(15, 116);
            this.cboZeal.Name = "cboZeal";
            this.cboZeal.Size = new System.Drawing.Size(194, 21);
            this.cboZeal.TabIndex = 9;
            // 
            // cboFemale
            // 
            this.cboFemale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFemale.FormattingEnabled = true;
            this.cboFemale.Location = new System.Drawing.Point(15, 64);
            this.cboFemale.Name = "cboFemale";
            this.cboFemale.Size = new System.Drawing.Size(194, 21);
            this.cboFemale.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Celo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hembra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Macho:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Modificar un servicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valores actuales:";
            // 
            // lblCurrentFemale
            // 
            this.lblCurrentFemale.AutoSize = true;
            this.lblCurrentFemale.Location = new System.Drawing.Point(234, 67);
            this.lblCurrentFemale.Name = "lblCurrentFemale";
            this.lblCurrentFemale.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentFemale.TabIndex = 16;
            // 
            // lblCurrentMale
            // 
            this.lblCurrentMale.AutoSize = true;
            this.lblCurrentMale.Location = new System.Drawing.Point(234, 167);
            this.lblCurrentMale.Name = "lblCurrentMale";
            this.lblCurrentMale.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentMale.TabIndex = 16;
            // 
            // lblCurrentZeal
            // 
            this.lblCurrentZeal.AutoSize = true;
            this.lblCurrentZeal.Location = new System.Drawing.Point(234, 119);
            this.lblCurrentZeal.Name = "lblCurrentZeal";
            this.lblCurrentZeal.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentZeal.TabIndex = 16;
            // 
            // FrmServicesModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 242);
            this.Controls.Add(this.lblCurrentZeal);
            this.Controls.Add(this.lblCurrentMale);
            this.Controls.Add(this.lblCurrentFemale);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.cboMale);
            this.Controls.Add(this.cboZeal);
            this.Controls.Add(this.cboFemale);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmServicesModify";
            this.Text = "Modificar un servicio";
            this.Load += new System.EventHandler(this.FrmServicesModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModify;
        protected System.Windows.Forms.ComboBox cboMale;
        protected System.Windows.Forms.ComboBox cboZeal;
        protected System.Windows.Forms.ComboBox cboFemale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentFemale;
        private System.Windows.Forms.Label lblCurrentMale;
        private System.Windows.Forms.Label lblCurrentZeal;
    }
}