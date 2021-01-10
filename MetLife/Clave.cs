using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetLife
{
    public partial class Clave : Form
    {
        public Clave()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string clave1 = "Saracho20*";
            string clave2 = "COas8691*";

            if (txtClave.Text == clave1 || txtClave.Text == clave2)
            {
                this.Hide();
                txtClave.Clear();
                Principal FormPrincipal = new Principal();
                FormPrincipal.ShowDialog();
                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("Clave incorrecta", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
