
using System.Windows.Forms;

namespace POO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Player p1 = new Player("JAMV", "c://Image/Mago.jpg");
            Player p2 = new Player("Alisson", "c://Image/Arqueiro.jpg");

            NPC n1 = new NPC("Pega a galinhaaa");
            NPC n2 = new NPC("Quer comprar algo??");

            p1.Update();
            p2.Update();
            n1.Update();
            n2.Update();

            //batalha fake que gera xp
            p1.CouldLevelUp(5);
            n1.NextText("SHOOOOWWWWW....TOMA PÓTE!!");
            n1.NextText("OBRIGADOOO");
        }
    }
}
