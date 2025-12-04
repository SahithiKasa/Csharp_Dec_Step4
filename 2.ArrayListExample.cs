using System;
using System.Collections;


namespace CsharpCourse_DataStructures
{
    class ArrayListExample
    {
        static void Main()
        {
            ArrayList data = new ArrayList();



            //object ---- int , decimal , bool , string


            //addthe numbers
            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);   // 10000
            data.Remove(30);
            data.Add("Apple");
            data.Add(true);  // add
            data[3] = 100;
            foreach (dynamic i in data)
            {
                Console.WriteLine(i);
            }
                //Console.WriteLine(data);
            

            //int            = object;      type cast  object into int 
            int secondValue = (int)data[1];   //step1 we converted   // GET
            Console.WriteLine(secondValue);

            data[3] = 10000;   // update
            data.Remove(30);  // remove



            Console.WriteLine(data);



        }
    }
}