using System.Security.Cryptography.X509Certificates;

namespace BirdenFazlaForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frm de ki text i, takvimde label a yazma
            //ctor 
            //frmTakvim takvim = new frmTakvim();
            //1.yontem public yap (Encapsulation)
            //2.yontem Metod
            //takvim.EtiketDegis(textBox1.Text);
            //3.yontem ctor
            //4.yontem prop
            frmTakvim takvim = new frmTakvim();
            takvim.Degistir = textBox1.Text;
            takvim.ShowDialog();
        }
    }
}