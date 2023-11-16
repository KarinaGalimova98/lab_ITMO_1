Console.WriteLine("Введите значение переметра: ");
int permtr   = int.Parse(Console.ReadLine());

double a, b, c;
a = permtr / 3;b = a;c = a;
double p = permtr / 2;
double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
s = Math.Round(s, 2);

Console.WriteLine("\t\tСторона:\tПлощадь:\n\t\t"+ a+"\t\t"+s);


