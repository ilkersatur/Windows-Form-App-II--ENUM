using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCokluForm
{
    public partial class Takvim : Form
    {
        public Takvim()
        {
            InitializeComponent();
        }
        Form1 _frm;
        public Takvim(Form1 frm)
        {
            InitializeComponent();
            _frm= frm;   
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            _frm.Tarih = e.Start.ToString();
            this.Close();
        }
    }
}
