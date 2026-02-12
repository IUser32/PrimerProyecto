namespace Prueba2
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
            btnAdivinar = new Button();
            txtPalindromo = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtNumero = new TextBox();
            label2 = new Label();
            btnMostrar = new Button();
            lstBoxResultado = new ListBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdivinar
            // 
            btnAdivinar.Location = new Point(481, 66);
            btnAdivinar.Name = "btnAdivinar";
            btnAdivinar.Size = new Size(274, 241);
            btnAdivinar.TabIndex = 0;
            btnAdivinar.Text = "Adivinar";
            btnAdivinar.UseVisualStyleBackColor = true;
            btnAdivinar.Click += btnAdivinar_Click;
            // 
            // txtPalindromo
            // 
            txtPalindromo.Location = new Point(63, 131);
            txtPalindromo.Name = "txtPalindromo";
            txtPalindromo.Size = new Size(412, 47);
            txtPalindromo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 66);
            label1.Name = "label1";
            label1.Size = new Size(121, 41);
            label1.TabIndex = 2;
            label1.Text = "Palabra:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnAdivinar);
            groupBox1.Controls.Add(txtPalindromo);
            groupBox1.Location = new Point(30, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(808, 341);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Palindromo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lstBoxResultado);
            groupBox2.Controls.Add(btnMostrar);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Location = new Point(30, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1049, 499);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Multiplicación";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(15, 117);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(250, 47);
            txtNumero.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(134, 41);
            label2.TabIndex = 3;
            label2.Text = "Numero:";
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(281, 89);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(274, 103);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lstBoxResultado
            // 
            lstBoxResultado.FormattingEnabled = true;
            lstBoxResultado.ItemHeight = 41;
            lstBoxResultado.Location = new Point(589, 139);
            lstBoxResultado.Name = "lstBoxResultado";
            lstBoxResultado.Size = new Size(431, 332);
            lstBoxResultado.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(589, 89);
            label3.Name = "label3";
            label3.Size = new Size(156, 41);
            label3.TabIndex = 5;
            label3.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1599, 983);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdivinar;
        private TextBox txtPalindromo;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label3;
        private ListBox lstBoxResultado;
        private Button btnMostrar;
        private Label label2;
        private TextBox txtNumero;
    }
}
