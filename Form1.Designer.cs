namespace geoAnalitica
{
    partial class FormRecta
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
            label1 = new Label();
            label2 = new Label();
            X1 = new Label();
            Y1 = new Label();
            Punto1 = new GroupBox();
            textBoxY1 = new TextBox();
            textBoxX1 = new TextBox();
            groupBox1 = new GroupBox();
            textBoxY2 = new TextBox();
            textBoxX2 = new TextBox();
            Y2 = new Label();
            label4 = new Label();
            X2 = new Label();
            label6 = new Label();
            textboxDistancia = new Button();
            buttonDistancia = new Button();
            Punto1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 56);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 0;
            label1.Text = "LÍNEA RECTA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 19);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "PUNTO 1";
            label2.Click += label2_Click;
            // 
            // X1
            // 
            X1.AutoSize = true;
            X1.Location = new Point(17, 43);
            X1.Name = "X1";
            X1.Size = new Size(20, 15);
            X1.TabIndex = 2;
            X1.Text = "X1";
            // 
            // Y1
            // 
            Y1.AutoSize = true;
            Y1.Location = new Point(17, 88);
            Y1.Name = "Y1";
            Y1.Size = new Size(20, 15);
            Y1.TabIndex = 3;
            Y1.Text = "Y1";
            // 
            // Punto1
            // 
            Punto1.Controls.Add(textBoxY1);
            Punto1.Controls.Add(textBoxX1);
            Punto1.Controls.Add(Y1);
            Punto1.Controls.Add(label2);
            Punto1.Controls.Add(X1);
            Punto1.Location = new Point(12, 151);
            Punto1.Name = "Punto1";
            Punto1.Size = new Size(200, 121);
            Punto1.TabIndex = 4;
            Punto1.TabStop = false;
            // 
            // textBoxY1
            // 
            textBoxY1.Location = new Point(75, 80);
            textBoxY1.Name = "textBoxY1";
            textBoxY1.Size = new Size(100, 23);
            textBoxY1.TabIndex = 5;
            // 
            // textBoxX1
            // 
            textBoxX1.Location = new Point(75, 48);
            textBoxX1.Name = "textBoxX1";
            textBoxX1.Size = new Size(100, 23);
            textBoxX1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxY2);
            groupBox1.Controls.Add(textBoxX2);
            groupBox1.Controls.Add(Y2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(X2);
            groupBox1.Location = new Point(257, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 121);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // textBoxY2
            // 
            textBoxY2.Location = new Point(75, 80);
            textBoxY2.Name = "textBoxY2";
            textBoxY2.Size = new Size(100, 23);
            textBoxY2.TabIndex = 5;
            // 
            // textBoxX2
            // 
            textBoxX2.Location = new Point(75, 48);
            textBoxX2.Name = "textBoxX2";
            textBoxX2.Size = new Size(100, 23);
            textBoxX2.TabIndex = 4;
            // 
            // Y2
            // 
            Y2.AutoSize = true;
            Y2.Location = new Point(17, 88);
            Y2.Name = "Y2";
            Y2.Size = new Size(20, 15);
            Y2.TabIndex = 3;
            Y2.Text = "Y2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 19);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 1;
            label4.Text = "PUNTO 2";
            // 
            // X2
            // 
            X2.AutoSize = true;
            X2.Location = new Point(17, 43);
            X2.Name = "X2";
            X2.Size = new Size(20, 15);
            X2.TabIndex = 2;
            X2.Text = "X2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 322);
            label6.Name = "label6";
            label6.Size = new Size(125, 15);
            label6.TabIndex = 7;
            label6.Text = "Distancia entre puntos";
            // 
            // textboxDistancia
            // 
            textboxDistancia.Location = new Point(29, 340);
            textboxDistancia.Name = "textboxDistancia";
            textboxDistancia.Size = new Size(142, 28);
            textboxDistancia.TabIndex = 8;
            textboxDistancia.UseVisualStyleBackColor = true;
            // 
            // buttonDistancia
            // 
            buttonDistancia.Location = new Point(528, 197);
            buttonDistancia.Name = "buttonDistancia";
            buttonDistancia.Size = new Size(75, 75);
            buttonDistancia.TabIndex = 9;
            buttonDistancia.Text = "DISTANCIA ENTRE DOS PUNTOS";
            buttonDistancia.UseVisualStyleBackColor = true;
            buttonDistancia.Click += buttonDistancia_Click;
            // 
            // FormRecta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(662, 543);
            Controls.Add(buttonDistancia);
            Controls.Add(textboxDistancia);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(Punto1);
            Controls.Add(label1);
            Name = "FormRecta";
            Text = "LINEA RECTA";
            WindowState = FormWindowState.Maximized;
            Punto1.ResumeLayout(false);
            Punto1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label X1;
        private Label Y1;
        private GroupBox Punto1;
        private TextBox textBoxY1;
        private TextBox textBoxX1;
        private GroupBox groupBox1;
        private TextBox textBoxY2;
        private TextBox textBoxX2;
        private Label Y2;
        private Label label4;
        private Label X2;
        private Label label6;
        private Button textboxDistancia;
        private Button buttonDistancia;
    }
}
