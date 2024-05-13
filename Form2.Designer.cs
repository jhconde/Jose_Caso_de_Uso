namespace Jose_Caso_de_Uso
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            seleccionOrdenInternaTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cantidadTextbox = new TextBox();
            tipoProductoTextbox = new TextBox();
            fechaModicacionDatepicker = new DateTimePicker();
            estadoCombobox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            numeroOrdenExternaTextbox = new TextBox();
            label6 = new Label();
            clienteTextbox = new TextBox();
            label7 = new Label();
            listoEntregaCheckbox = new CheckBox();
            fechaCreacionDatepicker = new DateTimePicker();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 36);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 0;
            label1.Text = "Número de Orden Interna";
            // 
            // seleccionOrdenInternaTextbox
            // 
            seleccionOrdenInternaTextbox.AccessibleRole = AccessibleRole.None;
            seleccionOrdenInternaTextbox.Cursor = Cursors.No;
            seleccionOrdenInternaTextbox.Location = new Point(84, 54);
            seleccionOrdenInternaTextbox.Name = "seleccionOrdenInternaTextbox";
            seleccionOrdenInternaTextbox.ReadOnly = true;
            seleccionOrdenInternaTextbox.Size = new Size(143, 23);
            seleccionOrdenInternaTextbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 211);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 152);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo de Producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(85, 480);
            label4.Name = "label4";
            label4.Size = new Size(127, 15);
            label4.TabIndex = 6;
            label4.Text = "Fecha de modificacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 331);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 7;
            label5.Text = "Estado";
            // 
            // cantidadTextbox
            // 
            cantidadTextbox.Location = new Point(87, 229);
            cantidadTextbox.Name = "cantidadTextbox";
            cantidadTextbox.Size = new Size(140, 23);
            cantidadTextbox.TabIndex = 8;
            // 
            // tipoProductoTextbox
            // 
            tipoProductoTextbox.Location = new Point(87, 170);
            tipoProductoTextbox.Name = "tipoProductoTextbox";
            tipoProductoTextbox.ReadOnly = true;
            tipoProductoTextbox.Size = new Size(140, 23);
            tipoProductoTextbox.TabIndex = 9;
            // 
            // fechaModicacionDatepicker
            // 
            fechaModicacionDatepicker.Enabled = false;
            fechaModicacionDatepicker.Format = DateTimePickerFormat.Short;
            fechaModicacionDatepicker.Location = new Point(88, 501);
            fechaModicacionDatepicker.Name = "fechaModicacionDatepicker";
            fechaModicacionDatepicker.Size = new Size(140, 23);
            fechaModicacionDatepicker.TabIndex = 10;
            // 
            // estadoCombobox
            // 
            estadoCombobox.FormattingEnabled = true;
            estadoCombobox.Location = new Point(89, 349);
            estadoCombobox.Name = "estadoCombobox";
            estadoCombobox.Size = new Size(140, 23);
            estadoCombobox.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(38, 548);
            button1.Name = "button1";
            button1.Size = new Size(107, 38);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(177, 548);
            button2.Name = "button2";
            button2.Size = new Size(101, 38);
            button2.TabIndex = 13;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numeroOrdenExternaTextbox
            // 
            numeroOrdenExternaTextbox.AccessibleRole = AccessibleRole.None;
            numeroOrdenExternaTextbox.Cursor = Cursors.No;
            numeroOrdenExternaTextbox.Location = new Point(84, 116);
            numeroOrdenExternaTextbox.Name = "numeroOrdenExternaTextbox";
            numeroOrdenExternaTextbox.ReadOnly = true;
            numeroOrdenExternaTextbox.Size = new Size(143, 23);
            numeroOrdenExternaTextbox.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(84, 98);
            label6.Name = "label6";
            label6.Size = new Size(145, 15);
            label6.TabIndex = 14;
            label6.Text = "Número de Orden Externa";
            // 
            // clienteTextbox
            // 
            clienteTextbox.Location = new Point(89, 287);
            clienteTextbox.Name = "clienteTextbox";
            clienteTextbox.ReadOnly = true;
            clienteTextbox.Size = new Size(140, 23);
            clienteTextbox.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 269);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 16;
            label7.Text = "Cliente";
            // 
            // listoEntregaCheckbox
            // 
            listoEntregaCheckbox.AutoSize = true;
            listoEntregaCheckbox.Location = new Point(90, 390);
            listoEntregaCheckbox.Name = "listoEntregaCheckbox";
            listoEntregaCheckbox.Size = new Size(120, 19);
            listoEntregaCheckbox.TabIndex = 18;
            listoEntregaCheckbox.Text = "Listo para Entrega";
            listoEntregaCheckbox.UseVisualStyleBackColor = true;
            // 
            // fechaCreacionDatepicker
            // 
            fechaCreacionDatepicker.Enabled = false;
            fechaCreacionDatepicker.Format = DateTimePickerFormat.Short;
            fechaCreacionDatepicker.Location = new Point(89, 444);
            fechaCreacionDatepicker.Name = "fechaCreacionDatepicker";
            fechaCreacionDatepicker.Size = new Size(140, 23);
            fechaCreacionDatepicker.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 423);
            label8.Name = "label8";
            label8.Size = new Size(102, 15);
            label8.TabIndex = 19;
            label8.Text = "Fecha de creacion";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 598);
            Controls.Add(fechaCreacionDatepicker);
            Controls.Add(label8);
            Controls.Add(listoEntregaCheckbox);
            Controls.Add(clienteTextbox);
            Controls.Add(label7);
            Controls.Add(numeroOrdenExternaTextbox);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(estadoCombobox);
            Controls.Add(fechaModicacionDatepicker);
            Controls.Add(tipoProductoTextbox);
            Controls.Add(cantidadTextbox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(seleccionOrdenInternaTextbox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "FormularioNuevaOrden";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox seleccionOrdenInternaTextbox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox cantidadTextbox;
        private TextBox tipoProductoTextbox;
        private DateTimePicker fechaModicacionDatepicker;
        private ComboBox estadoCombobox;
        private Button button1;
        private Button button2;
        private TextBox numeroOrdenExternaTextbox;
        private Label label6;
        private TextBox clienteTextbox;
        private Label label7;
        private CheckBox listoEntregaCheckbox;
        private DateTimePicker fechaCreacionDatepicker;
        private Label label8;
    }
}
