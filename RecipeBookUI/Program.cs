using RecipeBookModel;
using RecipeBookBL;
using System;

namespace RecipeBookUI
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            RecipeBL recipee = new RecipeBL();

            Console.WriteLine("WELCOME TO COOKERIE'S RECIPE BOOK! Wherein you'll find out different kind of Filipino Food.");
            Console.WriteLine("");
            Console.WriteLine("Choose to see the recipe and  start cooking with LOVE!");
            Console.WriteLine("1.KareKare");
            Console.WriteLine("2.Sinigang");
            Console.WriteLine("3.Chicharon Bulaklak");
            Console.WriteLine("4.Beef Pares");
            Console.WriteLine("5.Arroz Caldo");
            Console.WriteLine("---------------------------");

            Console.Write("Choose the number of your chosen dish!:  ");         
            int answer = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("---------------------------");

            switch (answer)
            {
                case 1:

                    foreach (RecipeModel info in recipee.KareKareBL())
                    {
                        
                        Console.WriteLine(info.title);
                        Console.WriteLine("");
                        Console.WriteLine("Ingredients:");
                        Console.WriteLine(info.ingredients + "\n" + info.ingredients1);
                        Console.WriteLine("");
                        Console.WriteLine("Procedure:");
                        Console.WriteLine(info.procedure);
                        Console.WriteLine(info.procedure1);
                        Console.WriteLine(info.procedure2);
                        Console.WriteLine(info.procedure3);
                    }

                    break;

                case 2:
                    foreach (RecipeModel info in recipee.SinigangBL())
                    {
                        Console.WriteLine(info.title);
                        Console.WriteLine("");
                        Console.WriteLine("Ingredients:");
                        Console.WriteLine(info.ingredients + "\n" + info.ingredients1);
                        Console.WriteLine("");
                        Console.WriteLine("Procedure:");
                        Console.WriteLine(info.procedure);
                        Console.WriteLine(info.procedure1);
                        Console.WriteLine(info.procedure2);
                        Console.WriteLine(info.procedure3);
                    }
                    break;

                case 3:
                    foreach (RecipeModel info in recipee.ChicharonBL())
                    {
                        Console.WriteLine(info.title);
                        Console.WriteLine("");
                        Console.WriteLine("Ingredients:");
                        Console.WriteLine(info.ingredients + "\n" + info.ingredients1);
                        Console.WriteLine("");
                        Console.WriteLine("Procedure:");
                        Console.WriteLine(info.procedure);
                        Console.WriteLine(info.procedure1);
                        Console.WriteLine(info.procedure2);
                        Console.WriteLine(info.procedure3);
                    }
                    break;

                case 4:
                    foreach (RecipeModel info in recipee.ParesBL())
                    {
                        Console.WriteLine(info.title);
                        Console.WriteLine("");
                        Console.WriteLine("Ingredients:");
                        Console.WriteLine(info.ingredients + "\n" + info.ingredients1);
                        Console.WriteLine("");
                        Console.WriteLine("Procedure:");
                        Console.WriteLine(info.procedure);
                        Console.WriteLine(info.procedure1);
                        Console.WriteLine(info.procedure2);
                        Console.WriteLine(info.procedure3);
                    }
                    break;

                case 5:
                    foreach (RecipeModel info in recipee.GotoBL())
                    {
                        Console.WriteLine(info.title);
                        Console.WriteLine("");
                        Console.WriteLine("Ingredients:");
                        Console.WriteLine(info.ingredients + "\n" + info.ingredients1);
                        Console.WriteLine("");
                        Console.WriteLine("Procedure:");
                        Console.WriteLine(info.procedure);
                        Console.WriteLine(info.procedure1);
                        Console.WriteLine(info.procedure2);
                        Console.WriteLine(info.procedure3);
                    }
                    break;
            }
            
            
        }
    }
}
