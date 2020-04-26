namespace InventarioNew
{
    partial class mantenimientoSuplidores
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
            this.estado = new System.Windows.Forms.CheckBox();
            this.txt_email = new Utilidades.Errortextbox(this.components);
            this.txt_telefono = new Utilidades.Errortextbox(this.components);
            this.txt_nombre = new Utilidades.Errortextbox(this.components);
            this.txt_codigo = new Utilidades.Errortextbox(this.components);
            this.label5 = new Utilidades.label(this.components);
            this.label4 = new Utilidades.label(this.components);
            this.label3 = new Utilidades.label(this.components);
            this.label1 = new Utilidades.label(this.components);
            this.label2 = new Utilidades.label(this.components);
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
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(262, 227);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(18, 17);
            this.estado.TabIndex = 31;
            this.estado.UseVisualStyleBackColor = true;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(231, 184);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(120, 22);
            this.txt_email.TabIndex = 30;
            this.txt_email.Validar = false;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(231, 142);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(120, 22);
            this.txt_telefono.TabIndex = 29;
            this.txt_telefono.Validar = false;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(231, 102);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(120, 22);
            this.txt_nombre.TabIndex = 28;
            this.txt_nombre.Validar = true;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(231, 58);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(120, 22);
            this.txt_codigo.TabIndex = 27;
            this.txt_codigo.Validar = true;
            this.txt_codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyUp);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(140, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Telefono: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre: ";
            // 
            // mantenimientoSuplidores
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
            this.Name = "mantenimientoSuplidores";
            this.Text = "mantenimientoSuplidores";
            this.Load += new System.EventHandler(this.mantenimientoSuplidores_Load);
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

        private System.Windows.Forms.CheckBox estado;
        private Utilidades.Errortextbox txt_email;
        private Utilidades.Errortextbox txt_telefono;
        private Utilidades.Errortextbox txt_nombre;
        private Utilidades.Errortextbox txt_codigo;
        private Utilidades.label label5;
        private Utilidades.label label4;
        private Utilidades.label label3;
        private Utilidades.label label1;
        private Utilidades.label label2;
    }
}