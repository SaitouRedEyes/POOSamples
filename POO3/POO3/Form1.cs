
using System.Windows.Forms;

namespace POO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Player p1 = new Player("JAMV");
            NPC n1 = new NPC();

            p1.Update();
            n1.Update();

            p1.CouldLevelUp(40);
            n1.NextText("SHOOOOWWWWW....TOMA PÓTE!!");
        }
    }
}
