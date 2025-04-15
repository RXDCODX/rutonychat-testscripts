using TestScripts;

namespace RutonyChat
{
    class Program
    {
        static void Main(string[] args)
        {
            TestMethods._script = new Script();
            TestMethods._script.InitParams("");

            // -----------------------------------------------------

            TestMethods.NewDonate();
            TestMethods.NewTwitchPoints();

            TestMethods.NewMessage("twitch", "rutony", "!hello");
            TestMethods.NewMessage("twitch", "vasya", "!hello");

            // ------------------------------------------------------

            TestMethods._script.Closing();

            Console.ReadKey();
        }
    }
}
