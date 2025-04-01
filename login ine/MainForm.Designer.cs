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
            this.btnImprimirSalida = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarEntrada = new System.Windows.Forms.Button();
            this.btnCargarFolio = new System.Windows.Forms.Button();
            this.txtEscaner = new System.Windows.Forms.TextBox();
            this.dgvEntradas = new System.Windows.Forms.DataGridView();
            this.codigo_articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cime_entradas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material_electoral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtFolio = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Location = new System.Drawing.Point(5, 3);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 611);
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
            this.Salidas.Location = new System.Drawing.Point(4, 22);
            this.Salidas.Margin = new System.Windows.Forms.Padding(2);
            this.Salidas.Name = "Salidas";
            this.Salidas.Padding = new System.Windows.Forms.Padding(2);
            this.Salidas.Size = new System.Drawing.Size(887, 585);
            this.Salidas.TabIndex = 0;
            this.Salidas.Text = "Salidas";
            // 
            // btnGuardarFolio
            // 
            this.btnGuardarFolio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnGuardarFolio.Location = new System.Drawing.Point(8, 210);
            this.btnGuardarFolio.Name = "btnGuardarFolio";
            this.btnGuardarFolio.Size = new System.Drawing.Size(87, 42);
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
            this.dgvDatosGenerales.Location = new System.Drawing.Point(183, 5);
            this.dgvDatosGenerales.Name = "dgvDatosGenerales";
            this.dgvDatosGenerales.ReadOnly = true;
            this.dgvDatosGenerales.RowHeadersWidth = 51;
            this.dgvDatosGenerales.Size = new System.Drawing.Size(669, 44);
            this.dgvDatosGenerales.TabIndex = 5;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ZORE";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ARE";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nombre";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Fecha";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(8, 302);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 41);
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
            this.dgvArticulos.Location = new System.Drawing.Point(183, 76);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(669, 483);
            this.dgvArticulos.TabIndex = 3;
            // 
            // Codigo_Artículo
            // 
            this.Codigo_Artículo.HeaderText = "Codigo_Artículo";
            this.Codigo_Artículo.MinimumWidth = 6;
            this.Codigo_Artículo.Name = "Codigo_Artículo";
            this.Codigo_Artículo.ReadOnly = true;
            // 
            // CIME
            // 
            this.CIME.HeaderText = "CIME";
            this.CIME.MinimumWidth = 6;
            this.CIME.Name = "CIME";
            this.CIME.ReadOnly = true;
            // 
            // NumeralMaterial
            // 
            this.NumeralMaterial.HeaderText = "Número";
            this.NumeralMaterial.MinimumWidth = 6;
            this.NumeralMaterial.Name = "NumeralMaterial";
            this.NumeralMaterial.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(8, 257);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 41);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(8, 164);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 41);
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
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(170, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.UseWaitCursor = true;
            // 
            // txtArticulos
            // 
            this.txtArticulos.Location = new System.Drawing.Point(54, 111);
            this.txtArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.txtArticulos.Name = "txtArticulos";
            this.txtArticulos.Size = new System.Drawing.Size(109, 20);
            this.txtArticulos.TabIndex = 8;
            this.txtArticulos.UseWaitCursor = true;
            this.txtArticulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtArticulos_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(54, 83);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(109, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.UseWaitCursor = true;
            // 
            // txtAre
            // 
            this.txtAre.Location = new System.Drawing.Point(54, 55);
            this.txtAre.Margin = new System.Windows.Forms.Padding(2);
            this.txtAre.Name = "txtAre";
            this.txtAre.Size = new System.Drawing.Size(109, 20);
            this.txtAre.TabIndex = 6;
            this.txtAre.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Artículos:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre:";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Are:";
            this.label2.UseWaitCursor = true;
            // 
            // txtZore
            // 
            this.txtZore.Location = new System.Drawing.Point(54, 24);
            this.txtZore.Margin = new System.Windows.Forms.Padding(2);
            this.txtZore.Name = "txtZore";
            this.txtZore.Size = new System.Drawing.Size(109, 20);
            this.txtZore.TabIndex = 2;
            this.txtZore.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zore:";
            this.label1.UseWaitCursor = true;
            // 
            // Entradas
            // 
            this.Entradas.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Entradas.Controls.Add(this.btnImprimirSalida);
            this.Entradas.Controls.Add(this.btnclean);
            this.Entradas.Controls.Add(this.label6);
            this.Entradas.Controls.Add(this.label5);
            this.Entradas.Controls.Add(this.btnRegistrarEntrada);
            this.Entradas.Controls.Add(this.btnCargarFolio);
            this.Entradas.Controls.Add(this.txtEscaner);
            this.Entradas.Controls.Add(this.dgvEntradas);
            this.Entradas.Controls.Add(this.txtFolio);
            this.Entradas.Location = new System.Drawing.Point(4, 22);
            this.Entradas.Margin = new System.Windows.Forms.Padding(2);
            this.Entradas.Name = "Entradas";
            this.Entradas.Padding = new System.Windows.Forms.Padding(2);
            this.Entradas.Size = new System.Drawing.Size(887, 585);
            this.Entradas.TabIndex = 1;
            this.Entradas.Text = "Entradas";
            // 
            // btnImprimirSalida
            // 
            this.btnImprimirSalida.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnImprimirSalida.Location = new System.Drawing.Point(111, 201);
            this.btnImprimirSalida.Name = "btnImprimirSalida";
            this.btnImprimirSalida.Size = new System.Drawing.Size(98, 39);
            this.btnImprimirSalida.TabIndex = 8;
            this.btnImprimirSalida.Text = "Imprimir";
            this.btnImprimirSalida.UseVisualStyleBackColor = true;
            this.btnImprimirSalida.Click += new System.EventHandler(this.btnImprimirSalida_Click);
            // 
            // btnclean
            // 
            this.btnclean.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnclean.Location = new System.Drawing.Point(109, 160);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(100, 35);
            this.btnclean.TabIndex = 7;
            this.btnclean.Text = "Limpiar";
            this.btnclean.UseVisualStyleBackColor = true;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Artículos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Folio:";
            // 
            // btnRegistrarEntrada
            // 
            this.btnRegistrarEntrada.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnRegistrarEntrada.Location = new System.Drawing.Point(5, 201);
            this.btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            this.btnRegistrarEntrada.Size = new System.Drawing.Size(100, 39);
            this.btnRegistrarEntrada.TabIndex = 4;
            this.btnRegistrarEntrada.Text = "Registrar";
            this.btnRegistrarEntrada.UseVisualStyleBackColor = true;
            // 
            // btnCargarFolio
            // 
            this.btnCargarFolio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.btnCargarFolio.Location = new System.Drawing.Point(5, 160);
            this.btnCargarFolio.Name = "btnCargarFolio";
            this.btnCargarFolio.Size = new System.Drawing.Size(100, 35);
            this.btnCargarFolio.TabIndex = 3;
            this.btnCargarFolio.Text = "Cargar Folio";
            this.btnCargarFolio.UseVisualStyleBackColor = true;
            this.btnCargarFolio.Click += new System.EventHandler(this.btnCargarFolio_Click_1);
            // 
            // txtEscaner
            // 
            this.txtEscaner.Location = new System.Drawing.Point(84, 94);
            this.txtEscaner.Name = "txtEscaner";
            this.txtEscaner.Size = new System.Drawing.Size(100, 20);
            this.txtEscaner.TabIndex = 2;
            this.txtEscaner.TextChanged += new System.EventHandler(this.txtEscaner_TextChanged_1);
            // 
            // dgvEntradas
            // 
            this.dgvEntradas.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dgvEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_articulo,
            this.cime_entradas,
            this.material_electoral,
            this.estado});
            this.dgvEntradas.Location = new System.Drawing.Point(215, 20);
            this.dgvEntradas.Name = "dgvEntradas";
            this.dgvEntradas.ReadOnly = true;
            this.dgvEntradas.RowHeadersWidth = 51;
            this.dgvEntradas.Size = new System.Drawing.Size(613, 489);
            this.dgvEntradas.TabIndex = 1;
            // 
            // codigo_articulo
            // 
            this.codigo_articulo.HeaderText = "Codigo de Artículo";
            this.codigo_articulo.MinimumWidth = 6;
            this.codigo_articulo.Name = "codigo_articulo";
            this.codigo_articulo.ReadOnly = true;
            this.codigo_articulo.Width = 125;
            // 
            // cime_entradas
            // 
            this.cime_entradas.HeaderText = "CIME";
            this.cime_entradas.MinimumWidth = 6;
            this.cime_entradas.Name = "cime_entradas";
            this.cime_entradas.ReadOnly = true;
            this.cime_entradas.Width = 125;
            // 
            // material_electoral
            // 
            this.material_electoral.HeaderText = "Nombre";
            this.material_electoral.MinimumWidth = 6;
            this.material_electoral.Name = "material_electoral";
            this.material_electoral.ReadOnly = true;
            this.material_electoral.Width = 125;
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.MinimumWidth = 6;
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 125;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(84, 33);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(100, 20);
            this.txtFolio.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 609);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.Button btnImprimirSalida;
    }
}