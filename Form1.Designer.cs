namespace CastingNumeros
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEntero = new System.Windows.Forms.Label();
            this.labelReal = new System.Windows.Forms.Label();
            this.textBoxEntero = new System.Windows.Forms.TextBox();
            this.textBoxReal = new System.Windows.Forms.TextBox();
            this.buttonEntero = new System.Windows.Forms.Button();
            this.buttonReal = new System.Windows.Forms.Button();
            this.labelDoble = new System.Windows.Forms.Label();
            this.labelMitad = new System.Windows.Forms.Label();
            this.textBoxDoble = new System.Windows.Forms.TextBox();
            this.textBoxMitad = new System.Windows.Forms.TextBox();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEntero
            // 
            this.labelEntero.AutoSize = true;
            this.labelEntero.Location = new System.Drawing.Point(46, 58);
            this.labelEntero.Name = "labelEntero";
            this.labelEntero.Size = new System.Drawing.Size(170, 20);
            this.labelEntero.TabIndex = 0;
            this.labelEntero.Text = "Dime un número entero:";
            // 
            // labelReal
            // 
            this.labelReal.AutoSize = true;
            this.labelReal.Location = new System.Drawing.Point(46, 126);
            this.labelReal.Name = "labelReal";
            this.labelReal.Size = new System.Drawing.Size(152, 20);
            this.labelReal.TabIndex = 1;
            this.labelReal.Text = "Dime un número real:";
            // 
            // textBoxEntero
            // 
            this.textBoxEntero.Location = new System.Drawing.Point(294, 55);
            this.textBoxEntero.Name = "textBoxEntero";
            this.textBoxEntero.Size = new System.Drawing.Size(125, 27);
            this.textBoxEntero.TabIndex = 2;
            // 
            // textBoxReal
            // 
            this.textBoxReal.Location = new System.Drawing.Point(294, 113);
            this.textBoxReal.Name = "textBoxReal";
            this.textBoxReal.Size = new System.Drawing.Size(125, 27);
            this.textBoxReal.TabIndex = 3;
            // 
            // buttonEntero
            // 
            this.buttonEntero.Location = new System.Drawing.Point(542, 45);
            this.buttonEntero.Name = "buttonEntero";
            this.buttonEntero.Size = new System.Drawing.Size(173, 47);
            this.buttonEntero.TabIndex = 4;
            this.buttonEntero.Text = "&Convertir";
            this.buttonEntero.UseVisualStyleBackColor = true;
            this.buttonEntero.Click += new System.EventHandler(this.buttonEntero_Click);
            // 
            // buttonReal
            // 
            this.buttonReal.Location = new System.Drawing.Point(542, 113);
            this.buttonReal.Name = "buttonReal";
            this.buttonReal.Size = new System.Drawing.Size(173, 47);
            this.buttonReal.TabIndex = 5;
            this.buttonReal.Text = "Converti&r";
            this.buttonReal.UseVisualStyleBackColor = true;
            this.buttonReal.Click += new System.EventHandler(this.buttonReal_Click);
            // 
            // labelDoble
            // 
            this.labelDoble.AutoSize = true;
            this.labelDoble.Location = new System.Drawing.Point(46, 213);
            this.labelDoble.Name = "labelDoble";
            this.labelDoble.Size = new System.Drawing.Size(165, 20);
            this.labelDoble.TabIndex = 6;
            this.labelDoble.Text = "El doble del número es:";
            // 
            // labelMitad
            // 
            this.labelMitad.AutoSize = true;
            this.labelMitad.Location = new System.Drawing.Point(46, 269);
            this.labelMitad.Name = "labelMitad";
            this.labelMitad.Size = new System.Drawing.Size(168, 20);
            this.labelMitad.TabIndex = 7;
            this.labelMitad.Text = "La mitad del número es:";
            // 
            // textBoxDoble
            // 
            this.textBoxDoble.Location = new System.Drawing.Point(294, 210);
            this.textBoxDoble.Name = "textBoxDoble";
            this.textBoxDoble.Size = new System.Drawing.Size(125, 27);
            this.textBoxDoble.TabIndex = 8;
            // 
            // textBoxMitad
            // 
            this.textBoxMitad.Location = new System.Drawing.Point(294, 266);
            this.textBoxMitad.Name = "textBoxMitad";
            this.textBoxMitad.Size = new System.Drawing.Size(125, 27);
            this.textBoxMitad.TabIndex = 9;
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(607, 265);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(129, 49);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "&Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 338);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.textBoxMitad);
            this.Controls.Add(this.textBoxDoble);
            this.Controls.Add(this.labelMitad);
            this.Controls.Add(this.labelDoble);
            this.Controls.Add(this.buttonReal);
            this.Controls.Add(this.buttonEntero);
            this.Controls.Add(this.textBoxReal);
            this.Controls.Add(this.textBoxEntero);
            this.Controls.Add(this.labelReal);
            this.Controls.Add(this.labelEntero);
            this.Name = "Form1";
            this.Text = "Trabajando con cadenas y números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelEntero;
        private Label labelReal;
        private TextBox textBoxEntero;
        private TextBox textBoxReal;
        private Button buttonEntero;
        private Button buttonReal;
        private Label labelDoble;
        private Label labelMitad;
        private TextBox textBoxDoble;
        private TextBox textBoxMitad;
        private Button buttonSalir;
    }
}