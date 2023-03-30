int[] Array = { 7, 1, 2, 4, 11, 5, 1, 12, 13, 14, 15 };

string ArraySeq(int[] Array)
{
    string message = String.Empty;

    SortedSet<int> NumSet = new SortedSet<int>();
    int dif = 0;
    int idx1 = 0;
    int idx2 = 0;
    SortedSet<int> IdxSet = new SortedSet<int>();


    for (int i = 0; i < Array.Length; i++)
    {
        for (int j = 0; j < Array.Length; j++)
        {
            if (Array[i] + 1 == Array[j])
            {
                NumSet.Add(Array[i]);
                NumSet.Add(Array[j]);
            }
        }
    }
 
    if (NumSet.Count == 0) message = "Последовательностей нет";

    else
    {
        for (int i = 0; i < NumSet.Count - 1; i++)
        {

            if (NumSet.ElementAt<int>(i) + 1 != NumSet.ElementAt<int>(i + 1)) IdxSet.Add(i);
        }

        IdxSet.Add(0);
        IdxSet.Add(NumSet.Count - 1);

        for (int i = 0; i < IdxSet.Count - 1; i++)
        {
            if (IdxSet.ElementAt<int>(i + 1) - IdxSet.ElementAt<int>(i) > dif)
            {
                dif = IdxSet.ElementAt<int>(i + 1) - IdxSet.ElementAt<int>(i);
                if (i == 0) idx1 = IdxSet.ElementAt<int>(i);
                else idx1 = IdxSet.ElementAt<int>(i) + 1;
                idx2 = IdxSet.ElementAt<int>(i + 1);
            }
        }

        message = $"Наиболее длинная последовательность: {NumSet.ElementAt<int>(idx1)}, {NumSet.ElementAt<int>(idx2)}";

    }

    return message;
}


Console.Write(ArraySeq(Array));










