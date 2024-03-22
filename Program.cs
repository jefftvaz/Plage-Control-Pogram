using Org.BouncyCastle.Bcpg;
using PlageControl;
using PlageControl.Login;
using System.Runtime.InteropServices.JavaScript;


Login user = new Login();
if( user.Creation() == false)
{
    if (user.Entrance() == true)
    {
        
            while (true)
            {
                Run run = new Run();
                run.RunProgram();
            }
        Console.ReadLine();
    }
} 