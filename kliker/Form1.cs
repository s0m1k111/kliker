using System.Windows.Forms;

namespace kliker
{
    public partial class Form1 : Form
    {
        Delay delay = new Delay();
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Resource1.prevedbol;
            delay.Start(timer1, 3, Shownax);
        }
        private void Shownax()
        {
            pictureBox1.Image = Resource1.prevedmal;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            delay.Tick();
        }
    }
}
