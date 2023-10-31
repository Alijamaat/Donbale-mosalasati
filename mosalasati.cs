using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
                //علی پیر محمد جماعت و حمیدرضا  واحدی  و مهدی نوروزی   پیشرفته1    شمسی پور
		Console.WriteLine("سلام خوبی میخوام دنباله مثلثاتی اعداد رو بهت بگم دوتا عدد بگو تا من اعداد دنباله مثلثاتی بین اونارو بگم ");

		Console.WriteLine("عدد اول رو بگو: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("عدد دوم رو بگو: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("اینم دنباله مثلثاتی بین دو عدد {0} و {1}:", firstNumber, secondNumber);
		

        for (int i = firstNumber; i <= secondNumber; i++)
       
            { if (donbale(i))
            {Console.WriteLine(i);}   }
         Console.ReadLine();  }     
                static bool donbale(int number)
     {  int sum = 0;
        int n = 1;
       while (sum < number)
         {   sum += n;
              n++;    }
        return sum == number;    }
    }
