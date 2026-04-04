public class StringUtility
{
    public static string SummarizeText(string sentence, int maxLength = 30)
    {
        if (sentence.Length > maxLength)
            return sentence;
        {
            var words = sentence.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();
            foreach (var word in words)
            {
                summaryWords.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            var summary = String.Join(" ", summaryWords) + "...";
            return summary;
        }
    }
}