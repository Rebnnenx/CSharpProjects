

/*
//simulates a random dice roll and displays it

//creates a new instance of Random object
Random dice = new Random();
int roll1 = dice.Next(); //selects value from 0 to 2147483647
int roll2 = dice.Next(101); //selects value 0 to 100
int roll3 = dice.Next(50, 101); // selects value between 50 and 100

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
*/

/*
//Math Class Methods Challenge
//use System.Math to find larger of two values and write it to console
// https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/5-challenge


int firstValue= 500;
int secondValue= 600;
int largerValue;

//calls Math.Max method and returns larger of the two values
largerValue= Math.Max(firstValue,secondValue);
Console.WriteLine(largerValue);
*/

/*decision logic gates

//generate 3 random numbers and display them in order including the SUM

Random dice = new Random();

int roll1 = 6;//dice.Next(1,7);
int roll2 = 6;//dice.Next(1,7);
int roll3 = 6;//dice.Next(1,7);

int total = roll1+roll2+roll3;

Console.WriteLine($"Dice Roll: {roll1} + {roll2} + {roll3} = {total}");

//add a doubles rule and nested triples rule
if((roll1==roll2) || (roll1==roll3)||(roll2==roll3))
{
    if (roll1==roll2 && roll2==roll3)
    {
        Console.WriteLine("you rolled triples! +6 to your score!");
        total+=6;
    }
    else
    {
        Console.WriteLine("you rolled doubles! +2 to your score!");
        total+=2;
    }
}

//add if statements to decide if you win or lose
if (total >=16)
{
    Console.WriteLine("You win a new car!!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("you win a trip for two!");
}
else
{
    Console.WriteLine("you win a rubber duck!");
}

*/

/* Challenge: improve renewal rate of subscriptions
https://learn.microsoft.com/en-us/training/modules/csharp-if-elseif-else/4-challenge
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <1)
{
    //expired sub
    Console.WriteLine("Your subscription has expired");
}
else if (daysUntilExpiration == 1)
{
    //sub expires today
    discountPercentage= 20;
    Console.WriteLine($"Your subscription expires today! \nRenew and save {discountPercentage}%!");
}
else if (daysUntilExpiration <=5 && daysUntilExpiration <1)
{
    //sub expires in x days
    discountPercentage=10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%");
}
else if(daysUntilExpiration <=10 && daysUntilExpiration >5)
{
    //expires soon
    Console.WriteLine("Your subscription expires soon. Renew now!");
}
else
{
    //display nothing
}