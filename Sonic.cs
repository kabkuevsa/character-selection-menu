using System;

namespace task
{
    class Sonic : Character, Metods
    {
        public override string Health => "85 единиц здоровья";

        public override string Damage => "10 урона с 1 клика";
        public override string Passive => "Резкие дэши";

        public  void ShowStateInfo()
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
            Console.WriteLine($"3.{GetType().Name}");
        } 
        public  void FirstSkills()
        {
            Console.WriteLine("Flash Strike");
        }

        public  void FourthSkills()
        {
            Console.WriteLine("Whirlwind Kick");
        }

        public  void SecondSkills()
        {
            Console.WriteLine("Scatter");
        }

        public  void ThirdSkills()
        {
            Console.WriteLine("Explosive Shuriken");
        }

        
    }
}
