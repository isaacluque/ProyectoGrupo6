
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.dataGridView_boleto = new System.Windows.Forms.DataGridView();
            this.cb_Destino = new System.Windows.Forms.ComboBox();
            this.cb_TipoBus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PrecioTotal = new System.Windows.Forms.TextBox();
            this.btn_nuevoBoleto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_boleto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(442, 365);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(146, 45);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(675, 365);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(146, 45);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(147, 108);
            this.txt_nombreUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.ReadOnly = true;
            this.txt_nombreUsuario.Size = new System.Drawing.Size(205, 26);
            this.txt_nombreUsuario.TabIndex = 2;
            // 
            // dataGridView_boleto
            // 
            this.dataGridView_boleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_boleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_boleto.Location = new System.Drawing.Point(75, 443);
            this.dataGridView_boleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_boleto.Name = "dataGridView_boleto";
            this.dataGridView_boleto.RowHeadersWidth = 62;
            this.dataGridView_boleto.Size = new System.Drawing.Size(1060, 197);
            this.dataGridView_boleto.TabIndex = 3;
            // 
            // cb_Destino
            // 
            this.cb_Destino.FormattingEnabled = true;
            this.cb_Destino.Location = new System.Drawing.Point(147, 252);
            this.cb_Destino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Destino.Name = "cb_Destino";
            this.cb_Destino.Size = new System.Drawing.Size(205, 28);
            this.cb_Destino.TabIndex = 4;
            // 
            // cb_TipoBus
            // 
            this.cb_TipoBus.FormattingEnabled = true;
            this.cb_TipoBus.Location = new System.Drawing.Point(675, 108);
            this.cb_TipoBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_TipoBus.Name = "cb_TipoBus";
            this.cb_TipoBus.Size = new System.Drawing.Size(212, 28);
            this.cb_TipoBus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione su Destino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(670, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccione el tipo de bus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(692, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Precio Total";
            // 
            // txt_PrecioTotal
            // 
            this.txt_PrecioTotal.Location = new System.Drawing.Point(675, 252);
            this.txt_PrecioTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_PrecioTotal.Name = "txt_PrecioTotal";
            this.txt_PrecioTotal.ReadOnly = true;
            this.txt_PrecioTotal.Size = new System.Drawing.Size(212, 26);
            this.txt_PrecioTotal.TabIndex = 10;
            // 
            // btn_nuevoBoleto
            // 
            this.btn_nuevoBoleto.Location = new System.Drawing.Point(208, 365);
            this.btn_nuevoBoleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_nuevoBoleto.Name = "btn_nuevoBoleto";
            this.btn_nuevoBoleto.Size = new System.Drawing.Size(146, 45);
            this.btn_nuevoBoleto.TabIndex = 11;
            this.btn_nuevoBoleto.Text = "Nuevo boleto";
            this.btn_nuevoBoleto.UseVisualStyleBackColor = true;
            // 
            // BoletoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn_nuevoBoleto);
            this.Controls.Add(this.txt_PrecioTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_TipoBus);
            this.Controls.Add(this.cb_Destino);
            this.Controls.Add(this.dataGridView_boleto);
            this.Controls.Add(this.txt_nombreUsuario);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BoletoView";
            this.Text = "BoletoView";
            this.Load += new System.EventHandler(this.BoletoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_boleto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_guardar;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.TextBox txt_nombreUsuario;
        public System.Windows.Forms.DataGridView dataGridView_boleto;
        public System.Windows.Forms.ComboBox cb_Destino;
        public System.Windows.Forms.ComboBox cb_TipoBus;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_PrecioTotal;
        public System.Windows.Forms.Button btn_nuevoBoleto;
    }
}