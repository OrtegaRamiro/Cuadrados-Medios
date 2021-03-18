using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting; 

namespace Cuadrados_Medios
{
    public partial class Form1 : Form
    {
        string[] Resultados = new string[4];

        public Form1()
        {
            InitializeComponent();
        }

        private void txtSemilla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            limpGrafica();
            lvResultados.Items.Clear();

            if (ComErroresTB())
            {
                return;
            }

            else {

                int total = int.Parse(txtNumTotal.Text);
                string semilla = txtSemilla.Text;
                string valorCuad = null;
                string valRecortado = null;
                string valDecimal;
               // Tuple<String, String> t;

                ListViewItem itm;

                for (int i = 1; i <= total; i++)
                {
                    Resultados[0] = i.ToString();

                    if (i == 1)
                    {
                        valorCuad = elevarCuad(semilla);
                        Resultados[1] = valorCuad;
                        valRecortado = cuatroNums(valorCuad);
                        Resultados[2] = valRecortado;
                        valDecimal = numDecimal(valRecortado);
                        Resultados[3] = valDecimal;
                        chart1.Series[0].Points.Add(new DataPoint(Convert.ToDouble(i), valDecimal));

                    }
                    else
                    {
                        valorCuad = elevarCuad(valRecortado);
                        Resultados[1] = valorCuad;
                        valRecortado = cuatroNums(valorCuad); ;
                        Resultados[2] = valRecortado;
                        valDecimal = numDecimal(valRecortado);
                        Resultados[3] = valDecimal;
                        chart1.Series[0].Points.Add(new DataPoint(Convert.ToDouble(i), valDecimal));
                    }

                    itm = new ListViewItem(Resultados);
                    lvResultados.Items.Add(itm);

                }
            }
        }

        private string comprobarNum(int num)
        {
            string valorNum = num.ToString();

            if (num.ToString().Length == 8)
            {
                return valorNum;
            }
            else if (num.ToString().Length == 7)
            {
                valorNum = valorNum.PadLeft(8, '0');
                return valorNum;
            }
            else if (num.ToString().Length == 6)
            {
                valorNum = num.ToString();
                valorNum = valorNum.PadLeft(8, '0');
                return valorNum;
            }
            else if (num.ToString().Length == 5)
            {
                valorNum = num.ToString();
                valorNum = valorNum.PadLeft(8, '0');
                return valorNum;
            }
            else if (num.ToString().Length == 4)
            {
                valorNum = num.ToString();
                valorNum = valorNum.PadLeft(8, '0');
                return valorNum;
            }
            else if (num.ToString().Length == 3)
            {
                valorNum = num.ToString();
                valorNum = valorNum.PadLeft(8, '0');
                return valorNum;
            }
            else if (num.ToString().Length == 2)
            {
                valorNum = num.ToString();
                valorNum = valorNum.PadLeft(8, '0');
                return valorNum;
            }
            else if (num.ToString().Length == 1)
            {
                valorNum = num.ToString();
                valorNum = valorNum.PadLeft(8, '0');
                return valorNum;
            }
            return valorNum;

        }
        private string elevarCuad(string semillaEnt)
        {
            string valor;
            int conversion;

            conversion = int.Parse(semillaEnt);
            conversion = conversion * conversion;

            valor = comprobarNum(conversion);

            return valor;
        }

        private string cuatroNums(string num)
        {
            string nuevo = num.Substring(2, 4);
            return nuevo;
        }

        private string numDecimal(string num)
        {
            string decNum;
            decNum = "0." + num;
            return decNum;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genTabla();
            grafica();
        }

        private void genTabla()
        {
            lvResultados.View = View.Details;
            lvResultados.GridLines = true;
            lvResultados.FullRowSelect = true;

            lvResultados.Columns.Add("#", 70, HorizontalAlignment.Center);
            lvResultados.Columns.Add("X", 70, HorizontalAlignment.Center);
            lvResultados.Columns.Add("Y", 70, HorizontalAlignment.Center);
            lvResultados.Columns.Add("R", 70, HorizontalAlignment.Center);
        }
        private void grafica()
        {
            chart1.Titles.Add("Cuadrados Medios");

            chart1.ChartAreas[0].Axes[0].Title = "N";
            chart1.ChartAreas[0].Axes[1].Title = "R";
            chart1.Series[0].ChartType = SeriesChartType.Point;
            chart1.Series[0].MarkerStyle = MarkerStyle.Circle;
            chart1.Series[0].Color = Color.Red;
            chart1.Series[0].LegendText = "Valor de R";
        }
        private void limpGrafica()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
        private void lvResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void SvLV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() {Filter = "Text Documents | *.txt" })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        foreach(ListViewItem item in lvResultados.Items)
                        {
                            await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[3].Text);
                        }
                        MessageBox.Show("¡¡Archivo de texto guardado correctamente!!");
                    }
                }

                using (SaveFileDialog sfdIMG = new SaveFileDialog())
                {
                    sfdIMG.Filter = "PNG Image|*.png";
                    sfdIMG.Title = "Guarda Chart Como Archivo Imagen";
                    sfdIMG.FileName = "Sample.png";


                    if(sfdIMG.ShowDialog() == DialogResult.OK && sfdIMG.FileName != "")
                    {
                        try
                        {
                            if (sfdIMG.CheckPathExists)
                            {
                                if (sfdIMG.FilterIndex == 1)
                                {
                                    chart1.SaveImage(sfdIMG.FileName, ChartImageFormat.Png);
                                    MessageBox.Show("¡¡Imagen guardada correctamente!!");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Dirección no valida");
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }

        }

        private void txtNumTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestringirChars(e, txtNumTotal);
        }
        private void txtSemilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            RestringirChars(e, txtSemilla);
        }

        private void RestringirChars(KeyPressEventArgs e, TextBox nombre) {
            nombre.MaxLength = 4;

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private bool ComErroresTB()
        {
            errorProvider1.Clear();
            errorProvider2.Clear();

            bool error1 = false;

            if (txtNumTotal.Text == string.Empty && txtSemilla.Text == string.Empty)
            {
                errorProvider1.SetError(txtNumTotal, "Ingrese al menos un numero");
                errorProvider1.SetError(txtSemilla, "Ingrese al menos un numero");
                return error1 = true;
            }
            else if(txtNumTotal.Text == string.Empty)
            {
                errorProvider1.SetError(txtNumTotal, "Ingrese al menos un numero");
                return error1 = true;
            }
            else if (txtSemilla.Text == string.Empty)
            {
                errorProvider1.SetError(txtSemilla, "Ingrese al menos un numero");
                return error1 = true;
            }

            if (!(txtNumTotal.Text == string.Empty) && !(txtSemilla.Text == string.Empty))
            {
                errorProvider2.SetError(txtNumTotal, "Correcto");
                errorProvider2.SetError(txtSemilla, "Correcto");
                return error1 = false;
            }

            else if(!(txtSemilla.Text == string.Empty))
            {
                errorProvider2.SetError(txtSemilla, "Correcto");
                return error1 = false;
            }
            else if (!(txtNumTotal.Text == string.Empty))
            {
                errorProvider2.SetError(txtNumTotal, "Correcto");
                return error1 = false;
            }

            return error1;
        }
    }
}
