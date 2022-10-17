Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("*");

int xa = 30, ya = 1, 
    xb = 1,  yb = 20, 
    xd = 60, yd = 20, 
    count = 0;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xd, yd);
Console.WriteLine("+");

int x = xa, y = xb;
while (count < 1000)
{
   int what = new Random().Next(0,3);  // числа 0,1,2
   if (what == 0)
   {
    x = (x + xa) / 2;
    y = (y + ya) / 2;
   } 
    if (what == 1)
   {
    x = (x + xb) / 2;
    y = (y + yb) / 2;
   } 
    if (what == 2)
   {
    x = (x + xd) / 2;
    y = (y + yd) / 2;
   } 
   Console.SetCursorPosition(x, y);
   Console.WriteLine("+");
   count++;
}    