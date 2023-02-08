namespace CastingNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEntero_Click(object sender, EventArgs e)
        {
            //var numero=Int32.Parse(labelEntero.Text);
            var numero = Convert.ToInt32(textBoxEntero.Text);
            var numero2 = numero / 2;
            textBoxMitad.Text = numero2.ToString();
            numero2 = numero * 2;
            textBoxDoble.Text = numero2.ToString();

        }

        private void buttonReal_Click(object sender, EventArgs e)
        {
            var numero = Convert.ToDouble(textBoxReal.Text);
            var numero2 = numero / 2;
            textBoxMitad.Text = numero2.ToString();
            numero2 = numero * 2;
            textBoxDoble.Text = numero2.ToString();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}