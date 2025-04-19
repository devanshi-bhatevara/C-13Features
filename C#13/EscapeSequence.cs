namespace CSharp13
{
    public class EscapeSequence
    {
        //Earlier we had to use \u001b or \x1b as an escape character now we can use \e directly
        public static void Run()
        {
            //before
            string red = "\u001b[31m";    // Start red color
            string reset = "\u001b[0m";

            Console.WriteLine($"{red}This is RED text using old escape sequence{reset}");
            Console.WriteLine("This is normal text.");

            //after
            string redNew = "\e[31m";    // Start red color
            string resetNew = "\e[0m";   // Reset color

            Console.WriteLine($"{redNew}This is RED text using new escape sequence{resetNew}");
            Console.WriteLine("This is normal text.");
        }
    }
}
