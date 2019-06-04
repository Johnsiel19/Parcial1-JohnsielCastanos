namespace Parcial1_JohnsielCastanos.UI
{
    partial class rProductos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.ValorInventariotextBox = new System.Windows.Forms.TextBox();
            this.ProductoIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ubicacioncomboBox = new System.Windows.Forms.ComboBox();
            this.AgregarUbicacion = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.ExistencianumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CostoUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistencianumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProfuctoId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Existencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor Inventario";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(127, 80);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(226, 22);
            this.DescripciontextBox.TabIndex = 0;
            // 
            // ValorInventariotextBox
            // 
            this.ValorInventariotextBox.Location = new System.Drawing.Point(127, 220);
            this.ValorInventariotextBox.Name = "ValorInventariotextBox";
            this.ValorInventariotextBox.ReadOnly = true;
            this.ValorInventariotextBox.Size = new System.Drawing.Size(100, 22);
            this.ValorInventariotextBox.TabIndex = 3;
            // 
            // ProductoIdnumericUpDown
            // 
            this.ProductoIdnumericUpDown.Location = new System.Drawing.Point(127, 26);
            this.ProductoIdnumericUpDown.Name = "ProductoIdnumericUpDown";
            this.ProductoIdnumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.ProductoIdnumericUpDown.TabIndex = 11;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ubicaciones";
            // 
            // ubicacioncomboBox
            // 
            this.ubicacioncomboBox.FormattingEnabled = true;
            this.ubicacioncomboBox.Location = new System.Drawing.Point(127, 274);
            this.ubicacioncomboBox.Name = "ubicacioncomboBox";
            this.ubicacioncomboBox.Size = new System.Drawing.Size(100, 24);
            this.ubicacioncomboBox.TabIndex = 12;
            // 
            // AgregarUbicacion
            // 
            this.AgregarUbicacion.Image = global::Parcial1_JohnsielCastanos.Properties.Resources.add_icon_icons_com_74429;
            this.AgregarUbicacion.Location = new System.Drawing.Point(233, 268);
            this.AgregarUbicacion.Name = "AgregarUbicacion";
            this.AgregarUbicacion.Size = new System.Drawing.Size(47, 42);
            this.AgregarUbicacion.TabIndex = 13;
            this.AgregarUbicacion.UseVisualStyleBackColor = true;
            this.AgregarUbicacion.Click += new System.EventHandler(this.AgregarUbicacion_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Image = global::Parcial1_JohnsielCastanos.Properties.Resources.eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(278, 316);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 64);
            this.Eliminarbutton.TabIndex = 7;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = global::Parcial1_JohnsielCastanos.Properties.Resources.guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(143, 316);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 64);
            this.Guardarbutton.TabIndex = 4;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Parcial1_JohnsielCastanos.Properties.Resources.nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 316);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 64);
            this.Nuevobutton.TabIndex = 5;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Parcial1_JohnsielCastanos.Properties.Resources.buscar;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(253, 26);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(100, 36);
            this.Buscarbutton.TabIndex = 6;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ExistencianumericUpDown
            // 
            this.ExistencianumericUpDown.DecimalPlaces = 2;
            this.ExistencianumericUpDown.Location = new System.Drawing.Point(127, 173);
            this.ExistencianumericUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.ExistencianumericUpDown.Name = "ExistencianumericUpDown";
            this.ExistencianumericUpDown.Size = new System.Drawing.Size(100, 22);
            this.ExistencianumericUpDown.TabIndex = 14;
            this.ExistencianumericUpDown.ValueChanged += new System.EventHandler(this.ExistencianumericUpDown_ValueChanged);
            // 
            // CostoUpDown
            // 
            this.CostoUpDown.DecimalPlaces = 2;
            this.CostoUpDown.Location = new System.Drawing.Point(127, 128);
            this.CostoUpDown.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.CostoUpDown.Name = "CostoUpDown";
            this.CostoUpDown.Size = new System.Drawing.Size(100, 22);
            this.CostoUpDown.TabIndex = 15;
            this.CostoUpDown.ValueChanged += new System.EventHandler(this.CostoUpDown_ValueChanged);
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 418);
            this.Controls.Add(this.CostoUpDown);
            this.Controls.Add(this.ExistencianumericUpDown);
            this.Controls.Add(this.AgregarUbicacion);
            this.Controls.Add(this.ubicacioncomboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductoIdnumericUpDown);
            this.Controls.Add(this.ValorInventariotextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Producto";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistencianumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostoUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.TextBox ValorInventariotextBox;
        private System.Windows.Forms.NumericUpDown ProductoIdnumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button AgregarUbicacion;
        private System.Windows.Forms.ComboBox ubicacioncomboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown CostoUpDown;
        private System.Windows.Forms.NumericUpDown ExistencianumericUpDown;
    }
}