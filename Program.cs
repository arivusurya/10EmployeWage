using System;
namespace Day10Employee{

    public class Program{

        public static void Main(string[] args){
            EmplyeeWage Chatgpt = new EmplyeeWage("Chatgpt" , 40,100,21);
            Chatgpt.computewage();
            Console.WriteLine(Chatgpt.toString());
            
        }

    }

}