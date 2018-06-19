namespace POO2
{
    class Person
    {
        public float hairLength;
        private string name;
        private int age;
        private DomesticAnimal animal;

        public Person(string name)
        {
            this.name = name;
            hairLength = 0;
            age = 0;
        }

        public void SetName(string newName)
        {
            if(age > 18)
            {
                name = newName;
            }
        }

        public void SetAnimal(string type, string name)
        {
            this.animal = new DomesticAnimal(type, name);
        }
    }
}


