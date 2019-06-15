using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Detalles.Clear();
            CargarGrip();
        }

        private void AgregarAnalisisbutton_Click(object sender, EventArgs e)
        {
            AnalisisDetalles analisis = new AnalisisDetalles()
            {TipoId = (int)TipoAnalisiscomboBox.SelectedValue,Resultado = ResultadotextBox.Text };

            Detalles.Add(analisis);
            CargarGrip();
        }
    }
}
