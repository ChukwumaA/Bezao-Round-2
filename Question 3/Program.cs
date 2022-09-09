//A program that translates a text to Pig Latin and back.

string sentence = "The quick brown fox jumps over the lazy dog";

Console.WriteLine(sentence+ "\n");

string pigLatin = string.Join(" ", 
    sentence.Split()
         .Select(word => word.Substring(1, word.Length - 1) + word[0] + "ay"));

Console.WriteLine(pigLatin+"\n");


Console.WriteLine(sentence);
