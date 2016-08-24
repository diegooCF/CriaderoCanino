namespace View.ServicesManager
{
    partial class FrmServicesModify
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDateMaxBirth = new System.Windows.Forms.Label();
            this.lblMinDateBirth = new System.Windows.Forms.Label();
            this.lblMale = new System.Windows.Forms.Label();
            this.lblZeal = new System.Windows.Forms.Label();
            this.lblFemale = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboFemale
            // 
            this.cboFemale.Items.AddRange(new object[] {
            "Génesis",
            "Génesis"});
            // 
            // cboMale
            // 
            this.cboMale.Items.AddRange(new object[] {
            "Enano",
            "Enano"});
            // 
            // lblDateMaxBirth
            // 
            this.lblDateMaxBirth.AutoSize = true;
            this.lblDateMaxBirth.Location = new System.Drawing.Point(11, 245);
            this.lblDateMaxBirth.Name = "lblDateMaxBirth";
            this.lblDateMaxBirth.Size = new System.Drawing.Size(0, 13);
            this.lblDateMaxBirth.TabIndex = 22;
            // 
            // lblMinDateBirth
            // 
            this.lblMinDateBirth.AutoSize = true;
            this.lblMinDateBirth.Location = new System.Drawing.Point(11, 192);
            this.lblMinDateBirth.Name = "lblMinDateBirth";
            this.lblMinDateBirth.Size = new System.Drawing.Size(0, 13);
            this.lblMinDateBirth.TabIndex = 23;
            // 
            // lblMale
            // 
            this.lblMale.AutoSize = true;
            this.lblMale.Location = new System.Drawing.Point(11, 133);
            this.lblMale.Name = "lblMale";
            this.lblMale.Size = new System.Drawing.Size(0, 13);
            this.lblMale.TabIndex = 24;
            // 
            // lblZeal
            // 
            this.lblZeal.AutoSize = true;
            this.lblZeal.Location = new System.Drawing.Point(11, 85);
            this.lblZeal.Name = "lblZeal";
            this.lblZeal.Size = new System.Drawing.Size(0, 13);
            this.lblZeal.TabIndex = 25;
            // 
            // lblFemale
            // 
            this.lblFemale.AutoSize = true;
            this.lblFemale.Location = new System.Drawing.Point(11, 33);
            this.lblFemale.Name = "lblFemale";
            this.lblFemale.Size = new System.Drawing.Size(0, 13);
            this.lblFemale.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFemale);
            this.groupBox1.Controls.Add(this.lblDateMaxBirth);
            this.groupBox1.Controls.Add(this.lblZeal);
            this.groupBox1.Controls.Add(this.lblMinDateBirth);
            this.groupBox1.Controls.Add(this.lblMale);
            this.groupBox1.Location = new System.Drawing.Point(215, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 305);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores actuales:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Modificar un servicio existente:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(127, 316);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(80, 23);
            this.btnAccept.TabIndex = 29;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // FrmServicesModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(405, 352);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmServicesModify";
            this.Text = "Modificar Servicio";
            this.Controls.SetChildIndex(this.cboFemale, 0);
            this.Controls.SetChildIndex(this.cboZeal, 0);
            this.Controls.SetChildIndex(this.cboMale, 0);
            this.Controls.SetChildIndex(this.dtpMinBirth, 0);
            this.Controls.SetChildIndex(this.dtpMaxBirth, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.btnAccept, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateMaxBirth;
        private System.Windows.Forms.Label lblMinDateBirth;
        private System.Windows.Forms.Label lblMale;
        private System.Windows.Forms.Label lblZeal;
        private System.Windows.Forms.Label lblFemale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAccept;
    }
}
