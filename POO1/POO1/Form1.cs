using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Person adam = new Person("Adão", "01");
            Person eve = new Person("Eva", "02");
            
            labelAdam.Text = adam.name;
            labelAdamNumber.Text = adam.registrationNumber;

            labelEve.Text = eve.name;
            labelEveNumber.Text = eve.registrationNumber;

            //Item i1 = new Item("AK-47", adam);
        }
    }
}





