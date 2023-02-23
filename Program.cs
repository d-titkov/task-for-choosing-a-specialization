Console.WriteLine("Enter comma-separated alphanumeric expressions:");
string input = Console.ReadLine();

string[] expressions = input.Split(',');
string[] shortExpressions = Array.FindAll(expressions, x => x.Length < 4);

string output = string.Join(", ", shortExpressions);
output = "[" + output + "]";

Console.WriteLine("Short expressions: " + output);