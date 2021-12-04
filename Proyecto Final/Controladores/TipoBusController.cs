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
            vista.Load += new EventHandler(Load);
            vista.btn_GuardarBus.Click += new EventHandler(Guardar);
            vista.btn_NuevoBus.Click += new EventHandler(Nuevo);
            vista.btn_ModificarReg.Click += new EventHandler(Modificar);
            vista.btn_EliminarReg.Click += new EventHandler(Eliminar);
            vista.btn_CancelarOp.Click += new EventHandler(Cancelar);
            vista.txt_PrecioB.KeyPress += new KeyPressEventHandler(ValidarPrecio);

        }

        private void Cancelar(object sender, EventArgs e)
        {
            vista.errorProvider_tipobus.SetError(vista.txt_DescripcionB, null);
            vista.errorProvider_tipobus.SetError(vista.txt_PrecioB, null);
            DesabilitarControles();
            LimpiarComandos();
            ReiniciarPlaceHolders();
            tipoBus = null;
        }

        private void Load(object sender, EventArgs e)
        {
            ListarTipos();
            vista.txt_DescripcionB.Enabled = false;
            vista.txt_PrecioB.Enabled = false;
            vista.txt_IdB.Enabled = false;
        }

        private void ListarTipos()
        {
            vista.dataGridView_TipoBus.DataSource = tipoBusDAO.GetTipoBus();
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
                else MessageBox.Show("No se elimino");
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
                vista.errorProvider_tipobus.SetError(vista.txt_DescripcionB, "Llene el campo");
                vista.txt_DescripcionB.Focus();
                return;
            }
            else vista.errorProvider_tipobus.SetError(vista.txt_DescripcionB, null);

            if (vista.txt_PrecioB.Texts == "")
            {
                vista.errorProvider_tipobus.SetError(vista.txt_PrecioB, "Llene el campo");
                vista.txt_PrecioB.Focus();
                return;
            }
            else vista.errorProvider_tipobus.SetError(vista.txt_PrecioB, null);

            TipoBusDAO tipoBusDAO = new TipoBusDAO();
            TipoBus tipoBus = new TipoBus();

            tipoBus.Descripcion = vista.txt_DescripcionB.Texts;
            tipoBus.Precio = Convert.ToDecimal(vista.txt_PrecioB.Texts);

            if (operacion == "Nuevo")
            {
                bool inserto = tipoBusDAO.InsertarNuevoTipoBus(tipoBus);
                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarComandos();
                    ListarTipos();
                    ReiniciarPlaceHolders();
                    MessageBox.Show("Datos Insertados Exitosamente");
                }
                else MessageBox.Show("No Inserto");
            }
            else if (operacion == "Modificar")
            {
                tipoBus.IdTipoBus = Convert.ToInt32(vista.txt_IdB.Text);
                bool modifico = tipoBusDAO.ActualizarTipoBus(tipoBus);
                if (modifico)
                {
                    DesabilitarControles();
                    LimpiarComandos();
                    ListarTipos();
                    ReiniciarPlaceHolders();
                    MessageBox.Show("Destino modificado exitosamente");
                }
                else MessageBox.Show("Destino no se modifico");
            }
        }

        private void LimpiarComandos()
        {
            vista.txt_IdB.Clear();
            vista.txt_DescripcionB.Clear();
            vista.txt_PrecioB.Clear();
        }

        private void Modificar(object sender, EventArgs e)
        {

            operacion = "Modificar";
            if (vista.dataGridView_TipoBus.SelectedRows.Count > 0)
            {
                vista.txt_DescripcionB.Texts = string.Empty;
                vista.txt_PrecioB.Texts = string.Empty;
                vista.txt_IdB.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["IdTipoBus"].Value.ToString();
                vista.txt_DescripcionB.Texts = vista.dataGridView_TipoBus.CurrentRow.Cells["Descripcion"].Value.ToString();
                vista.txt_PrecioB.Text = vista.dataGridView_TipoBus.CurrentRow.Cells["Precio"].Value.ToString();

                HabilitarControles();
            }
            else MessageBox.Show("Debe seleccionar un registro");
        }

        private void HabilitarControles()
        {
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
            vista.txt_DescripcionB.Texts = "Ingrese la Descripción";
            vista.txt_PrecioB.Texts = "Ingrese el Precio";
            vista.txt_IdB.Text = "Aquí Aparecerá el Id";
        }

        private void ValidarPrecio(object sender, KeyPressEventArgs e)
        {
            SoloNumerosEnteros.Comprobar(e);
        }
    }

}
