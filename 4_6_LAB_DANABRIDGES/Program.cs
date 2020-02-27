using System;
using System.Collections;
namespace _4_6_LAB_DANABRIDGES
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday","sunday" };
            string[] task = new string[7];
            
             
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine("type new task for" + " " + days[i]);
                task[i] = days[i] + Console.ReadLine();

                
            };

            for (int i = 0; i < task.Length; i++)
            {
                Console.WriteLine(task[i]);
            };
            

           

            
            


            
                
           

          
       

          



          
           
          
            

        }
    }
}
