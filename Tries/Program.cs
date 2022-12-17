namespace Tries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("babe");
            trie.Insert("baby");
            trie.Insert("babes");
            trie.Insert("child");
            trie.Insert("babies");
            trie.Insert("he");
            trie.Insert("hell");
            trie.Insert("hello");
            trie.Insert("heaven");
            trie.Insert("havana");

            List<string> s = trie.GetAllMatchingPrefixSearch("babe");
            List<string> y = trie.GetAllMatchingPrefixSearch("ha");
            List<string> qs = trie.GetAllMatchingPrefixSearch("he");
        }
    }
}