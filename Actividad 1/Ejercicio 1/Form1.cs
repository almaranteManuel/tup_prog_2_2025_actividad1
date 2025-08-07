using Ejercicio_1.models;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Ortoedro objeto3 = new Ortoedro(7, 7, 21);
            textBox1.Text = objeto3.Describir();
        }
    }
}
