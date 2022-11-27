namespace sistema_super
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabla_clientes = new System.Windows.Forms.Button();
            this.salido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tabla_clientes
            // 
            this.tabla_clientes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabla_clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tabla_clientes.Image = ((System.Drawing.Image)(resources.GetObject("tabla_clientes.Image")));
            this.tabla_clientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tabla_clientes.Location = new System.Drawing.Point(224, 96);
            this.tabla_clientes.Name = "tabla_clientes";
            this.tabla_clientes.Size = new System.Drawing.Size(167, 142);
            this.tabla_clientes.TabIndex = 6;
            this.tabla_clientes.Text = "Mascotas";
            this.tabla_clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tabla_clientes.UseVisualStyleBackColor = false;
            this.tabla_clientes.Click += new System.EventHandler(this.tabla_clientes_Click);
            // 
            // salido
            // 
            this.salido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.salido.Image = ((System.Drawing.Image)(resources.GetObject("salido.Image")));
            this.salido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.salido.Location = new System.Drawing.Point(462, 275);
            this.salido.Name = "salido";
            this.salido.Size = new System.Drawing.Size(143, 40);
            this.salido.TabIndex = 7;
            this.salido.Text = "Cerrar sesión";
            this.salido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.salido.UseVisualStyleBackColor = false;
            this.salido.Click += new System.EventHandler(this.salido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "REGISTRO MASCOTAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 327);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salido);
            this.Controls.Add(this.tabla_clientes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tabla_clientes;
        private System.Windows.Forms.Button salido;
        private System.Windows.Forms.Label label1;
    }
}

