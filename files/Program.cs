using System;
using System.IO;
using System.Text.RegularExpressions;

namespace files
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables declaration block
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pattern = @"\w\S+@{1}\w+\.{1}\w+";
            string aText = "";

            //'read text from a local .txt file' operation
            Console.WriteLine(File.Exists(@"emailAddress.txt") ? File.ReadAllText(@"emailAddress.txt") : "There's no file to read from one.\n ");

            //retrieving of an email with a regular expression
            aText = File.ReadAllText(@"emailAddress.txt");
            Match m = Regex.Match(aText, pattern);
            Console.Write("\nThe above text comprises a following email address: {0}", m.Value);

            //writing a text into a newly created TXT file
            aText = "Humpty Dumpty sat on a wall,\nHumpty Dumpty had a great fall.\nFour - score Men and Four - score more,\nCould not make Humpty Dumpty where he was before.\n\nHumpty Dumpty lay in a beck.\nWith all his sinews around his neck;\nForty Doctors and forty wrights\nCouldn't put Humpty Dumpty to rights!";
            using (StreamWriter inputStrm = new StreamWriter(filePath + @"\humpty_dumpty.txt"))
            {
                inputStrm.WriteLine(aText);
            }

            /*
            //this block displays a text that is written into a file by the previous block & one is optional (uncomment one in order to get the text desplayed)
            using (StreamReader outputStrm = new StreamReader(filePath + @"\humpty_dumpty.txt"))
            {
                Console.Write("\n\n{0}", aText = outputStrm.ReadToEnd());
            }
            */

            Console.ReadKey();
        }
    }
}
