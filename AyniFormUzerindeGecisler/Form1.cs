namespace AyniFormUzerindeGecisler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex=sayac;
            sayac++;
        }

        private void çýkýþToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Text = "Yükleeme...";
            toolStripProgressBar1.Value = 56;
        }
    }
}