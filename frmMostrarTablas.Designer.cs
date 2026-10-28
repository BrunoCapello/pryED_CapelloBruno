namespace pryED_CapelloBruno
{
    partial class frmConsultasSQL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbConsultas = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbConsultas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultas SQL";
            // 
            // lbConsultas
            // 
            this.lbConsultas.FormattingEnabled = true;
            this.lbConsultas.ItemHeight = 16;
            this.lbConsultas.Location = new System.Drawing.Point(6, 21);
            this.lbConsultas.Name = "lbConsultas";
            this.lbConsultas.Size = new System.Drawing.Size(764, 148);
            this.lbConsultas.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(268, 202);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(231, 27);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Location = new System.Drawing.Point(12, 236);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.RowHeadersWidth = 51;
            this.dgvConsultas.RowTemplate.Height = 24;
            this.dgvConsultas.Size = new System.Drawing.Size(776, 233);
            this.dgvConsultas.TabIndex = 2;
            // 
            // frmConsultasSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.dgvConsultas);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmConsultasSQL";
            this.Text = "Base de Datos: Consultas SQL";
            this.Load += new System.EventHandler(this.frmConsultasSQL_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.ListBox lbConsultas;
    }
}