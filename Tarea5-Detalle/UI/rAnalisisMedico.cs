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
    public partial class rAnalisisMedico : Form
    {
        List<AnalisisDetalles> Detalles;
        
        public rAnalisisMedico()
        {
            InitializeComponent();
            Detalles = new List<AnalisisDetalles>();
            CargarUsuarios();
            CargarTipos();
        }

        private void CargarUsuarios()
        {
            try
            {
                List<Usuarios> Usuarios = new List<Usuarios>();
                Usuarios = UsuariosBLL.GetList(p => true);
                UsuariocomboBox.DataSource = null;
                UsuariocomboBox.DataSource = Usuarios;
                UsuariocomboBox.ValueMember = "UsuarioId";
                UsuariocomboBox.DisplayMember = "Usuario";
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error al intentar cargar los usuarios");
            }
            
        }

        private void CargarTipos()
        {
            try
            {
                List<TipoAnalisis> tipos = new List<TipoAnalisis>();
                tipos = TipoAnalisisBLL.GetList(p => true);
                TipoAnalisiscomboBox.DataSource = null;
                TipoAnalisiscomboBox.DataSource = tipos;
                TipoAnalisiscomboBox.ValueMember = "TipoAnalisisId";
                TipoAnalisiscomboBox.DisplayMember = "Descripcion";
            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error al intentar cargar los Tipos");
            }
            

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        
        private void CargarGrip()
        {
            DetallesdataGridView.DataSource = null;
            DetallesdataGridView.DataSource = Detalles;
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            UsuariocomboBox.SelectedIndex = 0;
            TipoAnalisiscomboBox.SelectedIndex = 0;
            ResultadotextBox.Text = string.Empty;
            Detalles = new List<AnalisisDetalles>();
            CargarGrip();
        }

        private void AgregarAnalisisbutton_Click(object sender, EventArgs e)
        {
            AnalisisDetalles analisis = new AnalisisDetalles()
            {TipoAnalisisId = (int)TipoAnalisiscomboBox.SelectedValue,Resultado = ResultadotextBox.Text };

            Detalles.Add(analisis);
            CargarGrip();
        }

        private void RemoverFilabutton_Click(object sender, EventArgs e)
        {
            Detalles.RemoveAt(DetallesdataGridView.CurrentRow.Index);
            CargarGrip();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (!Validar())
                return;

            Analisis analisis = new Analisis();
            analisis = LlenarClase();

            try
            {
                if (AnalisisBLL.Buscar((int)IdnumericUpDown.Value) != null)
                {
                    AnalisisBLL.Modificar(analisis);
                    MessageBox.Show("Modificado Correctamente");
                    Limpiar();
                }
                else
                {
                    if (IdnumericUpDown.Value == 0)
                    {
                        AnalisisBLL.Guardar(analisis);
                        MessageBox.Show("Guardado correctamente");
                        Limpiar();
                    }
                    else
                    {
                        errorProvider.SetError(IdnumericUpDown, "Debe ser 0 para poder guardar");
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error");
            }

        }

        private void LlenarCampos(Analisis analisis)
        {
            Limpiar();
            IdnumericUpDown.Value = analisis.AnalisisId;
            FechadateTimePicker.Value = analisis.Fecha;
            UsuariocomboBox.SelectedValue = analisis.UsuarioId;
            Detalles = new List<AnalisisDetalles>();
            Detalles = analisis.Detalles;
            CargarGrip();

        }

        private Analisis LlenarClase()
        {
            Analisis analisis = new Analisis();

            analisis.AnalisisId = (int)IdnumericUpDown.Value;
            analisis.Fecha = FechadateTimePicker.Value;
            analisis.UsuarioId = (int)UsuariocomboBox.SelectedValue;
            analisis.Detalles = Detalles;

            return analisis;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if(string.IsNullOrWhiteSpace(ResultadotextBox.Text))
            {
                errorProvider.SetError(ResultadotextBox,"Este campo no puede estar vacio");
                paso = false;
            }

            if(Detalles.Count == 0)
            {
                MessageBox.Show("Debe agregar almenos 1 analiis para guardar los cambios");
            }
           
            return paso;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
