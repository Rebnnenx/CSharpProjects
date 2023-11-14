//writes to the console
///
//Console.WriteLine("Hello, World!");

//writes to the console and appends newline character after first statement
//Console.WriteLine("This is the first line.");
//Console.WriteLine("This is the second line.\n\n\n\n");

//verbatim string literals use the @ symbol before the double quoute
//Console.WriteLine(@"    c:\source\repos
//        (this is where your coed goes)");



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