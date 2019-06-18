namespace Homework {
    class Student {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Group { get; set; }
        public string Hobby { get; set; }
        public int Weight { get; set; }
        public int Lenght { get; set; }
        public Student(int age, string name, int group, string hobby, int weight, int lenght) {
            Age = age;
            Name = name;
            Group = group;
            Hobby = hobby;
            Weight = weight;
            Lenght = lenght;
        }
    }
}
