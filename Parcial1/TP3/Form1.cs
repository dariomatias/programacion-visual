using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form1 : Form
    {
        private List<Alumno> alumnos = new();
        private static List<TextBox> boxes = new();
        private static Alumno alumnoEnCarga;

        public Form1()
        {
            InitializeComponent();
            boxes.Add(txtNombre);
            boxes.Add(txtApellido);
            boxes.Add(txtDni);
            boxes.Add(txtAnioDeNacimiento);
            boxes.Add(txtEmail);
            boxes.Add(txtCarrera);
            boxes.Add(txtLegajo);
            boxes.Add(txtAnio);
            ActualizarContador();
        }
        
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        public bool ValidarCampo(TextBox textBox)
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

        public bool ValidarForm()
        {
            foreach (TextBox box in boxes)
            {
                if (!ValidarCampo(box))
                {
                    return false;
                }
            }

            try
            {
                txtDni.Focus();
                var temp = Int32.Parse(txtDni.Text);

                txtAnio.Focus();
                temp = Int32.Parse(txtAnio.Text);
                if (temp > DateTime.Now.Year)
                    throw new Exception("El año de inscripción no puede ser en el futuro.");

                txtAnioDeNacimiento.Focus();
                temp = Int32.Parse(txtAnioDeNacimiento.Text);

                if (DateTime.Now.Year - temp < 18)
                    throw new Exception("El alumno debe ser mayor de 18 años.");

                if (!ValidarEmail(txtEmail.Text.Trim()))
                    throw new Exception("El email ingresado es inválido");


            } catch (FormatException)
            {
                MessageBox.Show("Los datos numericos DNI, Año de Inscripción, o Año de Nacimiento son inválidos.");
                return false;
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                alumnoEnCarga = new Alumno(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDni.Text), txtLegajo.Text,
                    txtCarrera.Text, Int32.Parse(txtAnio.Text), Int32.Parse(txtAnioDeNacimiento.Text),
                    txtEmail.Text.Trim());
                alumnos.Add(alumnoEnCarga);
                LimpiarCampos();
                ActualizarContador();
                ActualizarGrilla();
                txtNombre.Focus();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtAnioDeNacimiento.Text = "";
            txtEmail.Text = "";
            txtLegajo.Text = "";
            txtCarrera.Text = "";
            txtAnio.Text = "";
            txtNombre.Focus();
        }

        private void ActualizarContador()
        {
            lblNumAlumnos.Text = alumnos.Count.ToString();
        }

        private void ActualizarGrilla()
        {
            dataGridView1.Rows.Add(alumnoEnCarga.Nombre, alumnoEnCarga.Apellido, alumnoEnCarga.Dni,
                alumnoEnCarga.AnioDeNacimiento, alumnoEnCarga.Email, alumnoEnCarga.Legajo, alumnoEnCarga.Carrera,
                alumnoEnCarga.AnioDeInscripcion);
        }

        bool ValidarEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
