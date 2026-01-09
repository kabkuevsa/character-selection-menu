using System;


namespace task
{
    class Genos : Character, Metods
    {
        public override string Health => "95 единиц здоровья";

        public override string Damage => "9 урона с 1 клика";
        public override string Passive => "После убийства пропадает кд на скилы";

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
            Console.WriteLine($"2.{GetType().Name}");
        }

        public  void FirstSkills()
        {
            Console.WriteLine("Machine Gun Blows");
        }

        public  void FourthSkills()
        {
            Console.WriteLine("Ignition Burst");
        }

        public  void SecondSkills()
        {
            Console.WriteLine("Blitz Shot");
        }

        public  void ThirdSkills()
        {
            Console.WriteLine("Jet Dive");
        }

        
    }
}
