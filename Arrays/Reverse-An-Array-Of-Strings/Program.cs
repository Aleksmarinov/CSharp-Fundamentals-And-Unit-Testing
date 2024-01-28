//Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').ToArray().Reverse().ToArray()));

var array = Console.ReadLine().Split(' ').ToArray();
List<string> reverseList = new List<string>(array);
reverseList.Reverse();

Console.WriteLine(string.Join(" ", reverseList));