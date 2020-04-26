namespace InventarioNew
{
    partial class mantenimientoClientes
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
            this.label5 = new Utilidades.label(this.components);
            this.label4 = new Utilidades.label(this.components);
            this.label3 = new Utilidades.label(this.components);
            this.label1 = new Utilidades.label(this.components);
            this.label2 = new Utilidades.label(this.components);
            this.txt_codigo = new Utilidades.Errortextbox(this.components);
            this.txt_nombre = new Utilidades.Errortextbox(this.components);
            this.txt_telefono = new Utilidades.Errortextbox(this.components);
            this.txt_email = new Utilidades.Errortextbox(this.components);
            this.estado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelcomando.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 104);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 198);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 292);
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelcomando
            // 
            this.panelcomando.Location = new System.Drawing.Point(640, 0);
            this.panelcomando.Size = new System.Drawing.Size(160, 450);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefono: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre: ";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(114, 12);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(120, 22);
            this.txt_codigo.TabIndex = 16;
            this.txt_codigo.Validar = true;
            this.txt_codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyUp);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(114, 56);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(120, 22);
            this.txt_nombre.TabIndex = 17;
            this.txt_nombre.Validar = true;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(114, 96);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(120, 22);
            this.txt_telefono.TabIndex = 18;
            this.txt_telefono.Validar = false;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(114, 138);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(120, 22);
            this.txt_email.TabIndex = 19;
            this.txt_email.Validar = false;
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(145, 181);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(18, 17);
            this.estado.TabIndex = 21;
            this.estado.UseVisualStyleBackColor = true;
            // 
            // mantenimientoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "mantenimientoClientes";
            this.Text = "mantenimientoClientes";
            this.Load += new System.EventHandler(this.mantenimientoClientes_Load);
            this.Controls.SetChildIndex(this.panelcomando, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txt_codigo, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.txt_telefono, 0);
            this.Controls.SetChildIndex(this.txt_email, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelcomando.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilidades.label label5;
        private Utilidades.label label4;
        private Utilidades.label label3;
        private Utilidades.label label1;
        private Utilidades.label label2;
        private Utilidades.Errortextbox txt_codigo;
        private Utilidades.Errortextbox txt_nombre;
        private Utilidades.Errortextbox txt_telefono;
        private Utilidades.Errortextbox txt_email;
        private System.Windows.Forms.CheckBox estado;
    }
}