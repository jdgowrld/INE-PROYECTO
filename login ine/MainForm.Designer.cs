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
            this.btnGuardarFolio = new System.Windows.Forms.Button();
            this.dgvDatosGenerales = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.Codigo_Artículo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeralMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.btnCargarFolio = new System.Windows.Forms.Button();
            this.txtEscaner = new System.Windows.Forms.TextBox();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.codigo_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cime_entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_electoral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Salidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosGenerales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Entradas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Salidas);
            this.tabControl1.Controls.Add(this.Entradas);
            this.tabControl1.Location = new System.Drawing.Point(7, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1193, 752);
            this.tabControl1.TabIndex = 0;
            // 
            // Salidas
            // 
            this.Salidas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Salidas.Controls.Add(this.btnGuardarFolio);
            this.Salidas.Controls.Add(this.dgvDatosGenerales);
            this.Salidas.Controls.Add(this.btnImprimir);
            this.Salidas.Controls.Add(this.dgvArticulos);
            this.Salidas.Controls.Add(this.btnLimpiar);
            this.Salidas.Controls.Add(this.btnAgregar);
            this.Salidas.Controls.Add(this.groupBox1);
            this.Salidas.Location = new System.Drawing.Point(4, 25);
            this.Salidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salidas.Name = "Salidas";
            this.Salidas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Salidas.Size = new System.Drawing.Size(1185, 723);
            this.Salidas.TabIndex = 0;
            this.Salidas.Text = "Salidas";
            // 
            // btnGuardarFolio
            // 
            this.btnGuardarFolio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnGuardarFolio.Location = new System.Drawing.Point(121, 202);
            this.btnGuardarFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarFolio.Name = "btnGuardarFolio";
            this.btnGuardarFolio.Size = new System.Drawing.Size(116, 52);
            this.btnGuardarFolio.TabIndex = 6;
            this.btnGuardarFolio.Text = "Guardar Folio";
            this.btnGuardarFolio.UseVisualStyleBackColor = true;
            this.btnGuardarFolio.Click += new System.EventHandler(this.btnGuardarFolio_Click_1);
            // 
            // dgvDatosGenerales
            // 
            this.dgvDatosGenerales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosGenerales.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvDatosGenerales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosGenerales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvDatosGenerales.Location = new System.Drawing.Point(244, 6);
            this.dgvDatosGenerales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatosGenerales.Name = "dgvDatosGenerales";
            this.dgvDatosGenerales.RowHeadersWidth = 51;
            this.dgvDatosGenerales.Size = new System.Drawing.Size(892, 54);
            this.dgvDatosGenerales.TabIndex = 5;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ZORE";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ARE";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nombre";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Fecha";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(121, 260);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(116, 50);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Artículo,
            this.CIME,
            this.NumeralMaterial,
            this.Column4});
            this.dgvArticulos.Location = new System.Drawing.Point(244, 94);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(892, 594);
            this.dgvArticulos.TabIndex = 3;
            // 
            // Codigo_Artículo
            // 
            this.Codigo_Artículo.HeaderText = "Codigo_Artículo";
            this.Codigo_Artículo.MinimumWidth = 6;
            this.Codigo_Artículo.Name = "Codigo_Artículo";
            // 
            // CIME
            // 
            this.CIME.HeaderText = "CIME";
            this.CIME.MinimumWidth = 6;
            this.CIME.Name = "CIME";
            // 
            // NumeralMaterial
            // 
            this.NumeralMaterial.HeaderText = "Número";
            this.NumeralMaterial.MinimumWidth = 6;
            this.NumeralMaterial.Name = "NumeralMaterial";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(11, 260);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 50);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(11, 202);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(104, 50);
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
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(227, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // txtArticulos
            // 
            this.txtArticulos.Location = new System.Drawing.Point(72, 137);
            this.txtArticulos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(144, 22);
            this.txtArticulos.TabIndex = 8;
            this.txtArticulos.UseWaitCursor = true;
            this.txtArticulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulos_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(72, 102);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(144, 22);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.UseWaitCursor = true;
            // 
            // txtAre
            // 
            this.txtAre.Location = new System.Drawing.Point(72, 68);
            this.txtAre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAre.Name = "txtAre";
            this.txtAre.Size = new System.Drawing.Size(144, 22);
            this.txtAre.TabIndex = 6;
            this.txtAre.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Artículos:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Are:";
            this.label2.UseWaitCursor = true;
            // 
            // txtZore
            // 
            this.txtZore.Location = new System.Drawing.Point(72, 30);
            this.txtZore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtZore.Name = "txtZore";
            this.txtZore.Size = new System.Drawing.Size(144, 22);
            this.txtZore.TabIndex = 2;
            this.txtZore.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zore:";
            this.label1.UseWaitCursor = true;
            // 
            // Entradas
            // 
            this.Entradas.Controls.Add(this.label6);
            this.Entradas.Controls.Add(this.label5);
            this.Entradas.Controls.Add(this.btnRegistrarEntrada);
            this.Entradas.Controls.Add(this.btnCargarFolio);
            this.Entradas.Controls.Add(this.txtEscaner);
            this.Entradas.Controls.Add(this.dgvEntradas);
            this.Entradas.Controls.Add(this.txtFolio);
            this.Entradas.Location = new System.Drawing.Point(4, 25);
            this.Entradas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Entradas.Name = "Entradas";
            this.Entradas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Entradas.Size = new System.Drawing.Size(1185, 723);
            this.Entradas.TabIndex = 1;
            this.Entradas.Text = "Entradas";
            this.Entradas.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Artículos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Folio:";
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(164, 212);
            this.btnRegistrarEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(100, 28);
            this.btnRegistrarEntrada.TabIndex = 4;
            this.btnRegistrarEntrada.Text = "Registrar";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
            this.btnRegistrarEntrada.Click += new System.EventHandler(this.btnRegistrarEntrada_Click);
            // 
            // btnCargarFolio
            // 
            this.btnCargarFolio.Location = new System.Drawing.Point(19, 212);
            this.btnCargarFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCargarFolio.Name = "btnCargarFolio";
            this.btnCargarFolio.Size = new System.Drawing.Size(100, 28);
            this.btnCargarFolio.TabIndex = 3;
            this.btnCargarFolio.Text = "Cargar Folio";
            this.btnCargarFolio.UseVisualStyleBackColor = true;
            this.btnCargarFolio.Click += new System.EventHandler(this.btnCargarFolio_Click_1);
            // 
            // txtEscaner
            // 
            this.txtEscaner.Location = new System.Drawing.Point(112, 116);
            this.txtEscaner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEscaner.Name = "txtEscaner";
            this.txtEscaner.Size = new System.Drawing.Size(132, 22);
            this.txtEscaner.TabIndex = 2;
            this.txtEscaner.TextChanged += new System.EventHandler(this.txtEscaner_TextChanged_1);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_articulo,
            this.cime_entradas,
            this.material_electoral,
            this.estado});
            this.dgvEntradas.Location = new System.Drawing.Point(352, 34);
            this.dgvEntradas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.RowHeadersWidth = 51;
            this.dgvEntradas.Size = new System.Drawing.Size(817, 602);
            this.dgvEntradas.TabIndex = 1;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(99, 41);
            this.txtFolio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(132, 22);
            this.txtFolio.TabIndex = 0;
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            // 
            // codigo_articulo
            // 
            this.codigo_articulo.HeaderText = "Codigo de Artículo";
            this.codigo_articulo.MinimumWidth = 6;
            this.codigo_articulo.Name = "codigo_articulo";
            this.codigo_articulo.Width = 125;
            // 
            // cime_entradas
            // 
            this.cime_entradas.HeaderText = "CIME";
            this.cime_entradas.MinimumWidth = 6;
            this.cime_entradas.Name = "cime_entradas";
            this.cime_entradas.Width = 125;
            // 
            // material_electoral
            // 
            this.material_electoral.HeaderText = "Nombre";
            this.material_electoral.MinimumWidth = 6;
            this.material_electoral.Name = "material_electoral";
            this.material_electoral.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 750);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.Salidas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosGenerales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Entradas.ResumeLayout(false);
            this.Entradas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntradas)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDatosGenerales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnGuardarFolio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Artículo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeralMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView dgvEntradas;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Button btnRegistrarEntrada;
        private System.Windows.Forms.Button btnCargarFolio;
        private System.Windows.Forms.TextBox txtEscaner;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cime_entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn material_electoral;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}