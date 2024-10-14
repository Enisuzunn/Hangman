namespace Hangman
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
            textTahmin = new TextBox();
            label15 = new Label();
            buttonTahmin = new Button();
            labelHata = new Label();
            buttonTekrar = new Button();
            button3 = new Button();
            label1Ekran = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textTahmin
            // 
            textTahmin.Location = new Point(517, 614);
            textTahmin.Name = "textTahmin";
            textTahmin.Size = new Size(618, 39);
            textTahmin.TabIndex = 14;
            // 
            // label15
            // 
            label15.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(213, 614);
            label15.Name = "label15";
            label15.Size = new Size(182, 39);
            label15.TabIndex = 15;
            label15.Text = "Tahmin:";
            label15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonTahmin
            // 
            buttonTahmin.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            buttonTahmin.Location = new Point(706, 704);
            buttonTahmin.Name = "buttonTahmin";
            buttonTahmin.Size = new Size(187, 74);
            buttonTahmin.TabIndex = 16;
            buttonTahmin.Text = "Tahmin";
            buttonTahmin.UseVisualStyleBackColor = true;
            buttonTahmin.Click += buttonTahmin_Click;
            // 
            // labelHata
            // 
            labelHata.Font = new Font("Segoe UI Black", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 162);
            labelHata.Location = new Point(53, 704);
            labelHata.Name = "labelHata";
            labelHata.Size = new Size(244, 80);
            labelHata.TabIndex = 17;
            labelHata.Text = "Hatalı Tahmin: ";
            labelHata.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonTekrar
            // 
            buttonTekrar.Location = new Point(967, 168);
            buttonTekrar.Name = "buttonTekrar";
            buttonTekrar.Size = new Size(186, 66);
            buttonTekrar.TabIndex = 18;
            buttonTekrar.Text = "Tekrar";
            buttonTekrar.UseVisualStyleBackColor = true;
            buttonTekrar.Click += buttonTekrar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1193, 168);
            button3.Name = "button3";
            button3.Size = new Size(186, 66);
            button3.TabIndex = 19;
            button3.Text = "Çıkış";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1Ekran
            // 
            label1Ekran.BackColor = Color.White;
            label1Ekran.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1Ekran.Location = new Point(100, 871);
            label1Ekran.Name = "label1Ekran";
            label1Ekran.Size = new Size(1212, 94);
            label1Ekran.TabIndex = 20;
            label1Ekran.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.realBos;
            pictureBox1.Location = new Point(83, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 437);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 1135);
            Controls.Add(pictureBox1);
            Controls.Add(label1Ekran);
            Controls.Add(button3);
            Controls.Add(buttonTekrar);
            Controls.Add(labelHata);
            Controls.Add(buttonTahmin);
            Controls.Add(label15);
            Controls.Add(textTahmin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textTahmin;
        private Label label15;
        private Button buttonTahmin;
        private Label labelHata;
        private Button buttonTekrar;
        private Button button3;
        private Label label1Ekran;
        private PictureBox pictureBox1;
    }
}
