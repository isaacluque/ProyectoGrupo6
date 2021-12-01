
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
            this.components = new System.ComponentModel.Container();
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
            this.txt_idusuario = new System.Windows.Forms.TextBox();
            this.txt_iddestino = new System.Windows.Forms.TextBox();
            this.txt_idtipobus = new System.Windows.Forms.TextBox();
            this.txt_asiento = new System.Windows.Forms.TextBox();
            this.txt_preciotipobus = new System.Windows.Forms.TextBox();
            this.txt_preciodestino = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_boleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(295, 237);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(97, 29);
            this.btn_guardar.TabIndex = 0;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(450, 237);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(97, 29);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(98, 70);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.ReadOnly = true;
            this.txt_nombreUsuario.Size = new System.Drawing.Size(138, 20);
            this.txt_nombreUsuario.TabIndex = 2;
            // 
            // dataGridView_boleto
            // 
            this.dataGridView_boleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_boleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_boleto.Location = new System.Drawing.Point(50, 288);
            this.dataGridView_boleto.Name = "dataGridView_boleto";
            this.dataGridView_boleto.RowHeadersWidth = 62;
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
            // btn_nuevoBoleto
            // 
            this.btn_nuevoBoleto.Location = new System.Drawing.Point(139, 237);
            this.btn_nuevoBoleto.Name = "btn_nuevoBoleto";
            this.btn_nuevoBoleto.Size = new System.Drawing.Size(97, 29);
            this.btn_nuevoBoleto.TabIndex = 11;
            this.btn_nuevoBoleto.Text = "Nuevo boleto";
            this.btn_nuevoBoleto.UseVisualStyleBackColor = true;
            // 
            // txt_idusuario
            // 
            this.txt_idusuario.Location = new System.Drawing.Point(65, 70);
            this.txt_idusuario.Name = "txt_idusuario";
            this.txt_idusuario.ReadOnly = true;
            this.txt_idusuario.Size = new System.Drawing.Size(27, 20);
            this.txt_idusuario.TabIndex = 21;
            this.txt_idusuario.Visible = false;
            // 
            // txt_iddestino
            // 
            this.txt_iddestino.Location = new System.Drawing.Point(65, 165);
            this.txt_iddestino.Name = "txt_iddestino";
            this.txt_iddestino.ReadOnly = true;
            this.txt_iddestino.Size = new System.Drawing.Size(27, 20);
            this.txt_iddestino.TabIndex = 20;
            this.txt_iddestino.Visible = false;
            // 
            // txt_idtipobus
            // 
            this.txt_idtipobus.Location = new System.Drawing.Point(417, 71);
            this.txt_idtipobus.Name = "txt_idtipobus";
            this.txt_idtipobus.ReadOnly = true;
            this.txt_idtipobus.Size = new System.Drawing.Size(27, 20);
            this.txt_idtipobus.TabIndex = 19;
            this.txt_idtipobus.Visible = false;
            // 
            // txt_asiento
            // 
            this.txt_asiento.Location = new System.Drawing.Point(614, 165);
            this.txt_asiento.Name = "txt_asiento";
            this.txt_asiento.Size = new System.Drawing.Size(143, 20);
            this.txt_asiento.TabIndex = 24;
            // 
            // txt_preciotipobus
            // 
            this.txt_preciotipobus.Location = new System.Drawing.Point(599, 71);
            this.txt_preciotipobus.Name = "txt_preciotipobus";
            this.txt_preciotipobus.ReadOnly = true;
            this.txt_preciotipobus.Size = new System.Drawing.Size(143, 20);
            this.txt_preciotipobus.TabIndex = 23;
            // 
            // txt_preciodestino
            // 
            this.txt_preciodestino.Location = new System.Drawing.Point(242, 165);
            this.txt_preciodestino.Name = "txt_preciodestino";
            this.txt_preciodestino.ReadOnly = true;
            this.txt_preciodestino.Size = new System.Drawing.Size(143, 20);
            this.txt_preciodestino.TabIndex = 22;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(390, 160);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(54, 29);
            this.btn_calcular.TabIndex = 25;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // BoletoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_asiento);
            this.Controls.Add(this.txt_preciotipobus);
            this.Controls.Add(this.txt_preciodestino);
            this.Controls.Add(this.txt_idusuario);
            this.Controls.Add(this.txt_iddestino);
            this.Controls.Add(this.txt_idtipobus);
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
            this.Name = "BoletoView";
            this.Text = "BoletoView";
            this.Load += new System.EventHandler(this.BoletoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_boleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        public System.Windows.Forms.TextBox txt_idusuario;
        public System.Windows.Forms.TextBox txt_iddestino;
        public System.Windows.Forms.TextBox txt_idtipobus;
        public System.Windows.Forms.TextBox txt_asiento;
        public System.Windows.Forms.TextBox txt_preciotipobus;
        public System.Windows.Forms.TextBox txt_preciodestino;
        public System.Windows.Forms.Button btn_calcular;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}