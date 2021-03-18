
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSemilla = new System.Windows.Forms.TextBox();
            this.lblSemilla = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lvResultados = new System.Windows.Forms.ListView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SvLV = new System.Windows.Forms.Button();
            this.lbTotalNumeros = new System.Windows.Forms.Label();
            this.txtNumTotal = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSemilla
            // 
            this.txtSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSemilla.Location = new System.Drawing.Point(143, 165);
            this.txtSemilla.Name = "txtSemilla";
            this.txtSemilla.Size = new System.Drawing.Size(110, 38);
            this.txtSemilla.TabIndex = 1;
            this.txtSemilla.TextChanged += new System.EventHandler(this.txtSemilla_TextChanged);
            this.txtSemilla.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSemilla_KeyPress);
            // 
            // lblSemilla
            // 
            this.lblSemilla.AutoSize = true;
            this.lblSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemilla.Location = new System.Drawing.Point(41, 174);
            this.lblSemilla.Name = "lblSemilla";
            this.lblSemilla.Size = new System.Drawing.Size(82, 25);
            this.lblSemilla.TabIndex = 1;
            this.lblSemilla.Text = "Semilla:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(52, 289);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(144, 44);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lvResultados
            // 
            this.lvResultados.AutoArrange = false;
            this.lvResultados.HideSelection = false;
            this.lvResultados.Location = new System.Drawing.Point(329, 12);
            this.lvResultados.Name = "lvResultados";
            this.lvResultados.Size = new System.Drawing.Size(406, 515);
            this.lvResultados.TabIndex = 3;
            this.lvResultados.UseCompatibleStateImageBehavior = false;
            this.lvResultados.View = System.Windows.Forms.View.Details;
            this.lvResultados.SelectedIndexChanged += new System.EventHandler(this.lvResultados_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(741, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(600, 515);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // SvLV
            // 
            this.SvLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SvLV.Location = new System.Drawing.Point(375, 571);
            this.SvLV.Name = "SvLV";
            this.SvLV.Size = new System.Drawing.Size(162, 41);
            this.SvLV.TabIndex = 4;
            this.SvLV.Text = "Guardar";
            this.SvLV.UseVisualStyleBackColor = true;
            this.SvLV.Click += new System.EventHandler(this.SvLV_Click);
            // 
            // lbTotalNumeros
            // 
            this.lbTotalNumeros.AutoSize = true;
            this.lbTotalNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalNumeros.Location = new System.Drawing.Point(3, 100);
            this.lbTotalNumeros.Name = "lbTotalNumeros";
            this.lbTotalNumeros.Size = new System.Drawing.Size(120, 25);
            this.lbTotalNumeros.TabIndex = 5;
            this.lbTotalNumeros.Text = "T. Numeros:";
            // 
            // txtNumTotal
            // 
            this.txtNumTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTotal.Location = new System.Drawing.Point(143, 91);
            this.txtNumTotal.Name = "txtNumTotal";
            this.txtNumTotal.Size = new System.Drawing.Size(110, 38);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1342, 753);
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
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mínimos cuadrados";
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
        private System.Windows.Forms.Button SvLV;
        private System.Windows.Forms.Label lbTotalNumeros;
        private System.Windows.Forms.TextBox txtNumTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

