using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_personaV3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_Limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void b_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void B_Guardar_Click(object sender, EventArgs e)
        {
            if (radioAlumno.Checked)//Alumno
            {
                MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
                + "\nEdad: " + textBox3.Text + "\nMatricula: " + textBox4.Text + "\nCarrera: " + textBox5.Text);
            }
            else
            {
                if (radioMaestro.Checked || radioEmpleado.Checked)//Docente o Maestro / Empleado
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
              + "\nEdad: " + textBox3.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "\nSueldo: " + textBox6.Text);
                }
                else//Persona
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
               + "\nEdad: " + textBox3.Text);
                }

            }
        }

        private void radioPersona_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\herna\\Desktop\\Clase_personaV3\\Imagenes\\Persona.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = false;
            textBox4.Visible = false;
            label7.Visible = false;
            textBox3.Visible = false;
            label6.Visible = false;
            textBox5.Visible = false;
        }

        private void radioEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\herna\\Desktop\\Clase_personaV3\\Imagenes\\Empleado.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label7.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
        }

        private void radioAlumno_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\herna\\Desktop\\Clase_personaV3\\Imagenes\\df13d7e7fbcba533b6fe9f01717504e4.jpg";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label7.Visible = false;
            textBox3.Visible = false;

        }

        private void radioMaestro_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\herna\\Desktop\\Clase_personaV3\\Imagenes\\prof.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label7.Visible = true;
            textBox3.Visible = true;
            label6.Visible = true;
            textBox5.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\herna\\Desktop\\Clase_personaV3\\Imagenes\\Persona.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void b_Validar_Click(object sender, EventArgs e)
        {
            if (radioAlumno.Checked)
            {

                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox6.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat);
            }
            else
            {
                if (radioEmpleado.Checked)
                {

                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox6.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox3.Text);
                    Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
                }
                else if (radioMaestro.Checked)
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox6.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox3.Text);
                    Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
                }
                else
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox6.Text);
                }
            }
        }
    }
}
