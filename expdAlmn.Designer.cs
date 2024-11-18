namespace Actividad_1
{
    partial class IDS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IDS));
            almn = new GroupBox();
            almnBirth = new DateTimePicker();
            almnAdress = new TextBox();
            almnName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            almnEdo = new ListBox();
            hr = new GroupBox();
            hrVes = new RadioButton();
            hrMat = new RadioButton();
            btnSave = new Button();
            label4 = new Label();
            label5 = new Label();
            almn.SuspendLayout();
            hr.SuspendLayout();
            SuspendLayout();
            // 
            // almn
            // 
            almn.Controls.Add(almnBirth);
            almn.Controls.Add(almnAdress);
            almn.Controls.Add(almnName);
            almn.Controls.Add(label3);
            almn.Controls.Add(label2);
            almn.Controls.Add(label1);
            almn.ForeColor = Color.FromArgb(202, 165, 109);
            almn.Location = new Point(30, 25);
            almn.Name = "almn";
            almn.Size = new Size(330, 236);
            almn.TabIndex = 0;
            almn.TabStop = false;
            almn.Text = "Datos personales";
            almn.Enter += groupBox1_Enter;
            // 
            // almnBirth
            // 
            almnBirth.AccessibleDescription = "Ingresar fecha de nacimiento";
            almnBirth.AccessibleName = "Fecha de nacimiento";
            almnBirth.CustomFormat = "DD/MM/YYYY";
            almnBirth.Format = DateTimePickerFormat.Short;
            almnBirth.Location = new Point(6, 127);
            almnBirth.Name = "almnBirth";
            almnBirth.Size = new Size(128, 23);
            almnBirth.TabIndex = 5;
            almnBirth.Value = new DateTime(2024, 11, 18, 5, 18, 17, 0);
            // 
            // almnAdress
            // 
            almnAdress.AccessibleDescription = "Ingresar direciòn";
            almnAdress.AccessibleName = "Direcciòn";
            almnAdress.Location = new Point(6, 192);
            almnAdress.Name = "almnAdress";
            almnAdress.Size = new Size(255, 23);
            almnAdress.TabIndex = 4;
            almnAdress.Tag = "";
            // 
            // almnName
            // 
            almnName.AccessibleDescription = "Ingresar nombre comleto";
            almnName.AccessibleName = "Nombre completo";
            almnName.Location = new Point(6, 65);
            almnName.Name = "almnName";
            almnName.Size = new Size(255, 23);
            almnName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 109);
            label3.Name = "label3";
            label3.Size = new Size(117, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha de nacimiento";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 174);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Direcciòn";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 47);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Nomre completo";
            // 
            // almnEdo
            // 
            almnEdo.AccessibleDescription = "Selecciona tu estado";
            almnEdo.AccessibleName = "Estados de la Reùblica Mèxicana";
            almnEdo.FormattingEnabled = true;
            almnEdo.ItemHeight = 15;
            almnEdo.Items.AddRange(new object[] { "Aguascalientes", "Baja California", "Baja California Sur", "Campeche", "Chiapas", "Chihuahua", "Coahuila de Zaragoza", "Colima", "Durango", "Estado de México", "Guanajuato", "Guerrero", "Hidalgo", "Jalisco", "Michoacán de Ocampo", "Morelos", "Nayarit", "Nuevo León", "Oaxaca", "Puebla", "Querétaro", "Quintana Roo", "San Luis Potosí", "Sinaloa", "Sonora", "Tabasco", "Tamaulipas", "Tlaxcala", "Veracruz de Ignacio de la Llave", "Yucatán", "Zacatecas" });
            almnEdo.Location = new Point(36, 295);
            almnEdo.Name = "almnEdo";
            almnEdo.Size = new Size(195, 109);
            almnEdo.TabIndex = 1;
            // 
            // hr
            // 
            hr.Controls.Add(hrVes);
            hr.Controls.Add(hrMat);
            hr.ForeColor = Color.FromArgb(202, 165, 109);
            hr.Location = new Point(411, 25);
            hr.Name = "hr";
            hr.Size = new Size(257, 124);
            hr.TabIndex = 2;
            hr.TabStop = false;
            hr.Text = "Horarios";
            // 
            // hrVes
            // 
            hrVes.AutoSize = true;
            hrVes.Location = new Point(14, 80);
            hrVes.Name = "hrVes";
            hrVes.Size = new Size(80, 19);
            hrVes.TabIndex = 1;
            hrVes.TabStop = true;
            hrVes.Text = "Vespertino";
            hrVes.UseVisualStyleBackColor = true;
            // 
            // hrMat
            // 
            hrMat.AutoSize = true;
            hrMat.Location = new Point(14, 42);
            hrMat.Name = "hrMat";
            hrMat.Size = new Size(74, 19);
            hrMat.TabIndex = 0;
            hrMat.TabStop = true;
            hrMat.Text = "Matutino";
            hrMat.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(593, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(202, 165, 109);
            label5.Location = new Point(36, 277);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 5;
            label5.Text = "Selecciona tu estado";
            label5.Click += label5_Click;
            // 
            // IDS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 36, 68);
            ClientSize = new Size(696, 430);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(hr);
            Controls.Add(almnEdo);
            Controls.Add(almn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "IDS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Expediente de alumno";
            Load += Form1_Load;
            almn.ResumeLayout(false);
            almn.PerformLayout();
            hr.ResumeLayout(false);
            hr.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox almn;
        private Label label1;
        private Label label3;
        private Label label2;
        private DateTimePicker almnBirth;
        private TextBox almnAdress;
        private TextBox almnName;
        private ListBox almnEdo;
        private GroupBox hr;
        private RadioButton hrVes;
        private RadioButton hrMat;
        private Button btnSave;
        private Label label4;
        private Label label5;
    }
}
