using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdenFazlaForm
{
    public partial class frmTakvim : Form
    {
        public frmTakvim()
        {
            InitializeComponent();
        }

        private void frmTakvim_Load(object sender, EventArgs e)
        {

        }
        //metod
        //public void EtiketDegis(string str)
        //{
        //    label1.Text = str;
        //}
        //property
        public string Degistir
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }

    }
}
