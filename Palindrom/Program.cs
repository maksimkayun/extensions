int num = Convert.ToInt32(Console.ReadLine());
Console.ReadLine().Split(' ')
    .OrderBy(x => x.Length).ToList().ForEach(s =>
    {
        if (s.Length <= num)
        {
            Console.Write(s);
            Environment.Exit(0);
        }
    });
