using static System.Console;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("My name is Ashley Davila");
Console.WriteLine("Version: {0}", Environment.Version.ToString());

string text = System.IO.File.ReadAllText("test.txt");
Console.WriteLine(text);

Console.WriteLine("My name is Ashley Davila");
Console.WriteLine("Version: {0}", Environment.Version.ToString());


string[] names; // can reference any size array of strings

// allocating memory for four strings in an array
names = new string[4];

// storing items at index positions
names[0] = "Ashley";
names[1] = "Brayan";
names[2] = "Violet";
names[3] = "Emily";

string[] names2 = new[] { "Ashley", "Brayan", "Violet", "Emily" };

// looping through the names
for (int i = 0; i < names2.Length; i++)
{
  // output the item at index position i
  WriteLine(names2[i]);
}

string[,] grid1 = new[,] // two dimensions
{
  { "Alpha", "Beta", "Gamma", "Delta" },
  { "Aroldo", "Bongo", "Toby", "Kate" },
  { "Dog", "Cat", "Bunny", "Lion" }
};

WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
  for (int col = 0; col <= grid1.GetUpperBound(1); col++)
  {
    WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
  }
}

// alternative syntax
string[,] grid2 = new string[3,4]; // allocate memory
grid2[0, 0] = "Alpha"; // assign string values
// and so on
grid2[2, 3] = "Dog";

string[][] jagged = new[] // array of string arrays
{
  new[] { "Alpha", "Beta", "Gamma" },
  new[] { "Aroldo", "Toby", "Bongo", "Kate" },
  new[] { "Dog", "Cat" }
};

WriteLine("Upper bound of array of arrays is: {0}",
  jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
  WriteLine("Upper bound of array {0} is: {1}",
    arg0: array,
    arg1: jagged[array].GetUpperBound(0));
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
  for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
  {
    WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
  }
}

// Pattern matching with arrays

int[] sequentialNumbers = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int[] oneTwoNumbers = new int[] { 10, 20 };
int[] oneTwoTenNumbers = new int[] { 10, 20, 100 };
int[] oneTwoThreeTenNumbers = new int[] { 10, 20, 30, 100 };
int[] primeNumbers = new int[] { 20, 30, 50, 70, 110, 130, 170, 190, 230, 290 };
int[] fibonacciNumbers = new int[] { 0, 10, 15, 20, 30, 55, 80, 137, 210, 345, 555, 890 };
int[] emptyNumbers = new int[] { };
int[] threeNumbers = new int[] { 99, 77, 55 };
int[] sixNumbers = new int[] { 92, 73, 52, 44, 25, 106 };

WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
  [] => "Empty array",
  [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
  [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
  [1, 2] => "Contains 1 then 2.",
  [int item1, int item2, int item3] => 
    $"Contains {item1} then {item2} then {item3}.",
  [0, _] => "Starts with 0, then one other number.",
  [0, ..] => "Starts with 0, then any range of numbers.",
  [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
  [..] => "Any items in any order.",
};

