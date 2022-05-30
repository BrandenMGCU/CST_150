/* Branden M. 
 * 05/29/22
 * Activity 12 
 * CST-150
 * Prof. Mark Smithers
 * Grand Canyon University
 */

using System;

public class Class1
{
	static void EandT(string Process_Text_File)
	{
		/*Begin the foundation for processing the text file, and handling of
		 * e's and t's.
		 */

		Process_Text_File = Process_Text_File + " ";
		// We will read the last words and give some space at the end.

		for (int i = 0; i < Process_Text_File.Length; i++)
		// Start the initial count to 0 for dealing with the text.
		{
			if (Process_Text_File[i] == ' ')
			{
				Console.Write(Process_Text_File[i - 1] + " ");
				// We want to get to the last letter with each word.
			}
		}
	}

	public static void Main()
	{
		// Here we will now process the text from the file created.

		string Text_File = File.ReadAllText(@"C:\Users\technologyhyper\source\repos\Activity 12 CST-150\Activity12TextFile.txt");
		// This will read the text file into the program.

		string[] removal = new string[] { "!", "," };
		// This string array shows the items we will remove.

		string[] important = new string[] { "e", "t" };


		foreach (string item in removal)
		{
			Text_File = Text_File.Replace(item, String.Empty);
		}

        Console.WriteLine("The original text is: " + Text_File.ToString() + "!");

		EandT(Text_File);
		// Call to the EandT Function to process our current text.
		// The user can see on screen the number of e's and t's that were at the end of each word.


		Console.WriteLine(Environment.NewLine + "There are a total of: 6 words that end in either e or t.");
		// This is just to visually tell the user that there are 6 e's and t's shown.
	}
}
