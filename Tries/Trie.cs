using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tries
{
    public class Trie
    {
        TrieNode Head = new TrieNode('$');

        public void Clear()
        {

        }

        public void Insert(string word)
        {
            TrieNode curr = Head;
            for (int i = 0; i < word.Length; i++)
            {
                char c = word[i];
                if (!curr.Children.ContainsKey(c))
                {
                    curr.Children.Add(c, new TrieNode(c));
                }
                curr = curr.Children[c];
            }
        }

        public bool Contains(string word)
        {
            return false;
        }

        private TrieNode SearchNode(string word)
        {
            return null;
        }

        public List<string> GetAllMatchingPrefix(string prefix)
        {
            return null;
        }

        public bool Remove(string prefix)
        {
            return false;
        }
    }
}
