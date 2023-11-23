// See https://aka.ms/new-console-template for more information
int[] ints = new int[] {1,3,2};
Console.WriteLine(TotalImbalance(ints));

int TotalImbalance(int[] Parcel)
{
  
    int len = Parcel.Length;
    int[,] W = new int[len+1,len+1];
    for (int i = 1; i <= len; i++)
    {
        W[0, i] = Parcel[i - 1];
        W[i, 0] = Parcel[i - 1];
    }
    int res = 0;

    for (int i = 1; i < len+1; i++)
    {
        for (int j = 1; j < len+1; j++)
        {
            if (i <= j)
                W[i, j] = 0;
            else
            {
                W[i, j] = Math.Abs(W[i, 0] - W[0, j]);
                res += W[i, j];
            }
        }
    }
    return res;
}
