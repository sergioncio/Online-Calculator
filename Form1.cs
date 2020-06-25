using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operaciones;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        private double int1 = 0;
        private double int2 = 0;

        //Para trabajar en local
        //operaciones op = new operaciones();

        //Para trabajar en remoto
        operaciones op = (operaciones)Activator.GetObject(typeof(operaciones),"http://localhost:8090/Operaciones");

        List<string> result = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
 
        private void Entrada_1(object sender, EventArgs e)
        {

        }

        private void Entrada_2(object sender, EventArgs e)
        {

        }

        private void Suma(object sender, EventArgs e)
        {
            //Comprobamos que el texto introducido es númerico
            if ((double.TryParse(Entrada1.Text, out int1) == true) && (double.TryParse(Entrada2.Text, out int2) == true))
            {
                int1 = double.Parse(Entrada1.Text);
                int2 = double.Parse(Entrada2.Text);

                result.Add(int1 + " + " + int2 + " = " + op.sumar(int1, int2));
                Resultado.DataSource = null;
                Resultado.DataSource = result;
            }
            else
            {
                MessageBox.Show("Los valores introducidos no son númericos.");
                Entrada1.Clear();
                Entrada2.Clear();
            }
        }

        private void Resta(object sender, EventArgs e)
        {
            //Comprobamos que el texto introducido es númerico
            if ((double.TryParse(Entrada1.Text, out int1) == true) && (double.TryParse(Entrada2.Text, out int2) == true))
            {
                int1 = double.Parse(Entrada1.Text);
                int2 = double.Parse(Entrada2.Text);

                result.Add(int1 + " - " + int2 + " = " + op.restar(int1, int2));
                Resultado.DataSource = null;
                Resultado.DataSource = result;
            }
            else
            {
                MessageBox.Show("Los valores introducidos no son númericos.");
                Entrada1.Clear();
                Entrada2.Clear();
            }
        }

        private void Multiplicacion(object sender, EventArgs e)
        {
            //Comprobamos que el texto introducido es númerico
            if ((double.TryParse(Entrada1.Text, out int1) == true) && (double.TryParse(Entrada2.Text, out int2) == true))
            {
                int1 = double.Parse(Entrada1.Text);
                int2 = double.Parse(Entrada2.Text);

                result.Add(int1 + " x " + int2 + " = " + op.multiplicar(int1, int2));
                Resultado.DataSource = null;
                Resultado.DataSource = result;
            }
            else
            {
                MessageBox.Show("Los valores introducidos no son númericos.");
                Entrada1.Clear();
                Entrada2.Clear();
            }
        }

        private void Division(object sender, EventArgs e)
        {
            //Comprobamos que el texto introducido es númerico
            if ((double.TryParse(Entrada1.Text, out int1) == true) && (double.TryParse(Entrada2.Text, out int2) == true))
            {
                int1 = double.Parse(Entrada1.Text);
                int2 = double.Parse(Entrada2.Text);

                result.Add(int1 + " / " + int2 + " = " + op.dividir(int1, int2));
                Resultado.DataSource = null;
                Resultado.DataSource = result;
            }
            else
            {
                MessageBox.Show("Los valores introducidos no son númericos.");
                Entrada1.Clear();
                Entrada2.Clear();
            }
        }

        private void Result(object sender, EventArgs e)
        {

        }
    }
}
