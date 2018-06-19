using System.Windows.Forms;

namespace AbstractionSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StudantNAVE s1 = new StudantNAVE("José Augusto", "123456", "Programação", 1003, 15);
            StudantNAVE s2 = new StudantNAVE("Henrique", "987654", "Multimidia", 1001, 8);

            nameS1.Text = s1.name;
            nameS2.Text = s2.name;

            registrationNumberS1.Text = s1.registerNumber;
            registrationNumberS2.Text = s2.registerNumber;

            courseS1.Text = s1.course;
            courseS2.Text = s2.course;

            classS1.Text = s1.myClass.ToString();
            classS2.Text = s2.myClass.ToString();

            classNumberS1.Text = s1.classNumber.ToString();
            classNumberS2.Text = s2.classNumber.ToString();

        }
    }
}
