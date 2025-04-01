namespace Solution.BracketValidation;

public class BracketValidator
{
    private class Node
    {
        public char Data;
        public Node? Next;

        public Node(char data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node? top;

    public BracketValidator()
    {
        top = null;
    }

    public void Push(char c)
    {
        var newNode = new Node(c);
        newNode.Next = top;
        top = newNode;
    }

    public char Pop()
    {
        if (top == null)
            throw new InvalidOperationException("");

        char data = top.Data;
        top = top.Next;
        return data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }

    public bool ValidasiEkspresi(string ekspresi)
    {
        foreach (char c in ekspresi)
        {
            if (c == '(' || c == '{' || c == '[')
            {
                Push(c);
            }
            else if (c == ')' || c == '}' || c == ']')
            {
                if (IsEmpty())
                    return false;

                char topChar = Pop();
                if (!IsMatchingPair(topChar, c))
                    return false;
            }
        }

        return IsEmpty();
    }
    private bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}
