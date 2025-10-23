using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2_Problema_2_Software_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            using (ConexionBD conexionBD = new ConexionBD())
            {
                try
                {
                    conexionBD.conectar();
                    if (conexionBD.getMiConexion().State == ConnectionState.Open)
                    {
                        this.Hide();
                        FormDataGridView frmMenu = new FormDataGridView();
                        frmMenu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error en Conexión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error:", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
