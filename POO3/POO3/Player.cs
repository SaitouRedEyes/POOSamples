
using System.Drawing;

namespace POO3
{
    class Player : Character
    {
        private int lvl;
        private int currentXP, limitLvlXP;

        public Player(string name, string filePath)
        {
            this.name = name;
            lvl = 1;
            currentXP = 0;
            limitLvlXP = 20;
            posX = posY = 5;
            image = new Bitmap(filePath);
        }

        public override void Update()
        {
            //Atualizo lógicamente o objeto
            //posX = 30;
            //Atualizo graficamente o objeto
            Draw();
        }

        public void CouldLevelUp(int receivedXP)
        {
            currentXP = currentXP + receivedXP;

            if(currentXP >= limitLvlXP)
            {
                lvl = lvl + 1;
                limitLvlXP *= 2;
            }
        }
    }
}
