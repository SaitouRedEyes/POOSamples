namespace HereditySample
{
    class Amphibian : Animal
    {
        public Amphibian(string name, int x, int y, int z, float w, float h)
        {
            this.name = name;
            posX = x; posY = y; posZ = z;
            width = w; height = h;
            weight = width * height;
        }

        protected override void Breathe()
        {
            //Implementação da respiração cutânea e pulmonar
        }

        private void Swim()
        {
            //Implementação de método específico
        }
    }
}
