/*

//writes to the console
///
//Console.WriteLine("Hello, World!");

//writes to the console and appends newline character after first statement
//Console.WriteLine("This is the first line.");
//Console.WriteLine("This is the second line.\n\n\n\n");

//verbatim string literals use the @ symbol before the double quoute
//Console.WriteLine(@"    c:\source\repos
//        (this is where your coed goes)");
*/
/*
//"generates" a customer report 
//Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
//Console.WriteLine("Invoice: 1021\t\tComplete!");
//Console.WriteLine("Invoice: 1022\t\tComplete!");
//Console.WriteLine("\nOutput Directory:\t");
//Console.Write(@"c:\invoices");

// To generate Japanese invoices: (uses unicode UTF-16)
// Nihon no seikyū-sho o seisei suru ni wa:
//Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
//Console.WriteLine(@"c:\invoices\app.exe -j"+"\n\n\n\n\n\n");


//string interpolation ($ and {}) to compine literal string and variable value
//string firstname = "bob";
//var message = $"Hello {firstname}";
//Console.WriteLine(message+"\n\n\n\n\n\n");

//int version = 11;
//string updateText = "Update to windows";
//string message2 = $"{updateText} {version}!";
//Console.WriteLine(message2);
*/
/*
//combines string interpolation ($ and {}) with verbatim literals(@"[message]")
string projectName1 = "First-Project";
Console.WriteLine($@"C:\Output\{projectName1}\Data"+"\n\n\n");


string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

//displays english output location
Console.WriteLine("View English output:");
Console.WriteLine($@"   c:\Exercise\{projectName}\data.txt"+"\n");

//displays Russian message version 
Console.WriteLine(russianMessage+":");
Console.WriteLine($@"   c:\Exercise\{projectName}\ru-RU\data.txt");
*/
/*
int sum = 7+5;
int diff = 7-5;
int product = 7*5;
int quotient = 7/5;
decimal deciQuotient = 7.0m/5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + diff);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient); //quotient improperly stored as integer

Console.WriteLine($"Decimal Quotient: {deciQuotient}"); //fixed above issue


int first = 7;
int second = 5;

decimal quotient = (decimal)first / (decimal)second; //casts both integers as decimal values before running
Console.WriteLine(quotient);
*/
/*

//displays the modulus of two mod functions
Console.WriteLine($"Modulus of 200 / 5 : {200%5}");
Console.WriteLine($"Modulus of 7 / 5 : {7%5}");
*/
/*


//display order of operations PEMDAS
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);
*/

/*
incremening and decrementing

int value =0; //value is 0
value = value + 5;   //value is 5
value += 5;   //value is 10

// ++ operator increments by 1
int value1 = 0;  //value is 0
value1 = value1 +1;  // value is 1
value1++;  //value is 2
*/

/*
//shows the difference between having incrementor
//before and after variable

int value = 1;
value++;
Console.WriteLine ("First: " + value);
Console.WriteLine($"Second: {value++}"); //note no increase until next line
Console.WriteLine("Third: "+ value); //no value modification on this line
Console.WriteLine("Fourth: " + (++value)); //note the value has incremented unlike second line
*/
