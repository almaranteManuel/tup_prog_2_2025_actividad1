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

            Rectangulo objeto2 = new Rectangulo(2, 4);

            textBox1.Text += $@"[
              {objeto2.Describir()},
              {objeto3.Describir()},
            ]";
        }
    }
}
