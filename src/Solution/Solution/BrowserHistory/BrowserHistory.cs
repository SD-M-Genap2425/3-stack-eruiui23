namespace Solution.BrowserHistory;

public class Halaman
{
    public string URL { get; set; }

    public Halaman(string url)
    {
        URL = url;
    }
}

public class Node
{
    public Halaman Data { get; set; }
    public Node Next { get; set; }

    public Node(Halaman data)
    {
        Data = data;
        Next = null;
    }
}

public class HistoryManager
{
    private Node top;

    public HistoryManager()
    {
        top = null;
    }

    public void Push(Halaman halaman)
    {
        Node newNode = new Node(halaman);
        newNode.Next = top;
        top = newNode;
    }

    public Halaman Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("");
        }

        Halaman poppedData = top.Data;
        top = top.Next;
        return poppedData;
    }

    public Halaman Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("");
        }

        return top.Data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }

    public void KunjungiHalaman(string url)
    {
        Push(new Halaman(url));
    }

    public string Kembali()
    {
        if (IsEmpty())
        {
            return "Tidak ada halaman sebelumnya.";
        }

        Pop();
        return IsEmpty() ? "Tidak ada halaman sebelumnya." : Peek().URL;
    }

    public string LihatHalamanSaatIni()
    {
        return IsEmpty() ? "" : Peek().URL;
    }

    public void TampilkanHistory()
    {
        
        List<string> urls = new List<string>();
        Node current = top;
        while (current != null)
        {
            urls.Add(current.Data.URL);
            current = current.Next;
        }
        
    
        for (int i = urls.Count - 1; i >= 0; i--)
        {
            Console.WriteLine(urls[i]);
        }
    }
}
