using System;
using PlageControl.IU;
using PlageControl.Repository;
using PlageControl.Services;


namespace PlageControl
{
#pragma warning disable SA1600 // ElementsMustBeDocumented

    public class Run
    {
        PlageRepository repository = new PlageRepository();

        public void RunProgram()
        {
            Console.WriteLine("\n");
            Interface.ShowMenuOptions();

            switch (Console.ReadLine())
            {
                case "r":
                    {
                        Console.WriteLine("\n");
                        Interface.ShowList(repository.GetAll());
                        break;
                    }
                case "st":
                    {
                        Console.WriteLine("\n");
                        Interface.ShowListOnTable(repository.GetAll());
                        break;
                    }
                case "c":
                    {
                        Console.WriteLine("\n");
                        CreatePlage.Plage();
                        break;
                    }
                case "d":
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Digite o id a ser deletado.");
                        int.TryParse(Console.ReadLine(), out int id);
                        repository.Delete(id);
                        break;
                    }
                case "u":
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Digite o id a ser modificado.");
                        int.TryParse(Console.ReadLine(), out int id);
                        repository.Update(repository.GetByID(id));
                        break;
                    }
                default:
                    {
                        break;
                    }
            }



        }

        public void CreatDataBaseOfPlage()
        {

        }

    
    }
}
