using System;

namespace PolimorfismSample
{
    class Player : Character, Villain
    {
        protected override void Move()
        {
            //Move Player
        }

        public void Destruct()
        {
            //Destrói coisas
        }

        public void Kill()
        {
            //Mata coisas
        }

        public void Love()
        {
            //Ama coisas
        }
    }
}
