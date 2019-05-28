
namespace POO3
{
    class NPC : Character
    {
        private string text;

        public NPC(string text)
        {
            this.text = text;
        }

        public override void Update()
        {
            //Atualizo lógicamente o objeto
            //posX = 80;
            //Atualizo graficamente o objeto
            Draw();
        }

        public void NextText(string newText)
        {
          //if(!newText.Equals(""))
            if(newText != "")
            {
                text = newText;
            }
        }
    }
}
