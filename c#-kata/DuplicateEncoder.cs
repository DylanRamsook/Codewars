// C# 8.0
// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp

using System.Linq;

public class Kata
{
  public static string DuplicateEncode(string word)
  {  
    return new string(word.ToLower().Select(ch => word.ToLower().Count(innerCh => ch == innerCh) == 1 ? '(' : ')').ToArray());
  }
}
