using System;
namespace Program
{
    public class Pair       // Pair num = new Pair(new TimeSpan (12,23,04)); - ввод времени
    {
        private readonly TimeSpan beginningsP;
        private readonly TimeSpan endingP;
        private readonly TimeSpan beginningsBreak;
        private readonly TimeSpan endingBreak;
        private readonly Shift shift;

        public Pair()
        {
            beginningsP = new TimeSpan(00, 00, 00);
            endingP = new TimeSpan(00, 00, 00);
            beginningsBreak = new TimeSpan(00, 00, 00);
            endingBreak = new TimeSpan(00, 00, 00);
            shift = new("Нет данных");
        }

        public TimeSpan BeginningsP { get => beginningsP; }
        public TimeSpan EndingP { get => endingP; }
        public TimeSpan BeginningsBreak { get => beginningsBreak; }
        public TimeSpan EndingBreak { get => endingBreak; }
        public Shift Shift_ { get => shift; }
        public Pair(TimeSpan beginningsP, TimeSpan endingP, TimeSpan beginningsBreak, TimeSpan endingBreak, Shift shift)
        {
            this.beginningsP = beginningsP;
            this.endingP = endingP;
            this.beginningsBreak = beginningsBreak;
            this.endingBreak = endingBreak;
            this.shift = shift;
        }
    }
    public class Shift
    {
        private readonly string name;

        public string Name { get => name; }

        public Shift(string name)
        {
            this.name = name;
        }
    }
    public class Employee
    {
        private readonly string fam;
        private readonly string name;
        private readonly string otch;
        private readonly Post post;

        public Employee(string fam, string name, string otch, Post post)
        {
            this.fam = fam;
            this.name = name;
            this.otch = otch;
            this.post = post;
        }
    }
    public class Post
    {
        private readonly string name;
        private readonly int salary;
        private readonly Division division;

        public string Name { get => name; }
        public int Salary { get => salary; }
        public Division Division { get => division; }
        public Post(string name, int salary, Division division)
        {
            this.name = name;
            this.salary = salary;
            this.division = division;
        }
    }
}
