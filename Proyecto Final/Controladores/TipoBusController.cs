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
            vista.btn_Modificar.Click += new EventHandler(Modificar);

        }

        private void Eliminar(object sender, EventArgs e)
        {
            if (vista.dataGridView_TipoBus.SelectedRows.Count > 0)
            {
                bool elimino = tipoBusDAO.EliminarTipo(Convert.ToInt32(vista.dataGridView_TipoBus.CurrentRow.Cells["IdTipoBus"].Value));
                if (elimino)
                {
                    MessageBox.Show("Elimino Exitosamente");
                    ListarTipos();
                }
                else
                {
                    MessageBox.Show("No se elimino");
                }
            }

        }
        /*
        private void Nuevo(object sender, EventArgs e)
        {
            //HabilitarComandos();
            operacion = "Nuevo";
        }
        */
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

            tipoBus.Descripcion = vista.txt_Descripcion.Text;
            tipoBus.Precio = Convert.ToDecimal(vista.Txt_Precio.Text);


           
                bool inserto = tipoBusDAO.InsertarNuevoTipoBus(tipoBus);
                if (inserto)
                {

                    MessageBox.Show("Datos Insertados Exitosamente");
                    LimpiarComandos();
                    vista.txt_Descripcion.Clear();
                    vista.Txt_Precio.Clear();
                    ListarTipos();

                }
                else
                {
                    MessageBox.Show("No Inserto");
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
            LimpiarComandos();
        }

        private void LimpiarComandos()
        {
            vista.txt_Descripcion.Clear();
            vista.Txt_Precio.Clear();
        }

        private void Modificar(object sender, EventArgs e)
        {
            if (vista.dataGridView_TipoBus.SelectedRows.Count > 0)
            {
                operacion = "Modificar";

                vista.txt_id.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["IdTipoBus"].Value.ToString();
                vista.txt_Descripcion.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["Descripcion"].Value.ToString();
                vista.Txt_Precio.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["Precio"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro");
            }


        }


    }

}
