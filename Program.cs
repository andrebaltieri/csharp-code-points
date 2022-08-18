using System.Text;

char letterA = '\u0041';
string emoji = "😂";

// char.ConvertToUtf32(input, i);

Console.Clear();

Console.WriteLine(letterA);
Console.WriteLine(char.IsSurrogate(letterA));

foreach (var item in emoji)
{
    Console.WriteLine(char.IsSurrogate(item));
}

Console.WriteLine(emoji);
Console.WriteLine(emoji.Length);

Console.WriteLine((int)emoji[0]);
// 55357 -> 0xD83D

Console.WriteLine((int)emoji[1]);
// 56834 -> 0xDE02

var codepoint = char.ConvertToUtf32(
    highSurrogate: emoji[0],
    lowSurrogate: emoji[1]);
Console.WriteLine(codepoint);

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine(emoji);

var runes = emoji.EnumerateRunes();
foreach (var r in runes)
    Console.Write($"U+{r.Value:X4}");
