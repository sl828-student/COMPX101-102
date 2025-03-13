
Console.WriteLine("Welcome to $100 word challenge");

Console.WriteLine("\nPlease enter the word you want valued:\n"); //askd user to enter value
string word = Console.ReadLine(); //takes value

int value = CalculateWordValue(word);
Console.WriteLine("\nThe value of the word is: " + value);

///calculates the value of word
static int CalculateWordValue(string word)
{
    int totalValue = 0;
    foreach ( char c in word.ToLower())//checks value of c=each letter and adds to total
        if(char.IsLetter(c))
        {
            totalValue += c - 'a' + 1;
        }
    return totalValue;
}


    
