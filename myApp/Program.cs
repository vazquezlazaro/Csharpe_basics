using System;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Challenge Multipe choise questions
            /*
            Console.WriteLine("Hello!\nPlease enter your name:");
            var name = tryAnswer();
            Console.WriteLine("Please enter your age:");
            var age = tryAnswer();
            Console.WriteLine("Please enter your born month:");
            var birthMonth = tryAnswer();
            Console.WriteLine("Your information:\n" + name +"\n"+ age +"\n"+ birthMonth);
            */
            
            //Challenge Passcode
            /*
            var responds= "";
            var secret = "abc";
            while(responds != secret){
                Console.WriteLine("Hello, Please enter the passcode:");
                responds = Console.ReadLine();
                if(responds != secret){
                    Console.WriteLine("Wrong passcode! Try again");
                }
            }
            Console.WriteLine("You entered the correct passcode.");
            */

            // Challenge LoopCounting
            /*
            for (int a = 0; a < 5 ; a++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                    
                }
                for (int x = 10; x >= 1; x--)   
                    {
                        Console.WriteLine(x);    
                    }
            }
            */
            //Array
            /*
            var studentGrades = new int[] {90,55,89,99,100,90,55,89,99,100};
            foreach (var studentgrade in studentGrades)
            {
                Console.WriteLine(studentgrade);
            }
            */
            /*
            Console.WriteLine("How many years of experience do you have?");
            var years = int.Parse(Console.ReadLine());
            switch (years)
            {
                case 0: 
                    Console.WriteLine("Inexperienced"); 
                break;
                case 1: 
                    Console.WriteLine("Junior");
                    break;
                case 2:
                    Console.WriteLine("Intermediate");
                    break;
                case 3:
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Senior");
                    break;

            }
                */

            //Challenge students and grades
            /*
            var studentCount = 0;
            Console.WriteLine("how many students in the class?");
            studentCount= int.Parse(Console.ReadLine());
            var studentNames = new string[studentCount];
            var studentGrades = new int[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Student Name:");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("Student Grade:");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < studentCount; i++){
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i],studentGrades[i]); 
            }
            */
            /*
            var studentNames = new List<string>();
            var studentGrades = new List<int>();
            var adding = true;
            while(adding)
            {
                Console.WriteLine("Student Name:");
                studentNames.Add(Console.ReadLine());

                Console.WriteLine("Student Grade:");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");
                if(Console.ReadLine().ToLower()== "n"){
                    adding = false;
                }

            }
            for (int i = 0; i < studentGrades.Count; i++){
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i],studentGrades[i]); 
            }
            */

        }

        static String tryAnswer(){
            var responds = Console.ReadLine();
            if (responds == "")
            {
                Console.WriteLine("You did not type anything. Please try again:");
                return Console.ReadLine(); 
            }
            return responds;  
        }

        

    }
}

