class Base 
{
    Random rnd = new Random();
    public int[] F1 = new int[3];
    public int[] F2 = new int[3];
    public int[] F3 = new int[3];
    public int sum;
    public float rapport;
    public void Start()
    {

        Fill(F1, 0, 3);
        Fill(F2, 0, 3);
        Fill(F3, 0, 3);

        sum = GetSum();
        rapport = GetRapport();
        //ShowTable(F1);
        //ShowTable(F2);
        //ShowTable(F3);
    }

    public void Fill(int[] t, int min, int max)
    {
        for (int i = 0; i < 3; i++)
        {
            t[i] = rnd.Next(min, max) + 1;
            int diff = max - min;
            min += diff;
            max += diff;
        }
    }

    public int GetSum()
    {
        int sum = 0;
        for(int i = 0; i < 3; i++)
        {
            if (i%2 == 0)
            {
                for(int y = 0; y < 3; y++)
                {
                    if(y%2 != 0)
                    {
                        sum += F1[i] * F2[y];

                        sum -= F3[y + 1];

                        break;
                    }
                }
            }
            else
            {
                for(int y = 0; y < 3; i++)
                {
                    if(y%2 == 0)
                    {
                        sum += F1[i] * F2[y];
                        sum -= F3[y + 1];
                        break;
                    }
                }
            }
        }

        return sum;
    }

    public float GetRapport()
    {
        float rapport = 0;
        
        for(int i = 0; i < 3; i++)
        {
            if(i%2 == 0)
            {
                for(int y = 0; y < 3; y++)
                {
                    if(y%2 != 0)
                    {
                        for(int h = 0; h < 3; h++)
                        {
                            if(h%2 == 0)
                            {
                                rapport = (F1[i] * F2[y]) / F3[h];
                            }
                        }
                    }
                }
            }
            else
            {
                for (int y = 0; y < 3; y++)
                {
                    if (y % 2 == 0)
                    {
                        for (int h = 0; h < 3; h++)
                        {
                            if (h % 2 != 0)
                            {
                                rapport = (F1[i] * F2[y]) / F3[h];
                            }
                        }
                    }
                }
            }
        }
        
        return rapport;
    }

    public void ShowTable(int[] t) 
    {
        for(int i = 0; i<3; i++)
        {
            Console.Write("f[" + i + "]" + ": " + t[i] + " ");
        }
    }
}