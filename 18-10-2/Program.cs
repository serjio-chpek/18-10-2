int[] A = new int[20];
int[] B = new int[20];


for (int i = 0; i < 20; i++)
{
    A[i] = random();
}

for (int i = 0; i < 20; i++)
{
    if (A[i] <= 888)
    {
        B[i] = A[i];
    }
}

int temp;
for (int i = 0; i < 19; i++)
{
    for (int j = i+1; j < 20; j++)
    {
        if (B[i] < B[j])
        {
            temp = B[i];
            B[i] = B[j];
            B[j] = temp;
        }
    }
}

for (int i = 0; i<20; i++)
{
    if (B[i] != 0)
    {
        Console.WriteLine(B[i]);
    }
}

static int random()
{
    Random rnd = new Random();
    int value = rnd.Next(-2000, 2000) ;
    return value;
}