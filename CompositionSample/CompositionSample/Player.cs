namespace CompositionSample
{
    class Player
    {
        private string name;
        private int hpBase, atkBase, defBase, spdBase, hpReal, atkReal, defReal, spdReal;
        private int lvl;
        private Item item;

        public Player(string name)
        {
            this.name = name;
            hpBase = hpReal = 10;
            atkBase = defBase = spdBase = atkReal = defReal = spdReal = 5;
            lvl = 1;
        }

        public void AddItem(Item newItem)
        {
            if(lvl >= newItem.lvl)
            {
                item = newItem;
                hpReal = hpBase + item.hpModifier;
                atkReal = atkBase + item.atkModifier;
                defReal = defBase + item.defModifier;
                spdReal = spdBase + item.spdModifier;
            }
        }
    }
}
