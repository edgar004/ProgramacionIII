namespace InventarioNew
{
    partial class ConsultaClientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelcomando.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // filtro
            // 
            this.filtro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filtro_KeyUp);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 288);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, 132);
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelcomando
            // 
            this.panelcomando.Location = new System.Drawing.Point(870, 0);
            this.panelcomando.Size = new System.Drawing.Size(160, 430);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(686, 371);
            this.dataGridView1.TabIndex = 4;
            // 
            // ConsultaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 430);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaClientes";
            this.Text = "ConsultaClientes";
            this.Load += new System.EventHandler(this.ConsultaClientes_Load);
            this.Controls.SetChildIndex(this.panelcomando, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelcomando.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
    }
}