namespace MateKids.Minijuego_6
{
    partial class Minijuego6
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Minijuego6));
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblInstruccion = new System.Windows.Forms.Label();
            this.pnlControles = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Reiniciar = new System.Windows.Forms.Button();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.IniciarJuego = new System.Windows.Forms.Button();
            this.btnOpcion4 = new System.Windows.Forms.Button();
            this.btnOpcion3 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.pbxTiempo = new System.Windows.Forms.PictureBox();
            this.tmrTiempoJuego = new System.Windows.Forms.Timer(this.components);
            this.pnlControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTiempo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTiempo
            // 
            this.lblTiempo.BackColor = System.Drawing.Color.Honeydew;
            this.lblTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(1067, 15);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(61, 44);
            this.lblTiempo.TabIndex = 27;
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstruccion
            // 
            this.lblInstruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruccion.Location = new System.Drawing.Point(323, 263);
            this.lblInstruccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Size = new System.Drawing.Size(865, 28);
            this.lblInstruccion.TabIndex = 22;
            this.lblInstruccion.Text = "SELECCIONA LA OPCION CORRECTA";
            this.lblInstruccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlControles
            // 
            this.pnlControles.BackColor = System.Drawing.Color.Honeydew;
            this.pnlControles.Controls.Add(this.label1);
            this.pnlControles.Controls.Add(this.Reiniciar);
            this.pnlControles.Controls.Add(this.lblPuntaje);
            this.pnlControles.Controls.Add(this.IniciarJuego);
            this.pnlControles.Location = new System.Drawing.Point(28, 30);
            this.pnlControles.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControles.Name = "pnlControles";
            this.pnlControles.Size = new System.Drawing.Size(267, 484);
            this.pnlControles.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Marcador";
            // 
            // Reiniciar
            // 
            this.Reiniciar.Location = new System.Drawing.Point(60, 350);
            this.Reiniciar.Margin = new System.Windows.Forms.Padding(4);
            this.Reiniciar.Name = "Reiniciar";
            this.Reiniciar.Size = new System.Drawing.Size(140, 42);
            this.Reiniciar.TabIndex = 2;
            this.Reiniciar.Text = "Jugar Otra Vez";
            this.Reiniciar.UseVisualStyleBackColor = true;
            this.Reiniciar.Visible = false;
            this.Reiniciar.Click += new System.EventHandler(this.Reiniciar_Click);
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.BackColor = System.Drawing.Color.Transparent;
            this.lblPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 65F);
            this.lblPuntaje.Location = new System.Drawing.Point(4, 66);
            this.lblPuntaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(259, 167);
            this.lblPuntaje.TabIndex = 1;
            this.lblPuntaje.Text = "0";
            this.lblPuntaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IniciarJuego
            // 
            this.IniciarJuego.Location = new System.Drawing.Point(60, 255);
            this.IniciarJuego.Margin = new System.Windows.Forms.Padding(4);
            this.IniciarJuego.Name = "IniciarJuego";
            this.IniciarJuego.Size = new System.Drawing.Size(140, 42);
            this.IniciarJuego.TabIndex = 0;
            this.IniciarJuego.Text = "Iniciar";
            this.IniciarJuego.UseVisualStyleBackColor = true;
            this.IniciarJuego.Click += new System.EventHandler(this.IniciarJuego_Click);
            // 
            // btnOpcion4
            // 
            this.btnOpcion4.BackColor = System.Drawing.Color.Honeydew;
            this.btnOpcion4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcion4.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.btnOpcion4.Location = new System.Drawing.Point(1004, 304);
            this.btnOpcion4.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpcion4.Name = "btnOpcion4";
            this.btnOpcion4.Size = new System.Drawing.Size(184, 155);
            this.btnOpcion4.TabIndex = 24;
            this.btnOpcion4.UseVisualStyleBackColor = false;
            this.btnOpcion4.Click += new System.EventHandler(this.btnOpcion4_Click);
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.BackColor = System.Drawing.Color.Honeydew;
            this.btnOpcion3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcion3.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.btnOpcion3.Location = new System.Drawing.Point(778, 304);
            this.btnOpcion3.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(184, 155);
            this.btnOpcion3.TabIndex = 23;
            this.btnOpcion3.UseVisualStyleBackColor = false;
            this.btnOpcion3.Click += new System.EventHandler(this.btnOpcion3_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.BackColor = System.Drawing.Color.Honeydew;
            this.btnOpcion2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcion2.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.btnOpcion2.Location = new System.Drawing.Point(547, 304);
            this.btnOpcion2.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(184, 155);
            this.btnOpcion2.TabIndex = 21;
            this.btnOpcion2.UseVisualStyleBackColor = false;
            this.btnOpcion2.Click += new System.EventHandler(this.btnOpcion2_Click);
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.BackColor = System.Drawing.Color.Honeydew;
            this.btnOpcion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpcion1.Font = new System.Drawing.Font("Microsoft Tai Le", 40F, System.Drawing.FontStyle.Bold);
            this.btnOpcion1.Location = new System.Drawing.Point(323, 304);
            this.btnOpcion1.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(184, 155);
            this.btnOpcion1.TabIndex = 20;
            this.btnOpcion1.UseVisualStyleBackColor = false;
            this.btnOpcion1.Click += new System.EventHandler(this.btnOpcion1_Click);
            // 
            // lblOperacion
            // 
            this.lblOperacion.BackColor = System.Drawing.Color.White;
            this.lblOperacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.Location = new System.Drawing.Point(324, 75);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(864, 175);
            this.lblOperacion.TabIndex = 19;
            this.lblOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxTiempo
            // 
            this.pbxTiempo.Image = ((System.Drawing.Image)(resources.GetObject("pbxTiempo.Image")));
            this.pbxTiempo.Location = new System.Drawing.Point(1136, 15);
            this.pbxTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxTiempo.Name = "pbxTiempo";
            this.pbxTiempo.Size = new System.Drawing.Size(52, 47);
            this.pbxTiempo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxTiempo.TabIndex = 26;
            this.pbxTiempo.TabStop = false;
            // 
            // tmrTiempoJuego
            // 
            this.tmrTiempoJuego.Interval = 1000;
            this.tmrTiempoJuego.Tick += new System.EventHandler(this.tmrTiempoJuego_Tick);
            // 
            // Minijuego6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1216, 528);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.pbxTiempo);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.pnlControles);
            this.Controls.Add(this.btnOpcion4);
            this.Controls.Add(this.btnOpcion3);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.lblOperacion);
            this.Name = "Minijuego6";
            this.Text = "Minijuego6";
            this.Load += new System.EventHandler(this.Minijuego1_Load);
            this.pnlControles.ResumeLayout(false);
            this.pnlControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTiempo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.PictureBox pbxTiempo;
        private System.Windows.Forms.Label lblInstruccion;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reiniciar;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Button IniciarJuego;
        private System.Windows.Forms.Button btnOpcion4;
        private System.Windows.Forms.Button btnOpcion3;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.Timer tmrTiempoJuego;
    }
}