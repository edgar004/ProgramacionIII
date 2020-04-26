namespace InventarioNew
{
    partial class Compras
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
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.precio_producto = new Utilidades.Errortextbox(this.components);
            this.cantidad_producto = new Utilidades.Errortextbox(this.components);
            this.nombre_producto = new Utilidades.Errortextbox(this.components);
            this.nombre_suplidor = new Utilidades.Errortextbox(this.components);
            this.codigo_suplidor = new Utilidades.Errortextbox(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.TextBox();
            this.label2 = new Utilidades.label(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new Utilidades.label(this.components);
            this.label5 = new Utilidades.label(this.components);
            this.label4 = new Utilidades.label(this.components);
            this.label3 = new Utilidades.label(this.components);
            this.label1 = new Utilidades.label(this.components);
            this.codigoProducto = new Utilidades.Errortextbox(this.components);
            this.label7 = new Utilidades.label(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(652, 285);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(201, 51);
            this.button6.TabIndex = 43;
            this.button6.Text = "Realizar compra";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(878, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 537);
            this.panel1.TabIndex = 42;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(18, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 49);
            this.button5.TabIndex = 22;
            this.button5.Text = "Nuevo";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 330);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 49);
            this.button4.TabIndex = 21;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(156, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 51);
            this.button3.TabIndex = 41;
            this.button3.Text = "Consultar producto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // precio_producto
            // 
            this.precio_producto.Enabled = false;
            this.precio_producto.Location = new System.Drawing.Point(277, 146);
            this.precio_producto.Name = "precio_producto";
            this.precio_producto.Size = new System.Drawing.Size(100, 22);
            this.precio_producto.TabIndex = 40;
            this.precio_producto.Validar = true;
            // 
            // cantidad_producto
            // 
            this.cantidad_producto.Location = new System.Drawing.Point(409, 146);
            this.cantidad_producto.Name = "cantidad_producto";
            this.cantidad_producto.Size = new System.Drawing.Size(100, 22);
            this.cantidad_producto.TabIndex = 39;
            this.cantidad_producto.Validar = true;
            // 
            // nombre_producto
            // 
            this.nombre_producto.Enabled = false;
            this.nombre_producto.Location = new System.Drawing.Point(146, 146);
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.Size = new System.Drawing.Size(100, 22);
            this.nombre_producto.TabIndex = 38;
            this.nombre_producto.Validar = true;
            // 
            // nombre_suplidor
            // 
            this.nombre_suplidor.Location = new System.Drawing.Point(190, 60);
            this.nombre_suplidor.Name = "nombre_suplidor";
            this.nombre_suplidor.Size = new System.Drawing.Size(100, 22);
            this.nombre_suplidor.TabIndex = 36;
            this.nombre_suplidor.Validar = false;
            // 
            // codigo_suplidor
            // 
            this.codigo_suplidor.Location = new System.Drawing.Point(50, 60);
            this.codigo_suplidor.Name = "codigo_suplidor";
            this.codigo_suplidor.Size = new System.Drawing.Size(100, 22);
            this.codigo_suplidor.TabIndex = 35;
            this.codigo_suplidor.Validar = false;
            this.codigo_suplidor.Leave += new System.EventHandler(this.codigo_suplidor_Leave);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 51);
            this.button2.TabIndex = 34;
            this.button2.Text = "Agregar producto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Location = new System.Drawing.Point(772, 387);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 22);
            this.total.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Total";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Importe});
            this.dataGridView1.Location = new System.Drawing.Point(28, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(568, 251);
            this.dataGridView1.TabIndex = 31;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            this.Importe.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 32);
            this.button1.TabIndex = 30;
            this.button1.Text = "Suplidor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Nombre Suplidor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Codigo Suplidor";
            // 
            // codigoProducto
            // 
            this.codigoProducto.Location = new System.Drawing.Point(28, 146);
            this.codigoProducto.Name = "codigoProducto";
            this.codigoProducto.Size = new System.Drawing.Size(100, 22);
            this.codigoProducto.TabIndex = 45;
            this.codigoProducto.Validar = true;
            this.codigoProducto.Leave += new System.EventHandler(this.codigoProducto_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Codigo";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 851);
            this.Controls.Add(this.codigoProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.precio_producto);
            this.Controls.Add(this.cantidad_producto);
            this.Controls.Add(this.nombre_producto);
            this.Controls.Add(this.nombre_suplidor);
            this.Controls.Add(this.codigo_suplidor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Compras";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.Compras_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private Utilidades.Errortextbox precio_producto;
        private Utilidades.Errortextbox cantidad_producto;
        private Utilidades.Errortextbox nombre_producto;
        private Utilidades.Errortextbox nombre_suplidor;
        private Utilidades.Errortextbox codigo_suplidor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox total;
        private Utilidades.label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button button1;
        private Utilidades.label label6;
        private Utilidades.label label5;
        private Utilidades.label label4;
        private Utilidades.label label3;
        private Utilidades.label label1;
        private Utilidades.Errortextbox codigoProducto;
        private Utilidades.label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}