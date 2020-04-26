namespace InventarioNew
{
    partial class MantenimientoCliente
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
            this.label1 = new Utilidades.label(this.components);
            this.textbox1 = new Utilidades.textbox(this.components);
            this.label2 = new Utilidades.label(this.components);
            this.textbox2 = new Utilidades.textbox(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelcomando.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(113, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(172, 24);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(100, 20);
            this.textbox1.TabIndex = 1;
            this.textbox1.validar = false;
            this.textbox1.TextChanged += new System.EventHandler(this.textbox1_TextChanged);
            this.textbox1.Leave += new System.EventHandler(this.textbox1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(172, 59);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(100, 20);
            this.textbox2.TabIndex = 3;
            this.textbox2.validar = false;
            // 
            // MantenimientoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label1);
            this.Name = "MantenimientoCliente";
            this.Text = "MantenimientoCliente";
            this.Load += new System.EventHandler(this.MantenimientoCliente_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textbox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textbox2, 0);
            this.Controls.SetChildIndex(this.panelcomando, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelcomando.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utilidades.label label1;
        private Utilidades.textbox textbox1;
        private Utilidades.label label2;
        private Utilidades.textbox textbox2;
    }
}