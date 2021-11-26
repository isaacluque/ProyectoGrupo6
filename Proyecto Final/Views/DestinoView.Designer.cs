﻿
namespace Proyecto_Final.Views
{
    partial class DestinoView
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
            this.dataGridView_Destino = new System.Windows.Forms.DataGridView();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_listarDestino = new System.Windows.Forms.Button();
            this.Txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Destino)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Destino
            // 
            this.dataGridView_Destino.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_Destino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Destino.Location = new System.Drawing.Point(12, 202);
            this.dataGridView_Destino.Name = "dataGridView_Destino";
            this.dataGridView_Destino.Size = new System.Drawing.Size(776, 215);
            this.dataGridView_Destino.TabIndex = 19;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(591, 159);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(113, 23);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Location = new System.Drawing.Point(433, 159);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(113, 23);
            this.btn_Eliminar.TabIndex = 17;
            this.btn_Eliminar.Text = "Eliminar Registro";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Location = new System.Drawing.Point(262, 159);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(113, 23);
            this.btn_Modificar.TabIndex = 16;
            this.btn_Modificar.Text = "Modificar Registro";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // btn_listarDestino
            // 
            this.btn_listarDestino.Location = new System.Drawing.Point(76, 159);
            this.btn_listarDestino.Name = "btn_listarDestino";
            this.btn_listarDestino.Size = new System.Drawing.Size(144, 23);
            this.btn_listarDestino.TabIndex = 15;
            this.btn_listarDestino.Text = "Listrar Nuevo Destino";
            this.btn_listarDestino.UseVisualStyleBackColor = true;
            // 
            // Txt_Precio
            // 
            this.Txt_Precio.Location = new System.Drawing.Point(433, 69);
            this.Txt_Precio.Name = "Txt_Precio";
            this.Txt_Precio.Size = new System.Drawing.Size(126, 20);
            this.Txt_Precio.TabIndex = 14;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.Location = new System.Drawing.Point(123, 69);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(114, 20);
            this.txt_Descripcion.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Descripcion";
            // 
            // DestinoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Destino);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_listarDestino);
            this.Controls.Add(this.Txt_Precio);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DestinoView";
            this.Text = "DestinoView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Destino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView_Destino;
        public System.Windows.Forms.Button btn_Cancelar;
        public System.Windows.Forms.Button btn_Eliminar;
        public System.Windows.Forms.Button btn_Modificar;
        public System.Windows.Forms.Button btn_listarDestino;
        public System.Windows.Forms.TextBox Txt_Precio;
        public System.Windows.Forms.TextBox txt_Descripcion;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
    }
}