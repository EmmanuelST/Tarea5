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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
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
            NombretextBox.Text = string.Empty;
            EmailtextBox.Text = string.Empty;
            UsuariotextBox.Text = string.Empty;
            ClavetextBox.Text = string.Empty;
            FechaIngresodateTimePicker.Value = DateTime.Now;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (!Validar())
                return;

            Usuarios usuario = new Usuarios();
            usuario = LlenarClase();

            try
            {
                if (UsuariosBLL.Buscar((int)IdnumericUpDown.Value) != null)
                {
                    UsuariosBLL.Modificar(usuario);
                    MessageBox.Show("Modificado correctamente");
                    Limpiar();
                }
                else
                {
                    if (IdnumericUpDown.Value == 0)
                    {
                        if(!UsuariosBLL.Duplicado(UsuariotextBox.Text))
                        {
                            UsuariosBLL.Guardar(usuario);
                            MessageBox.Show("Guardado Correctamente");
                            Limpiar();
                        }
                        else
                        {
                            errorProvider.SetError(UsuariotextBox,"Este usuario ya existe");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("El Id debe ser 0 para guardar");
                    }
                }
            }
            catch(Exception)
            {
                throw;
                //MessageBox.Show("Hubo un error al intentar guardar");
            }

        }

        private bool Validar()
        {
            errorProvider.Clear();
            bool paso = true;

            if(string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "Este campo no puede estar en blanco");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(EmailtextBox.Text))
            {
                errorProvider.SetError(EmailtextBox, "Este campo no puede estar en blanco");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(UsuariotextBox.Text))
            {
                errorProvider.SetError(UsuariotextBox, "Este campo no puede estar en blanco");
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ClavetextBox.Text))
            {
                errorProvider.SetError(ClavetextBox, "Este campo no puede estar en blanco");
                paso = false;
            }

            

            return paso;
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuarios = new Usuarios();

            usuarios.UsuarioId = (int)IdnumericUpDown.Value;
            usuarios.Nombre = NombretextBox.Text ;
            usuarios.Email = EmailtextBox.Text;
            usuarios.Usuario =  UsuariotextBox.Text;
            usuarios.Clave =  ClavetextBox.Text;
            usuarios.FechaIngreso =  FechaIngresodateTimePicker.Value;

            return usuarios;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

            try
            {
                if (UsuariosBLL.Buscar((int)IdnumericUpDown.Value) == null)
                {
                    MessageBox.Show("No se puede borrar un usuario que no existe");
                }
                else
                {

                    UsuariosBLL.Eliminar((int)IdnumericUpDown.Value);
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo eliminar el usuario");
            }
            
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario;
            try
            {
                usuario = UsuariosBLL.Buscar((int)IdnumericUpDown.Value);
                if(usuario != null)
                {
                    Limpiar();
                    LLenarCampos(usuario);
                }
                else
                {
                    MessageBox.Show("No se encontro el usuario");
                }

            }catch(Exception)
            {
                MessageBox.Show("Hubo un error al buscar el usuario");
            }
        }

        private void LLenarCampos(Usuarios usuarios)
        {
            IdnumericUpDown.Value = usuarios.UsuarioId;
            NombretextBox.Text = usuarios.Nombre;
            EmailtextBox.Text = usuarios.Email;
            UsuariotextBox.Text = usuarios.Usuario;
            ClavetextBox.Text = usuarios.Clave;
            FechaIngresodateTimePicker.Value = usuarios.FechaIngreso;
        }
    }
}
