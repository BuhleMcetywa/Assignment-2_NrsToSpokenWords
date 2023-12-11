namespace NrstoSpokenWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four-digit number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0 || number > 9999)
            {
                Console.WriteLine("Please enter a valid four-digit number.");

            }

            else if (number == 0)
            {
                Console.WriteLine("Zero");

            }
            else
            {
                Console.WriteLine(NumbersToWords.ConvertToWords(number));
            }

        }
    }
}
