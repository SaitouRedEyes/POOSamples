
namespace POO3
{
    class NPC : Character
    {
        private string text;

        public NPC()
        {
            text = "Pega a galinha!!!!";
        }

        public override void Update()
        {
            Draw();
        }

        public void NextText(string newText)
        {
            if(!newText.Equals(""))
            {
                text = newText;
            }
        }
    }
}
