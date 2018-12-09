using System;
using System.IO;

public class MovieData
{
	public static void Main()
	{
		string strChoice;
		int numChoice;
		string strMovie;
		string strRating;
		string s;

		Console.Out.WriteLine("type 1 to display movies, type 2 to add a movie, type 3 to quit.");
		strChoice = Console.ReadLine();

		try
		{
			numChoice = Convert.ToInt32(strChoice);
		}
		catch (Exception e)
		{
			Console.Out.WriteLine("Invalid number.");
			numChoice = 3;
		}
		
		if (numChoice == 1)
		{
			StreamReader inFile = File.OpenText("movies.txt");					s = inFile.ReadToEnd();
			Console.Out.WriteLine(s);
			inFile.Close();
		}
		else if (numChoice == 2)
		{
			Console.Out.WriteLine("Name of movie: ");
			strMovie = Console.ReadLine();
			Console.Out.WriteLine("Please rate movie on a scale of 1 - 5: ");
			strRating = Console.ReadLine();

			StreamWriter appFile = File.AppendText("movies.txt");
			appFile.WriteLine(strMovie);
			appFile.WriteLine(strRating);
			appFile.Close();
		}
		else if (numChoice == 3)
		{
			Console.Out.WriteLine("Closing program.");
		}
	}
}