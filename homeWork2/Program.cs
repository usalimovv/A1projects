namespace homeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bitta son berilgan uni necha xonali ekanligini aniqlang
            /*
            Console.WriteLine("Sonni kiriting: ");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number < 0)
            {
                number = number * -1;
            }
            var counter = 0;
            while (number > 0)
            {
                number = number / 10;
                counter++;
            }
            Console.WriteLine("res >> " + counter);
            */

            // bitta son berilgan Berilgan sonda juft raqamlar miqdorini aniqlang
            /*Console.WriteLine("enter number : ");
            var number = int.Parse(Console.ReadLine());
            var counter = 0;
            while (number > 0)
            {
                if ((number % 10) % 2 == 0)
                {
                    counter++;
                }
                number = number / 10;
            }
            Console.WriteLine("res : " + counter);*/

            // foydalanuvchi tomonidan sonlar kiritilaveradi bu holat 0 kiritilguncha davom etadi // Bu kiritilgan sonlarni miqdorini toping // 0 hisobga olinmasin

            /*Console.Write("Enter num : ");
            var number = int.Parse(Console.ReadLine());
            var counter = 0;
            while (number != 0)
            {
                if (number == 0)
                {
                    break;
                }
                counter++;
                Console.Write("Enter num : ");
                number = int.Parse(Console.ReadLine());
            }
            Console.Write("\n\nres : " + counter + "\n");*/

            // 1 ta son berilgan // bu sonni raqamlari ichida 5 soni bor yoqligini tekshiring ::
            /*
            Console.Write("Enter num : ");
            var number = Console.ReadLine();

            for (var i = 0; i < number.Length; i++)
            {
                if (number[i] == '5')
                {
                    Console.WriteLine("5 raqami bor");
                    return ;
                }
            }
            Console.WriteLine("5 raqami yo'q");*/

            //n soni berilgan (n>0) . Agar n soni 3ni darajasi bolsa "n soni 3 nig darajasi !"// aks xolda 
            //"n soni 3 ning darajasi emas !" degan natija chiqaruvchi dastur tuzing 
            // qoldiqli bolish va bolishni ishlatmang
            




            Main(args);
        }
    }
}
