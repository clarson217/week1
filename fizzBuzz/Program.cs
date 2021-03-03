using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            String rangeget = Console.ReadLine();
            int firstNum = 0;
            try{
                firstNum = int.Parse(rangeget);
            }catch (Exception e){
                Console.WriteLine("Not a number!");
            }
            Console.WriteLine("Enter another number: ");
            rangeget = Console.ReadLine();
            int secondNum = 0;
            try{
                secondNum = int.Parse(rangeget);
            }catch (Exception e){
                Console.WriteLine("Not a number!");
            }
            Console.WriteLine("Set a value for Fizz: ");
            var fizz = int.Parse(Console.ReadLine());
            Console.WriteLine("Set a value for Buzz: ");
            var buzz = int.Parse(Console.ReadLine());
            var min = 0;
            var max = 0;
            if(firstNum >= secondNum){
                min = secondNum;
                max = firstNum;
            }else{
                min = firstNum;
                max = secondNum;
            }
            FizzBuzz(fizz, buzz, min, max);
            
        }
        public static void FizzBuzz(int fizz, int buzz, int min, int max)
        {
            int[] counts = new int[3];
            counts[0] = 0;
            counts[1] = 0;
            counts[2] = 0;
            for(; min <= max; min++){
                if(min%fizz == 0 && min%buzz == 0)
                {
                    Console.WriteLine("FizzBuzz!");
                    counts[2]++;
                }else if(min%fizz == 0 && min%buzz != 0){
                    Console.WriteLine("Fizz...");
                    counts[0]++;
                }else if(min%buzz == 0 && min%fizz != 0){
                    Console.WriteLine("Buzz...");
                    counts[1]++;
                }
            }
            Console.WriteLine("Num Fizzes: " + counts[0] + 
            "/nNum Buzzes: " + counts[1] + 
            "/nNum FizzBuzzes: " + counts[2]);
        }
    }
}