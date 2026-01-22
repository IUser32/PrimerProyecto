namespace EjercicioPractico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string mensaje = $"Hola {nombre}, espero que estes bien.";

            MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK);
        }
    }
}
