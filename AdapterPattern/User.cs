namespace AdapterPattern
{
    public class User
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public User()
        {
            Name = "Gues";
            Age = -1;
        }
    }
}
