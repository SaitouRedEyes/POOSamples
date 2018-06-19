
using System.Drawing;

namespace POO3
{
    class Player : Character
    {
        private int lvl;
        private int currentXP, limitLvlXP;

        public Player(string name)
        {
            this.name = name;
            lvl = 1;
            currentXP = 0;
            limitLvlXP = 20;
            posX = posY = 5;
            image = new Bitmap("ImageName");
        }

        public override void Update()
        {
            //Atualizo lógicamente o objeto
            //Atualizo graficamente o objeto
            Draw();
        }

        public void CouldLevelUp(int receivedXP)
        {
            currentXP += receivedXP;

            if(currentXP >= limitLvlXP)
            {
                lvl += 1;
                limitLvlXP *= 2;
            }
        }
    }
}
