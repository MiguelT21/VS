namespace sistema_super
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label2 = new System.Windows.Forms.Label();
            this.direccion_cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.correo_cliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telefono_cliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_cliente = new System.Windows.Forms.TextBox();
            this.Aceptar_Btn = new System.Windows.Forms.Button();
            this.actualizarregistro = new System.Windows.Forms.Button();
            this.numero_cliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(24, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Registro";
            // 
            // direccion_cliente
            // 
            this.direccion_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.direccion_cliente.Location = new System.Drawing.Point(130, 182);
            this.direccion_cliente.Name = "direccion_cliente";
            this.direccion_cliente.Size = new System.Drawing.Size(187, 24);
            this.direccion_cliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(28, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Correo";
            // 
            // correo_cliente
            // 
            this.correo_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.correo_cliente.Location = new System.Drawing.Point(130, 235);
            this.correo_cliente.Name = "correo_cliente";
            this.correo_cliente.Size = new System.Drawing.Size(187, 24);
            this.correo_cliente.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(24, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefóno";
            // 
            // telefono_cliente
            // 
            this.telefono_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.telefono_cliente.Location = new System.Drawing.Point(130, 129);
            this.telefono_cliente.Name = "telefono_cliente";
            this.telefono_cliente.Size = new System.Drawing.Size(187, 24);
            this.telefono_cliente.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(14, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre Dueño";
            // 
            // nombre_cliente
            // 
            this.nombre_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nombre_cliente.Location = new System.Drawing.Point(130, 74);
            this.nombre_cliente.Name = "nombre_cliente";
            this.nombre_cliente.Size = new System.Drawing.Size(187, 24);
            this.nombre_cliente.TabIndex = 12;
            // 
            // Aceptar_Btn
            // 
            this.Aceptar_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Aceptar_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Aceptar_Btn.Image = ((System.Drawing.Image)(resources.GetObject("Aceptar_Btn.Image")));
            this.Aceptar_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptar_Btn.Location = new System.Drawing.Point(12, 284);
            this.Aceptar_Btn.Name = "Aceptar_Btn";
            this.Aceptar_Btn.Size = new System.Drawing.Size(97, 37);
            this.Aceptar_Btn.TabIndex = 14;
            this.Aceptar_Btn.Text = "Aceptar";
            this.Aceptar_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptar_Btn.UseVisualStyleBackColor = false;
            this.Aceptar_Btn.Click += new System.EventHandler(this.Aceptar_Btn_Click);
            // 
            // actualizarregistro
            // 
            this.actualizarregistro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.actualizarregistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.actualizarregistro.Image = ((System.Drawing.Image)(resources.GetObject("actualizarregistro.Image")));
            this.actualizarregistro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.actualizarregistro.Location = new System.Drawing.Point(210, 284);
            this.actualizarregistro.Name = "actualizarregistro";
            this.actualizarregistro.Size = new System.Drawing.Size(107, 37);
            this.actualizarregistro.TabIndex = 15;
            this.actualizarregistro.Text = "Editar";
            this.actualizarregistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.actualizarregistro.UseVisualStyleBackColor = false;
            this.actualizarregistro.Click += new System.EventHandler(this.actualizarregistro_Click);
            // 
            // numero_cliente
            // 
            this.numero_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.numero_cliente.Location = new System.Drawing.Point(130, 25);
            this.numero_cliente.Name = "numero_cliente";
            this.numero_cliente.Size = new System.Drawing.Size(187, 24);
            this.numero_cliente.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id de Mascota";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(342, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero_cliente);
            this.Controls.Add(this.actualizarregistro);
            this.Controls.Add(this.Aceptar_Btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nombre_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.telefono_cliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.correo_cliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.direccion_cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox correo_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox telefono_cliente;
        public System.Windows.Forms.TextBox direccion_cliente;
        public System.Windows.Forms.Button Aceptar_Btn;
        public System.Windows.Forms.Button actualizarregistro;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox nombre_cliente;
        public System.Windows.Forms.TextBox numero_cliente;
    }
}