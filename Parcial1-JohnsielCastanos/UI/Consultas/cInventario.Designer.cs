namespace Parcial1_JohnsielCastanos.UI.Consultas
{
    partial class cInventario
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
            this.label1 = new System.Windows.Forms.Label();
            this.valortextBox = new System.Windows.Forms.TextBox();
            this.Actualizarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Total  \r\nde Inventario";
            // 
            // valortextBox
            // 
            this.valortextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valortextBox.Location = new System.Drawing.Point(27, 77);
            this.valortextBox.Name = "valortextBox";
            this.valortextBox.ReadOnly = true;
            this.valortextBox.Size = new System.Drawing.Size(113, 27);
            this.valortextBox.TabIndex = 1;
            // 
            // Actualizarbutton
            // 
            this.Actualizarbutton.Image = global::Parcial1_JohnsielCastanos.Properties.Resources.actualizar;
            this.Actualizarbutton.Location = new System.Drawing.Point(177, 73);
            this.Actualizarbutton.Name = "Actualizarbutton";
            this.Actualizarbutton.Size = new System.Drawing.Size(83, 36);
            this.Actualizarbutton.TabIndex = 2;
            this.Actualizarbutton.UseVisualStyleBackColor = true;
            this.Actualizarbutton.Click += new System.EventHandler(this.Actualizarbutton_Click);
            // 
            // cInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 122);
            this.Controls.Add(this.Actualizarbutton);
            this.Controls.Add(this.valortextBox);
            this.Controls.Add(this.label1);
            this.Name = "cInventario";
            this.Text = "Valor Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valortextBox;
        private System.Windows.Forms.Button Actualizarbutton;
    }
}