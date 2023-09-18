//Console.Clear(); // очистка консоли, перед тем как наше приложение будет запускаться, всё в консоли будет очищаться.
//Console.SetCursorPosition(10, 4); // комманда которая будет "рисовать" в качестве аргументов (отступ от левого края, отступ от верхнего края). Строки и символы тут нумеруются с 0.
//Console.WriteLine("+");

int ax = 40;
int ay = 1;
int bx = 1;
int by = 30;
int cx = 80;
int cy = 30;

Console.SetCursorPosition(ax, ay);
Console.WriteLine("+");

Console.SetCursorPosition(bx, by);
Console.WriteLine("+");

Console.SetCursorPosition(cx, cy);
Console.WriteLine("+"); 

int x = ax;
int y = bx;

int count = 0;

while(count < 10000)
{
    int what = new Random().Next(0, 3); // [0,3) 0 1 2
    if(what == 0) 
    {
        x = (x + ax)/2;
        y = (y + ay)/2;
    }
    if (what == 1)
    {
        x = (x + bx) / 2;
        y = (y + by) / 2;
    }
    if(what == 2)
    {
        x = (x + cx)/2;
        y = (y + cy)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}