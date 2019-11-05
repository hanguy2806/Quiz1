using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Program
    {
        public int GetRandomData(int[] Data, int length)
        {
            Random random = new System.Random();
            //int returned_num = 0;
            bool flag = true;
            while (flag)
            {
                int random_no = random.Next();
                if (Search(Data, random_no) != true)
                {
                    flag = false;
                    return random_no;
                }
            }
        }

        //i prefer using linear search method over binary search because when you use binary search, you have to sort it before using searching.
        //the cost of sorting + binary sort is greater than the cost of just linear searching.
        public bool Search(int[] data, int random_no)
        {
            foreach (int item in data)
            {
                if (item == random_no)
                {
                    return true;
                }
            }
            return false;
        }
        public void UserInput()
        {

        }
        static void Main(string[] args)
        {

        }
    }
}
