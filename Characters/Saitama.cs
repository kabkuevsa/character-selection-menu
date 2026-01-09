using System;


namespace task
{
    class Saitama : Character, Metods
    {
        public override string Health => "120 единиц здоровья";

        public override string Damage => "11 урона с 1 клика";
        public override string Passive => "Повышенный урон";

        public void ShowStateInfo()
        {
            Console.WriteLine("\n______________________");
            Console.WriteLine(Health);
            Console.WriteLine(Damage);
            Console.WriteLine(Passive);
            Console.WriteLine("______________________");
        }
        public  void ShowSkillInfo()
        {
            Console.WriteLine("________________");
            FirstSkills();
            SecondSkills();
            ThirdSkills();
            FourthSkills();
            Console.WriteLine("________________");
        }
        public  void ShowInfoName()
        {
            Console.WriteLine($"1.{GetType().Name}");
        }

        public  void FirstSkills()
        {
            Console.WriteLine("Normal Punch");
        }

        public  void FourthSkills()
        {
            Console.WriteLine("Uppercut");
        }

        public  void SecondSkills()
        {
            Console.WriteLine("Consecutive Punches");
        }

        public  void ThirdSkills()
        {
            Console.WriteLine("Shove");
        }

        
    }
}
