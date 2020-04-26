namespace InventarioNew
{
    partial class Consultas
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new Utilidades.label(this.components);
            this.filtro = new Utilidades.Errortextbox(this.components);
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelcomando.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelcomando
            // 
            this.panelcomando.Controls.Add(this.button4);
            this.panelcomando.Controls.Add(this.button3);
            this.panelcomando.Controls.Add(this.button2);
            this.panelcomando.Location = new System.Drawing.Point(1014, 0);
            this.panelcomando.Size = new System.Drawing.Size(160, 566);
            this.panelcomando.Controls.SetChildIndex(this.button2, 0);
            this.panelcomando.Controls.SetChildIndex(this.button3, 0);
            this.panelcomando.Controls.SetChildIndex(this.button4, 0);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 424);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "Imprimir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.Location = new System.Drawing.Point(0, 346);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F);
            this.label1.Location = new System.Drawing.Point(76, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(171, 19);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(334, 22);
            this.filtro.TabIndex = 3;
            this.filtro.Validar = false;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.Location = new System.Drawing.Point(0, 268);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "Seleccionar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 566);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Consultas";
            this.puede_consultar = true;
            this.puede_imprimir = true;
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.Controls.SetChildIndex(this.panelcomando, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.filtro, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelcomando.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        public Utilidades.Errortextbox filtro;
        public Utilidades.label label1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button4;
    }
}