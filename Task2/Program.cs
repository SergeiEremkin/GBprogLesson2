int Number = new Random().Next(100, 1000);
System.Console.WriteLine(Number);
int NumberA = Number%10;
int NumberB = Number/10;
int NumberC = NumberB/10;
System.Console.WriteLine($"{NumberC}{NumberA}");