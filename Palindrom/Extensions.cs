namespace Palindrom;

public static class Extensions
{
    public static IEnumerable<int> GetReverseNumbersCollection(this string[]? arr, Predicate<int> condition)
    {
        List<int> result = new List<int>();
        Array.Reverse(arr);
        arr.Select(int.Parse).ToList().ForEach(e =>
        {
            if (condition(e))
            {
                result.Add(e);
            }
        });
        return result;
    }

    public static string GetFirstOrEmptyIf(this string[]? arr, Predicate<string> condition)
    {
        foreach (var name in arr)
        {
            if (condition(name))
            {
                return name;
            }
        }
        return string.Empty;
    }

    public static IEnumerable<int> ReshapeAndSort(this IEnumerable<int>? collect, Predicate<int> condition)
    {
        List<int> result = new List<int>();
        collect.ToList().ForEach(e =>
        {
            if (condition(e))
            {
                result.Add(e);
            }
        });
        result.Sort();
        return result;
    }

    public static List<string> CheckStringsAndSort(this List<string> collection, Predicate<string> condition)
    {
        List<string> result = new List<string>();
        collection.ForEach(s =>
        {
            if (condition(s))
            {
                result.Add(s);
            }
        });
        result.Sort();
        return result;
    }
}