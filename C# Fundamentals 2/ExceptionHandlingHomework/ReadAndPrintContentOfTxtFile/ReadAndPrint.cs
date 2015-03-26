/* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.*/

using System;
using System.IO;
using System.Security;

class ReadAndPrint
{
    static void Main(string[] args)
    {
        try
        {
            string poem = File.ReadAllText("C:\\Users\\Public\\Documents\\If.txt");
            Console.WriteLine(poem);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The argument you've been trying to pass to the method has not been assigned a value.");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("You've entered an invalid argument.");
        }
        catch(PathTooLongException)
        {
            Console.WriteLine("Either the file name, or path were longer than the allowed length.");
        }
        catch(DirectoryNotFoundException)
        {
            Console.WriteLine("No such directory or file can be found.");
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("There's no such file.");
        }
        catch(IOException)
        {
            Console.WriteLine("Error in the input/output data.");
        }
        catch(UnauthorizedAccessException)
        {
            Console.WriteLine("Error in the input/output data.");
        }
        catch(NotSupportedException)
        {
            Console.WriteLine("Method not supported.");
        }
        catch(SecurityException)
        {
            Console.WriteLine("An error was detected in the security.");
        }
        catch (SystemException systEx)
        {
            Console.WriteLine("Don't worry! Be Happy! And try one more time!" + systEx.GetType().Name + systEx.Message);
        }
    }
}
