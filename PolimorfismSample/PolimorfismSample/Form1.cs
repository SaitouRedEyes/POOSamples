using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolimorfismSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            NPC npc1 = new NPC();
            npc1.Talk(tbArroz);
            
        }
    }
}
