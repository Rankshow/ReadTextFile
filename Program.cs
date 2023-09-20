using System.IO;

namespace ReadTextFile;

class Program
{
    static void Main(string[] args)
    {
        Int64 x;
        try
        {
            StreamWriter sw = new StreamWriter(@"C:\Data\Services.txt");

            for(x = 0; x < 10; x++)
            {
                sw.Write(x);
            }
            sw.Close();
        }
        catch(Exception e)
        {
            Console.WriteLine("Please Enter a correct path because we :" + e.Message);
        }
        finally
        {
            Console.WriteLine("Exexution finally block...");
        }
    }
}
