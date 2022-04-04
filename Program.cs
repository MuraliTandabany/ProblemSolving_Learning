// See https://aka.ms/new-console-template for more information
using System.Text;
class TestClass
{
  public static void Main()
  {
    StripCommentsClass.StripComments("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" });
  }
}

public static class StripCommentsClass
{
  public static string StripComments(string text, string[] commentSymbols)
  {
    if (string.IsNullOrEmpty(text) || commentSymbols.Length < 1)
      return text;

    StringBuilder result = new StringBuilder();
    StringBuilder line = new StringBuilder();
    for (int i = 0; i < text.Length; i++)
    {
      if (commentSymbols.Contains(text[i].ToString()))
      {
        AppendEachLineToResult(result, line);
        line.Clear();
        i = findNextLineIndex(text, i);
        continue;
      }
      line.Append(text[i]);
    }
    if(line.Length > 0)
      AppendEachLineToResult(result, line);
    return result.ToString().Replace(" \n", "\n");
    }

  private static void AppendEachLineToResult(StringBuilder sb, StringBuilder line)
  {
    if(sb.Length > 0)
    {
      sb.Append('\n');
    }
    sb.Append(line.ToString().TrimEnd());
  }

  private static int findNextLineIndex(string text, int i)
  {
    for (int j = i; j < text.Length; j++)
    {
      if (text[j] == '\n')
      {
        return j;
      }
      continue;
    }
    return text.Length;
  }
}