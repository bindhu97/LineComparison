// See https://aka.ms/new-console-template for more information
using LineComparison;

Console.WriteLine("Welocome to Line Comparison Program");

Console.WriteLine("Calling CompareTwoLines");
CompareTwoLines twoLines = new CompareTwoLines();
twoLines.Compare();

Console.WriteLine("Calling CheckEquality");
CheckEquality check = new CheckEquality();
check.Equality();

Console.WriteLine("Caling LengthOfLine");
LengthOfLine ofLine = new LengthOfLine();
ofLine.Length();

