using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ColaCircularEstatica
{
    public partial class Form1 : Form
    {
        ColaCircular MiCola;
        public Form1()
        {
            InitializeComponent();
            groupBox2.Visible = false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int tamaño = int.Parse(txtTamaño.Text);
                if(tamaño <= 0)
                {
                    MessageBox.Show("Tamaño minimo : 1");
                    txtTamaño.Clear();
                    return;
                }
                MiCola = new ColaCircular(tamaño);
                groupBox1.Visible = false;
                groupBox2.Visible = true;
            }catch
            {
                MessageBox.Show("Introduzca un tamaño valido");
            }
            
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = txtDato.Text;
                if(dato == "")
                {
                    MessageBox.Show("Introduzca un dato valido");
                    return;
                }
                MiCola.Encolar(dato);
                lblCola.Text = MiCola.Imprimir();
                txtDato.Clear();
            }
            catch
            {
                MessageBox.Show("Bruh");
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            try
            {
                MiCola.Eliminar();
                lblCola.Text = MiCola.Imprimir();
                txtDato.Clear();
            }
            catch
            {
                MessageBox.Show("Bruh");
            }
        }

        private void btnFrente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El frente de la cola es " + MiCola.Front());
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog Dialogo = new FolderBrowserDialog();
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    string dato = MiCola.guardarFormato();
                    string nombreDelArchivo;
                    if(txtNombreArchivo.Text == "")
                    {
                        nombreDelArchivo = "Cola";
                    }
                    else
                    {
                        nombreDelArchivo = txtNombreArchivo.Text;
                    }

                    string ruta = Dialogo.SelectedPath + "\\" + nombreDelArchivo + ".txt";
                    using (var writer = new StreamWriter(ruta))
                    {
                        writer.Close();
                    }
                    string[] datos = { dato,MiCola.arregloCircular.Length +"" };
                    File.WriteAllLines(ruta, datos);
                    MessageBox.Show("Datos guardados en la ruta : "+ ruta);
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar los datos");
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Seleccionar = new OpenFileDialog();
            if (Seleccionar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = true;
                    int contador = 0;
                    string ruta = Seleccionar.FileName;
                    string[] datos = File.ReadAllLines(ruta);
                    string linea = datos[0];
                    int maximo = int.Parse(datos[1]);
                    string[] Lista = linea.Split(',');
                    MiCola = new ColaCircular(maximo);
                    foreach (string i in Lista)
                    {
                        MiCola.Encolar(Lista[contador]);
                        contador++;

                    }
                    lblCola.Text = MiCola.Imprimir();
                }
                catch
                {
                    MessageBox.Show("Error al cargar el archivo");
                }

            }
        }
    }
}
