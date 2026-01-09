using System;


namespace task
{
    interface Metods
    {
        void ShowStateInfo();
        void ShowSkillInfo();
        void ShowInfoName();
        void FirstSkills();
        void SecondSkills(); 
        void ThirdSkills();
        void FourthSkills();
    }

    abstract class Character
    {
        public abstract string Health { get; }
        public abstract string Damage { get; }
        public abstract string Passive { get; }
       

    }
}
