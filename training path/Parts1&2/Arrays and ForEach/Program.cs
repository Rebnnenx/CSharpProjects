
/* Array declaration

//declare string array declaration starts at 0
string[] fraudulentOrderIds = new string[3];
fraudulentOrderIds[0]= "A123";
fraudulentOrderIds[1]= "B456";
fraudulentOrderIds[2]= "C789";
//fraudulentOrderIds[3]= "D000"  THis would not work because out of scope. THe error would not be seen until runtime. will compile fine


*/

/*declare an array and initialize it
string[] fraudulentOrderIds = {"A123", "B456", "C789"};
*/

/*retrieve values from an array
Console.WriteLine($"First: {fraudulentOrderIds[0]}");
Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

//reassigns first array item to a different string
fraudulentOrderIds[0]= "F000";
Console.WriteLine($"Reassigned First: {fraudulentOrderIds[0]}");


//the Length property contains the number of elements inside the array
Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process");
*/

/*implementing foreach statements in an array

string [] names = {"Rowena", "Robin", "Bao"};
foreach(string name in names)//each element in array names is temporarily assigned to variable name
{
    Console.WriteLine(name);
}

*/


/* Prompt
Suppose you work for a manufacturing company. 
The company needs you to complete an inventory of your warehouse to determine the number of products that are ready to ship. 
In addition to the total number of finished products, you need to report the number of finished products stored 
in each individual bin in your warehouse, along with a running total. This running total will be used to create 
an audit trail so you can double-check your work and identify "shrinkage".
*/

int[] inventory = {200,450,700,175,250};
int sum =0;
//shows what "bin" current items are stored in
int bin =0;

//aggregates total number of items in inventory
foreach(int items in inventory)
{
    sum +=items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (running total: {sum})");
}

//display total sum of inventory
Console.WriteLine($"We have {sum} items in inventory.");