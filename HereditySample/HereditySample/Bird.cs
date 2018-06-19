using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HereditySample
{
    class Bird : Animal
    {
        public Bird(string name, int x, int y, int z, float w, float h)
        {
            this.name = name;
            posX = x; posY = y; posZ = z;
            width = w; height = h;
            weight = width / height;
        }

        protected override void Breathe()
        {
            //Implementação da respiração apenas pulmonar
        }

        private void Fly()
        {
            //Implementação de método específico
        }
    }
}
