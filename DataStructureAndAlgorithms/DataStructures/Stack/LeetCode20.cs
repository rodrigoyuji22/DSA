namespace DataStructureAndAlgorithms.DataStructures.Stack;

public class LeetCode20
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        foreach (var c in s)
        {
            if(c == '(' || c == '[' || c == '{' )
                stack.Push(c);
            else
            {
                if(stack.Count == 0)
                    return false;
                var compare = stack.Pop();
                if((c == ')' && compare != '(' ) ||  
                   (c == ']' && compare != '[')  ||  
                   (c == '}' && compare != '{'))
                {
                    return false;
                }
            }
        }
        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}