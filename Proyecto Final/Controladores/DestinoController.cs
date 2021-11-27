using Proyecto_Final.Modelos.DAO;
using Proyecto_Final.Modelos.Entidades;
using Proyecto_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.Controladores
{
    public class DestinoController
    {
        DestinoView vista;
        string operacion = string.Empty;
        DestinoDAO destDAO = new DestinoDAO();
        Destino dest = new Destino();

        public DestinoController(DestinoView view)
        {
            vista = view;
            vista.btn_nuevo.Click += new EventHandler(Nuevo);
            vista.btn_listarDestino.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.btn_Modificar.Click += new EventHandler(Modificar);
            vista.btn_Eliminar.Click += new EventHandler(Eliminar);
            vista.btn_Cancelar.Click += new EventHandler(Cancelar);
        }

        private void Cancelar(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
            dest = null;
        }
        private void Load(object sender, EventArgs e)
        {
            ListarDestino();
        }

        private void ListarDestino()
        {
            vista.dataGridView_Destino.DataSource = destDAO.GetDestino();
        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.dataGridView_Destino.SelectedRows.Count > 0)
            {
                bool elimino = destDAO.EliminarDestino(Convert.ToInt32(vista.dataGridView_Destino.CurrentRow.Cells["IdDestino"].Value));
                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    MessageBox.Show("Destino eliminado exitosamente");
                    ListarDestino();
                    operacion = string.Empty;
                }
                else MessageBox.Show("Destino no se elimino");
            }
        }

        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }

        private void Guardar(object sender, EventArgs e)
        {
            if (vista.txt_Descripcion.Text == "")
            {
                vista.errorProvider1.SetError(vista.txt_Descripcion, "Ingrese una descripción de destino");
                vista.txt_Descripcion.Focus();
                return;
            }
            if (vista.Txt_Precio.Text == "")
            {
                vista.errorProvider1.SetError(vista.Txt_Precio, "Ingrese un precio");
                vista.Txt_Precio.Focus();
                return;
            }

            DestinoDAO destDAO = new DestinoDAO();
            Destino dest = new Destino();

            dest.Destinos = vista.txt_Descripcion.Text;
            dest.PRECIO = Convert.ToDecimal(vista.Txt_Precio.Text);

            if (operacion == "Nuevo")
            {
                bool inserto = destDAO.InsertarNuevoDestino(dest);
                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    ListarDestino();
                    MessageBox.Show("Cliente creado exitosamente");
                }
                else
                {
                    MessageBox.Show("Cliente creado exitosamente");
                }
            }
            else if (operacion == "Modificar")
            {
                dest.ID = Convert.ToInt32(vista.txt_Id.Text);
                bool modifico = destDAO.ActualizarDestino(dest);
                if (modifico)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    ListarDestino();
                    MessageBox.Show("Destino modificado exitosamente");
                }
                else
                {
                    MessageBox.Show("Destino no se modifico");
                }
            }
        }

        private void Modificar(object sender, EventArgs e)
        {
            operacion = "Modificar";
            if (vista.dataGridView_Destino.SelectedRows.Count > 0)
            {
                vista.txt_Id.Text = vista.dataGridView_Destino.CurrentRow.Cells["IdDestino"].Value.ToString();
                vista.txt_Descripcion.Text = vista.dataGridView_Destino.CurrentRow.Cells["Destino"].Value.ToString();
                vista.Txt_Precio.Text = vista.dataGridView_Destino.CurrentRow.Cells["Precio"].Value.ToString();

                HabilitarControles();
            }
            else MessageBox.Show("Seleccione un registro");
        }

        private void LimpiarControles()
        {
            vista.txt_Id.Clear();
            vista.txt_Descripcion.Clear();
            vista.Txt_Precio.Clear();
        }

        private void HabilitarControles()
        {
            vista.txt_Descripcion.Enabled = true;
            vista.Txt_Precio.Enabled = true;

            vista.btn_listarDestino.Enabled = true;
            vista.btn_Cancelar.Enabled = true;
            vista.btn_Modificar.Enabled = false;
            vista.btn_nuevo.Enabled = false;
            vista.btn_Eliminar.Enabled = false;
        }

        private void DesabilitarControles()
        {
            vista.txt_Descripcion.Enabled = false;
            vista.Txt_Precio.Enabled = false;

            vista.btn_listarDestino.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Eliminar.Enabled = true;
            vista.btn_nuevo.Enabled = true;

        }
    }
}
