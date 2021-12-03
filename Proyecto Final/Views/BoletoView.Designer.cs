
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoletoView));
            this.dataGridView_boleto = new System.Windows.Forms.DataGridView();
            this.cb_Destino = new System.Windows.Forms.ComboBox();
            this.cb_TipoBus = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_CancelarOp = new Proyecto_Final.Controles_Personalizados.BotonPersonalizado();
            this.btn_NuevoBol = new Proyecto_Final.Controles_Personalizados.BotonPersonalizado();
            this.btn_GuardarBol = new Proyecto_Final.Controles_Personalizados.BotonPersonalizado();
            this.btn_CalcularPT = new Proyecto_Final.Controles_Personalizados.BotonPersonalizado();
            this.txt_NumAsiento = new Proyecto_Final.Controles_Personalizados.TextBoxPersonalizado();
            this.txt_IdDest = new Proyecto_Final.Controles_Personalizados.TextBoxPersonalizado();
            this.txt_PrecioBus = new Proyecto_Final.Controles_Personalizados.TextBoxPersonalizado();
            this.txt_IdTipoB = new Proyecto_Final.Controles_Personalizados.TextBoxPersonalizado();
            this.txt_NombreUs = new Proyecto_Final.Controles_Personalizados.TextBoxPersonalizado();
            this.txt_PrecioT = new Proyecto_Final.Controles_Personalizados.TextBoxPersonalizado();
            this.txt_PrecioDest = new Proyecto_Final.Controles_Personalizados.TextBoxPersonalizado();
            this.txt_IdUs = new Proyecto_Final.Controles_Personalizados.TextBoxPersonalizado();
            this.btn_Eliminar = new Proyecto_Final.Controles_Personalizados.BotonPersonalizado();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_boleto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_boleto
            // 
            this.dataGridView_boleto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_boleto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_boleto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_boleto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dataGridView_boleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_boleto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_boleto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Geomanist Book", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(63)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_boleto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_boleto.ColumnHeadersHeight = 34;
            this.dataGridView_boleto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_boleto.EnableHeadersVisualStyles = false;
            this.dataGridView_boleto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.dataGridView_boleto.Location = new System.Drawing.Point(1, 367);
            this.dataGridView_boleto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_boleto.Name = "dataGridView_boleto";
            this.dataGridView_boleto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Geomanist Book", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_boleto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_boleto.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Geomanist Book", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(255)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.dataGridView_boleto.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_boleto.Size = new System.Drawing.Size(1017, 155);
            this.dataGridView_boleto.TabIndex = 3;
            // 
            // cb_Destino
            // 
            this.cb_Destino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.cb_Destino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Destino.Font = new System.Drawing.Font("Poppins", 10F);
            this.cb_Destino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.cb_Destino.FormattingEnabled = true;
            this.cb_Destino.Location = new System.Drawing.Point(127, 163);
            this.cb_Destino.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Destino.Name = "cb_Destino";
            this.cb_Destino.Size = new System.Drawing.Size(312, 44);
            this.cb_Destino.TabIndex = 4;
            this.cb_Destino.Text = "Seleccione su Destino";
            // 
            // cb_TipoBus
            // 
            this.cb_TipoBus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_TipoBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.cb_TipoBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_TipoBus.Font = new System.Drawing.Font("Poppins", 10F);
            this.cb_TipoBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.cb_TipoBus.FormattingEnabled = true;
            this.cb_TipoBus.Location = new System.Drawing.Point(607, 50);
            this.cb_TipoBus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_TipoBus.Name = "cb_TipoBus";
            this.cb_TipoBus.Size = new System.Drawing.Size(312, 44);
            this.cb_TipoBus.TabIndex = 5;
            this.cb_TipoBus.Text = "Seleccione el Tipo de Bus";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // btn_CancelarOp
            // 
            this.btn_CancelarOp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_CancelarOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_CancelarOp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_CancelarOp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_CancelarOp.BorderRadius = 17;
            this.btn_CancelarOp.BorderSize = 0;
            this.btn_CancelarOp.FlatAppearance.BorderSize = 0;
            this.btn_CancelarOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarOp.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarOp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_CancelarOp.Location = new System.Drawing.Point(778, 258);
            this.btn_CancelarOp.Name = "btn_CancelarOp";
            this.btn_CancelarOp.Size = new System.Drawing.Size(186, 55);
            this.btn_CancelarOp.TabIndex = 40;
            this.btn_CancelarOp.Text = "Cancelar";
            this.btn_CancelarOp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_CancelarOp.UseVisualStyleBackColor = false;
            // 
            // btn_NuevoBol
            // 
            this.btn_NuevoBol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_NuevoBol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_NuevoBol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_NuevoBol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_NuevoBol.BorderRadius = 17;
            this.btn_NuevoBol.BorderSize = 0;
            this.btn_NuevoBol.FlatAppearance.BorderSize = 0;
            this.btn_NuevoBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoBol.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoBol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_NuevoBol.Location = new System.Drawing.Point(577, 258);
            this.btn_NuevoBol.Name = "btn_NuevoBol";
            this.btn_NuevoBol.Size = new System.Drawing.Size(186, 55);
            this.btn_NuevoBol.TabIndex = 39;
            this.btn_NuevoBol.Text = "Nuevo Boleto";
            this.btn_NuevoBol.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_NuevoBol.UseVisualStyleBackColor = false;
            // 
            // btn_GuardarBol
            // 
            this.btn_GuardarBol.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GuardarBol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_GuardarBol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_GuardarBol.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_GuardarBol.BorderRadius = 17;
            this.btn_GuardarBol.BorderSize = 0;
            this.btn_GuardarBol.FlatAppearance.BorderSize = 0;
            this.btn_GuardarBol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarBol.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarBol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_GuardarBol.Location = new System.Drawing.Point(376, 258);
            this.btn_GuardarBol.Name = "btn_GuardarBol";
            this.btn_GuardarBol.Size = new System.Drawing.Size(186, 55);
            this.btn_GuardarBol.TabIndex = 38;
            this.btn_GuardarBol.Text = "Guardar Registro";
            this.btn_GuardarBol.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_GuardarBol.UseVisualStyleBackColor = false;
            // 
            // btn_CalcularPT
            // 
            this.btn_CalcularPT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CalcularPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_CalcularPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_CalcularPT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_CalcularPT.BorderRadius = 17;
            this.btn_CalcularPT.BorderSize = 0;
            this.btn_CalcularPT.FlatAppearance.BorderSize = 0;
            this.btn_CalcularPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CalcularPT.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CalcularPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_CalcularPT.Location = new System.Drawing.Point(747, 152);
            this.btn_CalcularPT.Name = "btn_CalcularPT";
            this.btn_CalcularPT.Size = new System.Drawing.Size(186, 55);
            this.btn_CalcularPT.TabIndex = 37;
            this.btn_CalcularPT.Text = "Calcular";
            this.btn_CalcularPT.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_CalcularPT.UseVisualStyleBackColor = false;
            // 
            // txt_NumAsiento
            // 
            this.txt_NumAsiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_NumAsiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_NumAsiento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.txt_NumAsiento.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            this.txt_NumAsiento.BorderRadius = 0;
            this.txt_NumAsiento.BorderSize = 2;
            this.txt_NumAsiento.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumAsiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_NumAsiento.Location = new System.Drawing.Point(39, 262);
            this.txt_NumAsiento.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NumAsiento.Multiline = false;
            this.txt_NumAsiento.Name = "txt_NumAsiento";
            this.txt_NumAsiento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_NumAsiento.PasswordChar = false;
            this.txt_NumAsiento.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_NumAsiento.PlaceholderText = "Ingrese el Número de Asiento";
            this.txt_NumAsiento.Size = new System.Drawing.Size(317, 51);
            this.txt_NumAsiento.TabIndex = 36;
            this.txt_NumAsiento.Texts = "";
            this.txt_NumAsiento.UnderlinedStyle = true;
            // 
            // txt_IdDest
            // 
            this.txt_IdDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_IdDest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.txt_IdDest.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            this.txt_IdDest.BorderRadius = 0;
            this.txt_IdDest.BorderSize = 2;
            this.txt_IdDest.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdDest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_IdDest.Location = new System.Drawing.Point(39, 156);
            this.txt_IdDest.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdDest.Multiline = false;
            this.txt_IdDest.Name = "txt_IdDest";
            this.txt_IdDest.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_IdDest.PasswordChar = false;
            this.txt_IdDest.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_IdDest.PlaceholderText = "Id";
            this.txt_IdDest.Size = new System.Drawing.Size(64, 51);
            this.txt_IdDest.TabIndex = 35;
            this.txt_IdDest.Texts = "";
            this.txt_IdDest.UnderlinedStyle = true;
            // 
            // txt_PrecioBus
            // 
            this.txt_PrecioBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PrecioBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_PrecioBus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.txt_PrecioBus.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            this.txt_PrecioBus.BorderRadius = 0;
            this.txt_PrecioBus.BorderSize = 2;
            this.txt_PrecioBus.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioBus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_PrecioBus.Location = new System.Drawing.Point(965, 43);
            this.txt_PrecioBus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrecioBus.Multiline = false;
            this.txt_PrecioBus.Name = "txt_PrecioBus";
            this.txt_PrecioBus.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_PrecioBus.PasswordChar = false;
            this.txt_PrecioBus.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_PrecioBus.PlaceholderText = "Precio de Bus";
            this.txt_PrecioBus.Size = new System.Drawing.Size(199, 51);
            this.txt_PrecioBus.TabIndex = 34;
            this.txt_PrecioBus.Texts = "";
            this.txt_PrecioBus.UnderlinedStyle = true;
            // 
            // txt_IdTipoB
            // 
            this.txt_IdTipoB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_IdTipoB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_IdTipoB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.txt_IdTipoB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            this.txt_IdTipoB.BorderRadius = 0;
            this.txt_IdTipoB.BorderSize = 2;
            this.txt_IdTipoB.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdTipoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_IdTipoB.Location = new System.Drawing.Point(498, 43);
            this.txt_IdTipoB.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdTipoB.Multiline = false;
            this.txt_IdTipoB.Name = "txt_IdTipoB";
            this.txt_IdTipoB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_IdTipoB.PasswordChar = false;
            this.txt_IdTipoB.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_IdTipoB.PlaceholderText = "Id";
            this.txt_IdTipoB.Size = new System.Drawing.Size(64, 51);
            this.txt_IdTipoB.TabIndex = 33;
            this.txt_IdTipoB.Texts = "";
            this.txt_IdTipoB.UnderlinedStyle = true;
            // 
            // txt_NombreUs
            // 
            this.txt_NombreUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_NombreUs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.txt_NombreUs.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            this.txt_NombreUs.BorderRadius = 0;
            this.txt_NombreUs.BorderSize = 2;
            this.txt_NombreUs.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NombreUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_NombreUs.Location = new System.Drawing.Point(127, 43);
            this.txt_NombreUs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreUs.Multiline = false;
            this.txt_NombreUs.Name = "txt_NombreUs";
            this.txt_NombreUs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_NombreUs.PasswordChar = false;
            this.txt_NombreUs.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_NombreUs.PlaceholderText = "Nombre";
            this.txt_NombreUs.Size = new System.Drawing.Size(300, 51);
            this.txt_NombreUs.TabIndex = 32;
            this.txt_NombreUs.Texts = "";
            this.txt_NombreUs.UnderlinedStyle = true;
            // 
            // txt_PrecioT
            // 
            this.txt_PrecioT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_PrecioT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_PrecioT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.txt_PrecioT.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            this.txt_PrecioT.BorderRadius = 0;
            this.txt_PrecioT.BorderSize = 2;
            this.txt_PrecioT.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_PrecioT.Location = new System.Drawing.Point(965, 156);
            this.txt_PrecioT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrecioT.Multiline = false;
            this.txt_PrecioT.Name = "txt_PrecioT";
            this.txt_PrecioT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_PrecioT.PasswordChar = false;
            this.txt_PrecioT.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_PrecioT.PlaceholderText = "Precio Total";
            this.txt_PrecioT.Size = new System.Drawing.Size(199, 51);
            this.txt_PrecioT.TabIndex = 31;
            this.txt_PrecioT.Texts = "";
            this.txt_PrecioT.UnderlinedStyle = true;
            // 
            // txt_PrecioDest
            // 
            this.txt_PrecioDest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_PrecioDest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_PrecioDest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.txt_PrecioDest.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            this.txt_PrecioDest.BorderRadius = 0;
            this.txt_PrecioDest.BorderSize = 2;
            this.txt_PrecioDest.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioDest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_PrecioDest.Location = new System.Drawing.Point(475, 156);
            this.txt_PrecioDest.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrecioDest.Multiline = false;
            this.txt_PrecioDest.Name = "txt_PrecioDest";
            this.txt_PrecioDest.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_PrecioDest.PasswordChar = false;
            this.txt_PrecioDest.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_PrecioDest.PlaceholderText = "Precio del Destino";
            this.txt_PrecioDest.Size = new System.Drawing.Size(208, 51);
            this.txt_PrecioDest.TabIndex = 30;
            this.txt_PrecioDest.Texts = "";
            this.txt_PrecioDest.UnderlinedStyle = true;
            // 
            // txt_IdUs
            // 
            this.txt_IdUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.txt_IdUs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.txt_IdUs.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(161)))), ((int)(((byte)(17)))));
            this.txt_IdUs.BorderRadius = 0;
            this.txt_IdUs.BorderSize = 2;
            this.txt_IdUs.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_IdUs.Location = new System.Drawing.Point(39, 43);
            this.txt_IdUs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IdUs.Multiline = false;
            this.txt_IdUs.Name = "txt_IdUs";
            this.txt_IdUs.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_IdUs.PasswordChar = false;
            this.txt_IdUs.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.txt_IdUs.PlaceholderText = "Id";
            this.txt_IdUs.Size = new System.Drawing.Size(64, 51);
            this.txt_IdUs.TabIndex = 29;
            this.txt_IdUs.Texts = "";
            this.txt_IdUs.UnderlinedStyle = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_Eliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_Eliminar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(83)))), ((int)(((byte)(35)))));
            this.btn_Eliminar.BorderRadius = 17;
            this.btn_Eliminar.BorderSize = 0;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Geomanist Book", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_Eliminar.Location = new System.Drawing.Point(978, 258);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(186, 55);
            this.btn_Eliminar.TabIndex = 41;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(242)))), ((int)(((byte)(237)))));
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.p6;
            this.pictureBox1.Location = new System.Drawing.Point(1025, 333);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // BoletoView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1200, 523);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_CancelarOp);
            this.Controls.Add(this.btn_NuevoBol);
            this.Controls.Add(this.btn_GuardarBol);
            this.Controls.Add(this.btn_CalcularPT);
            this.Controls.Add(this.txt_NumAsiento);
            this.Controls.Add(this.txt_IdDest);
            this.Controls.Add(this.txt_PrecioBus);
            this.Controls.Add(this.txt_IdTipoB);
            this.Controls.Add(this.txt_NombreUs);
            this.Controls.Add(this.txt_PrecioT);
            this.Controls.Add(this.txt_PrecioDest);
            this.Controls.Add(this.txt_IdUs);
            this.Controls.Add(this.cb_TipoBus);
            this.Controls.Add(this.cb_Destino);
            this.Controls.Add(this.dataGridView_boleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BoletoView";
            this.Text = "BoletoView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_boleto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView_boleto;
        public System.Windows.Forms.ComboBox cb_Destino;
        public System.Windows.Forms.ComboBox cb_TipoBus;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        public Controles_Personalizados.TextBoxPersonalizado txt_PrecioT;
        public Controles_Personalizados.TextBoxPersonalizado txt_PrecioDest;
        public Controles_Personalizados.TextBoxPersonalizado txt_IdUs;
        public Controles_Personalizados.TextBoxPersonalizado txt_PrecioBus;
        public Controles_Personalizados.TextBoxPersonalizado txt_IdTipoB;
        public Controles_Personalizados.TextBoxPersonalizado txt_NombreUs;
        public Controles_Personalizados.TextBoxPersonalizado txt_NumAsiento;
        public Controles_Personalizados.TextBoxPersonalizado txt_IdDest;
        public Controles_Personalizados.BotonPersonalizado btn_CalcularPT;
        public Controles_Personalizados.BotonPersonalizado btn_CancelarOp;
        public Controles_Personalizados.BotonPersonalizado btn_NuevoBol;
        public Controles_Personalizados.BotonPersonalizado btn_GuardarBol;
        public Controles_Personalizados.BotonPersonalizado btn_Eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}