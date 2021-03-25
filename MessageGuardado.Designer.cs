
namespace Cuadrados_Medios
{
    partial class MessageGuardado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageGuardado));
            this.btnTablas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGuardado = new System.Windows.Forms.Label();
            this.brtnGuardarTodo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTablas
            // 
            this.btnTablas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTablas.Location = new System.Drawing.Point(191, 57);
            this.btnTablas.Name = "btnTablas";
            this.btnTablas.Size = new System.Drawing.Size(100, 60);
            this.btnTablas.TabIndex = 0;
            this.btnTablas.Text = "Tablas";
            this.btnTablas.UseVisualStyleBackColor = true;
            this.btnTablas.Click += new System.EventHandler(this.btnImaComp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblGuardado
            // 
            this.lblGuardado.AutoSize = true;
            this.lblGuardado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuardado.Location = new System.Drawing.Point(210, 30);
            this.lblGuardado.Name = "lblGuardado";
            this.lblGuardado.Size = new System.Drawing.Size(194, 24);
            this.lblGuardado.TabIndex = 5;
            this.lblGuardado.Text = "¿Qué desea guardar?";
            // 
            // brtnGuardarTodo
            // 
            this.brtnGuardarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brtnGuardarTodo.Location = new System.Drawing.Point(314, 57);
            this.brtnGuardarTodo.Name = "brtnGuardarTodo";
            this.brtnGuardarTodo.Size = new System.Drawing.Size(100, 60);
            this.brtnGuardarTodo.TabIndex = 7;
            this.brtnGuardarTodo.Text = "Guardar Todo";
            this.brtnGuardarTodo.UseVisualStyleBackColor = true;
            this.brtnGuardarTodo.Click += new System.EventHandler(this.brtnGuardarTodo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(469, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 23);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 8;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 23);
            this.panel1.TabIndex = 9;
            // 
            // MessageGuardado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 127);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.brtnGuardarTodo);
            this.Controls.Add(this.lblGuardado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTablas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageGuardado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecciona una opcion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MessageGuardado_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTablas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGuardado;
        private System.Windows.Forms.Button brtnGuardarTodo;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel panel1;
    }
}