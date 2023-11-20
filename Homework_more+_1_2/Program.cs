Console.WriteLine("Input number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine(next(a));

static bool prime(int b)
{
	if (b <= 1)
	{
		return false;
	}
	for (int i = 2; i * i <= b; i++)
	{
		if (b % i == 0)
		{
			return false;
		}
	}
	return true;
}

static int next(int a)
{
	int i = 1;
    int y = 1;
	if (a <= 1) 
	{ 
		return 2; 
	}
    while (prime(a+i) == false) 
    {
		i++;
	}
    while (prime(a - y) == false)
	{
		y++;
	}
	if ( i <= y)
	{
		return a+i;
	}
    return a - y;
}

