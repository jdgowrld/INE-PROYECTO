namespace login_ine
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Salidas = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtArticulos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZore = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Entradas = new System.Windows.Forms.TabPage();
            this.CodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Salidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Salidas);
            this.tabControl1.Controls.Add(this.Entradas);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // Salidas
            // 
            this.Salidas.Controls.Add(this.btnImprimir);
            this.Salidas.Controls.Add(this.dgvArticulos);
            this.Salidas.Controls.Add(this.btnLimpiar);
            this.Salidas.Controls.Add(this.btnAgregar);
            this.Salidas.Controls.Add(this.groupBox1);
            this.Salidas.Location = new System.Drawing.Point(4, 25);
            this.Salidas.Name = "Salidas";
            this.Salidas.Padding = new System.Windows.Forms.Padding(3);
            this.Salidas.Size = new System.Drawing.Size(789, 418);
            this.Salidas.TabIndex = 0;
            this.Salidas.Text = "Salidas";
            this.Salidas.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(198, 379);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(88, 33);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoArticulo,
            this.DescripcionArticulo,
            this.CantidadArticulo});
            this.dgvArticulos.Location = new System.Drawing.Point(273, 6);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(495, 306);
            this.dgvArticulos.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(101, 379);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(91, 33);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 379);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 33);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtArticulos);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtAre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtZore);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 306);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtArticulos
            // 
            this.txtArticulos.Location = new System.Drawing.Point(75, 140);
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(100, 22);
            this.txtArticulos.TabIndex = 8;
            this.txtArticulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulos_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 7;
            // 
            // txtAre
            // 
            this.txtAre.Location = new System.Drawing.Point(75, 68);
            this.txtAre.Name = "txtAre";
            this.txtAre.Size = new System.Drawing.Size(100, 22);
            this.txtAre.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Artículos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Are:";
            // 
            // txtZore
            // 
            this.txtZore.Location = new System.Drawing.Point(75, 30);
            this.txtZore.Name = "txtZore";
            this.txtZore.Size = new System.Drawing.Size(100, 22);
            this.txtZore.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zore:";
            // 
            // Entradas
            // 
            this.Entradas.Location = new System.Drawing.Point(4, 25);
            this.Entradas.Name = "Entradas";
            this.Entradas.Padding = new System.Windows.Forms.Padding(3);
            this.Entradas.Size = new System.Drawing.Size(789, 418);
            this.Entradas.TabIndex = 1;
            this.Entradas.Text = "Entradas";
            this.Entradas.UseVisualStyleBackColor = true;
            // 
            // CodigoArticulo
            // 
            this.CodigoArticulo.HeaderText = "Código";
            this.CodigoArticulo.MinimumWidth = 6;
            this.CodigoArticulo.Name = "CodigoArticulo";
            this.CodigoArticulo.Width = 125;
            // 
            // DescripcionArticulo
            // 
            this.DescripcionArticulo.HeaderText = "Descripción";
            this.DescripcionArticulo.MinimumWidth = 6;
            this.DescripcionArticulo.Name = "DescripcionArticulo";
            this.DescripcionArticulo.Width = 125;
            // 
            // CantidadArticulo
            // 
            this.CantidadArticulo.HeaderText = "Cantidad";
            this.CantidadArticulo.MinimumWidth = 6;
            this.CantidadArticulo.Name = "CantidadArticulo";
            this.CantidadArticulo.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.Salidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Salidas;
        private System.Windows.Forms.TabPage Entradas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArticulos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadArticulo;
    }
}