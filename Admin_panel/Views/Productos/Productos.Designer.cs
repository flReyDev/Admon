namespace Admin_panel.Views.Productos
{
    partial class Productos
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
            this.ComboTipo = new System.Windows.Forms.ComboBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboEstandar = new System.Windows.Forms.ComboBox();
            this.ComboUM = new System.Windows.Forms.ComboBox();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboImpuesto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCantPaquete = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtCantReal = new System.Windows.Forms.TextBox();
            this.ComboMandato = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboTransCarga = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ComboPrecio = new System.Windows.Forms.ComboBox();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.FechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtMaxStock = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtMinStock = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.BtnConsulta = new FontAwesome.Sharp.IconButton();
            this.BtnAgregarProducto = new FontAwesome.Sharp.IconButton();
            this.BtnClean = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SelectValueImpuesto = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboTipo
            // 
            this.ComboTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ComboTipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboTipo.DisplayMember = "Tipo";
            this.ComboTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTipo.Font = new System.Drawing.Font("Decker", 12F);
            this.ComboTipo.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ComboTipo.FormattingEnabled = true;
            this.ComboTipo.Items.AddRange(new object[] {
            "Selecciona..",
            "Servicio",
            "Producto"});
            this.ComboTipo.Location = new System.Drawing.Point(35, 52);
            this.ComboTipo.MaxDropDownItems = 3;
            this.ComboTipo.Name = "ComboTipo";
            this.ComboTipo.Size = new System.Drawing.Size(239, 37);
            this.ComboTipo.TabIndex = 0;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.AccessibleDescription = "Codigo";
            this.TxtCodigo.AccessibleName = "Codigo";
            this.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigo.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtCodigo.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtCodigo.Location = new System.Drawing.Point(35, 151);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(139, 36);
            this.TxtCodigo.TabIndex = 1;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.AccessibleDescription = "Codigo";
            this.TxtPrecio.AccessibleName = "Codigo";
            this.TxtPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecio.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtPrecio.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtPrecio.Location = new System.Drawing.Point(35, 342);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(585, 36);
            this.TxtPrecio.TabIndex = 1;
            this.TxtPrecio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(29, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio unitario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(176, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción";
            // 
            // ComboEstandar
            // 
            this.ComboEstandar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ComboEstandar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboEstandar.DisplayMember = "Tipo";
            this.ComboEstandar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboEstandar.Font = new System.Drawing.Font("Decker", 12F);
            this.ComboEstandar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ComboEstandar.FormattingEnabled = true;
            this.ComboEstandar.Items.AddRange(new object[] {
            "Selecciona..",
            "Adopción del contribuyente"});
            this.ComboEstandar.Location = new System.Drawing.Point(180, 242);
            this.ComboEstandar.MaxDropDownItems = 3;
            this.ComboEstandar.Name = "ComboEstandar";
            this.ComboEstandar.Size = new System.Drawing.Size(438, 37);
            this.ComboEstandar.TabIndex = 0;
            // 
            // ComboUM
            // 
            this.ComboUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ComboUM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboUM.DisplayMember = "Tipo";
            this.ComboUM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboUM.Font = new System.Drawing.Font("Decker", 12F);
            this.ComboUM.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ComboUM.FormattingEnabled = true;
            this.ComboUM.Items.AddRange(new object[] {
            "Selecciona..",
            "Servicio",
            "Producto"});
            this.ComboUM.Location = new System.Drawing.Point(33, 242);
            this.ComboUM.MaxDropDownItems = 3;
            this.ComboUM.Name = "ComboUM";
            this.ComboUM.Size = new System.Drawing.Size(139, 37);
            this.ComboUM.TabIndex = 0;
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.AccessibleDescription = "Codigo";
            this.TxtDescripcion.AccessibleName = "Codigo";
            this.TxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescripcion.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtDescripcion.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtDescripcion.Location = new System.Drawing.Point(180, 151);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(440, 36);
            this.TxtDescripcion.TabIndex = 1;
            this.TxtDescripcion.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "UM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(178, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Codigo Estandar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(31, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Codigo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(31, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tipo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.BtnConsulta);
            this.panel1.Controls.Add(this.ComboMandato);
            this.panel1.Controls.Add(this.BtnAgregarProducto);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.BtnClean);
            this.panel1.Controls.Add(this.TxtPrecio);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtComentarios);
            this.panel1.Controls.Add(this.ComboUM);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.TxtMaxStock);
            this.panel1.Controls.Add(this.ComboTipo);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtModelo);
            this.panel1.Controls.Add(this.ComboPrecio);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.TxtUbicacion);
            this.panel1.Controls.Add(this.TxtMarca);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TxtCantReal);
            this.panel1.Controls.Add(this.SelectValueImpuesto);
            this.panel1.Controls.Add(this.ComboImpuesto);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.TxtMinStock);
            this.panel1.Controls.Add(this.ComboEstandar);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FechaVencimiento);
            this.panel1.Controls.Add(this.ComboTransCarga);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.TxtCodigo);
            this.panel1.Controls.Add(this.TxtCantPaquete);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.TxtDescripcion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1529, 649);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ComboImpuesto
            // 
            this.ComboImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ComboImpuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboImpuesto.DisplayMember = "Tipo";
            this.ComboImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboImpuesto.Font = new System.Drawing.Font("Decker", 12F);
            this.ComboImpuesto.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ComboImpuesto.FormattingEnabled = true;
            this.ComboImpuesto.Items.AddRange(new object[] {
            "Selecciona..",
            "Servicio",
            "Producto"});
            this.ComboImpuesto.Location = new System.Drawing.Point(694, 52);
            this.ComboImpuesto.MaxDropDownItems = 3;
            this.ComboImpuesto.Name = "ComboImpuesto";
            this.ComboImpuesto.Size = new System.Drawing.Size(264, 37);
            this.ComboImpuesto.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(690, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Impuestos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(31, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Marca:";
            // 
            // TxtMarca
            // 
            this.TxtMarca.AccessibleDescription = "Codigo";
            this.TxtMarca.AccessibleName = "Codigo";
            this.TxtMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMarca.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtMarca.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtMarca.Location = new System.Drawing.Point(35, 431);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(312, 36);
            this.TxtMarca.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(357, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 24);
            this.label9.TabIndex = 2;
            this.label9.Text = "Modelo:";
            // 
            // TxtModelo
            // 
            this.TxtModelo.AccessibleDescription = "Codigo";
            this.TxtModelo.AccessibleName = "Codigo";
            this.TxtModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtModelo.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtModelo.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtModelo.Location = new System.Drawing.Point(353, 431);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(267, 36);
            this.TxtModelo.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(349, 488);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cantidad x PQ";
            // 
            // TxtCantPaquete
            // 
            this.TxtCantPaquete.AccessibleDescription = "Codigo";
            this.TxtCantPaquete.AccessibleName = "Codigo";
            this.TxtCantPaquete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtCantPaquete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantPaquete.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtCantPaquete.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtCantPaquete.Location = new System.Drawing.Point(353, 525);
            this.TxtCantPaquete.Name = "TxtCantPaquete";
            this.TxtCantPaquete.Size = new System.Drawing.Size(267, 36);
            this.TxtCantPaquete.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(31, 488);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 24);
            this.label11.TabIndex = 2;
            this.label11.Text = "Cantidad real:";
            // 
            // TxtCantReal
            // 
            this.TxtCantReal.AccessibleDescription = "Codigo";
            this.TxtCantReal.AccessibleName = "Codigo";
            this.TxtCantReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtCantReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCantReal.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtCantReal.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtCantReal.Location = new System.Drawing.Point(35, 525);
            this.TxtCantReal.Name = "TxtCantReal";
            this.TxtCantReal.Size = new System.Drawing.Size(312, 36);
            this.TxtCantReal.TabIndex = 1;
            // 
            // ComboMandato
            // 
            this.ComboMandato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboMandato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ComboMandato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboMandato.DisplayMember = "Tipo";
            this.ComboMandato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboMandato.Font = new System.Drawing.Font("Decker", 12F);
            this.ComboMandato.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ComboMandato.FormattingEnabled = true;
            this.ComboMandato.Items.AddRange(new object[] {
            "Selecciona..",
            "Servicio",
            "Producto"});
            this.ComboMandato.Location = new System.Drawing.Point(694, 138);
            this.ComboMandato.MaxDropDownItems = 3;
            this.ComboMandato.Name = "ComboMandato";
            this.ComboMandato.Size = new System.Drawing.Size(264, 37);
            this.ComboMandato.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(690, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Mandato:";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(690, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Transportes de carga";
            // 
            // ComboTransCarga
            // 
            this.ComboTransCarga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboTransCarga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ComboTransCarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboTransCarga.DisplayMember = "Tipo";
            this.ComboTransCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboTransCarga.Font = new System.Drawing.Font("Decker", 12F);
            this.ComboTransCarga.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ComboTransCarga.FormattingEnabled = true;
            this.ComboTransCarga.Items.AddRange(new object[] {
            "Selecciona..",
            "Servicio",
            "Producto"});
            this.ComboTransCarga.Location = new System.Drawing.Point(694, 341);
            this.ComboTransCarga.MaxDropDownItems = 3;
            this.ComboTransCarga.Name = "ComboTransCarga";
            this.ComboTransCarga.Size = new System.Drawing.Size(264, 37);
            this.ComboTransCarga.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(690, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(151, 24);
            this.label14.TabIndex = 2;
            this.label14.Text = "Precio por pais:";
            // 
            // ComboPrecio
            // 
            this.ComboPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ComboPrecio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboPrecio.DisplayMember = "Tipo";
            this.ComboPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboPrecio.Font = new System.Drawing.Font("Decker", 12F);
            this.ComboPrecio.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.ComboPrecio.FormattingEnabled = true;
            this.ComboPrecio.Items.AddRange(new object[] {
            "Selecciona..",
            "Servicio",
            "Producto"});
            this.ComboPrecio.Location = new System.Drawing.Point(694, 230);
            this.ComboPrecio.MaxDropDownItems = 3;
            this.ComboPrecio.Name = "ComboPrecio";
            this.ComboPrecio.Size = new System.Drawing.Size(264, 37);
            this.ComboPrecio.TabIndex = 0;
            // 
            // txtComentarios
            // 
            this.txtComentarios.AccessibleDescription = "Codigo";
            this.txtComentarios.AccessibleName = "Codigo";
            this.txtComentarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.txtComentarios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComentarios.Font = new System.Drawing.Font("Decker", 12F);
            this.txtComentarios.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtComentarios.Location = new System.Drawing.Point(694, 528);
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(518, 108);
            this.txtComentarios.TabIndex = 1;
            this.txtComentarios.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Decker", 12F);
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(689, 488);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 29);
            this.label15.TabIndex = 2;
            this.label15.Text = "Comentarios:";
            // 
            // FechaVencimiento
            // 
            this.FechaVencimiento.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FechaVencimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.FechaVencimiento.Font = new System.Drawing.Font("Decker", 12F);
            this.FechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVencimiento.Location = new System.Drawing.Point(301, 52);
            this.FechaVencimiento.MinDate = new System.DateTime(2002, 1, 1, 0, 0, 0, 0);
            this.FechaVencimiento.Name = "FechaVencimiento";
            this.FechaVencimiento.Size = new System.Drawing.Size(317, 36);
            this.FechaVencimiento.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(297, 11);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 24);
            this.label16.TabIndex = 2;
            this.label16.Text = "Fecha vencimiento";
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(690, 393);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 24);
            this.label17.TabIndex = 2;
            this.label17.Text = "Max Stock:";
            // 
            // TxtMaxStock
            // 
            this.TxtMaxStock.AccessibleDescription = "Codigo";
            this.TxtMaxStock.AccessibleName = "Codigo";
            this.TxtMaxStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMaxStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtMaxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMaxStock.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtMaxStock.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtMaxStock.Location = new System.Drawing.Point(694, 431);
            this.TxtMaxStock.MinimumSize = new System.Drawing.Size(239, 36);
            this.TxtMaxStock.Name = "TxtMaxStock";
            this.TxtMaxStock.Size = new System.Drawing.Size(264, 36);
            this.TxtMaxStock.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(971, 393);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 24);
            this.label18.TabIndex = 2;
            this.label18.Text = "Min Stock:";
            // 
            // TxtMinStock
            // 
            this.TxtMinStock.AccessibleDescription = "Codigo";
            this.TxtMinStock.AccessibleName = "Codigo";
            this.TxtMinStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMinStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtMinStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMinStock.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtMinStock.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtMinStock.Location = new System.Drawing.Point(975, 431);
            this.TxtMinStock.Name = "TxtMinStock";
            this.TxtMinStock.Size = new System.Drawing.Size(237, 36);
            this.TxtMinStock.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label19.Location = new System.Drawing.Point(1228, 393);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "Ubicación:";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.AccessibleDescription = "Codigo";
            this.TxtUbicacion.AccessibleName = "Codigo";
            this.TxtUbicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUbicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.TxtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUbicacion.Font = new System.Drawing.Font("Decker", 12F);
            this.TxtUbicacion.ForeColor = System.Drawing.SystemColors.Menu;
            this.TxtUbicacion.Location = new System.Drawing.Point(1232, 431);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(264, 36);
            this.TxtUbicacion.TabIndex = 1;
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConsulta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnConsulta.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnConsulta.IconColor = System.Drawing.Color.White;
            this.BtnConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsulta.IconSize = 30;
            this.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConsulta.Location = new System.Drawing.Point(1354, 547);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(140, 33);
            this.BtnConsulta.TabIndex = 5;
            this.BtnConsulta.Text = "Consultar";
            this.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsulta.UseVisualStyleBackColor = true;
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregarProducto.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.BtnAgregarProducto.IconColor = System.Drawing.Color.White;
            this.BtnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAgregarProducto.IconSize = 30;
            this.BtnAgregarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregarProducto.Location = new System.Drawing.Point(1251, 592);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(245, 44);
            this.BtnAgregarProducto.TabIndex = 4;
            this.BtnAgregarProducto.Text = "Agregar Producto";
            this.BtnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.AgregarProducto);
            // 
            // BtnClean
            // 
            this.BtnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClean.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClean.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.BtnClean.IconColor = System.Drawing.Color.White;
            this.BtnClean.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClean.IconSize = 30;
            this.BtnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClean.Location = new System.Drawing.Point(1374, 504);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(122, 33);
            this.BtnClean.TabIndex = 4;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnClean.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Location = new System.Drawing.Point(655, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 627);
            this.panel2.TabIndex = 6;
            // 
            // SelectValueImpuesto
            // 
            this.SelectValueImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectValueImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.SelectValueImpuesto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectValueImpuesto.DisplayMember = "Tipo";
            this.SelectValueImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectValueImpuesto.Font = new System.Drawing.Font("Decker", 12F);
            this.SelectValueImpuesto.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.SelectValueImpuesto.FormattingEnabled = true;
            this.SelectValueImpuesto.Items.AddRange(new object[] {
            "Selecciona..",
            "Servicio",
            "Producto"});
            this.SelectValueImpuesto.Location = new System.Drawing.Point(975, 52);
            this.SelectValueImpuesto.MaxDropDownItems = 3;
            this.SelectValueImpuesto.Name = "SelectValueImpuesto";
            this.SelectValueImpuesto.Size = new System.Drawing.Size(264, 37);
            this.SelectValueImpuesto.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(971, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(167, 24);
            this.label20.TabIndex = 2;
            this.label20.Text = "Tipo de impuesto";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label21.Location = new System.Drawing.Point(971, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(132, 24);
            this.label21.TabIndex = 2;
            this.label21.Text = "Identificación";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleDescription = "Codigo";
            this.textBox1.AccessibleName = "Codigo";
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Decker", 12F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(975, 139);
            this.textBox1.MinimumSize = new System.Drawing.Size(239, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 36);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.AccessibleDescription = "Codigo";
            this.textBox2.AccessibleName = "Codigo";
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Decker", 12F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(1220, 139);
            this.textBox2.MinimumSize = new System.Drawing.Size(239, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(239, 36);
            this.textBox2.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(1216, 105);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(55, 24);
            this.label22.TabIndex = 2;
            this.label22.Text = "Valor";
            // 
            // textBox3
            // 
            this.textBox3.AccessibleDescription = "Codigo";
            this.textBox3.AccessibleName = "Codigo";
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Decker", 12F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(975, 230);
            this.textBox3.MinimumSize = new System.Drawing.Size(239, 36);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 36);
            this.textBox3.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label23.Location = new System.Drawing.Point(971, 193);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 24);
            this.label23.TabIndex = 2;
            this.label23.Text = "Valor";
            // 
            // textBox4
            // 
            this.textBox4.AccessibleDescription = "Codigo";
            this.textBox4.AccessibleName = "Codigo";
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Decker", 12F);
            this.textBox4.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox4.Location = new System.Drawing.Point(975, 341);
            this.textBox4.MinimumSize = new System.Drawing.Size(239, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 36);
            this.textBox4.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Decker", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(971, 296);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 24);
            this.label24.TabIndex = 2;
            this.label24.Text = "Numero flete";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1529, 649);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboTipo;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboEstandar;
        private System.Windows.Forms.ComboBox ComboUM;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker FechaVencimiento;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox ComboTransCarga;
        private System.Windows.Forms.ComboBox ComboPrecio;
        private System.Windows.Forms.ComboBox ComboMandato;
        private System.Windows.Forms.ComboBox ComboImpuesto;
        private System.Windows.Forms.TextBox TxtCantReal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtCantPaquete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtMinStock;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtMaxStock;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label label19;
        private FontAwesome.Sharp.IconButton BtnConsulta;
        private FontAwesome.Sharp.IconButton BtnClean;
        private FontAwesome.Sharp.IconButton BtnAgregarProducto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox SelectValueImpuesto;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
    }
}