using System.Windows.Forms;

namespace PolimorfismSample
{
    class NPC : Character
    {
        private string text;

        protected override void Move()
        {
            //Move NPC
        }

        public void Talk(string newText)
        {
            text = newText;
        }

        public void Talk(TextBox newText)
        {
            text = newText.Text;
        }
    }
}
