namespace geoAnalitica
{
    public partial class FormRecta : Form
    {
        public FormRecta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonDistancia_Click(object sender, EventArgs e)
        {
            //crear dos ojetos de la clase punto local
            Punto a = new Punto();//Crear objeto de la clase punto
            Punto b = new Punto();//Crear objeto de la clase punto
            //colocar en a los valores de x1
            //colocar en b los valores de x2
            a.X = Convert.ToSingle(textBoxX1.Text);
            a.Y = Convert.ToSingle(textBoxY1.Text);
            b.X = Convert.ToSingle(textBoxX2.Text);
            b.X = Convert.ToSingle(textBoxY2.Text);
            Recta rec1= new Recta(a, b);
            textboxDistancia.Text = Convert.ToString(rec1.distancia());
        }
    }
}
