// C# 8.0
// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp

public class Kata
{
  public static string DuplicateEncode(string word)
  {
    string encodedString = "";      //Create empty string to return encoded value  
    System.Console.WriteLine(word); //Display word for testing purposes
    string lowerWord = word.ToLower();
    
    foreach(char letter in lowerWord){  // For each char in word
      int count = lowerWord.Split(letter).Length - 1; //Count occurences of character in word and ignore case
      System.Console.WriteLine(letter+ ": " + count); // Output count
      if(count == 1 ){  
        encodedString += '(' ; //If the count is 1, the character occurence was unique.  
      }
      else{
        encodedString +=')' ; //Else, it occured multiple times.
      }
    }
    
    System.Console.WriteLine(encodedString) ; 
    
    return encodedString;
  }
}
