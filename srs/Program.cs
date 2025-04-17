namespace srs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number!");
            var num = Convert.ToInt32(Console.ReadLine());

            var ones = num % 10;
            var tens = (num / 10) % 10;
            var hunders = (num / 100) % 10;
            var tsousands = (num / 1000) % 10;

            var res = ones + tens + hunders + tsousands;

            Console.Write("res : " + res );


        }
    }
}
