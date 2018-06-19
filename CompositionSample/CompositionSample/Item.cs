namespace CompositionSample
{
    class Item
    {
        private string name;
        public int hpModifier, atkModifier, defModifier, spdModifier;
        public int lvl;

        public Item(string name)
        {
            this.name = name;

            //Consulta ao DB para pegar os stats (no momento valores fictícios serão atribuidos)
            hpModifier = 2;
            atkModifier = 0;
            defModifier = 3;
            spdModifier = -1;

            lvl = 1; 
        }
    }
}
