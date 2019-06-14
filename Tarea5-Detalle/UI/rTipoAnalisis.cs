using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if()

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
    }
}
