using System.Collections;
// Noah Hoff NET24

namespace Felsökning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Case 1. Problem: Koden genererar ett fel och körs inte.

            //int number = 2;

            //if (number > 3)
            //{
            //    Console.WriteLine("Talet är större än tre"); // la till ett saknat semicolon
            //}
            //else if (number < 3) // la till ett saknat mellanrum
            //{
            //    Console.WriteLine("Talet är mindre än tre");
            //}
            //else // la till else för att fånga de som de tidigare inte fångar
            //{
            //    Console.WriteLine("Talet är tre");
            //}

            // Case 2. Problem: Koden ska skriva ut alla siffror mellan 1 och 100 men skriver bara ut till nummer 99

            //for (int i = 1; i <= 100; i++) // la till ett = tecken så att loopen fortsätter sålänge den är mindre eller = 100
            //{
            //    Console.WriteLine(i);
            //}

            // Case 3. Problem: Koden genererar ett fel och körs inte

            //for (int i = 1; i <= 5; i++) // la till ++ efter i och j eftersom det fältet behöver en förändring av veriabeln, och ingen annan info gavs.
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}

            // Case 4. Problem: Koden har ingen output, varför inte?
            // la till "" och innehåll i Console.Write och Console.WriteLine, nu är det en rutschkana

            //int i = 1;
            //while (i <= 5)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("O"); 
            //    }

            //    Console.WriteLine("\\");
            //    i++;
            //}

            // Case 5. Problem: 
            //Eftersom i är 1 i exemplet nedan förväntar vi oss att koden
            //inte ska göra något men nu skriver den ut "Two".
            //Varför blir det så och hur löser vi det så att det inte blir någon utskrift om i är 1?

            //int i = 1;

            //switch (i)
            //{
            //    case 1:
            //        break; // la till break så att case 2 inte faller under case 1
            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    default:
            //        Console.WriteLine("Other");
            //        break;
            //}

            // Case 6. Problem: Koden genererar ett fel och körs inte.

            //int i = 10;

            //if (i == 5) // la till ett = så att i och 5 jämförs istället för att i tilldelas 5
            //{
            //    Console.WriteLine("i är 5");
            //}
        }
    }
}
