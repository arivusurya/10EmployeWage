using System;
namespace Day10Employee{

    public class Program{

        public static void Main(string[] args){
           EmplyeeWage Companylist = new EmplyeeWage();
           Companylist.Add("gpt",20,100,21);
           Companylist.Computewage();
           
        }

    }

}