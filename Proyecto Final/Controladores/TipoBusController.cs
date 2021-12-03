using Proyecto_Final.Modelos.DAO;
using Proyecto_Final.Modelos.Entidades;
using Proyecto_Final.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proyecto_Final.Adicionales.ValidarTextBoxs;

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
            //vista.btn_listar.Click += new EventHandler(Guardar);
            vista.btn_GuardarBus.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            //vista.btn_Eliminar.Click += new EventHandler(Eliminar);
            vista.btn_EliminarReg.Click += new EventHandler(Eliminar);
            //vista.btn_Cancelar.Click += new EventHandler(Cancelar);
            vista.btn_CancelarOp.Click += new EventHandler(Cancelar);
            //vista.btn_nuevo.Click += new EventHandler(Nuevo);
            vista.btn_NuevoBus.Click += new EventHandler(Nuevo);
            //vista.btn_Modificar.Click += new EventHandler(Modificar);
            vista.btn_ModificarReg.Click += new EventHandler(Modificar);
            vista.txt_PrecioB.KeyPress += new KeyPressEventHandler(ValidarPrecio);

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
            ReiniciarPlaceHolders();
            operacion = "Nuevo";
        }
       
        private void Guardar(object sender, EventArgs e)
        {
            
            if (vista.txt_DescripcionB.Texts == "")
            {
                //vista.errorProvider_tipobus.SetError(vista.txt_Descripcion, "Llene el campo");
                //vista.txt_Descripcion.Focus();
                vista.errorProvider_tipobus.SetError(vista.txt_DescripcionB, "Llene el campo");
                vista.txt_DescripcionB.Focus();
                return;
            }

            if (vista.txt_PrecioB.Texts == "")
            {
                //vista.errorProvider_tipobus.SetError(vista.Txt_Precio, "Llene el campo");
                vista.errorProvider_tipobus.SetError(vista.txt_PrecioB, "Llene el campo");
                //vista.txt_Descripcion.Focus();
                vista.txt_PrecioB.Focus();
                return;
            }

            TipoBusDAO tipoBusDAO = new TipoBusDAO();
            TipoBus tipoBus = new TipoBus();

            //tipoBus.Descripcion = vista.txt_Descripcion.Text;
            tipoBus.Descripcion = vista.txt_DescripcionB.Texts;
            //tipoBus.Precio = Convert.ToDecimal(vista.Txt_Precio.Text);
            tipoBus.Precio = Convert.ToDecimal(vista.txt_PrecioB.Texts);

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
                //tipoBus.IdTipoBus = Convert.ToInt32(vista.txt_id.Text);
                tipoBus.IdTipoBus = Convert.ToInt32(vista.txt_IdB.Texts);
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
            vista.txt_DescripcionB.Enabled = false;
            vista.txt_PrecioB.Enabled = false;
            vista.txt_IdB.Enabled = false;
        }

        private void Cancelar(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarComandos();
            ReiniciarPlaceHolders();
            tipoBus = null;
        }

        private void LimpiarComandos()
        {
            //vista.txt_id.Clear();
            vista.txt_IdB.Clear();
            vista.txt_DescripcionB.Clear();
            vista.txt_PrecioB.Clear();
            //vista.txt_Descripcion.Clear();
            //vista.Txt_Precio.Clear();
        }

        private void Modificar(object sender, EventArgs e)
        {

            operacion = "Modificar";
            if (vista.dataGridView_TipoBus.SelectedRows.Count > 0)
            {
                //vista.txt_id.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["IdTipoBus"].Value.ToString();
                vista.txt_IdB.Texts = vista.dataGridView_TipoBus.CurrentRow.Cells["IdTipoBus"].Value.ToString();
                //vista.txt_Descripcion.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["Descripcion"].Value.ToString();
                vista.txt_DescripcionB.Texts = vista.dataGridView_TipoBus.CurrentRow.Cells["Descripcion"].Value.ToString();
                //vista.Txt_Precio.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["Precio"].Value.ToString();
                vista.txt_PrecioB.Texts = vista.dataGridView_TipoBus.CurrentRow.Cells["Precio"].Value.ToString();

                HabilitarControles();
            }
            else MessageBox.Show("Debe seleccionar un registro");
        }

        private void HabilitarControles()
        {
            //vista.txt_Descripcion.Enabled = true;
            //vista.Txt_Precio.Enabled = true;
            //vista.btn_listar.Enabled = true;
            //vista.btn_Cancelar.Enabled = true;
            //vista.btn_Modificar.Enabled = false;
            //vista.btn_nuevo.Enabled = false;
            //vista.btn_Eliminar.Enabled = false;

            vista.txt_DescripcionB.Enabled = true;
            vista.txt_PrecioB.Enabled = true;
            vista.btn_GuardarBus.Enabled = true;
            vista.btn_CancelarOp.Enabled = true;
            vista.btn_ModificarReg.Enabled = false;
            vista.btn_NuevoBus.Enabled = false;
            vista.btn_EliminarReg.Enabled = false;

        }

        private void DesabilitarControles()
        {
            //vista.txt_Descripcion.Enabled = false;
            //vista.Txt_Precio.Enabled = false;
            //vista.btn_listar.Enabled = false;
            //vista.btn_Cancelar.Enabled = false;
            //vista.btn_Modificar.Enabled = true;
            //vista.btn_Eliminar.Enabled = true;
            //vista.btn_nuevo.Enabled = true;

            vista.txt_DescripcionB.Enabled = false;
            vista.txt_PrecioB.Enabled = false;
            vista.btn_GuardarBus.Enabled = false;
            vista.btn_CancelarOp.Enabled = false;
            vista.btn_ModificarReg.Enabled = true;
            vista.btn_EliminarReg.Enabled = true;
            vista.btn_NuevoBus.Enabled = true;

        }

        private void ReiniciarPlaceHolders()
        {
            vista.txt_DescripcionB.PlaceholderText = "Ingrese la Descripción";
            vista.txt_PrecioB.PlaceholderText = "Ingrese el Precio";
            vista.txt_IdB.PlaceholderText = "Aquí Aparecerá el Id";
        }

        private void ValidarPrecio(object sender, KeyPressEventArgs e)
        {
            SoloNumerosEnteros.Comprobar(e);
        }


    }

}
