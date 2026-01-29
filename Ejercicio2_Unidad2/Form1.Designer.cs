namespace Ejercicio2_Unidad2
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
            btnCambiar = new Button();
            lblTextoACambiar = new Label();
            SuspendLayout();
            // 
            // btnCambiar
            // 
            btnCambiar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiar.Location = new Point(99, 106);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(247, 107);
            btnCambiar.TabIndex = 0;
            btnCambiar.Text = "Cambiar";
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += btnCambiar_Click;
            // 
            // lblTextoACambiar
            // 
            lblTextoACambiar.AutoSize = true;
            lblTextoACambiar.Font = new Font("Segoe UI", 20.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoACambiar.ForeColor = SystemColors.ButtonFace;
            lblTextoACambiar.Location = new Point(376, 106);
            lblTextoACambiar.Name = "lblTextoACambiar";
            lblTextoACambiar.Size = new Size(283, 89);
            lblTextoACambiar.TabIndex = 1;
            lblTextoACambiar.Text = "Texto....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(938, 307);
            Controls.Add(lblTextoACambiar);
            Controls.Add(btnCambiar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCambiar;
        private Label lblTextoACambiar;
    }
}
