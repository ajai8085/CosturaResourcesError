using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Runner
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MyApp.Resources.Properties.Resources.Message1);

            //Above line will cause issue 

            //1) Open up the folder %temp%\Costura  and clean up all the folders 
            //2 Run this application , you will get following error 

            //            System.IO.FileNotFoundException was unhandled
            //Message: An unhandled exception of type 'System.IO.FileNotFoundException' occurred in mscorlib.dll
            //Additional information: Could not load file or assembly 'MyApp.Resources, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null' or one of its dependencies.The system cannot find the file specified.

            //3 Open up the folder %temp%\Costura 
            //4 Open up the respective folder with unique name 
            //5 you can find a file with name "Release.myapp.resources.dll" or "Debug.myapp.resources.dll" based on configuration . 

        }
    }
}
