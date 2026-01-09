using System;


namespace task
{
    class Player
    {

        public void ShowInfo(Metods character)
        {
            character.ShowInfoName();
        }
        public void ShowStateInfo(Metods character)
        {
            character.ShowSkillInfo();
        }
        
        public void Specifications(Metods character)
        {
            character.ShowStateInfo();
        }

    }
}
