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
    public class DestinoController
    {
        DestinoView vista;
        string operacion = string.Empty;
        DestinoDAO destDAO = new DestinoDAO();
        Destino dest = new Destino();

        public DestinoController(DestinoView view)
        {
            vista = view;
            //vista.btn_nuevo.Click += new EventHandler(Nuevo);
            vista.btn_NuevoDest.Click += new EventHandler(Nuevo);
            //vista.btn_listarDestino.Click += new EventHandler(Guardar);
            vista.btn_GuardarDestino.Click += new EventHandler(Guardar);
            vista.Load += new EventHandler(Load);
            //vista.btn_Modificar.Click += new EventHandler(Modificar);
            vista.btn_ModificarReg.Click += new EventHandler(Modificar);
            //vista.btn_Eliminar.Click += new EventHandler(Eliminar);
            vista.btn_EliminarReg.Click += new EventHandler(Eliminar);
            //vista.btn_Cancelar.Click += new EventHandler(Cancelar);
            vista.btn_CancelarOp.Click += new EventHandler(Cancelar);
            vista.txt_PrecioD.KeyPress += new KeyPressEventHandler(ValidarPrecio);
        }

        private void Cancelar(object sender, EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
            ReiniciarPlaceHolders();
            dest = null;
        }
        private void Load(object sender, EventArgs e)
        {
            ListarDestino();
            vista.txt_DescripcionD.Enabled = false;
            vista.txt_PrecioD.Enabled = false;
            vista.txt_IdDes.Enabled = false;
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
                }
                else MessageBox.Show("Destino no se elimino");
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
            if (vista.txt_DescripcionD.Texts == "")
            {
                vista.errorProvider1.SetError(vista.txt_DescripcionD, "Ingrese una descripción de destino");
                vista.txt_DescripcionD.Focus();
                return;
            }
            if (vista.txt_PrecioD.Texts == "")
            {
                vista.errorProvider1.SetError(vista.txt_PrecioD, "Ingrese un precio");
                vista.txt_PrecioD.Focus();
                return;
            }

            DestinoDAO destDAO = new DestinoDAO();
            Destino dest = new Destino();

            //dest.Destinos = vista.txt_Descripcion.Text;
            //dest.PRECIO = Convert.ToDecimal(vista.Txt_Precio.Text);
            dest.Destinos = vista.txt_DescripcionD.Texts;
            dest.PRECIO = Convert.ToDecimal(vista.txt_PrecioD.Texts);

            if (operacion == "Nuevo")
            {
                bool inserto = destDAO.InsertarNuevoDestino(dest);
                if (inserto)
                {
                    DesabilitarControles();
                    LimpiarControles();
                    ListarDestino();
                    MessageBox.Show("Destino creado exitosamente");
                }
                else
                {
                    MessageBox.Show("No se pudo crear el destino");
                }
            }
            else if (operacion == "Modificar")
            {
                dest.ID = Convert.ToInt32(vista.txt_IdDes.Text);
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
                //vista.txt_IdD.Text = vista.dataGridView_Destino.CurrentRow.Cells["IdDestino"].Value.ToString();
                vista.txt_IdDes.Texts = vista.dataGridView_Destino.CurrentRow.Cells["IdDestino"].Value.ToString();
                //vista.txt_Descripcion.Text = vista.dataGridView_Destino.CurrentRow.Cells["Destino"].Value.ToString();
                vista.txt_DescripcionD.Texts = vista.dataGridView_Destino.CurrentRow.Cells["Destino"].Value.ToString();
                //vista.Txt_Precio.Text = vista.dataGridView_Destino.CurrentRow.Cells["Precio"].Value.ToString();
                vista.txt_PrecioD.Texts = vista.dataGridView_Destino.CurrentRow.Cells["Precio"].Value.ToString();

                HabilitarControles();
            }
            else MessageBox.Show("Seleccione un registro");
        }

        private void LimpiarControles()
        {
            //vista.txt_IdD.Clear();
            //vista.txt_Descripcion.Clear();
            //vista.Txt_Precio.Clear();
            vista.txt_IdDes.Clear();
            vista.txt_DescripcionD.Clear();
            vista.txt_PrecioD.Clear();
        }

        private void HabilitarControles()
        {
            //vista.txt_Descripcion.Enabled = true;
            //vista.Txt_Precio.Enabled = true;
            //vista.btn_listarDestino.Enabled = true;
            //vista.btn_Cancelar.Enabled = true;
            //vista.btn_Modificar.Enabled = false;
            //vista.btn_nuevo.Enabled = false;
            //vista.btn_Eliminar.Enabled = false;

            vista.txt_DescripcionD.Enabled = true;
            vista.txt_PrecioD.Enabled = true;
            vista.btn_GuardarDestino.Enabled = true;
            vista.btn_CancelarOp.Enabled = true;
            vista.btn_ModificarReg.Enabled = false;
            vista.btn_NuevoDest.Enabled = false;
            vista.btn_EliminarReg.Enabled = false;
        }

        private void DesabilitarControles()
        {
            //vista.txt_Descripcion.Enabled = false;
            //vista.Txt_Precio.Enabled = false;
            //vista.btn_listarDestino.Enabled = false;
            //vista.btn_Cancelar.Enabled = false;
            //vista.btn_Modificar.Enabled = true;
            //vista.btn_Eliminar.Enabled = true;
            //vista.btn_nuevo.Enabled = true;

            vista.txt_DescripcionD.Enabled = false;
            vista.txt_PrecioD.Enabled = false;
            vista.btn_GuardarDestino.Enabled = false;
            vista.btn_CancelarOp.Enabled = false;
            vista.btn_ModificarReg.Enabled = true;
            vista.btn_EliminarReg.Enabled = true;
            vista.btn_NuevoDest.Enabled = true;

        }

        private void ReiniciarPlaceHolders()
        {
            vista.txt_DescripcionD.PlaceholderText = "Ingrese la Descripción";
            vista.txt_PrecioD.PlaceholderText = "Ingrese el Precio";
            vista.txt_IdDes.PlaceholderText = "Aquí Aparecerá el Id";
        }

        private void ValidarPrecio(object sender, KeyPressEventArgs e)
        {
            SoloNumerosEnteros.Comprobar(e);
        }

    }
}
