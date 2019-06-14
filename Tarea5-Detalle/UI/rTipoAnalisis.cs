using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea5_Detalle.BLL;
using Tarea5_Detalle.Entidades;

namespace Tarea5_Detalle.UI
{
    public partial class rTipoAnalisis : Form
    {
        public rTipoAnalisis()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            TipoAnalisis tipo = new TipoAnalisis();
            tipo = LlenarClase();

            try
            {
                if (TipoAnalisisBLL.Buscar((int)IdnumericUpDown.Value) != null)
                {
                    TipoAnalisisBLL.Modificar(tipo);
                    MessageBox.Show("Modificado Correctamente");
                    Limpiar();
                }
                else
                {
                    if (IdnumericUpDown.Value == 0)
                    {
                        if(!TipoAnalisisBLL.Duplicado(DescripciontextBox.Text))
                        {
                            TipoAnalisisBLL.Guardar(tipo);
                            MessageBox.Show("Se guardo correctamente");
                            Limpiar();
                        }
                        else
                        {
                            errorProvider.SetError(DescripciontextBox,"Este Tipo ya existe");
                        }
                        
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un erro");
            }

        }

        private TipoAnalisis LlenarClase()
        {
            TipoAnalisis tipo = new TipoAnalisis();

            tipo.TipoAnalisisId = (int)IdnumericUpDown.Value;
            tipo.Descripcion = DescripciontextBox.Text;

            return tipo;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if(string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox,"Este campo no puede estar en blanco");
                paso = false;
            }


            return paso;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TipoAnalisisBLL.Buscar((int)IdnumericUpDown.Value) == null)
                {
                    MessageBox.Show("No se puede eliminar un tipo de analisis que no existe");
                }
                else
                {
                    TipoAnalisisBLL.Eliminar((int)IdnumericUpDown.Value);
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            TipoAnalisis tipo = new TipoAnalisis();

            try
            {
                tipo = TipoAnalisisBLL.Buscar((int)IdnumericUpDown.Value);

                if (tipo != null)
                {
                    Limpiar();
                    LlenarCampos(tipo);
                }
                else
                {
                    MessageBox.Show("Tipo de analisis no encontrado");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error");
            }

            
        }

        private void LlenarCampos(TipoAnalisis tipo)
        {
            IdnumericUpDown.Value = tipo.TipoAnalisisId;
            DescripciontextBox.Text = tipo.Descripcion;
        }
    }
}
