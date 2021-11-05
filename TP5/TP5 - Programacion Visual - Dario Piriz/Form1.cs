using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP5___Programacion_Visual___Dario_Piriz
{
    public partial class Form1 : Form
    {
        private static Libro libro;
        private LibroBusinessLogic libroBusiness;
        private static List<TextBox> boxes = new List<TextBox>();
        private static Libro libroEnCarga;

        public Form1()
        {
            InitializeComponent();
            boxes.Add(txtTitulo);
            boxes.Add(txtAutor);
            boxes.Add(txtIsbn);
            boxes.Add(txtPaginas);
            boxes.Add(txtEdicion);
            boxes.Add(txtEditorial);
            boxes.Add(txtLugar);
            libroBusiness = new LibroBusinessLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.librosTableAdapter.Fill(this.libreriaDataSet.Libros);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool result;
            if (ValidarForm())
            {
                string idFromForm = txtId.Text.Trim().Length == 0 ? "-1" : txtId.Text;
                int parsedId = int.Parse(idFromForm);
                libro = new Libro(
                    txtTitulo.Text, 
                    txtAutor.Text,
                    int.Parse(txtIsbn.Text),
                    int.Parse(txtPaginas.Text),
                    int.Parse(txtEdicion.Text),
                    txtEditorial.Text,
                    txtLugar.Text,
                    dtpFechaEdicion.Value,
                    parsedId);

                result = libro.Id == -1
                    ? libroBusiness.GuardarRegistro(libro)
                    : libroBusiness.ActualizarRegistro(libro);  

                if (!result)
                {
                    MessageBox.Show("Registro no guardado. Revisar log.");
                } 
                else
                {
                    LimpiarCampos();
                    dgvLibros.DataSource = libroBusiness.GetLibrosActualizados();
                }
            }
        }

        private bool ValidarForm()
        {
            //Validar campos requeridos
            foreach (TextBox box in boxes) 
                if (!ValidarCampo(box)) return false;

            //Validar tipo de datos
            //numericos
            TextBox textBox = new TextBox();

            try
            {
                textBox = txtIsbn;
                textBox.Focus();
                Int32.Parse(textBox.Text);

                textBox = txtPaginas;
                textBox.Focus();
                Int32.Parse(textBox.Text);

                textBox = txtEdicion;
                textBox.Focus();
                Int32.Parse(textBox.Text);

                if (DateTime.Compare(dtpFechaEdicion.Value, DateTime.Now) > 0)
                    throw new Exception("La fecha de edicion no puede ser superior al dia de hoy.");
            } catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un dato numérico válido en el campo " + textBox.Name.Substring(3));
                return false;
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            
            return true;
        }
        
        private static bool ValidarCampo(TextBox textBox)
        {
            if (textBox.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un dato válido en el campo " + textBox.Name.Substring(3));
                textBox.Focus();
                textBox.SelectAll();
                return false;
            }

            return true;
        }

        private void LimpiarCampos()
        {
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtIsbn.Text = "";
            txtPaginas.Text = "";
            txtEdicion.Text = "";
            txtEditorial.Text = "";
            txtLugar.Text = "";
            txtTitulo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cancelar?", "Caption", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LimpiarCampos();
            }
        }

        private void dgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // DataGridViewLinkCell cell = (DataGridViewLinkCell)dgvLibros.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = (int)senderGrid.Rows[e.RowIndex].Cells[0].Value;
                if (e.ColumnIndex == 9) //EDICION
                    PopularFormulario(id);
                else if (e.ColumnIndex == 10)
                {
                    EliminarRegistro(id);
                }
                Console.WriteLine("");
            }
            
        }

        private void PopularFormulario(int id)
        {
            Libro libro = libroBusiness.GetLibro(id);
            txtId.Text = libro.Id.ToString();
            txtTitulo.Text = libro.Titulo;
            txtAutor.Text = libro.Autor;
            txtIsbn.Text = libro.ISBN.ToString();
            txtPaginas.Text = libro.Paginas.ToString();
            txtEdicion.Text = libro.Edicion.ToString();
            txtEditorial.Text = libro.Editorial;
            txtLugar.Text = libro.Lugar;
            dtpFechaEdicion.Value = libro.FechaDeEdicion;
            txtTitulo.Focus();
            txtTitulo.SelectAll();
        }
        
        private void EliminarRegistro(int id)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro seleccioado?", "Caption", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                libroBusiness.EliminarRegistro(id);
                LimpiarCampos();
                dgvLibros.DataSource = libroBusiness.GetLibrosActualizados();
            }
        }
    }
}
