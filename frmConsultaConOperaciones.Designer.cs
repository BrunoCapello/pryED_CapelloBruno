namespace pryED_CapelloBruno
{
    partial class frmConsultaConOperaciones
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
            this.btnListar = new System.Windows.Forms.Button();
            this.lblOperaciones = new System.Windows.Forms.Label();
            this.cmbConsultasOperaciones = new System.Windows.Forms.ComboBox();
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblConsultaSQL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(657, 15);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(132, 25);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblOperaciones
            // 
            this.lblOperaciones.AutoSize = true;
            this.lblOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperaciones.Location = new System.Drawing.Point(9, 18);
            this.lblOperaciones.Name = "lblOperaciones";
            this.lblOperaciones.Size = new System.Drawing.Size(200, 18);
            this.lblOperaciones.TabIndex = 1;
            this.lblOperaciones.Text = "Operación a realizar en la db:";
            // 
            // cmbConsultasOperaciones
            // 
            this.cmbConsultasOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConsultasOperaciones.FormattingEnabled = true;
            this.cmbConsultasOperaciones.Location = new System.Drawing.Point(215, 14);
            this.cmbConsultasOperaciones.Name = "cmbConsultasOperaciones";
            this.cmbConsultasOperaciones.Size = new System.Drawing.Size(436, 26);
            this.cmbConsultasOperaciones.TabIndex = 2;
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(12, 173);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(777, 294);
            this.dgvMostrar.TabIndex = 4;
            // 
            // lblConsultaSQL
            // 
            this.lblConsultaSQL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblConsultaSQL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConsultaSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaSQL.Location = new System.Drawing.Point(12, 43);
            this.lblConsultaSQL.Name = "lblConsultaSQL";
            this.lblConsultaSQL.Size = new System.Drawing.Size(777, 127);
            this.lblConsultaSQL.TabIndex = 5;
            // 
            // frmConsultaConOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.lblConsultaSQL);
            this.Controls.Add(this.dgvMostrar);
            this.Controls.Add(this.cmbConsultasOperaciones);
            this.Controls.Add(this.lblOperaciones);
            this.Controls.Add(this.btnListar);
            this.Name = "frmConsultaConOperaciones";
            this.Text = "frmConsultaConOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblOperaciones;
        private System.Windows.Forms.ComboBox cmbConsultasOperaciones;
        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lblConsultaSQL;
    }
}