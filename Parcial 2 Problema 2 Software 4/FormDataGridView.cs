using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_2_Problema_2_Software_4
{
    public partial class FormDataGridView : Form
    {
        public FormDataGridView()
        {
            InitializeComponent();
            conexionBD.conectar();
            loadDGV();
            updateComboBox();
        }
        ConexionBD conexionBD = new ConexionBD();
        SqlCommand com;
        DataTable table = new DataTable();
        SqlDataReader reader;

        public void loadDGV(bool standard = true)
        {
            if (standard)
            {
                com = new SqlCommand("select * from Libreria", conexionBD.getMiConexion());
            }
            table.Clear();
            reader = com.ExecuteReader();
            table.Load(reader);
            dgvLibros.DataSource = table;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Size preferredSize = dgvLibros.GetPreferredSize(new Size(0, 0));
            dgvLibros.Width = preferredSize.Width;
            dgvLibros.Left = this.Width / 2 - dgvLibros.Width / 2;
            lblTitulo.Left = this.Width / 2 - lblTitulo.Width / 2;
        }

        public void updateComboBox(bool standard=true)
        {
            cmbGeneros.Items.Clear();
            if (standard)
            {
                com = new SqlCommand("SELECT Genero FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Libreria'");
            }
            table.Load(reader);
            List<string> generos = new List<string>();
            string genero;
            foreach (DataRow row in table.Rows)
            {
                genero = row["Genero"].ToString();
                if (!generos.Contains(genero)){
                    generos.Add(genero);
                    cmbGeneros.Items.Add(genero);
                }
            }
            cmbGeneros.Items.Add("--ELEGIR TODOS--");
        }

        private void cmbGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGeneros.SelectedItem.ToString() == "--ELEGIR TODOS--")
            {
                com = new SqlCommand("select * from Libreria", conexionBD.getMiConexion());
            } else
                com = new SqlCommand("select * from Libreria where genero = '" + cmbGeneros.SelectedItem + "'", conexionBD.getMiConexion());
            loadDGV(false);
        }

        private void rdbAgregar_CheckedChanged(object sender, EventArgs e)
        {
            grpAcciones.Visible = true;
            grpAcciones.Text = "Agregar";
            txtAutor.Enabled = true;
            txtCodigo.Enabled = true;
            txtGenero.Enabled = true;
            txtNombre.Enabled = true;
            txtPaginas.Enabled = true;
            txtPrecio.Enabled = true;
            txtGenero.Enabled = true;
            btnReset.Enabled = true;
            btnConfirmar.Enabled = true;
        }

        private void rdbModificar_CheckedChanged(object sender, EventArgs e)
        {
            grpAcciones.Visible = true;
            grpAcciones.Text = "Modificar";
            txtAutor.Enabled = false;
            txtCodigo.Enabled = false;
            txtGenero.Enabled = false;
            txtNombre.Enabled = false;
            txtPaginas.Enabled = false;
            txtPrecio.Enabled = false;
            txtGenero.Enabled = false;
            txtAutor.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtGenero.Text = "";
            txtPrecio.Text = "";
            txtPaginas.Text = "";
            btnReset.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void rdbEliminar_CheckedChanged(object sender, EventArgs e)
        {
            grpAcciones.Visible = false;
        }
        public void agregar(string codigo, string nombre, string autor, string paginas, string precio, string genero)
        {
            com = new SqlCommand("INSERT INTO Libreria(Codigo,Nombre,Autor,Paginas,Precio,Genero) VALUES (" + codigo + ",'" + nombre + "','" + autor + "'," + paginas + "," + precio + ",'" + genero + "');", conexionBD.getMiConexion());
            com.ExecuteNonQuery();
        }

        public void modificar(string codigo, string nombre, string autor, string paginas, string precio, string genero, string codigo2)
        {
            com = new SqlCommand("UPDATE Libreria SET Codigo = " + codigo + ",Nombre = '" + nombre + "',Autor = '" + autor + "',Paginas = " + paginas + ",Precio = " + precio + ",Genero = '" + genero + "' WHERE Codigo = " + codigo2 + ";", conexionBD.getMiConexion());
            com.ExecuteNonQuery();
        }

        public void eliminar(string codigo)
        {
            com = new SqlCommand("DELETE FROM Libreria WHERE Codigo = " + codigo + ";", conexionBD.getMiConexion());
            com.ExecuteNonQuery();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
            //disculpa por este codigo tan feo
        {
            if (rdbAgregar.Checked)
            {
                if (int.TryParse(txtCodigo.Text, out int codigo) && codigo > 0)
                {
                    com = new SqlCommand("SELECT Codigo FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Libreria'");
                    table.Load(reader);
                    List<string> codigos = new List<string>();
                    foreach (DataRow row in table.Rows)
                    {
                        if (codigo.ToString() == row["Codigo"].ToString())
                        {
                            MessageBox.Show("Ya existe un registro con el código " + txtCodigo.Text + "!\nCrear un registro nuevo!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    if (txtNombre.Text.Length > 0 && txtNombre.Text.Length < 51)
                    {
                        string nombre = txtNombre.Text;
                        if (!txtAutor.Text.IsNullOrEmpty() && txtAutor.Text.Length < 31)
                        {
                            string autor = txtAutor.Text;
                            if (autor.Split().Count() == 2)
                            {
                                foreach (string nom in autor.Split())
                                {
                                    if (nom[0].ToString() != nom[0].ToString().ToUpper())
                                    {
                                        MessageBox.Show("El nombre y apellido del autor(a) debe empezar con mayuscula!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                if (int.TryParse(txtPaginas.Text, out int paginas) && paginas > 0)
                                {
                                    if (float.TryParse(txtPrecio.Text, out float precio) && precio > 0)
                                    {
                                        if (txtGenero.Text.Length > 0 && txtGenero.Text.Length < 21)
                                        {
                                            string genero = txtGenero.Text;
                                            txtAutor.Text = "";
                                            txtCodigo.Text = "";
                                            txtNombre.Text = "";
                                            txtGenero.Text = "";
                                            txtPrecio.Text = "";
                                            txtPaginas.Text = "";
                                            agregar(codigo.ToString(), nombre, autor, paginas.ToString(), precio.ToString(), genero);
                                            loadDGV();
                                            updateComboBox(false);
                                            MessageBox.Show("Libro agregado!", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Genero debe tener una longitud válida!\n(No puede estar vacio y debe tener menos de 21 caracteres)", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Precio debe tener un número float válido!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Páginas debe tener un número entero válido!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Autor(a) debe tener nombre y apellido!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Autor(a) debe tener una longitud válida!\n(No puede estar vacio y debe tener menos de 31 caracteres)", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre debe tener una longitud válida!\n(No puede estar vacio y debe tener menos de 51 caracteres)", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Codigo debe tener un número entero válido!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                string nombre, autor, genero;
                if (int.TryParse(txtCodigo.Text, out int codigo) && codigo > 0)
                {
                    com = new SqlCommand("SELECT Codigo FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'Libreria'");
                    table.Load(reader);
                    List<string> codigos = new List<string>();
                    foreach (DataRow row in table.Rows)
                    {
                        if (codigo.ToString() == row["Codigo"].ToString() && codigo.ToString() != dgvLibros.SelectedRows[0].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Ya existe un registro con el código " + txtCodigo.Text + "!\nUtilizar un codigo nuevo!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                } else
                {
                    MessageBox.Show("Codigo debe tener un número entero válido!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtPaginas.Text, out int paginas) && paginas > 0)
                {
                    MessageBox.Show("Páginas debe tener un número entero válido!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!float.TryParse(txtPrecio.Text, out float precio) && precio > 0)
                {
                    MessageBox.Show("Precio debe tener un número float válido!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtNombre.Text.Length > 0 && txtNombre.Text.Length < 51)
                {
                    nombre = txtNombre.Text;
                }
                else
                {
                    MessageBox.Show("Nombre debe tener una longitud válida!\n(No puede estar vacio y debe tener menos de 51 caracteres)", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtGenero.Text.Length > 0 && txtGenero.Text.Length < 21)
                {
                    genero = txtGenero.Text;
                }
                else
                {
                    MessageBox.Show("Genero debe tener una longitud válida!\n(No puede estar vacio y debe tener menos de 21 caracteres)", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!txtAutor.Text.IsNullOrEmpty() && txtAutor.Text.Length < 31)
                {
                    autor = txtAutor.Text;
                    if (autor.Split().Count() == 2)
                    {
                        foreach (string nom in autor.Split())
                        {
                            if (nom[0].ToString() != nom[0].ToString().ToUpper())
                            {
                                MessageBox.Show("El nombre y apellido del autor(a) debe empezar con mayuscula!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Autor(a) debe tener nombre y apellido!", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Autor(a) debe tener una longitud válida!\n(No puede estar vacio y debe tener menos de 31 caracteres)", "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                modificar(codigo.ToString(), nombre, autor, paginas.ToString(), precio.ToString(), genero, dgvLibros.SelectedRows[0].Cells[0].Value.ToString());
                loadDGV();
                updateComboBox(false);
                MessageBox.Show("Modificación hecha!", "Hecho!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAutor.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtGenero.Text = "";
            txtPrecio.Text = "";
            txtPaginas.Text = "";
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rdbModificar.Checked)
            {
                txtCodigo.Text = dgvLibros.SelectedRows[0].Cells[0].Value.ToString();
                txtCodigo.Enabled = true;
                txtNombre.Text = dgvLibros.SelectedRows[0].Cells[1].Value.ToString().Trim();
                txtNombre.Enabled = true;
                txtAutor.Text = dgvLibros.SelectedRows[0].Cells[2].Value.ToString().Trim();
                txtAutor.Enabled = true;
                txtPaginas.Text = dgvLibros.SelectedRows[0].Cells[3].Value.ToString();
                txtPaginas.Enabled = true;
                txtPrecio.Text = dgvLibros.SelectedRows[0].Cells[4].Value.ToString();
                txtPrecio.Enabled = true;
                txtGenero.Text = dgvLibros.SelectedRows[0].Cells[5].Value.ToString().Trim();
                txtGenero.Enabled = true;
                btnConfirmar.Enabled = true;
            }
        }

        private void dgvLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string[] cells = new string[6];
            int i = 0;
            foreach(DataGridViewCell celda in dgvLibros.SelectedRows[0].Cells)
            {
                cells[i] = celda.Value.ToString();
                i++;
            }
            if (rdbEliminar.Checked)
            {
                DialogResult result = MessageBox.Show("Seguro que quiere eliminar el siguiente registro?:\n\nCodigo: " + cells[0]+ "\nNombre: "+ cells[1] + "\nAutor(a): " + cells[2]+ "\nPaginas: " + cells[3]+"\nPrecio: " + cells[4]+ "\nGenero: " + cells[5], "?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    eliminar(cells[0]);
                    loadDGV();
                    updateComboBox(false);
                    MessageBox.Show("Se ha eliminado ese registro\nEspero que no fue accidente!!!", "Hecho...!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
