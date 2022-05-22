// Напишите программу, которая принимает 
//на вход число и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void GetSum(string[] args)
        {   
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(a));
        }
 
        static int Sum(int value)
        {
            int result = 0;
            result += value % 10;
            value /= 10;
            if(value > 0)
            {
                result += Sum(value);
            }
            return result;
        }
GetSum(args);
