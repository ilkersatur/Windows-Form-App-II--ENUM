namespace From_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
            {
                if (label1.Left < this.Width)
                {
                    label1.Left = 0 - label1.Width;

                }
                label1.Left -= 5;
            }
            else if (e.KeyCode == Keys.Right)
            {
                label1.Left += 5;
                if (label1.Left > this.Width)
                {
                    label1.Left = 0 - label1.Width;

                }
            }
            else if (e.KeyCode == Keys.Up)
            {
                label1.Top -= 5;
            }
            else if (e.KeyCode == Keys.Down)
            {
                label1.Top += 5;
            }
            else if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dr =MessageBox.Show("Kapatýlsýn mý?","",MessageBoxButtons.YesNo);
            if (dr==DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}