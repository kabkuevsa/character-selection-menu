using System;




namespace task
{

    internal class Program
    {
        static void Main(string[] args)
        {

            MenuPlays();
            Console.ReadKey();
        }


        public static void MenuPlays()
        {
            string yourCharacter = "Casual";
            Console.WriteLine("\n-------------------------");
            Console.WriteLine($"Сейчас вы используете персонажа {yourCharacter}");
            Console.WriteLine("-------------------------");

            while (true)
            {
                Console.WriteLine("\n1. Сменить персонажа");
                Console.WriteLine("2. Посмотреть скилы");
                Console.WriteLine("3. Посмотреть характеристики");
                Console.WriteLine("4. Выход\n");

                if (!int.TryParse(Console.ReadLine(), out int numberChoose))
                {
                    Console.WriteLine("Ошибка ввода! Введите число.");
                    continue;
                }

                switch (numberChoose)
                {
                    case 1:
                        // Меняем персонажа
                        string newCharacter = ChangeCharacter();
                        if (newCharacter != null)
                        {
                            yourCharacter = newCharacter;
                        }
                        break;

                    case 2:
                        // Передаем текущего персонажа в метод просмотра характеристик
                        ShowCharacterSkills(yourCharacter);
                        break;

                    case 3:
                        ShowCharacterStats(yourCharacter);
                        break;

                    case 4:
                        Console.WriteLine("Выход из меню...");
                        return; // Выходим из цикла и метода

                    default:
                        Console.WriteLine("Неверный выбор!");
                        break;
                }
            }
        }

        public static string ChangeCharacter()
        {
            Console.WriteLine("\nВыберите персонажа:");
            Console.WriteLine("1. Saitama");
            Console.WriteLine("2. Genos");
            Console.WriteLine("3. Sonic");
            Console.Write("Ваш выбор: ");

            if (!int.TryParse(Console.ReadLine(), out int numberChoose))
            {
                Console.WriteLine("Ошибка ввода!");
                return null;
            }

            switch (numberChoose)
            {
                case 1:
                    Console.WriteLine("\n=== Вы используете персонажа Saitama ===");
                    return "Saitama";
                case 2:
                    Console.WriteLine("\n=== Вы используете персонажа Genos ===");
                    return "Genos";
                case 3:
                    Console.WriteLine("\n=== Вы используете персонажа Sonic ===");
                    return "Sonic";
                default:
                    Console.WriteLine("Неверный выбор!");
                    return null;
            }
        }

        public static void ShowCharacterSkills(string currentCharacter)
        {
            // Создаем экземпляры персонажей
            Saitama saitama = new Saitama();
            Genos genos = new Genos();
            Sonic sonic = new Sonic();

            // Получаем информацию о текущем персонаже
            Player player = new Player();

            Console.WriteLine($"\nСкилы текущего персонажа ({currentCharacter}):\n");

            switch (currentCharacter)
            {
                case "Saitama":
                    player.ShowStateInfo(saitama);
                    break;
                case "Genos":
                    player.ShowStateInfo(genos);
                    break;
                case "Sonic":
                    player.ShowStateInfo(sonic);
                    break;
                case "Casual":
                    Console.WriteLine("Это обычный персонаж без специальных характеристик.");
                    break;
                default:
                    Console.WriteLine("Неизвестный персонаж.");
                    break;
            }
        }

        public static void ShowCharacterStats(string Character)
        {
            // Создаем экземпляры персонажей
            Saitama saitama = new Saitama();
            Genos genos = new Genos();
            Sonic sonic = new Sonic();

            // Получаем информацию о текущем персонаже
            Player player = new Player();

            switch (Character)
            {
                case "Saitama":
                    player.Specifications(saitama);
                    break;
                case "Genos":
                    player.Specifications(genos);
                    break;
                case "Sonic":
                    player.Specifications(sonic);
                    break;
                case "Casual":
                    Console.WriteLine("Это обычный персонаж без специальных характеристик.");
                    break;
                default:
                    Console.WriteLine("Неизвестный персонаж.");
                    break;
            }
        }



    }




}






