namespace HereditySample
{
    abstract class Animal
    {
        protected string name;
        protected int posX, posY, posZ;
        protected float width, height, weight;

        protected void Translate(int newPosX)
        {
            //Implementação do método de translação
        }

        //método abstrato não há implementação
        abstract protected void Breathe();
    }
}