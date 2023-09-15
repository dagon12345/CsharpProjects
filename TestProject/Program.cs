/*
    In this code you reverse the string 
    originalMessage using Array.Reverse class and method function
    and it will count the letter 'o' present in the originalMessage
*/


string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = originalMessage.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;

foreach(char letter in charMessage)
{
    if(letter == 'o')
    {
        letterCount++;
    }
     
}
string newMessage = new string(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");