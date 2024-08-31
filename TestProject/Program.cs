/*Fizz Buzz code
for (int i = 1; i <= 100; i++)
{
    Console.Write(i);
    Console.WriteLine(i % 3 == 0 && i % 5 == 0 ? " - FizzBuzz" : i % 3 == 0 ? " - Fizz": i % 5 == 0 ? " - Buzz" : "");
}
*/
//Monster game below.
/*
Random random = new Random();
int MonsterHealth = 10;
int HeroHealth = 10;

do{
    int roll = random.Next(1, 11);
    MonsterHealth -= roll;
    Console.WriteLine($"Monster was damage and lost {roll} health and now has {MonsterHealth} health.");

    if(MonsterHealth <= 0) continue; //continue means break or done if true.
    //IF above is true then trigger the below code which is the while then write it in the Console.WriteLine.

    roll = random.Next(1, 11);
    HeroHealth -= roll;
    Console.WriteLine($"Hero was damage and lost {roll} health and now has {HeroHealth} health.");

}while(HeroHealth > 0 && MonsterHealth > 0);
Console.WriteLine(HeroHealth > MonsterHealth ? "Hero wins!" : "Monster wins!");
*/

//Problem number one solved.
string? readResult;
int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Please enter an integer value between 5 and 10");
do{
     
    readResult = Console.ReadLine();
    //validNumber = int.TryParse(readResult, out numericValue); 
    if(readResult != null)
    {
        validNumber = int.TryParse(readResult, out numericValue);
        if(validNumber && numericValue >= 5 && validNumber && numericValue <=10)
        {
            validNumber = true;
            Console.WriteLine($"Your input value {readResult} has been accepted.");

        }
        else if( validNumber && numericValue <=5 || validNumber && numericValue >= 10)
        {
             Console.WriteLine($"You entered {readResult}, please enter a number between 5 and 10");
        }
        else
        {
            Console.WriteLine("Sorry you've entered invalid number.");

        }

    }

}while(validNumber == false);
//validNumber = int.TryParse(readResult, out numericValue);
