using System.Windows.Forms;

namespace POO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Person p1 = new Person("Adao");
            Person p2 = new Person("Eva");

            p1.SetAnimal("Cat", "Tomas");
        }
    }
}

