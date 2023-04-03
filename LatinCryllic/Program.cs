using System.Text;

static void Main(string[] args)
{
    TransliterateToLatin("аёллар");
}
 static string TransliterateToLatin(string text)
{
    // Create a StringBuilder to store the result
    var result = new StringBuilder();

    // Define a dictionary to map Cyrillic characters to their Latin equivalents
    var dictionary = new Dictionary<char, string>()
    {
        { 'а', "a" }, { 'б', "b" }, { 'в', "v" }, { 'г', "g" }, { 'д', "d" }, { 'е', "e" },
        { 'ё', "yo" }, { 'ж', "zh" }, { 'з', "z" }, { 'и', "i" }, { 'й', "y" }, { 'к', "k" },
        { 'л', "l" }, { 'м', "m" }, { 'н', "n" }, { 'о', "o" }, { 'п', "p" }, { 'р', "r" },
        { 'с', "s" }, { 'т', "t" }, { 'у', "u" }, { 'ф', "f" }, { 'х', "h" }, { 'ц', "ts" },
        { 'ч', "ch" }, { 'ш', "sh" }, { 'щ', "sch" }, { 'ъ', "" }, { 'ы', "y" }, { 'ь', "" },
        { 'э', "e" }, { 'ю', "yu" }, { 'я', "ya" }
    };

    // Iterate over each character in the input text
    foreach (var c in text)
    {
        // If the character is Cyrillic, replace it with its Latin equivalent
        if (dictionary.ContainsKey(c))
        {
            result.Append(dictionary[c]);
        }
        else
        {
            result.Append(c);
        }
    }

    // Return the result as a string
    return result.ToString();
}

