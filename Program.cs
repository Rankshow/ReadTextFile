using System.IO;

namespace ReadTextFile;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            StreamWriter sw = new StreamWriter(@"C:\Data\Programmers.txt");
            
            sw.WriteLine("- using System.Net");
            sw.WriteLine("- using System.Collection");

            sw.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Please Enter a correct path because we :" + e.Message);
        }
        finally
        {
            Console.WriteLine("Successful, Execution we no longer continue");
        }
    }
}
