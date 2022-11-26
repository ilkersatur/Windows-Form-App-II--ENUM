namespace _18._11._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("","",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
            button1.Dock = DockStyle.Left;
            textBox1.TextAlign = HorizontalAlignment.Center;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = true;
            DialogResult dialog = colorDialog1.ShowDialog();
            if (dialog == DialogResult.OK) //if((int)dialog==1)
            {
                this.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
            label1.ForeColor = fontDialog1.Color;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            label1.Text = openFileDialog1.FileName;
            //filtreleme için property den filter dan yapýlýr
            // Text Dosyalar|*txt|JPG Dosyalar
        }

        private void button6_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            label1.Text = saveFileDialog1.FileName;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Emin misin", "Uyarý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                MessageBox.Show("Ýþlemi yap");
            }
        }
    }
}