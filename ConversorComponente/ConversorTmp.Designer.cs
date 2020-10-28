namespace ConversorComponente
{
    partial class Conversor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tCent = new System.Windows.Forms.TextBox();
            this.tFah = new System.Windows.Forms.TextBox();
            this.LCen = new System.Windows.Forms.Label();
            this.LFah = new System.Windows.Forms.Label();
            this.Convertir = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tCent
            // 
            this.tCent.Location = new System.Drawing.Point(37, 52);
            this.tCent.Margin = new System.Windows.Forms.Padding(4);
            this.tCent.Multiline = true;
            this.tCent.Name = "tCent";
            this.tCent.Size = new System.Drawing.Size(193, 46);
            this.tCent.TabIndex = 0;
            // 
            // tFah
            // 
            this.tFah.Location = new System.Drawing.Point(37, 141);
            this.tFah.Margin = new System.Windows.Forms.Padding(4);
            this.tFah.Multiline = true;
            this.tFah.Name = "tFah";
            this.tFah.Size = new System.Drawing.Size(193, 50);
            this.tFah.TabIndex = 1;
            // 
            // LCen
            // 
            this.LCen.AutoSize = true;
            this.LCen.Location = new System.Drawing.Point(32, 19);
            this.LCen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCen.Name = "LCen";
            this.LCen.Size = new System.Drawing.Size(94, 18);
            this.LCen.TabIndex = 2;
            this.LCen.Text = "Centigrados";
            // 
            // LFah
            // 
            this.LFah.AutoSize = true;
            this.LFah.Location = new System.Drawing.Point(32, 110);
            this.LFah.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFah.Name = "LFah";
            this.LFah.Size = new System.Drawing.Size(82, 18);
            this.LFah.TabIndex = 3;
            this.LFah.Text = "Fahrenheit";
            // 
            // Convertir
            // 
            this.Convertir.Location = new System.Drawing.Point(238, 48);
            this.Convertir.Margin = new System.Windows.Forms.Padding(4);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(128, 143);
            this.Convertir.TabIndex = 4;
            this.Convertir.Text = "Convertir";
            this.Convertir.UseVisualStyleBackColor = true;
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(37, 199);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(193, 50);
            this.Limpiar.TabIndex = 5;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Conversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Convertir);
            this.Controls.Add(this.LFah);
            this.Controls.Add(this.LCen);
            this.Controls.Add(this.tFah);
            this.Controls.Add(this.tCent);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Conversor";
            this.Size = new System.Drawing.Size(404, 263);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tCent;
        private System.Windows.Forms.TextBox tFah;
        private System.Windows.Forms.Label LCen;
        private System.Windows.Forms.Label LFah;
        private System.Windows.Forms.Button Convertir;
        private System.Windows.Forms.Button Limpiar;
    }
}
