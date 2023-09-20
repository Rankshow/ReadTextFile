using System.IO;

namespace ReadTextFile;

class Program
{
    static void Main(string[] args)
    {
        String line;
        try
        {
          StreamReader sr = new StreamReader(@"C:\Data\Programmers.txt");
          line = sr.ReadLine();
          
          while(line != null)
          {
            Console.WriteLine(line);
            line = sr.ReadLine();
          }
          sr.Close();
          Console.WriteLine(line);
        }
        catch(Exception e)
        {
            Console.WriteLine("Sorry!! we  :" + e.Message);
        }
        finally
        {
            Console.WriteLine("Thanks, at this moment we have to executing the code");
        }
    }
}
