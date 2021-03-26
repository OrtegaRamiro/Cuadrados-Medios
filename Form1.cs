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
        int total;
        string[] Resultados = new string[4];
        string[] TablaChi = new string[4];
        int[] NumerosContados = new int[10];
        List<float> GuardarNums = new List<float>();

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
            lvComprobacion.Items.Clear();
            txtResultado.Text = "";
            txtValSuma.Text = "";
            GuardarNums.Clear();

            if (ComErroresTB())
            {
                NoError();

                return;
            }

            else {
                NoError();

                total = int.Parse(txtNumTotal.Text);
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
                        GuardarNums.Add(float.Parse(valDecimal));
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
                        GuardarNums.Add(float.Parse(valDecimal));
                        chart1.Series[0].Points.Add(new DataPoint(Convert.ToDouble(i), valDecimal));
                    }

                    itm = new ListViewItem(Resultados);
                    lvResultados.Items.Add(itm);
                }
                ChiCuad();
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
        public void ChiCuad()
        {
            lvComprobacion.Items.Clear();
            totalNumIntervalos();

            int n = total;
            float resultado = 0;
            float suma = 0;
            float m = (float) Math.Sqrt(n);
            
            float e = n / m;

            ListViewItem itm;

            for (int i = 0; i<10; i++)
            {
                float operacion = 0;

                // TablaChi[0] = (i+1).ToString();
                if (i == 9)
                    TablaChi[0] = ("[0." + i + " - 1.00]" );
                
                else
                    TablaChi[0] = ("[0." + i + " - " + "0." + (i + 1).ToString() + "]");

                TablaChi[1] = NumerosContados[i].ToString();
                TablaChi[2] = e.ToString();

                operacion = e - NumerosContados[i];             
                resultado = (float)Math.Pow(operacion, 2) / e;
                TablaChi[3] = resultado.ToString();
                
                suma = suma + resultado;

                itm = new ListViewItem(TablaChi);
                lvComprobacion.Items.Add(itm);
            }
            // txtValSuma.Text = ("");
            string ValordeSuma = suma.ToString();
            txtValSuma.Text = string.Format(ValordeSuma);

            if (suma < 16.91)
            {
                txtResultado.Text = string.Format("El valor de la suma es menor que (Xa,9). El resultado es CORRECTO");
            }
            else
            {
                txtResultado.Text = "El valor de la suma es mayor que (Xa,9). El resultado es INCORRECTO";
            }
        }
        public void totalNumIntervalos()
        {
            int ceroDiez = 0;
            int DiezVeinte = 0;
            int VeinteTreinta = 0;
            int TreintaCuarenta = 0;
            int CuarentaCincuenta = 0;
            int CincuentaSesenta = 0;
            int SesentaSetenta = 0;
            int SetentaOchenta = 0;
            int OchentaNoventa = 0;
            int NoventaCien = 0;

            for (int i = 0; i < total; i++)
            {
                if(GuardarNums[i]>=0 && GuardarNums[i] < 0.10)
                {
                    ceroDiez = ceroDiez + 1;
                }
                else if (GuardarNums[i] >= 0.10 && GuardarNums[i] < 0.20)
                {
                    DiezVeinte = DiezVeinte + 1;
                }
                else if (GuardarNums[i] >= 0.20 && GuardarNums[i] < 0.30)
                {
                    VeinteTreinta = VeinteTreinta + 1;
                }
                else if (GuardarNums[i] >= 0.30 && GuardarNums[i] < 0.40)
                {
                    TreintaCuarenta = TreintaCuarenta + 1;
                }
                else if (GuardarNums[i] >= 0.40 && GuardarNums[i] < 0.50)
                {
                    CuarentaCincuenta = CuarentaCincuenta + 1;
                }
                else if (GuardarNums[i] >= 0.50 && GuardarNums[i] < 0.60)
                {
                    CincuentaSesenta = CincuentaSesenta + 1;
                }
                else if (GuardarNums[i] >= 0.60 && GuardarNums[i] < 0.70)
                {
                    SesentaSetenta = SesentaSetenta + 1;
                }
                else if (GuardarNums[i] >= 0.70 && GuardarNums[i] < 0.80)
                {
                    SetentaOchenta = SetentaOchenta + 1;
                }
                else if (GuardarNums[i] >= 0.80 && GuardarNums[i] < 0.90)
                {
                    OchentaNoventa = OchentaNoventa + 1;
                }
                else if (GuardarNums[i] >= 0.90 && GuardarNums[i] <= 1.00)
                {
                    NoventaCien = NoventaCien + 1;
                }
            }
            NumerosContados[0] = ceroDiez;
            NumerosContados[1] = DiezVeinte;
            NumerosContados[2] = VeinteTreinta;
            NumerosContados[3] = TreintaCuarenta;
            NumerosContados[4] = CuarentaCincuenta;
            NumerosContados[5] = CincuentaSesenta;
            NumerosContados[6] = SesentaSetenta;
            NumerosContados[7] = SetentaOchenta;
            NumerosContados[8] = OchentaNoventa;
            NumerosContados[9] = NoventaCien;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            genTabla();
            genTablaChiCuadrada();
            grafica();
            txtResultado.AutoSize = false;
            txtResultado.Size = new Size(305, 45);
        }
        private void genTabla()
        {
            lvResultados.View = View.Details;
            lvResultados.GridLines = true;
            lvResultados.FullRowSelect = true;

            lvResultados.Columns.Add("#", 70, HorizontalAlignment.Center);
            lvResultados.Columns.Add("Y", 70, HorizontalAlignment.Center);
            lvResultados.Columns.Add("X", 70, HorizontalAlignment.Center);
            lvResultados.Columns.Add("R", 70, HorizontalAlignment.Center);
        }
        private void genTablaChiCuadrada()
        {
            lvComprobacion.View = View.Details;
            lvComprobacion.GridLines = true;
            lvComprobacion.FullRowSelect = true;

            lvComprobacion.Columns.Add("#", 70, HorizontalAlignment.Center);
            lvComprobacion.Columns.Add("Oi", 70, HorizontalAlignment.Center);
            lvComprobacion.Columns.Add("Ei", 70, HorizontalAlignment.Center);
            lvComprobacion.Columns.Add("Resultado", 70, HorizontalAlignment.Center);

        }
        private void grafica()
        {
            chart1.Titles.Add("Gráfica de dispersión");

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
        private void SvLV_Click(object sender, EventArgs e)
        {
            this.Hide();

            DialogResult respuesta = new DialogResult();
            Form mensaje = new MessageGuardado();
            respuesta = mensaje.ShowDialog();

            if (respuesta == DialogResult.OK)
            {
                _ = GuardarTablas();
            }
            else if (respuesta == DialogResult.Yes)
            {
                _ = GuardarTablas();
                GuardarImagen();
            }
            else if (respuesta == DialogResult.Cancel)
            {
                mensaje.Dispose();
            }
            this.Show();
        }

        private async Task GuardarTablas()
        {

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents | *.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        await tw.WriteLineAsync("\n\tGENERACIÓN DE NÚMEROS ALEATORIOS\n");
                        await tw.WriteLineAsync(string.Format("#\t   Y\t\t  X\t   R"));
                        foreach (ListViewItem item in lvResultados.Items)
                        {
                            await tw.WriteLineAsync(item.SubItems[0].Text + "\t" + item.SubItems[1].Text + "\t" + item.SubItems[2].Text + "\t" + item.SubItems[3].Text);
                        }

                        await tw.WriteLineAsync("\n\tCOMPROBACIÓN CON CHI CUADRADA\n");
                        await tw.WriteLineAsync(string.Format("#\t        Oi\t   Ei\t       Resultado"));
                        foreach (ListViewItem item2 in lvComprobacion.Items)
                        {
                            await tw.WriteLineAsync(item2.SubItems[0].Text + "\t" + item2.SubItems[1].Text + "\t" + item2.SubItems[2].Text + "\t" +item2.SubItems[3].Text);
                        }

                        tw.WriteLine(string.Format("\nValor de la suma: " + txtValSuma.Text+"\t\tValor de Xa,9: "+txtValXa.Text+"\n"+txtResultado.Text));

                        MessageBox.Show("¡¡Archivo de texto guardado correctamente!!");
                    }
                }
            }
        }

        private void GuardarImagen()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents | *.txt" })
            {

                using (SaveFileDialog sfdIMG = new SaveFileDialog())
                {
                    sfdIMG.Filter = "PNG Image|*.png";
                    sfdIMG.Title = "Guarda Chart Como Archivo Imagen";
                    sfdIMG.FileName = "Sample.png";


                    if (sfdIMG.ShowDialog() == DialogResult.OK && sfdIMG.FileName != "")
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
                        catch (Exception ex)
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
                return true;
            }
            else if(txtNumTotal.Text == string.Empty)
            {
                errorProvider1.SetError(txtNumTotal, "Ingrese al menos un numero");
                return true;
            }
            else if (txtSemilla.Text == string.Empty)
            {
                errorProvider1.SetError(txtSemilla, "Ingrese al menos un numero");
                return true;
            }
            return error1;
        }
        private void NoError()
        {
            if (!(txtNumTotal.Text == string.Empty) && !(txtSemilla.Text == string.Empty))
            {
                errorProvider2.SetError(txtNumTotal, "Correcto");
                errorProvider2.SetError(txtSemilla, "Correcto");
            }
            else if (!(txtSemilla.Text == string.Empty))
            {
                errorProvider2.SetError(txtSemilla, "Correcto");
            }
            else if (!(txtNumTotal.Text == string.Empty))
            {
                errorProvider2.SetError(txtNumTotal, "Correcto");
            }
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {

        }
    }
}
