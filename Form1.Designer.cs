
namespace Cuadrados_Medios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lvResultados = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbTotalNumeros = new System.Windows.Forms.Label();
            this.txtNumTotal = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lvComprobacion = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SvLV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValSuma = new System.Windows.Forms.TextBox();
            this.txtValXa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSemilla
            // 
            this.txtSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla.Location = new System.Drawing.Point(106, 191);
            this.txtSemilla.Margin = new System.Windows.Forms.Padding(2);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(84, 32);
            this.txtSemilla.TabIndex = 1;
            this.txtSemilla.TextChanged += new System.EventHandler(this.txtSemilla_TextChanged);
            this.txtSemilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemilla_KeyPress);
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemilla.Location = new System.Drawing.Point(30, 198);
            this.lblSemilla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(64, 20);
            this.lblSemilla.TabIndex = 1;
            this.lblSemilla.Text = "Semilla:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(91, 289);
            this.btnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(108, 36);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lvResultados
            // 
            this.lvResultados.AutoArrange = false;
            this.lvResultados.HideSelection = false;
            this.lvResultados.Location = new System.Drawing.Point(246, 67);
            this.lvResultados.Margin = new System.Windows.Forms.Padding(2);
            this.lvResultados.Name = "lvResultados";
            this.lvResultados.Size = new System.Drawing.Size(306, 322);
            this.lvResultados.TabIndex = 3;
            this.lvResultados.UseCompatibleStateImageBehavior = false;
            this.lvResultados.View = System.Windows.Forms.View.Details;
            this.lvResultados.SelectedIndexChanged += new System.EventHandler(this.lvResultados_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(555, 67);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(442, 322);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // lbTotalNumeros
            // 
            this.lbTotalNumeros.AutoSize = true;
            this.lbTotalNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalNumeros.Location = new System.Drawing.Point(2, 138);
            this.lbTotalNumeros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalNumeros.Name = "lbTotalNumeros";
            this.lbTotalNumeros.Size = new System.Drawing.Size(94, 20);
            this.lbTotalNumeros.TabIndex = 5;
            this.lbTotalNumeros.Text = "T. Numeros:";
            // 
            // txtNumTotal
            // 
            this.txtNumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTotal.Location = new System.Drawing.Point(106, 131);
            this.txtNumTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumTotal.Name = "txtNumTotal";
            this.txtNumTotal.Size = new System.Drawing.Size(84, 32);
            this.txtNumTotal.TabIndex = 0;
            this.txtNumTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTotal_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(433, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mínimos Cuadrados";
            // 
            // lvComprobacion
            // 
            this.lvComprobacion.HideSelection = false;
            this.lvComprobacion.Location = new System.Drawing.Point(246, 430);
            this.lvComprobacion.Margin = new System.Windows.Forms.Padding(2);
            this.lvComprobacion.Name = "lvComprobacion";
            this.lvComprobacion.Size = new System.Drawing.Size(306, 259);
            this.lvComprobacion.TabIndex = 9;
            this.lvComprobacion.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Generación de Numeros";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(268, 408);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Comprobación con Chi Cuadrada";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SvLV
            // 
            this.SvLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SvLV.Location = new System.Drawing.Point(450, 730);
            this.SvLV.Margin = new System.Windows.Forms.Padding(2);
            this.SvLV.Name = "SvLV";
            this.SvLV.Size = new System.Drawing.Size(122, 33);
            this.SvLV.TabIndex = 4;
            this.SvLV.Text = "Guardar";
            this.SvLV.UseVisualStyleBackColor = true;
            this.SvLV.Click += new System.EventHandler(this.SvLV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(684, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resultado de comprobación";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(650, 516);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(305, 40);
            this.txtResultado.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Valor de Suma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(674, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Valor (Xa,9):";
            // 
            // txtValSuma
            // 
            this.txtValSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValSuma.Location = new System.Drawing.Point(777, 440);
            this.txtValSuma.Name = "txtValSuma";
            this.txtValSuma.ReadOnly = true;
            this.txtValSuma.Size = new System.Drawing.Size(97, 26);
            this.txtValSuma.TabIndex = 18;
            // 
            // txtValXa
            // 
            this.txtValXa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValXa.Location = new System.Drawing.Point(777, 477);
            this.txtValXa.Name = "txtValXa";
            this.txtValXa.ReadOnly = true;
            this.txtValXa.Size = new System.Drawing.Size(97, 26);
            this.txtValXa.TabIndex = 19;
            this.txtValXa.Text = "16.9189776";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1006, 774);
            this.Controls.Add(this.txtValXa);
            this.Controls.Add(this.txtValSuma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lvComprobacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumTotal);
            this.Controls.Add(this.lbTotalNumeros);
            this.Controls.Add(this.SvLV);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lvResultados);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.lblSemilla);
            this.Controls.Add(this.txtSemilla);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mínimos cuadrados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.Label lblSemilla;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ListView lvResultados;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbTotalNumeros;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNumTotal;
        private System.Windows.Forms.ListView lvComprobacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SvLV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtValXa;
        private System.Windows.Forms.TextBox txtValSuma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

