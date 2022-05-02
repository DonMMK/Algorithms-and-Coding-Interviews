using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace programming_challenge
{
	class Program
	{

		private Dictionary<string, string> phrases = new Dictionary<string, string>()
			{
				{"Hello", "Ellohay"},
				{"Pig Latin", "Igpay Atinlay"},
				{"The first month is Janurary", "Ethay irstfay onthmay isway Anuraryjay"},
				{"The floor is sticky", "Ethay oorflay isway ickystay"}
			};

		static void Main(string[] args)
		{
			new Program();
		}

		public Program()
		{
			foreach (var pair in phrases) {
				testEquals(pair.Key, pair.Value, translateEnglishToPigLatin(pair.Key));
			}
		}


		// Pig Latin takes the first consonant (or consonant cluster) of an English word
		// moves it to the end of the word and appends an "ay"
		// If a word begins with a vowel you just append "way"
		// Bonus Restore the first letter case of the Pig Latin word to match the English word.
		private string translateEnglishToPigLatin(string english)
		{

		/****************************************************************************************************
			Pig Latin Solver 1
		****************************************************************************************************/

			// string[] words = english.Split(' ');
			// string pigLatin = "";
			// string vowels = "aeiouAEIOU";
			// string consonant = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
			// bool flagToCapitalize;	

			// foreach (string word in words) 
			// {
			// 	string firstLetter = word.Substring(0, 1);
			// 	string secondLetter = word.Substring(1, 1);
			// 	string restOfWord = word.Substring(1);

			// 	// Setting a flag for the bonus question
			// 	if(firstLetter == firstLetter.ToUpper()){flagToCapitalize = true;}
			// 	else{flagToCapitalize = false;}

			// 	// Convert all letters to lowercase
			// 	pigLatin = pigLatin.ToLower();
				

			// 	if (vowels.Contains(firstLetter)) {
			// 		pigLatin += word + "way ";
					
			// 		// If the flag to capitalize is true 
			// 		// Then capialize the first letter of the word in the varibale english
			// 		if(flagToCapitalize == true){
			// 			pigLatin = pigLatin.Substring(0, 1).ToUpper() + pigLatin.Substring(1);
			// 		}	
			// 	} 
			// 	else if ( consonant.Contains(firstLetter) == true && consonant.Contains(secondLetter) == true ) 
			// 	{
			// 		restOfWord = word.Substring(2);
			// 		pigLatin += restOfWord + firstLetter + secondLetter + "ay ";
					
			// 		// If the flag to capitalize is true 
			// 		// Then capialize the first letter of the word in the varibale english
			// 		if(flagToCapitalize == true){
			// 			pigLatin = pigLatin.Substring(0, 1).ToUpper() + pigLatin.Substring(1);
			// 		}	
			// 	} 
			// 	else {
			// 		pigLatin += restOfWord + firstLetter + "ay ";	

			// 		// If the flag to capitalize is true 
			// 		// Then capialize the first letter of the word in the varibale english
			// 		if(flagToCapitalize == true){
			// 			pigLatin = pigLatin.Substring(0, 1).ToUpper() + pigLatin.Substring(1);
			// 		}			
			// 	}
				
			// }
			// return pigLatin.Trim();

		


		/****************************************************************************************************
			Pig Latin Solver 3
		****************************************************************************************************/
			// String[] Words = english.Split(new char[] { ' ' });
        	// String PigLatinSentence = "" ;

        	// foreach (string word in Words){
        	//     String CurrentWord = word;
        	//     char FirstLetter = CurrentWord.ToUpper()[0];
			// 	char secondLetter = CurrentWord.ToUpper()[1];
	
        	//     CurrentWord = CurrentWord.Remove(0, 1);
        	//     CurrentWord = CurrentWord.Insert(CurrentWord.Length, FirstLetter.ToString());

        	//     if (IsConsonant(FirstLetter)) {
        	//        CurrentWord= CurrentWord.Insert(CurrentWord.Length , "ay");}
			// 	//else if (IsConsonant(FirstLetter) & IsConsonant(secondLetter)) {
			// 	//	CurrentWord= CurrentWord.Insert(CurrentWord.Length , "ay");}
        	//     else{ CurrentWord= CurrentWord.Insert(CurrentWord.Length , "y");}
        	//     PigLatinSentence= PigLatinSentence.Insert(PigLatinSentence.Length, CurrentWord + " ");
        	// }

        	// return PigLatinSentence.Remove(PigLatinSentence.Length-1);


		/****************************************************************************************************
			Pig Latin Solver 4
		****************************************************************************************************/

				string vowels = "AEIOUaeiou";
    			string cons = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";

    			Func<string, string> toPigLatin = word =>
    			{
	        		word = word.ToLower();

	        		var result = word;

	        	Func<string, string, (string, string)> split = (w, l) =>
	        	{
    	        	var prefix = new string(w.ToArray().TakeWhile(x => l.Contains(x)).ToArray());
	            	return (prefix, w.Substring(prefix.Length));
    	    	};

    	    	if (!word.Any(w => cons.Contains(w)))
    	    	{
    	        	result = word + "way";
    	    	}
    	    	else
    	    	{
    	        	var (s, e) = split(word, vowels);
    	        	var (s2, e2) = split(e, cons);
    	        	result = e2 + s + s2 + "ay";
    	    	}
    	    		return result;
    			};
    		return string.Join(" ", english.Split(' ').Select(x => toPigLatin(x)));


		/****************************************************************************************************
			Pig Latin Solver 2
		****************************************************************************************************/

			// return string.Join(" ", english.Split(' ')
    		// .Select(word => word.SkipWhile(c => !"aeiouy".Contains(c)).Concat(word.TakeWhile(c => !"aeiou".Contains(c))))
    		// .Select(word =>
    		// 	{
        	// 		var ending = "aeiouy".Contains(word.Last()) ? "way" : "ay";
        	// 		return word.Concat(ending.ToCharArray());
    		// 	})
    		// 	.Select(word => string.Concat(word)));


		/****************************************************************************************************
			Pig Latin Solver 5
		****************************************************************************************************/
        
		
        	// return english.Split(' ')
        	// .Select(word => word.SkipWhile(c => !c.IsVowel()).Concat(word.TakeWhile(c => c.IsVowel())))
        	// .Select(word => word.Concat((word.Last().IsVowel() ? "way" : "ay").ToCharArray()))
        	// .Select(word => string.Concat(word))
        	// .Join(" ");





		/****************************************************************************************************
			Pig Latin Solver 7
		****************************************************************************************************/

			// const string vowels = "AEIOUaeio";
        	//     var returnSentence = "";
        	//     foreach (var word in english.Split())
        	//     {
        	//         var firstLetter = word.Substring(0, 1);
        	//         var restOfWord = word.Substring(1, word.Length - 1);
        	//         var currentLetter 	= vowels.IndexOf(firstLetter, StringComparison.Ordinal);

        	//         if (currentLetter == -1)
        	//         {
        	//             returnSentence += restOfWord + firstLetter + "ay ";
        	//         }
        	//         else
        	//         {
        	//             returnSentence += word + "way ";
        	//         }
        	//     }
        	// return returnSentence;

		/****************************************************************************************************
			Pig Latin Solver 8
		****************************************************************************************************/

// 			english.Split(' ').Aggregate(new StringBuilder(), (cur, next) =>
// {
//             cur.Append(cur.Length > 0 ? " " : "");
//             if ((new[] { "a", "e", "i", "o", "u", "xr", "yt" }).Any(x => x == next[0..(x.Length)]))
//                 cur.Append($"{next}ay");
//             else
//             	{
//             	    var pattern = @"^((qu|.)+?(qu|(?=[aeiouy])))";
//             	    var rg = new Regex(pattern);
//             	    var matches = rg.Matches(next);
//             	    var match = matches[0].Groups[0].Value;
//             	    cur.Append(next.Substring(match.Length) + match + "ay");
//             	}
//             return cur;
//         	}).ToString();
			


		}


		private void testEquals(string input, string expect, string actual)
		{
			if (expect.ToLower() == actual.ToLower()) {
				if (expect != expect.ToLower() && expect == actual) {
					Console.WriteLine("PASS (Bonus)! {0} -> {1}", input, actual);
				} else {
					Console.WriteLine("PASS! {0} -> {1}", input, actual);
				}
			} else {
				Console.WriteLine("FAIL!");
				Console.WriteLine("  Input: {0}", input);
				Console.WriteLine("  Expect: {0}", expect);
				Console.WriteLine("  Actual: {0}", actual);
			}
		}

	}
}


/********************************************************************************************************************************
	Comments about Code

	1. Passed regular questions 

	2. More try-catch methods can be used to check for errors in the if conditions for consanant clusters - 
	The code does not handle when there are three consonants in a row. While no words of such a cluster exists in the dictionary,
	Error checking should be done for that.

	3. Attempted bonus questions for restoring capital letters of Pig Latin. Left as is after few attempts due to time constraints.

********************************************************************************************************************************/