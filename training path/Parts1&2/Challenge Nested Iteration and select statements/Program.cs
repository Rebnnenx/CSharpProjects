//https://learn.microsoft.com/en-us/training/modules/csharp-arrays/4-challenge
//write code which will find orders IDs starting with B and examine them for further examination


//decalre array of fraudulent IDs


string[] OrderIDs= {"B123", "C234", "A345", "C15","B177", "G3003", "C235", "B179"};

//foreach to iterate through the list of ids
foreach(string Order in OrderIDs)
{
    if (Order.StartsWith("B"))
    {
        Console.WriteLine(Order);
    }
}