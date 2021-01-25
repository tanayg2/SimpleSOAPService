using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MathSOAPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public static List<char> vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
        public int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                //Get last rightmost digit of num and divide it off
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }

        public int VowelCount(string word)
        {
            int vowelCount = 0;
            foreach (char letter in word)
            {
                if (vowels.Contains(letter))
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
