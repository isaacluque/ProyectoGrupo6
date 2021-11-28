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
    public class TipoBusController
    {
        TipoBusView vista;
        string operacion = string.Empty;
        TipoBusDAO tipoBusDAO = new TipoBusDAO();
        TipoBus tipoBus = new TipoBus();

        public TipoBusController(TipoBusView view)
        {
            vista = view;
            vista.btn_listar.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            vista.btn_Eliminar.Click += new EventHandler(Eliminar);
            vista.btn_Cancelar.Click += new EventHandler(Cancelar);
            vista.btn_nuevo.Click += new EventHandler(Nuevo);
            vista.btn_Modificar.Click += new EventHandler(Modificar);

        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.dataGridView_TipoBus.SelectedRows.Count > 0)
            {
                bool elimino = tipoBusDAO.EliminarTipo(Convert.ToInt32(vista.dataGridView_TipoBus.CurrentRow.Cells["IdTipoBus"].Value));
                if (elimino)
                {
                    DesabilitarControles();
                    LimpiarComandos();
                    MessageBox.Show("Elimino Exitosamente");
                    ListarTipos();
                }
                else
                {
                    MessageBox.Show("No se elimino");
                }
            }

        }
        
        private void Nuevo(object sender, EventArgs e)
        {
            HabilitarControles();
            operacion = "Nuevo";
        }
       
        private void Guardar(object sender, EventArgs e)
        {
            
            if (vista.txt_Descripcion.Text == " ")
            {
                vista.errorProvider_tipobus.SetError(vista.txt_Descripcion, "Llene el campo");
                vista.txt_Descripcion.Focus();
                return;
            }

            if (vista.Txt_Precio.Text == " ")
            {
                vista.errorProvider_tipobus.SetError(vista.Txt_Precio, "Llene el campo");
                vista.txt_Descripcion.Focus();
                return;
            }

            TipoBusDAO tipoBusDAO = new TipoBusDAO();
            TipoBus tipoBus = new TipoBus();

            tipoBus.Descripcion = vista.txt_Descripcion.Text;
            tipoBus.Precio = Convert.ToDecimal(vista.Txt_Precio.Text);

            if (operacion == "Nuevo")
            {
                bool inserto = tipoBusDAO.InsertarNuevoTipoBus(tipoBus);
                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarComandos();
                    ListarTipos();
                    MessageBox.Show("Datos Insertados Exitosamente");
                }
                else
                {
                    MessageBox.Show("No Inserto");
                }
            }
            else if (operacion == "Modificar")
            {
                tipoBus.IdTipoBus = Convert.ToInt32(vista.txt_id.Text);
                bool modifico = tipoBusDAO.ActualizarTipoBus(tipoBus);
                if (modifico)
                {
                    DesabilitarControles();
                    LimpiarComandos();
                    ListarTipos();
                    MessageBox.Show("Destino modificado exitosamente");
                }
                else
                {
                    MessageBox.Show("Destino no se modifico");
                }
            }



        }

        private void ListarTipos()
        {
            vista.dataGridView_TipoBus.DataSource = tipoBusDAO.GetTipoBus();
        }

        private void Load(object sender, EventArgs e)
        {
            ListarTipos();
        }

        private void Cancelar(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarComandos();
            tipoBus = null;
        }

        private void LimpiarComandos()
        {
            vista.txt_id.Clear();
            vista.txt_Descripcion.Clear();
            vista.Txt_Precio.Clear();
        }

        private void Modificar(object sender, EventArgs e)
        {

            operacion = "Modificar";
            if (vista.dataGridView_TipoBus.SelectedRows.Count > 0)
            {
                vista.txt_id.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["IdTipoBus"].Value.ToString();
                vista.txt_Descripcion.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["Descripcion"].Value.ToString();
                vista.Txt_Precio.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["Precio"].Value.ToString();

                HabilitarControles();
            }
            else MessageBox.Show("Debe seleccionar un registro");
        }

        private void HabilitarControles()
        {
            vista.txt_Descripcion.Enabled = true;
            vista.Txt_Precio.Enabled = true;

            vista.btn_listar.Enabled = true;
            vista.btn_Cancelar.Enabled = true;
            vista.btn_Modificar.Enabled = false;
            vista.btn_nuevo.Enabled = false;
            vista.btn_Eliminar.Enabled = false;
        }

        private void DesabilitarControles()
        {
            vista.txt_Descripcion.Enabled = false;
            vista.Txt_Precio.Enabled = false;

            vista.btn_listar.Enabled = false;
            vista.btn_Cancelar.Enabled = false;
            vista.btn_Modificar.Enabled = true;
            vista.btn_Eliminar.Enabled = true;
            vista.btn_nuevo.Enabled = true;

        }

     
    }

}
