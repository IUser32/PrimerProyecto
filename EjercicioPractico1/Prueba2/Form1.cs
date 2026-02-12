namespace Prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdivinar_Click(object sender, EventArgs e)
        {
            string palabra = txtPalindromo.Text;

            if (string.IsNullOrEmpty(palabra))
            {
                MessageBox.Show("Debe introducir una palabra correcta.",
                                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var arrayPalabra = palabra.ToArray();
            Array.Reverse(arrayPalabra);

            string palabraInversa = string.Join("", arrayPalabra);

            if (palabra.Equals(palabraInversa, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Esta palabra es palindroma.", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Esta palabra NO es palindroma.", "Informacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstBoxResultado.Items.Clear();

            string numero = txtNumero.Text;

            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("Debe introducir un numero.",
                                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var numeroParsed = 0;
            if (!int.TryParse(numero, out numeroParsed))
            {
                MessageBox.Show("Usted ha introducido un numero incorrecto.",
                                    "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = 1; i <= 12; i++)
            {
                lstBoxResultado.Items.Add(string.Format("{0}x{1}={2}", numeroParsed, i, (numeroParsed*i)));
            }

        }
    }
}
