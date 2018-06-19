using System.Drawing;

namespace POO3
{
    abstract class Character 
    {
        protected string name;
        protected float posX, posY;
        protected Bitmap image;

        protected void Draw()
        {
            //Desenha imagem
        }

        abstract public void Update();
    }
}
