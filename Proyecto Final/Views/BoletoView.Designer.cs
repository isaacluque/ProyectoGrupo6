
namespace Proyecto_Final.Views
{
    partial class BoletoView
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
            this.btn_Pedir = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView_boleto = new System.Windows.Forms.DataGridView();
            this.cb_Destino = new System.Windows.Forms.ComboBox();
            this.cb_TipoBus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PrecioTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_boleto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Pedir
            // 
            this.btn_Pedir.Location = new System.Drawing.Point(254, 235);
            this.btn_Pedir.Name = "btn_Pedir";
            this.btn_Pedir.Size = new System.Drawing.Size(97, 29);
            this.btn_Pedir.TabIndex = 0;
            this.btn_Pedir.Text = "Pedir Boleto";
            this.btn_Pedir.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(386, 235);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(97, 29);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView_boleto
            // 
            this.dataGridView_boleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_boleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_boleto.Location = new System.Drawing.Point(50, 288);
            this.dataGridView_boleto.Name = "dataGridView_boleto";
            this.dataGridView_boleto.Size = new System.Drawing.Size(707, 128);
            this.dataGridView_boleto.TabIndex = 3;
            // 
            // cb_Destino
            // 
            this.cb_Destino.FormattingEnabled = true;
            this.cb_Destino.Location = new System.Drawing.Point(98, 164);
            this.cb_Destino.Name = "cb_Destino";
            this.cb_Destino.Size = new System.Drawing.Size(138, 21);
            this.cb_Destino.TabIndex = 4;
            // 
            // cb_TipoBus
            // 
            this.cb_TipoBus.FormattingEnabled = true;
            this.cb_TipoBus.Location = new System.Drawing.Point(450, 70);
            this.cb_TipoBus.Name = "cb_TipoBus";
            this.cb_TipoBus.Size = new System.Drawing.Size(143, 21);
            this.cb_TipoBus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione su Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione el tipo de bus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio Total";
            // 
            // txt_PrecioTotal
            // 
            this.txt_PrecioTotal.Location = new System.Drawing.Point(450, 164);
            this.txt_PrecioTotal.Name = "txt_PrecioTotal";
            this.txt_PrecioTotal.ReadOnly = true;
            this.txt_PrecioTotal.Size = new System.Drawing.Size(143, 20);
            this.txt_PrecioTotal.TabIndex = 10;
            // 
            // BoletoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_PrecioTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_TipoBus);
            this.Controls.Add(this.cb_Destino);
            this.Controls.Add(this.dataGridView_boleto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Pedir);
            this.Name = "BoletoView";
            this.Text = "BoletoView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_boleto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_Pedir;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.DataGridView dataGridView_boleto;
        public System.Windows.Forms.ComboBox cb_Destino;
        public System.Windows.Forms.ComboBox cb_TipoBus;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_PrecioTotal;
    }
}