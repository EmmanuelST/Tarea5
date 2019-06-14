using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea5_Detalle.UI;

namespace Tarea5_Detalle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistrarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios rUsuarios = new rUsuarios();
            rUsuarios.MdiParent = this;
            rUsuarios.Show();
        }

        private void TipoDeAnalisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTipoAnalisis rTipo = new rTipoAnalisis();
            rTipo.MdiParent = this;
            rTipo.Show();
        }
    }
}
