using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Csharp_Dec_Step4
{
    class HashsetExample
    {
        static void Main()
        {
            HashSet<string> userNames = new HashSet<string>();

            // Adding items to the HashSet
            userNames.Add("Alice");
            userNames.Add("Bob");
            userNames.Add("Charlie");


            userNames.Add("Alice");
            userNames.Remove("Bob");
            //userNames.Add("Alice");
            // Checking if an item exists in the HashSet
            // Console.WriteLine("Is 'Alice' in the HashSet? " + userNames.Contains("Alice"));


            foreach (string name in userNames)
            {
                Console.WriteLine(name);
            }


            userNames.Remove("Bob");

            // Checking if an item exists in the HashSet
            Console.WriteLine("Is 'Bob in the HashSet? " + userNames.Contains("Bob"));

            Console.WriteLine();

            HashSet<string> newuserNames = new HashSet<string>() { "Ajay", "Ravi", "Rahul" };
            //userNames.ExceptWith(newuserNames);
            userNames.IntersectWith(newuserNames);
            Console.WriteLine("\nAfter intersectWith:");
            foreach (string name in newuserNames)
            {

                Console.WriteLine(name);
            }

                userNames.UnionWith(newuserNames);
                Console.WriteLine("\nAfter UnionWith:");
                foreach (string name1 in newuserNames)
                {

                    Console.WriteLine(name1);
                    //userNames.IntersectWith(newuserNames);

                }
            HashSet<string> banneduserNames = new HashSet<string>() { "Ajay" };

            userNames.ExceptWith(banneduserNames);
            Console.WriteLine("\nAfter ExceptWith(Removed newuserNames):");
            foreach (string names in banneduserNames)
            {

                Console.WriteLine(names);
                //userNames.IntersectWith(newuserNames);

            }
        }
        }
    }


    

    
