using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probabilidade_Estatistica
{
    public partial class Esperanca : Form
    {
        public Esperanca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> probabilidades = CalculaProbabilidades();
            string aux = string.Empty;

            List<double> lucros = CalculaLucros();

            List<double> xPxs = CalculaXPX(probabilidades, lucros);

            MessageBox.Show(string.Format("{0:f2}", CalculaEsperanca(xPxs)));
        }

        private List<double> CalculaLucros()
        {
            List<double> lucros = new List<double>();

            lucros.Add(int.Parse(txtOp4.Text) - int.Parse(txtGasto.Text));
            lucros.Add(int.Parse(txtOp1.Text) - int.Parse(txtGasto.Text));
            lucros.Add(int.Parse(txtOp2.Text) - int.Parse(txtGasto.Text));
            lucros.Add(int.Parse(txtOp3.Text) - int.Parse(txtGasto.Text));

            return lucros;
        }

        private List<double> CalculaXPX(List<double> probabilidades, List<double> lucros)
        {
            List<double> aux = new List<double>();

            aux.Add(lucros[0] * probabilidades[0]);
            aux.Add(lucros[1] * probabilidades[1]);
            aux.Add(lucros[2] * probabilidades[2]);
            aux.Add(lucros[3] * probabilidades[3]);

            return aux;
        }

        private double CalculaEsperanca(List<double> xPxs)
        {
            double aux = 0;

            foreach (var item in xPxs)
            {
                aux += item;
            }

            return aux;
        }

        private List<double> CalculaProbabilidades()
        {
            List<double> probabilidades = new List<double>(0);

            double p = double.Parse(txtProb1.Text) / double.Parse(txtProb2.Text);
            double q = 1 - p;

            if (txtQtdd.Text.Trim() == "2")
            {
                probabilidades.Add(p * p * 1); //2A
                probabilidades.Add(p * q * 2); //1A
                probabilidades.Add(q * q * 1); //0A
            }

            if (txtQtdd.Text.Trim() == "3")
            {
                probabilidades.Add(p * p * p * 1); //3A
                probabilidades.Add(p * p * q * 3); //2A
                probabilidades.Add(p * q * q * 3); //1A
                probabilidades.Add(q * q * q * 1); //0A
            }

            if (txtQtdd.Text.Trim() == "4")
            {
                probabilidades.Add(p * p * p * p * 1); //4A
                probabilidades.Add(p * p * p * q * 4); //3A
                probabilidades.Add(p * p * q * q * 6); //2A
                probabilidades.Add(p * q * q * q * 4); //1A
                probabilidades.Add(q * q * q * q * 1); //0A
            }

            return probabilidades;
        }

    }
}
