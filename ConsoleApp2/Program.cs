namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Илья";
            byte MyAge = 25;
            bool MyPet = true;
            double MyShoeSize = 43.5;

            Console.WriteLine("Меня зовут "+ MyName);
            Console.WriteLine("мне " + MyAge);
            Console.WriteLine("Есть ли у меня живность в доме? " + MyPet);
            Console.WriteLine("Мой размер ноги " + MyShoeSize);
        }
    }
}