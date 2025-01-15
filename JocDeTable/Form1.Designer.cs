namespace JocDeTable
{
    partial class Form1
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
            this.Tabla = new System.Windows.Forms.PictureBox();
            this.Zar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // Tabla
            // 
            this.Tabla.Image = global::JocDeTable.Properties.Resources._506a5289_e7ca_4f51_a315_d5429a470eb5;
            this.Tabla.Location = new System.Drawing.Point(-31, 12);
            this.Tabla.Name = "Tabla";
            this.Tabla.Size = new System.Drawing.Size(1211, 694);
            this.Tabla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Tabla.TabIndex = 0;
            this.Tabla.TabStop = false;
            this.Tabla.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.Tabla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mutare);
            // 
            // Zar
            // 
            this.Zar.Location = new System.Drawing.Point(1209, 57);
            this.Zar.Name = "Zar";
            this.Zar.Size = new System.Drawing.Size(127, 65);
            this.Zar.TabIndex = 1;
            this.Zar.Text = "Zar";
            this.Zar.UseVisualStyleBackColor = true;
            this.Zar.Click += new System.EventHandler(this.Zar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1209, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Zar1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1209, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 62);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zar2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1208, 311);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 62);
            this.button3.TabIndex = 4;
            this.button3.Text = "Suma zaruri 1 si 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1209, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 87);
            this.button4.TabIndex = 5;
            this.button4.Text = "Inchei runda(galben)";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1209, 499);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 86);
            this.button5.TabIndex = 6;
            this.button5.Text = "Jucator curent";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1208, 606);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 63);
            this.button6.TabIndex = 7;
            this.button6.Text = "Inchei runda (verde)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Zar);
            this.Controls.Add(this.Tabla);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Tabla;
        private System.Windows.Forms.Button Zar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

