namespace Triangulo
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            btnVeri = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(565, 122);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(565, 187);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 1;
            // 
            // txtC
            // 
            txtC.Location = new Point(565, 252);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 2;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(352, 125);
            lblA.Name = "lblA";
            lblA.Size = new Size(44, 15);
            lblA.TabIndex = 3;
            lblA.Text = "Lado A";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(352, 190);
            lblB.Name = "lblB";
            lblB.Size = new Size(43, 15);
            lblB.TabIndex = 4;
            lblB.Text = "Lado B";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(352, 255);
            lblC.Name = "lblC";
            lblC.Size = new Size(44, 15);
            lblC.TabIndex = 5;
            lblC.Text = "Lado C";
            lblC.Click += lblC_Click;
            // 
            // btnVeri
            // 
            btnVeri.Location = new Point(313, 419);
            btnVeri.Name = "btnVeri";
            btnVeri.Size = new Size(75, 23);
            btnVeri.TabIndex = 6;
            btnVeri.Text = "Verificar";
            btnVeri.UseVisualStyleBackColor = true;
            btnVeri.Click += btnVeri_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(475, 419);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 7;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(671, 419);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 8;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 602);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnVeri);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private Button btnVeri;
        private Button btnLimpar;
        private Button btnSair;
    }
}