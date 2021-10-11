using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeSkillDuplicateNonLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 1, 2, 3 ,5, 3 ,6, 8 };
            Console.WriteLine(  CountDuplicate(numbers));
            Console.ReadLine();

        }

    

        private static int CountDuplicate(List<int> numbers)
        {
            
            int counter = 0;
            int temp = 0;
            List<int> numberMarks = new List<int>();
            foreach(int num in numbers)
            {

                if(numbers.FindAll(p=>p == num).Count > 1  && !numberMarks.Contains(num))
                {
                    numberMarks.Add(num);
                    counter++;
     
                }
    
            }
            return counter;

        }
    }


    
}
