using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDOList
{
    public partial class Listukolu : UserControl
    {
        public string[] Ukoly;
        public string Jmeno;
        public Listukolu()
        {
            InitializeComponent();
        }

        public Listukolu( string jmeno) : this()
        {
            this.Jmeno = jmeno;
            ZobrazJmeno();
        }

        private void ZobrazJmeno()
        {
            label1.Text = Jmeno;
        }
    }
}
