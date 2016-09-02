namespace View.ZealsManager
{
    partial class FrmZealsModify
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
            this.cboFemale = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpStartZeal = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentStartDate = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblCurrentFemale = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modificar celo:";
            // 
            // cboFemale
            // 
            this.cboFemale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFemale.FormattingEnabled = true;
            this.cboFemale.Location = new System.Drawing.Point(15, 57);
            this.cboFemale.Name = "cboFemale";
            this.cboFemale.Size = new System.Drawing.Size(111, 21);
            this.cboFemale.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hembra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha:";
            // 
            // dtpStartZeal
            // 
            this.dtpStartZeal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartZeal.Location = new System.Drawing.Point(15, 117);
            this.dtpStartZeal.Name = "dtpStartZeal";
            this.dtpStartZeal.Size = new System.Drawing.Size(111, 20);
            this.dtpStartZeal.TabIndex = 10;
            this.dtpStartZeal.ValueChanged += new System.EventHandler(this.dtpStartZeal_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(137, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valores actuales:";
            // 
            // lblCurrentStartDate
            // 
            this.lblCurrentStartDate.AutoSize = true;
            this.lblCurrentStartDate.Location = new System.Drawing.Point(137, 123);
            this.lblCurrentStartDate.Name = "lblCurrentStartDate";
            this.lblCurrentStartDate.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentStartDate.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(69, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnModify.Location = new System.Drawing.Point(155, 171);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 23);
            this.btnModify.TabIndex = 11;
            this.btnModify.Text = "Aceptar";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblCurrentFemale
            // 
            this.lblCurrentFemale.AutoSize = true;
            this.lblCurrentFemale.Location = new System.Drawing.Point(137, 60);
            this.lblCurrentFemale.Name = "lblCurrentFemale";
            this.lblCurrentFemale.Size = new System.Drawing.Size(0, 13);
            this.lblCurrentFemale.TabIndex = 9;
            // 
            // FrmZealsModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 206);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dtpStartZeal);
            this.Controls.Add(this.lblCurrentFemale);
            this.Controls.Add(this.lblCurrentStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboFemale);
            this.Controls.Add(this.label1);
            this.Name = "FrmZealsModify";
            this.Text = "Modificar Celo";
            this.Load += new System.EventHandler(this.FrmZealsModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cboFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpStartZeal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentStartDate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lblCurrentFemale;
    }
}