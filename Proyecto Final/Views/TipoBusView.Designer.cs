
namespace Proyecto_Final.Views
{
    partial class TipoBusView
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_listar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dataGridView_TipoBus = new System.Windows.Forms.DataGridView();
            this.errorProvider_tipobus = new System.Windows.Forms.ErrorProvider(this.components);
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TipoBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_tipobus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(107, 180);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(113, 23);
            this.btn_listar.TabIndex = 6;
            this.btn_listar.Text = "Guardar Bus";
            this.btn_listar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(262, 180);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(113, 23);
            this.btn_Modificar.TabIndex = 7;
            this.btn_Modificar.Text = "Modificar Registro";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(433, 180);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(113, 23);
            this.btn_Eliminar.TabIndex = 8;
            this.btn_Eliminar.Text = "Eliminar Registro";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(591, 180);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(113, 23);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // dataGridView_TipoBus
            // 
            this.dataGridView_TipoBus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_TipoBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TipoBus.Location = new System.Drawing.Point(12, 223);
            this.dataGridView_TipoBus.Name = "dataGridView_TipoBus";
            this.dataGridView_TipoBus.Size = new System.Drawing.Size(776, 215);
            this.dataGridView_TipoBus.TabIndex = 10;
            // 
            // errorProvider_tipobus
            // 
            this.errorProvider_tipobus.ContainerControl = this;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(123, 94);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(139, 20);
            this.txt_Descripcion.TabIndex = 11;
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(433, 94);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(134, 20);
            this.Txt_Precio.TabIndex = 12;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(21, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(20, 20);
            this.txt_id.TabIndex = 13;
            // 
            // TipoBusView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.Txt_Precio);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.dataGridView_TipoBus);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_listar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TipoBusView";
            this.Text = "TipoBusView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TipoBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_tipobus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btn_listar;
        public System.Windows.Forms.Button btn_Modificar;
        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.DataGridView dataGridView_TipoBus;
        public System.Windows.Forms.ErrorProvider errorProvider_tipobus;
        public System.Windows.Forms.TextBox Txt_Precio;
        public System.Windows.Forms.TextBox txt_Descripcion;
        public System.Windows.Forms.TextBox txt_id;
    }
}