using System;
namespace Exercise_6
{
    public class Dog
    {
        private string _name;
        private string _sex;

        public string Name { get => _name; set => _name = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public Dog Father { get; set; }
        public Dog Mother { get; set; }

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public string GetFatherName()
        {
            if (Father != null)
            {
                return Father.Name;
            }
            return "Unknown";
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (this.Mother != null && otherDog.Mother != null)
            {
                return this.Mother.Name == otherDog.Mother.Name;
            }
            return false;
        }
    }
}