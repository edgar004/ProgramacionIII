namespace InventarioNew
{
    partial class mantenimientoProducto
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
            this.txt_nombre = new Utilidades.Errortextbox(this.components);
            this.txt_codigo = new Utilidades.Errortextbox(this.components);
            this.label3 = new Utilidades.label(this.components);
            this.label1 = new Utilidades.label(this.components);
            this.label2 = new Utilidades.label(this.components);
            this.label4 = new Utilidades.label(this.components);
            this.departamento = new System.Windows.Forms.ComboBox();
            this.suplidor = new System.Windows.Forms.ComboBox();
            this.label5 = new Utilidades.label(this.components);
            this.reorden = new Utilidades.Errortextbox(this.components);
            this.existente = new Utilidades.Errortextbox(this.components);
            this.label6 = new Utilidades.label(this.components);
            this.label7 = new Utilidades.label(this.components);
            this.unidad_medida = new System.Windows.Forms.ComboBox();
            this.label8 = new Utilidades.label(this.components);
            this.precio = new Utilidades.Errortextbox(this.components);
            this.label9 = new Utilidades.label(this.components);
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
            this.estado.Location = new System.Drawing.Point(315, 399);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(18, 17);
            this.estado.TabIndex = 31;
            this.estado.UseVisualStyleBackColor = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(275, 114);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(120, 22);
            this.txt_nombre.TabIndex = 28;
            this.txt_nombre.Validar = true;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(275, 70);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(120, 22);
            this.txt_codigo.TabIndex = 27;
            this.txt_codigo.Validar = true;
            this.txt_codigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_KeyUp);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Departamento:";
            // 
            // departamento
            // 
            this.departamento.FormattingEnabled = true;
            this.departamento.Location = new System.Drawing.Point(274, 156);
            this.departamento.Name = "departamento";
            this.departamento.Size = new System.Drawing.Size(121, 24);
            this.departamento.TabIndex = 33;
            // 
            // suplidor
            // 
            this.suplidor.FormattingEnabled = true;
            this.suplidor.Location = new System.Drawing.Point(275, 198);
            this.suplidor.Name = "suplidor";
            this.suplidor.Size = new System.Drawing.Size(121, 24);
            this.suplidor.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Suplidor:";
            // 
            // reorden
            // 
            this.reorden.Location = new System.Drawing.Point(274, 283);
            this.reorden.Name = "reorden";
            this.reorden.Size = new System.Drawing.Size(120, 22);
            this.reorden.TabIndex = 39;
            this.reorden.Validar = true;
            // 
            // existente
            // 
            this.existente.Location = new System.Drawing.Point(274, 236);
            this.existente.Name = "existente";
            this.existente.Size = new System.Drawing.Size(120, 22);
            this.existente.TabIndex = 38;
            this.existente.Validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Cantidad existente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Reorden: ";
            // 
            // unidad_medida
            // 
            this.unidad_medida.FormattingEnabled = true;
            this.unidad_medida.Location = new System.Drawing.Point(273, 328);
            this.unidad_medida.Name = "unidad_medida";
            this.unidad_medida.Size = new System.Drawing.Size(121, 24);
            this.unidad_medida.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Unidad medida:";
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(276, 364);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(120, 22);
            this.precio.TabIndex = 43;
            this.precio.Validar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Precio venta: ";
            // 
            // mantenimientoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.unidad_medida);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.reorden);
            this.Controls.Add(this.existente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.suplidor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.departamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "mantenimientoProducto";
            this.Text = "mantenimientoProducto";
            this.Load += new System.EventHandler(this.mantenimientoProducto_Load);
            this.Controls.SetChildIndex(this.panelcomando, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txt_codigo, 0);
            this.Controls.SetChildIndex(this.txt_nombre, 0);
            this.Controls.SetChildIndex(this.estado, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.departamento, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.suplidor, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.existente, 0);
            this.Controls.SetChildIndex(this.reorden, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.unidad_medida, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.precio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelcomando.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox estado;
        private Utilidades.Errortextbox txt_nombre;
        private Utilidades.Errortextbox txt_codigo;
        private Utilidades.label label3;
        private Utilidades.label label1;
        private Utilidades.label label2;
        private Utilidades.label label4;
        private System.Windows.Forms.ComboBox departamento;
        private System.Windows.Forms.ComboBox suplidor;
        private Utilidades.label label5;
        private Utilidades.Errortextbox reorden;
        private Utilidades.Errortextbox existente;
        private Utilidades.label label6;
        private Utilidades.label label7;
        private System.Windows.Forms.ComboBox unidad_medida;
        private Utilidades.label label8;
        private Utilidades.Errortextbox precio;
        private Utilidades.label label9;
    }
}