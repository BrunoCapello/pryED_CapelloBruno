namespace pryED_CapelloBruno
{
    partial class frmOperaciones
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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.gpProyeccion = new System.Windows.Forms.GroupBox();
            this.btnProyeccionSimple = new System.Windows.Forms.Button();
            this.btnProyeccionMultiatributo = new System.Windows.Forms.Button();
            this.btnJuntar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionConvolucion = new System.Windows.Forms.Button();
            this.btnSelecciónMultiatributo = new System.Windows.Forms.Button();
            this.btnSelecciónSimple = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDiferencia = new System.Windows.Forms.Button();
            this.btnInterseccion = new System.Windows.Forms.Button();
            this.btnUnion = new System.Windows.Forms.Button();
            this.lblBotonSeleccionado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.gpProyeccion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(12, 12);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.RowHeadersWidth = 51;
            this.dgvMostrar.RowTemplate.Height = 24;
            this.dgvMostrar.Size = new System.Drawing.Size(835, 307);
            this.dgvMostrar.TabIndex = 0;
            // 
            // gpProyeccion
            // 
            this.gpProyeccion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpProyeccion.Controls.Add(this.btnJuntar);
            this.gpProyeccion.Controls.Add(this.btnProyeccionMultiatributo);
            this.gpProyeccion.Controls.Add(this.btnProyeccionSimple);
            this.gpProyeccion.Location = new System.Drawing.Point(12, 361);
            this.gpProyeccion.Name = "gpProyeccion";
            this.gpProyeccion.Size = new System.Drawing.Size(257, 148);
            this.gpProyeccion.TabIndex = 1;
            this.gpProyeccion.TabStop = false;
            this.gpProyeccion.Text = "Operacion de Proyección - SELECT";
            // 
            // btnProyeccionSimple
            // 
            this.btnProyeccionSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccionSimple.Location = new System.Drawing.Point(17, 32);
            this.btnProyeccionSimple.Name = "btnProyeccionSimple";
            this.btnProyeccionSimple.Size = new System.Drawing.Size(225, 29);
            this.btnProyeccionSimple.TabIndex = 2;
            this.btnProyeccionSimple.Text = "Proyeccion Simple";
            this.btnProyeccionSimple.UseVisualStyleBackColor = true;
            this.btnProyeccionSimple.Click += new System.EventHandler(this.btnProyeccionSimple_Click);
            // 
            // btnProyeccionMultiatributo
            // 
            this.btnProyeccionMultiatributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProyeccionMultiatributo.Location = new System.Drawing.Point(17, 73);
            this.btnProyeccionMultiatributo.Name = "btnProyeccionMultiatributo";
            this.btnProyeccionMultiatributo.Size = new System.Drawing.Size(225, 29);
            this.btnProyeccionMultiatributo.TabIndex = 3;
            this.btnProyeccionMultiatributo.Text = "Proyeccion Multiatributo";
            this.btnProyeccionMultiatributo.UseVisualStyleBackColor = true;
            this.btnProyeccionMultiatributo.Click += new System.EventHandler(this.btnProyeccionMultiatributo_Click);
            // 
            // btnJuntar
            // 
            this.btnJuntar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJuntar.Location = new System.Drawing.Point(17, 113);
            this.btnJuntar.Name = "btnJuntar";
            this.btnJuntar.Size = new System.Drawing.Size(225, 29);
            this.btnJuntar.TabIndex = 4;
            this.btnJuntar.Text = "Juntar";
            this.btnJuntar.UseVisualStyleBackColor = true;
            this.btnJuntar.Click += new System.EventHandler(this.btnJuntar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btnSeleccionConvolucion);
            this.groupBox1.Controls.Add(this.btnSelecciónMultiatributo);
            this.groupBox1.Controls.Add(this.btnSelecciónSimple);
            this.groupBox1.Location = new System.Drawing.Point(301, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 148);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operacion de Proyección - WHERE";
            // 
            // btnSeleccionConvolucion
            // 
            this.btnSeleccionConvolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionConvolucion.Location = new System.Drawing.Point(17, 113);
            this.btnSeleccionConvolucion.Name = "btnSeleccionConvolucion";
            this.btnSeleccionConvolucion.Size = new System.Drawing.Size(225, 29);
            this.btnSeleccionConvolucion.TabIndex = 4;
            this.btnSeleccionConvolucion.Text = "Selección por convolución";
            this.btnSeleccionConvolucion.UseVisualStyleBackColor = true;
            this.btnSeleccionConvolucion.Click += new System.EventHandler(this.btnSeleccionConvolucion_Click);
            // 
            // btnSelecciónMultiatributo
            // 
            this.btnSelecciónMultiatributo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecciónMultiatributo.Location = new System.Drawing.Point(17, 73);
            this.btnSelecciónMultiatributo.Name = "btnSelecciónMultiatributo";
            this.btnSelecciónMultiatributo.Size = new System.Drawing.Size(225, 29);
            this.btnSelecciónMultiatributo.TabIndex = 3;
            this.btnSelecciónMultiatributo.Text = "Selección Multiatributo";
            this.btnSelecciónMultiatributo.UseVisualStyleBackColor = true;
            this.btnSelecciónMultiatributo.Click += new System.EventHandler(this.btnSelecciónMultiatributo_Click);
            // 
            // btnSelecciónSimple
            // 
            this.btnSelecciónSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecciónSimple.Location = new System.Drawing.Point(17, 32);
            this.btnSelecciónSimple.Name = "btnSelecciónSimple";
            this.btnSelecciónSimple.Size = new System.Drawing.Size(225, 29);
            this.btnSelecciónSimple.TabIndex = 2;
            this.btnSelecciónSimple.Text = "Selección Simple";
            this.btnSelecciónSimple.UseVisualStyleBackColor = true;
            this.btnSelecciónSimple.Click += new System.EventHandler(this.btnSelecciónSimple_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.btnDiferencia);
            this.groupBox2.Controls.Add(this.btnInterseccion);
            this.groupBox2.Controls.Add(this.btnUnion);
            this.groupBox2.Location = new System.Drawing.Point(590, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 148);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operaciones Algebraicas";
            // 
            // btnDiferencia
            // 
            this.btnDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiferencia.Location = new System.Drawing.Point(17, 113);
            this.btnDiferencia.Name = "btnDiferencia";
            this.btnDiferencia.Size = new System.Drawing.Size(225, 29);
            this.btnDiferencia.TabIndex = 4;
            this.btnDiferencia.Text = "Diferencia";
            this.btnDiferencia.UseVisualStyleBackColor = true;
            this.btnDiferencia.Click += new System.EventHandler(this.btnDiferencia_Click);
            // 
            // btnInterseccion
            // 
            this.btnInterseccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInterseccion.Location = new System.Drawing.Point(17, 73);
            this.btnInterseccion.Name = "btnInterseccion";
            this.btnInterseccion.Size = new System.Drawing.Size(225, 29);
            this.btnInterseccion.TabIndex = 3;
            this.btnInterseccion.Text = "Intersección";
            this.btnInterseccion.UseVisualStyleBackColor = true;
            this.btnInterseccion.Click += new System.EventHandler(this.btnInterseccion_Click);
            // 
            // btnUnion
            // 
            this.btnUnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnion.Location = new System.Drawing.Point(17, 32);
            this.btnUnion.Name = "btnUnion";
            this.btnUnion.Size = new System.Drawing.Size(225, 29);
            this.btnUnion.TabIndex = 2;
            this.btnUnion.Text = "Unión";
            this.btnUnion.UseVisualStyleBackColor = true;
            this.btnUnion.Click += new System.EventHandler(this.btnUnion_Click);
            // 
            // lblBotonSeleccionado
            // 
            this.lblBotonSeleccionado.AutoSize = true;
            this.lblBotonSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBotonSeleccionado.Location = new System.Drawing.Point(12, 331);
            this.lblBotonSeleccionado.Name = "lblBotonSeleccionado";
            this.lblBotonSeleccionado.Size = new System.Drawing.Size(142, 18);
            this.lblBotonSeleccionado.TabIndex = 6;
            this.lblBotonSeleccionado.Text = "Botón Seleccionado";
            // 
            // frmOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(859, 521);
            this.Controls.Add(this.lblBotonSeleccionado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpProyeccion);
            this.Controls.Add(this.dgvMostrar);
            this.Name = "frmOperaciones";
            this.Text = "Base de Datos: Operaciones SQL";
            this.Load += new System.EventHandler(this.frmOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.gpProyeccion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.GroupBox gpProyeccion;
        private System.Windows.Forms.Button btnJuntar;
        private System.Windows.Forms.Button btnProyeccionMultiatributo;
        private System.Windows.Forms.Button btnProyeccionSimple;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSeleccionConvolucion;
        private System.Windows.Forms.Button btnSelecciónMultiatributo;
        private System.Windows.Forms.Button btnSelecciónSimple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDiferencia;
        private System.Windows.Forms.Button btnInterseccion;
        private System.Windows.Forms.Button btnUnion;
        private System.Windows.Forms.Label lblBotonSeleccionado;
    }
}