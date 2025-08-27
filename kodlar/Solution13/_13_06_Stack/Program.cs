Console.WriteLine(IsBalanced("{ [ (a+b)*c ]-5}")); // true
Console.WriteLine(IsBalanced("{ [ (a+b)*c ]")); // false

bool IsBalanced(string input)
{
    const string openBrackets = "([{";
    const string closeBrackets = ")]}";

    var stack = new Stack<char>();

    foreach (char ch in input)
    {
        int openIndex = openBrackets.IndexOf(ch);
        if (openIndex>=0)
        {
            stack.Push(ch);
            continue;
        }

        int closeIndex = closeBrackets.IndexOf(ch);
        if (closeIndex>=0)
        {
            // yığın boş olma durumunu
            if (stack.Count == 0)
                return false;

            char lastOpen = stack.Pop();
            if (lastOpen != openBrackets[closeIndex])
                return false;
        }
    }
    return stack.Count == 0;
}

Console.ReadKey();