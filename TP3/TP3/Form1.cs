using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form1 : Form
    {
        private List<Alumno> alumnos = new();
        private static  List<TextBox> boxes = new();

        public Form1()
        {
            InitializeComponent();
            boxes.Add(txtNombre);
            boxes.Add(txtApellido);
            boxes.Add(txtDni);
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
                var temp = Int32.Parse(txtDni.Text);
                temp = Int32.Parse(txtAnio.Text);
            } catch (Exception)
            {
                MessageBox.Show("Los datos numericos DNI o Año de Inscripción son inválidos.");
                txtDni.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                alumnos.Add(new Alumno(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDni.Text), txtLegajo.Text, txtCarrera.Text, Int32.Parse(txtAnio.Text)));
                LimpiarCampos();
                ActualizarContador();
                txtNombre.Focus();
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtLegajo.Text = "";
            txtCarrera.Text = "";
            txtAnio.Text = "";
        }

        private void ActualizarContador()
        {
            lblNumAlumnos.Text = alumnos.Count.ToString();
        }
    }
}
