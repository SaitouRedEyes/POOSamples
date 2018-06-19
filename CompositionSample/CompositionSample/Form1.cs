using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompositionSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Player player = new Player("JAMV");

            //Se player matou algum inimigo, drop a new Item;
            Item item = new Item("Leather Armor");

            //Se player colidiu com item;
            player.AddItem(item);
        }
    }
}
