using System.Windows.Forms;

namespace HereditySample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Bird pidgeon = new Bird("pipi", 10, 10, 0, 3.5f, 2.3f);
            Amphibian frog = new Amphibian("sapo", 230, 250, 175, 3.7f, 2.9f);
        }
    }
}
