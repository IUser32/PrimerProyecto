namespace CalculadoraNomina
{
    partial class FrmCalculadora
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
            label1 = new Label();
            mskSueldo = new MaskedTextBox();
            btnCalcular = new Button();
            label2 = new Label();
            txtArs = new TextBox();
            groupBox1 = new GroupBox();
            label5 = new Label();
            txtTotal = new TextBox();
            label4 = new Label();
            txtIsr = new TextBox();
            label3 = new Label();
            txtAfp = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(117, 41);
            label1.TabIndex = 0;
            label1.Text = "Sueldo:";
            // 
            // mskSueldo
            // 
            mskSueldo.Location = new Point(38, 75);
            mskSueldo.Mask = "999999";
            mskSueldo.Name = "mskSueldo";
            mskSueldo.Size = new Size(250, 47);
            mskSueldo.TabIndex = 1;
            mskSueldo.ValidatingType = typeof(int);
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(322, 69);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(188, 58);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 78);
            label2.Name = "label2";
            label2.Size = new Size(78, 41);
            label2.TabIndex = 3;
            label2.Text = "ARS:";
            // 
            // txtArs
            // 
            txtArs.Location = new Point(130, 78);
            txtArs.Name = "txtArs";
            txtArs.ReadOnly = true;
            txtArs.Size = new Size(311, 47);
            txtArs.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtIsr);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAfp);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtArs);
            groupBox1.Location = new Point(38, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(486, 365);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Deducciones";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 282);
            label5.Name = "label5";
            label5.Size = new Size(88, 41);
            label5.TabIndex = 9;
            label5.Text = "Total:";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(130, 282);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(311, 47);
            txtTotal.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 217);
            label4.Name = "label4";
            label4.Size = new Size(67, 41);
            label4.TabIndex = 7;
            label4.Text = "ISR:";
            // 
            // txtIsr
            // 
            txtIsr.Location = new Point(130, 217);
            txtIsr.Name = "txtIsr";
            txtIsr.ReadOnly = true;
            txtIsr.Size = new Size(311, 47);
            txtIsr.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 150);
            label3.Name = "label3";
            label3.Size = new Size(76, 41);
            label3.TabIndex = 5;
            label3.Text = "AFP:";
            // 
            // txtAfp
            // 
            txtAfp.Location = new Point(130, 150);
            txtAfp.Name = "txtAfp";
            txtAfp.ReadOnly = true;
            txtAfp.Size = new Size(311, 47);
            txtAfp.TabIndex = 6;
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 556);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcular);
            Controls.Add(mskSueldo);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCalculadora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deducciones";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox mskSueldo;
        private Button btnCalcular;
        private Label label2;
        private TextBox txtArs;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtIsr;
        private Label label3;
        private TextBox txtAfp;
        private Label label5;
        private TextBox txtTotal;
    }
}