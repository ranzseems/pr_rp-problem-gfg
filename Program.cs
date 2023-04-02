class Solution
{
     public long[] get(char c1, char c2, String str)
    {
        Stack<Char> s1 = new Stack<Char>();
        Stack<Char> s2 = new Stack<Char>();

        long cnt1 = 0, cnt2 = 0;

        s1.Push(str[0]);
        char temp = str[0];

        for (int i = 1; i < str.Length; i++)
        {
            //rprprpp
            if (s1.Count != 0 && str[i] == c2 && s1.Peek() == c1)
            {
                s1.Pop();
                cnt1++;
            }
            else s1.Push(str[i]);
        }

        s2.Push(s1.Pop());

        temp = s2.Peek();

        while (s1.Count != 0)
        {
            //rpp
            if (s2.Count != 0 && s1.Peek() == c2 && s2.Peek() == c1)
            {
                cnt2++;
                s2.Pop();
            }
            else
            {
                s2.Push(s1.Peek());
            }

            s1.Pop();
        }

        if (c1 == 'p') return new long[] { cnt1, cnt2 };

        return new long[] { cnt2, cnt1 };
    }
     public  void Solve(int X = 5, int Y=4, String S="rprprpp")
    {
        long[] elements;

        if (X > Y)
            elements = get('p', 'r', S);
        else
            elements = get('r', 'p', S);

        Console.WriteLine( elements[0] * X + elements[1] * Y);
        Console.ReadLine();
    }
}

