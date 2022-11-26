namespace Windows_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor=this.BackColor;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Left += 10;
            button1.Top+= 10;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = e.X + " " + e.Y + " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}