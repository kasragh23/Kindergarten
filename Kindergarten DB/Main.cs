using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main(String welcome)
        {
           // setWelcome = welcome;
            InitializeComponent();
        }
        
        private String welcome;

        public void setWelcome(String welcome)
        {
            this.welcome = welcome;
        }
        public String getWelcome()
        {
            return welcome;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lblwel.Text = "Welcome Dear " + welcome;
        }
    }
}
