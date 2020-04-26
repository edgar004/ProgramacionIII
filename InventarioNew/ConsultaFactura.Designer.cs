namespace InventarioNew
{
    partial class ConsultaFactura
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new Utilidades.label(this.components);
            this.fechaini = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new Utilidades.label(this.components);
            this.Filtrar = new System.Windows.Forms.Button();
            this.label4 = new Utilidades.label(this.components);
            this.cliente_Factura = new System.Windows.Forms.TextBox();
            this.orden = new System.Windows.Forms.ComboBox();
            this.label5 = new Utilidades.label(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelcomando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filtro
            // 
            this.filtro.Visible = false;
            // 
            // label1
            // 
            this.label1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 395);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 239);
            // 
            // panelcomando
            // 
            this.panelcomando.Location = new System.Drawing.Point(851, 0);
            this.panelcomando.Size = new System.Drawing.Size(160, 537);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Factura,
            this.Fecha,
            this.Total,
            this.Codigo_Cliente,
            this.Cliente});
            this.dataGridView1.Location = new System.Drawing.Point(12, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(832, 295);
            this.dataGridView1.TabIndex = 4;
            // 
            // Factura
            // 
            this.Factura.HeaderText = "Factura";
            this.Factura.Name = "Factura";
            this.Factura.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Codigo_Cliente
            // 
            this.Codigo_Cliente.HeaderText = "Codigo Cliente";
            this.Codigo_Cliente.Name = "Codigo_Cliente";
            this.Codigo_Cliente.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Desde:";
            // 
            // fechaini
            // 
            this.fechaini.Location = new System.Drawing.Point(171, 84);
            this.fechaini.Name = "fechaini";
            this.fechaini.Size = new System.Drawing.Size(246, 22);
            this.fechaini.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(530, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasta:";
            // 
            // Filtrar
            // 
            this.Filtrar.Location = new System.Drawing.Point(539, 157);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(119, 43);
            this.Filtrar.TabIndex = 9;
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.UseVisualStyleBackColor = true;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cliente:";
            // 
            // cliente_Factura
            // 
            this.cliente_Factura.Location = new System.Drawing.Point(213, 137);
            this.cliente_Factura.Name = "cliente_Factura";
            this.cliente_Factura.Size = new System.Drawing.Size(100, 22);
            this.cliente_Factura.TabIndex = 11;
            // 
            // orden
            // 
            this.orden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orden.FormattingEnabled = true;
            this.orden.Items.AddRange(new object[] {
            "Factura",
            "Fecha",
            "Cliente"});
            this.orden.Location = new System.Drawing.Point(213, 191);
            this.orden.Name = "orden";
            this.orden.Size = new System.Drawing.Size(121, 24);
            this.orden.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Orden:";
            // 
            // ConsultaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 537);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.orden);
            this.Controls.Add(this.cliente_Factura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fechaini);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaFactura";
            this.Text = "ConsultaFactura";
            this.Load += new System.EventHandler(this.ConsultaFactura_Load);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.fechaini, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.Filtrar, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.panelcomando, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
            this.Controls.SetChildIndex(this.cliente_Factura, 0);
            this.Controls.SetChildIndex(this.orden, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelcomando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Utilidades.label label2;
        private System.Windows.Forms.DateTimePicker fechaini;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private Utilidades.label label3;
        private System.Windows.Forms.Button Filtrar;
        private Utilidades.label label4;
        private System.Windows.Forms.TextBox cliente_Factura;
        private System.Windows.Forms.ComboBox orden;
        private Utilidades.label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
    }
}