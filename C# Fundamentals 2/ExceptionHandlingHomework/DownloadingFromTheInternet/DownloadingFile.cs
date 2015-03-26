/* Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.*/

using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

class DownloadingFile
{
    static void Main()
    {
        using(WebClient client = new WebClient())
        {
            try 
	        {	        
		        client.DownloadFile("http://www.rotoscopers.com/wp-content/uploads/2013/11/BestMovieWalls_Frozen_08-.jpg" ,"BestMovieWalls_Frozen_08-.jpg");
	        }
	        catch (ArgumentNullException aEx)
	        {
		        Console.WriteLine("No value was asigned to the argument!");
	        }
            catch(NotSupportedException nEx)
            {
                Console.WriteLine(nEx.Message);
            }
            catch(WebException wEx)
            {
                Console.WriteLine("Invalid web-address!");
            }
        }

    }
}
