using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optik_Proje
{
    public partial class FRMURUN : Form
    {
        public FRMURUN()
        {
            InitializeComponent();
        }

        private void FRMURUN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hareketProjeDataSet3.URUNLER' table. You can move, or remove it, as needed.
            this.uRUNLERTableAdapter.Fill(this.hareketProjeDataSet3.URUNLER);

        }
    }
}
