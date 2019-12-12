using System;
namespace PlantNameSpace
{
    public class Program
    {
        public static void Main()
        {
            int condition = 0;
            do{
                Console.WriteLine("Please Enter name of the plant: ");
                string plantName = Console.ReadLine();
                
                Plant plant = new Plant(plantName);
                int input=0;
                do
                {    
                    Console.WriteLine("Please Enter 1 to water the plant: ");
                    Console.WriteLine("Please Enter 2 to feed the plant: ");
                    Console.WriteLine("Please Enter 3 to give SunShine the plant: ");
                    Console.WriteLine("Please Enter 4 to make  windStorm:  ");
                    Console.WriteLine("Please Enter 5 to make aphiattack:  ");
                    Console.WriteLine("Please Enter 6 to make slugBite:  ");
                    Console.WriteLine("Please Enter 7 to exit the program:  ");
                    input = int.Parse(Console.ReadLine());
                    if(input==1)
                    {
                        plant.Water();
                    }
                    else if(input==2)
                    {
                        plant.Feed();
                    }
                    else if(input==3)
                    {
                        plant.GiveSunShine();
                    }
                    else if(input==4)
                    {
                        plant.Windstrom();
                    }
                    else if(input==5)
                    {
                        plant.AphidAttack();
                    }
                    else if(input==6)
                    {
                        plant.SlugBite();
                    }

                    if(plant.CheckStatus()==false)
                    {
                            Console.WriteLine("The "+plant.getPlant()+ " is dead!");
                            input = 7;
                    }

                        Console.WriteLine(plant.PrintPlant());

                }while(input!=7);
                Console.WriteLine("Please enter 9 to exit or any number to continue: ");
                condition = int.Parse(Console.ReadLine());

            }while(condition!=9);
            Console.WriteLine("See you next time !");

        }
    }
}