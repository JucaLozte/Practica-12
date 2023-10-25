namespace Practica_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Cal;
            Cal = double.Parse(textBox1.Text);
            if (Cal < 3.0) MessageBox.Show("REPROBADO");
        }
    }
}