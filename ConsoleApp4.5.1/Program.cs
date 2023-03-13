namespace ConsoleApp4._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] Favcolors, double Age) User;

            for (int k = 0; k < 3; k++)
            {

                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length;

                Console.WriteLine("Напишите есть ли у вас животные? Да или Нет");

                var result = Console.ReadLine();
                if (result == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }
                Console.WriteLine("Введите три любимых цвета пользователя");
                User.Favcolors = new string[3];

                for (int i = 0; i < User.Favcolors.Length; i++)
                {
                    User.Favcolors[i] = Console.ReadLine();
                }
                Console.WriteLine("Введите возраст пользователя");
                User.Age = double.Parse(Console.ReadLine());
            }
        }
    }
}