using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Lorem Ipsum bla bla bla";
            //File.WriteAllText(@"C:\Users\Andrzej\source\repos\AssembliesAndNamespaces\bin\Release\net6.0\text.txt", text);

            WebClient client = new WebClient(); // requires using System.Net;
            string reply = client.DownloadString("http://msdn.microsoft.com");


            //Console class comes from System namespace
            System.Console.WriteLine(reply);
            File.WriteAllText(@"C:\Users\Andrzej\source\repos\AssembliesAndNamespaces\bin\Release\net6.0\reply.txt", reply);
            File.WriteAllText(@"C:\Users\Andrzej\source\repos\AssembliesAndNamespaces\bin\Release\net6.0\reply2.html", reply);
            Console.ReadLine();
            //debug -> release then Build -> Build Solution

            //compiling a project in .dll results in creation of library of code accessible
            //to multiple projects

            //creating a console project results in creation of references to files in
            //.net framework
        }
    }
}