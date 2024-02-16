
namespace App_Calculator_Actualizacion
{
    partial class Home_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Calculator));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxhoraingreso = new System.Windows.Forms.TextBox();
            this.textBoxdiasemana = new System.Windows.Forms.TextBox();
            this.textBoxhorasalida = new System.Windows.Forms.TextBox();
            this.labelinstruciondia = new System.Windows.Forms.Label();
            this.labelnumerodias = new System.Windows.Forms.Label();
            this.labelingresadia = new System.Windows.Forms.Label();
            this.labelhoraingr = new System.Windows.Forms.Label();
            this.labelhorasali = new System.Windows.Forms.Label();
            this.buttonsiguiente = new System.Windows.Forms.Button();
            this.labelinstruccionhoras = new System.Windows.Forms.Label();
            this.labelinstrucciones = new System.Windows.Forms.Label();
            this.buttonguardar = new System.Windows.Forms.Button();
            this.buttoncalcular = new System.Windows.Forms.Button();
            this.labelcoregirdia = new System.Windows.Forms.Label();
            this.labelcorregirhoras = new System.Windows.Forms.Label();
            this.errorguardar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelcalcular = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcula tu Salario Semanal";
            // 
            // textBoxhoraingreso
            // 
            this.textBoxhoraingreso.Enabled = false;
            this.textBoxhoraingreso.Location = new System.Drawing.Point(143, 417);
            this.textBoxhoraingreso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxhoraingreso.Name = "textBoxhoraingreso";
            this.textBoxhoraingreso.Size = new System.Drawing.Size(116, 25);
            this.textBoxhoraingreso.TabIndex = 2;
            this.textBoxhoraingreso.TextChanged += new System.EventHandler(this.textBoxhoraingreso_TextChanged);
            // 
            // textBoxdiasemana
            // 
            this.textBoxdiasemana.Location = new System.Drawing.Point(272, 278);
            this.textBoxdiasemana.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxdiasemana.Name = "textBoxdiasemana";
            this.textBoxdiasemana.Size = new System.Drawing.Size(116, 25);
            this.textBoxdiasemana.TabIndex = 3;
            this.textBoxdiasemana.TextChanged += new System.EventHandler(this.textBoxdiasemana_TextChanged);
            // 
            // textBoxhorasalida
            // 
            this.textBoxhorasalida.Enabled = false;
            this.textBoxhorasalida.Location = new System.Drawing.Point(394, 417);
            this.textBoxhorasalida.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxhorasalida.Name = "textBoxhorasalida";
            this.textBoxhorasalida.Size = new System.Drawing.Size(116, 25);
            this.textBoxhorasalida.TabIndex = 4;
            this.textBoxhorasalida.TextChanged += new System.EventHandler(this.textBoxhorasalida_TextChanged);
            // 
            // labelinstruciondia
            // 
            this.labelinstruciondia.AutoSize = true;
            this.labelinstruciondia.BackColor = System.Drawing.Color.White;
            this.labelinstruciondia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinstruciondia.Location = new System.Drawing.Point(72, 94);
            this.labelinstruciondia.Name = "labelinstruciondia";
            this.labelinstruciondia.Size = new System.Drawing.Size(487, 17);
            this.labelinstruciondia.TabIndex = 5;
            this.labelinstruciondia.Text = "Ingresa el dia de la semana solo en formato numerico segun los siguientes datos:";
            this.labelinstruciondia.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelnumerodias
            // 
            this.labelnumerodias.AutoSize = true;
            this.labelnumerodias.BackColor = System.Drawing.Color.White;
            this.labelnumerodias.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnumerodias.Location = new System.Drawing.Point(72, 111);
            this.labelnumerodias.Name = "labelnumerodias";
            this.labelnumerodias.Size = new System.Drawing.Size(438, 17);
            this.labelnumerodias.TabIndex = 6;
            this.labelnumerodias.Text = "Viernes: 1. Sabado:2. Domingo:3. Lunes:4, Martes:5. Miercoles:6. Jueves:7.";
            this.labelnumerodias.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelingresadia
            // 
            this.labelingresadia.AutoSize = true;
            this.labelingresadia.Location = new System.Drawing.Point(179, 240);
            this.labelingresadia.Name = "labelingresadia";
            this.labelingresadia.Size = new System.Drawing.Size(294, 17);
            this.labelingresadia.TabIndex = 7;
            this.labelingresadia.Text = "Ingresa el dia de la semana que deseas registrar";
            // 
            // labelhoraingr
            // 
            this.labelhoraingr.AutoSize = true;
            this.labelhoraingr.Enabled = false;
            this.labelhoraingr.Location = new System.Drawing.Point(155, 387);
            this.labelhoraingr.Name = "labelhoraingr";
            this.labelhoraingr.Size = new System.Drawing.Size(104, 17);
            this.labelhoraingr.TabIndex = 8;
            this.labelhoraingr.Text = "Hora de ingreso";
            // 
            // labelhorasali
            // 
            this.labelhorasali.AutoSize = true;
            this.labelhorasali.Enabled = false;
            this.labelhorasali.Location = new System.Drawing.Point(416, 387);
            this.labelhorasali.Name = "labelhorasali";
            this.labelhorasali.Size = new System.Drawing.Size(94, 17);
            this.labelhorasali.TabIndex = 9;
            this.labelhorasali.Text = "Hora de salida";
            // 
            // buttonsiguiente
            // 
            this.buttonsiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonsiguiente.Enabled = false;
            this.buttonsiguiente.Location = new System.Drawing.Point(289, 334);
            this.buttonsiguiente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonsiguiente.Name = "buttonsiguiente";
            this.buttonsiguiente.Size = new System.Drawing.Size(87, 30);
            this.buttonsiguiente.TabIndex = 10;
            this.buttonsiguiente.Text = "Siguiente";
            this.buttonsiguiente.UseVisualStyleBackColor = false;
            this.buttonsiguiente.Click += new System.EventHandler(this.buttonsiguiente_Click);
            // 
            // labelinstruccionhoras
            // 
            this.labelinstruccionhoras.AutoSize = true;
            this.labelinstruccionhoras.BackColor = System.Drawing.Color.White;
            this.labelinstruccionhoras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinstruccionhoras.Location = new System.Drawing.Point(72, 128);
            this.labelinstruccionhoras.Name = "labelinstruccionhoras";
            this.labelinstruccionhoras.Size = new System.Drawing.Size(568, 17);
            this.labelinstruccionhoras.TabIndex = 11;
            this.labelinstruccionhoras.Text = "Ingresa las horas en formato militar y en fraciones. Ejemplo: 9:30 pm lo debes in" +
    "gresar asi: 21.5";
            this.labelinstruccionhoras.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelinstrucciones
            // 
            this.labelinstrucciones.AutoSize = true;
            this.labelinstrucciones.BackColor = System.Drawing.Color.White;
            this.labelinstrucciones.Location = new System.Drawing.Point(286, 68);
            this.labelinstrucciones.Name = "labelinstrucciones";
            this.labelinstrucciones.Size = new System.Drawing.Size(83, 17);
            this.labelinstrucciones.TabIndex = 12;
            this.labelinstrucciones.Text = "Instrucciones";
            // 
            // buttonguardar
            // 
            this.buttonguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonguardar.Enabled = false;
            this.buttonguardar.Location = new System.Drawing.Point(301, 466);
            this.buttonguardar.Name = "buttonguardar";
            this.buttonguardar.Size = new System.Drawing.Size(75, 31);
            this.buttonguardar.TabIndex = 13;
            this.buttonguardar.Text = "Guardar";
            this.buttonguardar.UseVisualStyleBackColor = false;
            this.buttonguardar.Click += new System.EventHandler(this.buttonguardar_Click);
            // 
            // buttoncalcular
            // 
            this.buttoncalcular.BackColor = System.Drawing.Color.Yellow;
            this.buttoncalcular.Location = new System.Drawing.Point(301, 503);
            this.buttoncalcular.Name = "buttoncalcular";
            this.buttoncalcular.Size = new System.Drawing.Size(75, 33);
            this.buttoncalcular.TabIndex = 14;
            this.buttoncalcular.Text = "Calcular";
            this.buttoncalcular.UseVisualStyleBackColor = false;
            this.buttoncalcular.Click += new System.EventHandler(this.buttoncalcular_Click);
            // 
            // labelcoregirdia
            // 
            this.labelcoregirdia.AutoSize = true;
            this.labelcoregirdia.Location = new System.Drawing.Point(186, 313);
            this.labelcoregirdia.Name = "labelcoregirdia";
            this.labelcoregirdia.Size = new System.Drawing.Size(287, 17);
            this.labelcoregirdia.TabIndex = 15;
            this.labelcoregirdia.Text = "Ingresa un dia correcto. Revisa las instrucciones";
            this.labelcoregirdia.Visible = false;
            // 
            // labelcorregirhoras
            // 
            this.labelcorregirhoras.AutoSize = true;
            this.labelcorregirhoras.Location = new System.Drawing.Point(260, 446);
            this.labelcorregirhoras.Name = "labelcorregirhoras";
            this.labelcorregirhoras.Size = new System.Drawing.Size(137, 17);
            this.labelcorregirhoras.TabIndex = 16;
            this.labelcorregirhoras.Text = "Ingresa bien las horas";
            this.labelcorregirhoras.Visible = false;
            // 
            // errorguardar
            // 
            this.errorguardar.AutoSize = true;
            this.errorguardar.Location = new System.Drawing.Point(528, 32);
            this.errorguardar.Name = "errorguardar";
            this.errorguardar.Size = new System.Drawing.Size(129, 17);
            this.errorguardar.TabIndex = 17;
            this.errorguardar.Text = "No se pudo guardar";
            this.errorguardar.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(568, 35);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nota: Si su hora de salida fue despues de las 24 horas debe registrar las siguien" +
    "tes horas como un nuevo dia";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(565, 35);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nota: Si usted tuvo dos o mas turnos en el dia: Registra sus diferentes jornadas " +
    "laboradas con el mismo dia";
            // 
            // labelcalcular
            // 
            this.labelcalcular.AutoSize = true;
            this.labelcalcular.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcalcular.Location = new System.Drawing.Point(153, 539);
            this.labelcalcular.Name = "labelcalcular";
            this.labelcalcular.Size = new System.Drawing.Size(141, 25);
            this.labelcalcular.TabIndex = 20;
            this.labelcalcular.Text = "Su pago tal es:";
            this.labelcalcular.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(541, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 33);
            this.button1.TabIndex = 21;
            this.button1.Text = "Borrar Datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(669, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelcalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorguardar);
            this.Controls.Add(this.labelcorregirhoras);
            this.Controls.Add(this.labelcoregirdia);
            this.Controls.Add(this.buttoncalcular);
            this.Controls.Add(this.buttonguardar);
            this.Controls.Add(this.labelinstrucciones);
            this.Controls.Add(this.labelinstruccionhoras);
            this.Controls.Add(this.buttonsiguiente);
            this.Controls.Add(this.labelhorasali);
            this.Controls.Add(this.labelhoraingr);
            this.Controls.Add(this.labelingresadia);
            this.Controls.Add(this.labelnumerodias);
            this.Controls.Add(this.labelinstruciondia);
            this.Controls.Add(this.textBoxhorasalida);
            this.Controls.Add(this.textBoxdiasemana);
            this.Controls.Add(this.textBoxhoraingreso);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Home_Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxhoraingreso;
        private System.Windows.Forms.TextBox textBoxdiasemana;
        private System.Windows.Forms.TextBox textBoxhorasalida;
        private System.Windows.Forms.Label labelinstruciondia;
        private System.Windows.Forms.Label labelnumerodias;
        private System.Windows.Forms.Label labelingresadia;
        private System.Windows.Forms.Label labelhoraingr;
        private System.Windows.Forms.Label labelhorasali;
        private System.Windows.Forms.Button buttonsiguiente;
        private System.Windows.Forms.Label labelinstruccionhoras;
        private System.Windows.Forms.Label labelinstrucciones;
        private System.Windows.Forms.Button buttonguardar;
        private System.Windows.Forms.Button buttoncalcular;
        private System.Windows.Forms.Label labelcoregirdia;
        private System.Windows.Forms.Label labelcorregirhoras;
        private System.Windows.Forms.Label errorguardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelcalcular;
        private System.Windows.Forms.Button button1;
    }
}

