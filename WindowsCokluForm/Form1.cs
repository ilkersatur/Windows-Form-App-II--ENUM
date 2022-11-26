namespace WindowsCokluForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Takvim takvim = new Takvim(this);
            takvim.Text = textBox1.Text;
            takvim.ShowDialog();
        }
        public string Tarih 
        { 
          get { return textBox1.Text; }
          set{textBox1.Text = value; }
        }
    }
}
