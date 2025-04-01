using Solution.BracketValidation;
using Solution.BrowserHistory;
using Solution.Palindrome;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        // Browser history
        HistoryManager history = new HistoryManager();

        // Demonstrasi penggunaan
        Console.WriteLine("Mengunjungi halaman...");
        history.KunjungiHalaman("https://example.com");
        history.KunjungiHalaman("https://google.com");
        history.KunjungiHalaman("https://github.com");

        Console.WriteLine("\nHalaman saat ini:");
        Console.WriteLine(history.LihatHalamanSaatIni());

        Console.WriteLine("\nKembali ke halaman sebelumnya:");
        Console.WriteLine(history.Kembali());

        Console.WriteLine("\nHalaman saat ini:");
        Console.WriteLine(history.LihatHalamanSaatIni());

        Console.WriteLine("\nHistory:");
        history.TampilkanHistory();
        
        // Bracket validator
        Console.WriteLine("\nValidasi ekspresi dengan bracket validator:");
        string[] ekspresi = { "()", "(]", "([])", "{[()]}", "{[(])}" };

        var validator = new BracketValidator();
        foreach (var exp in ekspresi)
        {
            Console.WriteLine($"Ekspresi: {exp} -> Valid: {validator.ValidasiEkspresi(exp)}");
        }

        //Palindrome Checker
         string[] testCases = {
                "Kasur ini rusak",
                "Ibu Ratna antar ubi",
                "Hello World"
            };

            foreach (string testCase in testCases)
            {
                bool result = PalindromeChecker.CekPalindrom(testCase);
                Console.WriteLine($"Input: \"{testCase}\" => Output: {result}");
            }
    }
}

