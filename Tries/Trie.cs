using System;
using System.Collections;
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
            Head.Children.Clear();
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
            curr.IsWord = true;
        }

        public bool Remove(string search)
        {
            TrieNode curr = Head;
            Stack<TrieNode> stack = new Stack<TrieNode>();

            for (int i = 0; i < search.Length; i++)
            {
                if (curr.Children.ContainsKey(search[i]))
                {
                    stack.Push(curr);
                    curr = curr.Children[search[i]];
                }
                else return false;
            }

            if (curr.Letter == search[search.Length - 1]) return false;

            stack.Push(curr);
            curr.IsWord = false;

            while (stack.Count != 1)
            {
                TrieNode temp = stack.Pop();
                if (temp.Children.Count >= 1 || temp.IsWord == true)
                {
                    return true;
                }
                TrieNode t;
                t = stack.Peek();
                t.Children.Remove(temp.Letter);
            }
            return false;
        }

        public bool Contains(string search)
        {
            TrieNode curr = Head;
            Stack<TrieNode> stack = new Stack<TrieNode>();

            for (int i = 0; i < search.Length; i++)
            {
                if (curr.Children.ContainsKey(search[i]))
                {
                    stack.Push(curr);
                    curr = curr.Children[search[i]];
                }
            }
            stack.Push(curr);
            if (stack.Count == search.Length + 1) return true;
            return false;
        }

        public TrieNode SearchNode(string search)
        {
            TrieNode curr = Head;
            TrieNode ret;
            Stack<TrieNode> stack = new Stack<TrieNode>();

            for (int i = 0; i < search.Length; i++)
            {
                if (curr.Children.ContainsKey(search[i]))
                {
                    stack.Push(curr);
                    curr = curr.Children[search[i]];
                }
            }
            stack.Push(curr);
            if (stack.Count == search.Length + 1)
            {
                ret = stack.Pop();
                return ret;
            }
            return null;
        }

        public List<string> GetAllMatchingPrefix(string search)
        {
            List<string> ret = new List<string>();
            TrieNode curr = SearchNode(search);

            for (int i = 0; i < curr.Children.Count; i++)
            {
                GetAllMatchingPrefix(curr.Children[].Letter);
            }

            return ret;

            //FIX RECUSIVE CALLS
        }
    }
}
