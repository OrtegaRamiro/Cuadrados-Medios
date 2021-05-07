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
using System.Threading;

namespace Cuadrados_Medios
{
    public partial class Form1 : Form
    {
        int total;
        string[] Resultados = new string[7];
        string[] TablaChi = new string[4];
        int[] NumerosContados = new int[10];
        List<float> GuardarNums = new List<float>();
        List<float> GuardarNumsCarta = new List<float>();
        List<float> COLORES = new List<float>();
        float[] colores;
        float[] numCartas;

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
            GuardarNumsCarta.Clear();

            if (ComErroresTB())
            {
                NoError();

                return;
            }

            else {
                NoError();
                generacionColores();
               // generacionCartas();
            }
        }
        private void generacionColores()
        {
            total = int.Parse(txtNumTotal.Text);
            string semilla = txtSemilla.Text;
            string semillaCarta = txtCartaSemilla.Text;
            string valorCuad = null;
            string valRecortado = null;
            string valDecimal;

            string valorCuad2 = null;
            string valRecortado2 = null;
            string valDecimal2;

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

                    valorCuad2 = elevarCuad(semillaCarta);
                    Resultados[4] = valorCuad2;
                    valRecortado2 = cuatroNums(valorCuad2);
                    Resultados[5] = valRecortado2;
                    valDecimal2 = numDecimal(valRecortado2);
                    Resultados[6] = valDecimal2;
                    GuardarNumsCarta.Add(float.Parse(valDecimal2));

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

                    valorCuad2 = elevarCuad(valRecortado2);
                    Resultados[4] = valorCuad2;
                    valRecortado2 = cuatroNums(valorCuad2);
                    Resultados[5] = valRecortado2;
                    valDecimal2 = numDecimal(valRecortado2);
                    Resultados[6] = valDecimal2;
                    GuardarNumsCarta.Add(float.Parse(valDecimal2));

                    chart1.Series[0].Points.Add(new DataPoint(Convert.ToDouble(i), valDecimal));
                }

                itm = new ListViewItem(Resultados);
                lvResultados.Items.Add(itm);
            }
            ChiCuad();
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
            lvResultados.Columns.Add("COLOR", 70, HorizontalAlignment.Center);
            lvResultados.Columns.Add("X", 70, HorizontalAlignment.Center);
            lvResultados.Columns.Add("R", 70, HorizontalAlignment.Center);

            lvResultados.Columns.Add("CARTA", 70, HorizontalAlignment.Center);
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

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        /*****************************UNO*****************************/
        private void CartasColores()
        {
            total = int.Parse(txtNumTotal.Text);
            colores = new float[total];
            int j = 0;

            foreach (ListViewItem item in lvResultados.Items)
            {
                j++;
                colores[j - 1] = float.Parse(item.SubItems[3].Text);
                //colores[item] = float.Parse(item.SubItems[3].Text);
            }
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(colores[i]);
            }

        }

        private void CartasNumeros()
        {
            total = int.Parse(txtNumTotal.Text);
            numCartas = new float[total];
            int j = 0;
          //  List<string> lisNumCarta = new List<string>();
            
            foreach (ListViewItem item in lvResultados.Items)
            {
                j++;
                numCartas[j - 1] = float.Parse(item.SubItems[6].Text);
              //  lisNumCarta.Add(item.SubItems[6].Text);
                //colores[item] = float.Parse(item.SubItems[3].Text);
            }
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            dgvMazo.Rows.Clear();
            dgvJugando.Rows.Clear();
            dgvJug1.Rows.Clear();
            dgvJug2.Rows.Clear();
            //Tuple<string, string> tupla;
            /*(string, string) t1;
            t1.Item1(interColores, interCartas);*/

            CartasColores();
            CartasNumeros();
            for (int i = 0; i < total; i++)
            {
                dgvMazo.Rows.Add(i.ToString(), interCartas(numCartas[i]),interColores(colores[i]));
            }
        }

        private void reparCartaInicial()
        {
            dgvJug1.Rows.Clear();
            dgvJug2.Rows.Clear();
            repCarJug();
        }

        private async void CartaInicial()
        {
            int i = 0;
            foreach (DataGridViewRow row in dgvMazo.Rows)
            {
                i++;
            }
            await Task.Delay(500);

            dgvJugando.Rows.Add(dgvMazo.Rows[i-2].Cells[1].Value, dgvMazo.Rows[i-2].Cells[2].Value);
            dgvMazo.Rows.Remove(dgvMazo.Rows[i - 2]);

        }
        private async void repCarJug()
        {
            int i = 0;
            int j = 0;
            foreach (DataGridViewRow row in dgvMazo.Rows)
            {
                await Task.Delay(500);
               
                if (j == 14)
                {
                    break;
                }
                else
                {
                    //if (i % 2 == 0)
                    if(i==0)
                    {
                        dgvJug1.Rows.Add(dgvMazo.Rows[i].Cells[1].Value, dgvMazo.Rows[i].Cells[2].Value);
                        //dgvMazo.Rows.Remove(dgvMazo.Rows);
                        dgvMazo.Rows.Remove(dgvMazo.CurrentRow);
                        i=1;

                    }
                    else 
                    {
                        dgvJug2.Rows.Add(dgvMazo.Rows[i-1].Cells[1].Value, dgvMazo.Rows[i-1].Cells[2].Value);
                        dgvMazo.Rows.Remove(dgvMazo.CurrentRow);
                        //dgvMazo.Rows.RemoveAt(i);
                        i=0;
                    }
                    j++;
                }
            }
            CartaInicial();
            //dgvJug1.Rows[0].Cells[1].Value = dgvMazo.CurrentRow.Cells[1].Value;

        }


        private string interCartas(float numCarta)
        {
            string C0 = "0";
            string C1 = "1";
            string C2 = "2";
            string C3 = "3";
            string C4 = "4";
            string C5 = "5";
            string C6 = "6";
            string C7 = "7";
            string C8 = "8";
            string C9 = "9";
            string CMasDos = "Come +2";
            string CReversa = "Reversa";
            string CCancelar = "Cancelar";
            string CComodin = "Comodin";
            string CComodin4 = "Comodin+4";

            if (numCarta >= 0 && numCarta < 0.06666)
            {
                return C0;
            }
            else if(numCarta >= 0.06666 && numCarta < 0.13333)
            {
                return C1;
            }
            else if (numCarta >= 0.13333 && numCarta < 0.2)
            {
                return C2;
            }
            else if (numCarta >= 00.2 && numCarta < 0.26666)
            {
                return C3;
            }
            else if (numCarta >= 0.26666 && numCarta < 0.33333)
            {
                return C4;
            }
            else if (numCarta >= 0.33333 && numCarta < 0.4)
            {
                return C5;
            }
            else if (numCarta >= 0.4 && numCarta < 0.46666)
            {
                return C6;
            }
            else if (numCarta >= 0.46666 && numCarta < 0.53333)
            {
                return C7;
            }
            else if (numCarta >= 0.53333 && numCarta < 0.6)
            {
                return C8;
            }
            else if (numCarta >= 0.6 && numCarta < 0.66666)
            {
                return C9;
            }
            else if (numCarta >= 0.66666 && numCarta < 0.73333)
            {
                return CMasDos;
            }
            else if (numCarta >= 0.73333 && numCarta < 0.8)
            {
                return CReversa;
            }
            else if (numCarta >= 0.8 && numCarta < 0.86666)
            {
                return CCancelar;
            }
            else if (numCarta >= 0.86666 && numCarta < 0.93333)
            {
                return CComodin;
            }

            else if (numCarta >= 0.93333 && numCarta < 1)
            {
                return CComodin4;
            }


            return "Error";
        }

        private string interColores(float numeroColor)
        {
            string azul = "Azul";
            string Verde = "Verde";
            string Rojo = "Rojo";
            string Amarilo = "Amarillo";



            if(numeroColor>= 0 && numeroColor < 0.25)
            {
                return azul;
            }
            else if(numeroColor >=0.25 && numeroColor < 0.50)
            {
                return Verde;
            }
            else if (numeroColor >= 0.50 && numeroColor < 0.75)
            {
                return Rojo;
            }
            else if (numeroColor >= 0.75 && numeroColor < 1)
            {
                return Amarilo;
            }


            return "Error";

        }

        private void btnRepartir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                eliminar();
            }
        }

        private void eliminar()
        {
            int i = 0;
            
            int cuentaCeroAzul = 0;
            int cuentaUnoAzul = 0;
            int cuentaDosAzul = 0;
            int cuentaTresAzul = 0;
            int cuentaCuatroAzul = 0;
            int cuentaCincoAzul = 0;
            int cuentaSeisAzul = 0;
            int cuentaSieteAzul = 0;
            int cuentaOchoAzul = 0;
            int cuentaNueveAzul = 0;
            int cuentaReversaAzul = 0;
            int cuentaMasDosAzul = 0;
            int cuentaCancelarAzul = 0;

            int cuentaCeroRojo = 0;
            int cuentaUnoRojo = 0;
            int cuentaDosRojo = 0;
            int cuentaTresRojo = 0;
            int cuentaCuatroRojo = 0;
            int cuentaCincoRojo = 0;
            int cuentaSeisRojo = 0;
            int cuentaSieteRojo = 0;
            int cuentaOchoRojo = 0;
            int cuentaNueveRojo = 0;
            int cuentaReversaRojo = 0;
            int cuentaMasDosRojo = 0;
            int cuentaCancelarRojo = 0;

            int cuentaCeroVerde = 0;
            int cuentaUnoVerde = 0;
            int cuentaDosVerde = 0;
            int cuentaTresVerde = 0;
            int cuentaCuatroVerde = 0;
            int cuentaCincoVerde = 0;
            int cuentaSeisVerde = 0;
            int cuentaSieteVerde = 0;
            int cuentaOchoVerde = 0;
            int cuentaNueveVerde = 0;
            int cuentaReversaVerde = 0;
            int cuentaMasDosVerde = 0;
            int cuentaCancelarVerde = 0;

            int cuentaCeroAmarillo = 0;
            int cuentaUnoAmarillo = 0;
            int cuentaDosAmarillo = 0;
            int cuentaTresAmarillo = 0;
            int cuentaCuatroAmarillo = 0;
            int cuentaCincoAmarillo = 0;
            int cuentaSeisAmarillo = 0;
            int cuentaSieteAmarillo = 0;
            int cuentaOchoAmarillo = 0;
            int cuentaNueveAmarillo = 0;
            int cuentaReversaAmarillo = 0;
            int cuentaMasDosAmarillo = 0;
            int cuentaCancelarAmarillo = 0;

            int cuentaComodin = 0;
            int cuentaComodin4 = 0;

            foreach (DataGridViewRow row in dgvMazo.Rows)
            {
                /******************Azules*********************/
                if (dgvMazo.Rows[i].Cells[2].Value == "Azul")
                {
                    if (dgvMazo.Rows[i].Cells[1].Value == "0")
                    {
                        if (cuentaCeroAzul > 0)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCeroAzul++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "1")
                    {
                        if (cuentaUnoAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaUnoAzul++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "2")
                    {
                        if (cuentaDosAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaDosAzul++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "3")
                    {
                        if (cuentaTresAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaTresAzul++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "4")
                    {
                        if (cuentaCuatroAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCuatroAzul++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "5")
                    {
                        if (cuentaCincoAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCincoAzul++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "6")
                    {
                        if (cuentaSeisAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaSeisAzul++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "7")
                    {
                        if (cuentaSieteAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaSieteAzul++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "8")
                    {
                        if (cuentaOchoAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaOchoAzul++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "9")
                    {
                        if (cuentaNueveAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaNueveAzul++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "Reversa")
                    {
                        if (cuentaReversaAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaReversaAzul++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "Come +2")
                    {
                        if (cuentaMasDosAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaMasDosAzul++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "Cancelar")
                    {
                        if (cuentaCancelarAzul > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCancelarAzul++;
                        }
                    }
                }

                /******************Rojos*********************/
                if (dgvMazo.Rows[i].Cells[2].Value == "Rojo")
                {
                    if (dgvMazo.Rows[i].Cells[1].Value == "0")
                    {
                        if (cuentaCeroRojo > 0)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCeroRojo++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "1")
                    {
                        if (cuentaUnoRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaUnoRojo++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "2")
                    {
                        if (cuentaDosRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaDosRojo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "3")
                    {
                        if (cuentaTresRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaTresRojo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "4")
                    {
                        if (cuentaCuatroRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCuatroRojo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "5")
                    {
                        if (cuentaCincoRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCincoRojo++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "6")
                    {
                        if (cuentaSeisRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaSeisRojo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "7")
                    {
                        if (cuentaSieteRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaSieteRojo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "8")
                    {
                        if (cuentaOchoRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaOchoRojo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "9")
                    {
                        if (cuentaNueveRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaNueveRojo++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "Reversa")
                    {
                        if (cuentaReversaRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaReversaRojo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "Come +2")
                    {
                        if (cuentaMasDosRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaMasDosRojo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "Cancelar")
                    {
                        if (cuentaCancelarRojo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCancelarRojo++;
                        }
                    }
                }

                /******************Verdes*********************/
                if (dgvMazo.Rows[i].Cells[2].Value == "Verde")
                {
                    if (dgvMazo.Rows[i].Cells[1].Value == "0")
                    {
                        if (cuentaCeroVerde > 0)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCeroVerde++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "1")
                    {
                        if (cuentaUnoVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaUnoVerde++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "2")
                    {
                        if (cuentaDosVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaDosVerde++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "3")
                    {
                        if (cuentaTresVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaTresVerde++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "4")
                    {
                        if (cuentaCuatroVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCuatroVerde++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "5")
                    {
                        if (cuentaCincoVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCincoVerde++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "6")
                    {
                        if (cuentaSeisVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaSeisVerde++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "7")
                    {
                        if (cuentaSieteVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaSieteVerde++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "8")
                    {
                        if (cuentaOchoVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaOchoVerde++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "9")
                    {
                        if (cuentaNueveVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaNueveVerde++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "Reversa")
                    {
                        if (cuentaReversaVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaReversaVerde++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "Come +2")
                    {
                        if (cuentaMasDosVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaMasDosVerde++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "Cancelar")
                    {
                        if (cuentaCancelarVerde > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCancelarVerde++;
                        }
                    }
                }

                /******************Amarillo*********************/
                if (dgvMazo.Rows[i].Cells[2].Value == "Amarillo")
                {
                    if (dgvMazo.Rows[i].Cells[1].Value == "0")
                    {
                        if (cuentaCeroAmarillo > 0)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCeroAmarillo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "1")
                    {
                        if (cuentaUnoAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaUnoAmarillo++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "2")
                    {
                        if (cuentaDosAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaDosAmarillo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "3")
                    {
                        if (cuentaTresAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaTresAmarillo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "4")
                    {
                        if (cuentaCuatroAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCuatroAmarillo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "5")
                    {
                        if (cuentaCincoAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCincoAmarillo++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "6")
                    {
                        if (cuentaSeisAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaSeisAmarillo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "7")
                    {
                        if (cuentaSieteAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaSieteAmarillo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "8")
                    {
                        if (cuentaOchoAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaOchoAmarillo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "9")
                    {
                        if (cuentaNueveAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaNueveAmarillo++;
                        }
                    }

                    if (dgvMazo.Rows[i].Cells[1].Value == "Reversa")
                    {
                        if (cuentaReversaAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaReversaAmarillo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "Come +2")
                    {
                        if (cuentaMasDosAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaMasDosAmarillo++;
                        }
                    }
                    if (dgvMazo.Rows[i].Cells[1].Value == "Cancelar")
                    {
                        if (cuentaCancelarAmarillo > 1)
                        {
                            dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                        }
                        else
                        {
                            cuentaCancelarAmarillo++;
                        }
                    }
                }
                
                if (dgvMazo.Rows[i].Cells[1].Value == "Comodin")
                {
                    if(cuentaComodin > 3)
                    {
                        dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                    }
                    else
                    {
                        cuentaComodin++;
                    }
                }

                if (dgvMazo.Rows[i].Cells[1].Value == "Comodin+4")
                {
                    if (cuentaComodin4 > 3)
                    {
                        dgvMazo.Rows.Remove(dgvMazo.Rows[i]);
                    }
                    else
                    {
                        cuentaComodin4++;
                    }
                }
                
                i++;

            }
        }

        private void btnRepartir_Click_1(object sender, EventArgs e)
        {
            reparCartaInicial();
        }

        private void turnoJugador1()
        {
            CompararColoresJug1();
        }
        private void turnoJugador2()
        {
            if (dgvJug2.Rows.Count - 1 == 1)
            {
                MessageBox.Show("UNO");
                //CompararColoresJug2();
            }
            else if (dgvJug2.Rows.Count -1 == 0)
            {
                MessageBox.Show("GANASTE 2");
                //CompararColoresJug2();
            }
            else
            {
                CompararColoresJug2();
                turnoJugador1();
            }
        }
        private async void CompararColoresJug1()
        {
            int i = 0;
            string nomColor;
            bool existe = false;
            bool existeMasDos = false;
            bool existeCancelar = false;

            nomColor = obtenerColorJugando();
            foreach (DataGridViewRow row in dgvJug1.Rows)
            {
                if ((dgvJug1.Rows[i].Cells[1].Value == nomColor) || (dgvJug1.Rows[i].Cells[0].Value == obtenerCartaJugando()))
                {
                    await Task.Delay(3000);
                    dgvJugando.Rows.Add(dgvJug1.Rows[i].Cells[0].Value, dgvJug1.Rows[i].Cells[1].Value);
                    dgvJug1.Rows.Remove(dgvJug1.Rows[i]);

                    if (dgvJugando.Rows[dgvJugando.Rows.Count-1].Cells[0].Value == "Come +2")
                    {
                        existeMasDos = true;

                        await Task.Delay(3000);
                        dgvJug2.Rows.Add(dgvMazo.Rows[dgvMazo.Rows.Count-2].Cells[1].Value, dgvMazo.Rows[dgvMazo.Rows.Count-2].Cells[2].Value);
                        dgvMazo.Rows.RemoveAt(ultCartaMazo() - 2);

                        await Task.Delay(3000);
                        dgvJug2.Rows.Add(dgvMazo.Rows[dgvMazo.Rows.Count -2].Cells[1].Value, dgvMazo.Rows[dgvMazo.Rows.Count - 2].Cells[2].Value);
                        dgvMazo.Rows.RemoveAt(ultCartaMazo() - 2);

                        await Task.Delay(1000);
                        CompararColoresJug1();
                    }
                    else if(dgvJugando.Rows[dgvJugando.Rows.Count-1].Cells[0].Value == "Cancelar")
                    {
                        existeCancelar = true;
                        await Task.Delay(1000);
                        CompararColoresJug1();
                    }


                    dgvJugando.FirstDisplayedScrollingRowIndex = UltCartaJugada();

                    existe = true;
                    break;
                }

                else
                {
                    i++;
                }
            }
            if(existe == false)
            {
                await Task.Delay(1000);
                dgvJug1.Rows.Add(dgvMazo.Rows[dgvMazo.Rows.Count-2].Cells[1].Value, dgvMazo.Rows[dgvMazo.Rows.Count-2].Cells[2].Value);
                dgvMazo.Rows.RemoveAt(dgvMazo.Rows.Count-2);
            }
            if ((dgvJug1.Rows.Count - 1 == -1))
            {
                
                MessageBox.Show("GANA JUGADOR 1");
            }
            else if (dgvJug1.Rows.Count - 1 == 0)
            {
                MessageBox.Show("UNO", "JUGADOR 1");

                if((existeMasDos == false) && (existeCancelar == false))
                {
                    CompararColoresJug2();
                }
            }
            else
            {
                if ((existeMasDos == false) && (existeCancelar == false))
                {
                    CompararColoresJug2();
                }
            }
        }
        private async void CompararColoresJug2()
        {
            int i = 0;
            string nomColor;
            bool existe = false;
            bool existeMasDos = false;
            bool existeCancelar = false;

            nomColor = obtenerColorJugando();

            foreach (DataGridViewRow row in dgvJug2.Rows)
            {
                if ((dgvJug2.Rows[i].Cells[1].Value == nomColor) || (dgvJug2.Rows[i].Cells[0].Value == obtenerCartaJugando()))
                {

                    await Task.Delay(3000);
                    dgvJugando.Rows.Add(dgvJug2.Rows[i].Cells[0].Value, dgvJug2.Rows[i].Cells[1].Value);
                    dgvJug2.Rows.Remove(dgvJug2.Rows[i]);

                    if (dgvJugando.Rows[dgvJugando.Rows.Count - 1].Cells[0].Value == "Come +2")
                    {
                        existeMasDos = true;
                        await Task.Delay(3000);
                        dgvJug1.Rows.Add(dgvMazo.Rows[dgvMazo.Rows.Count - 2].Cells[1].Value, dgvMazo.Rows[dgvMazo.Rows.Count - 2].Cells[2].Value);
                        dgvMazo.Rows.RemoveAt(ultCartaMazo()-2);

                        await Task.Delay(3000);
                        dgvJug1.Rows.Add(dgvMazo.Rows[dgvMazo.Rows.Count - 2].Cells[1].Value, dgvMazo.Rows[dgvMazo.Rows.Count - 2].Cells[2].Value);
                        dgvMazo.Rows.RemoveAt(ultCartaMazo()-2);
                        
                        await Task.Delay(1000);
                        
                        CompararColoresJug2();

                    }
                    else if (dgvJugando.Rows[dgvJugando.Rows.Count - 1].Cells[0].Value == "Cancelar")
                    {
                        existeCancelar = true;
                        CompararColoresJug2();
                    }

                    dgvJugando.FirstDisplayedScrollingRowIndex = UltCartaJugada();
                    existe = true;
                    break;
                }
                else
                {
                    i++;
                }
            }

            if (existe == false)
            {
                await Task.Delay(1000);

                dgvJug2.Rows.Add(dgvMazo.Rows[dgvMazo.Rows.Count-2].Cells[1].Value, dgvMazo.Rows[dgvMazo.Rows.Count-2].Cells[2].Value);
                dgvMazo.Rows.RemoveAt(dgvMazo.Rows.Count-2);
            }

            if (dgvJug2.Rows.Count - 1 == -1)
            {
                MessageBox.Show("GANA JUGADOR 2");
            }
            else if(dgvJug2.Rows.Count -1 == 0)
            {
                MessageBox.Show("UNO", "JUGADOR 2");
                if ((existeMasDos == false) && (existeCancelar == false))
                {
                    CompararColoresJug1();
                }
            }
            else
            {
                if ((existeMasDos == false) && (existeCancelar == false))
                {
                    CompararColoresJug1();
                }
            }
        }

        private int ultCartaMazo()
        {
            int i = 0;
            foreach(DataGridViewRow row in dgvMazo.Rows)
            {
                i++;
            }
            return i;
        }
        private int UltCartaJugada()
        {
            int i = 0;
            foreach(DataGridViewRow row in dgvJugando.Rows)
            {
                i++;
            }
            return i-1;
        }

        /*------------------Se obtiene el ultimo color colocado------------------*/
        private string obtenerColorJugando()
        {
            int i = 0;
            string color;

            foreach(DataGridViewRow row in dgvJugando.Rows)
            {
                i++;
            }
            color = dgvJugando.Rows[i-1].Cells[1].Value.ToString();
            return color;
        }

        private string obtenerCartaJugando()
        {
            int i = 0;
            //string Carta;

            foreach (DataGridViewRow row in dgvJugando.Rows)
            {
                i++;
            }
            return dgvJugando.Rows[i - 1].Cells[0].Value.ToString(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            turnoJugador1();

        }

        private void btnJug2_Click(object sender, EventArgs e)
        {
            turnoJugador2();
        }
    }
}
