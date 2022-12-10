namespace Tries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("babe");
            trie.Insert("baby");

            bool i = trie.Remove("baby");

            bool c = trie.Contains("babee");

            TrieNode node = trie.SearchNode("babeeeeee");

            List<string> s = trie.GetAllMatchingPrefix("babe");
        }
    }
}