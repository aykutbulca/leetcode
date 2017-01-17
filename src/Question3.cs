using System;
using System.Collections.Generic;
//using System.Linq;

namespace LeetCode.Problems
{
    public class Question3
    {
        public int LengthOfLongestSubstring(string s) {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int longest = 0, currentLongest = 0;
            Char[] chars = s.ToCharArray(); 

            for(int i=0; i<chars.Length; i++){
                if(dic.ContainsKey(chars[i])) {
                    i = dic[chars[i]];
                    dic.Clear();
                    currentLongest = 0;
                } else {
                    dic.Add(chars[i], i);
                    currentLongest++;
                }
                
                if(currentLongest > longest) longest = currentLongest;
            }

            return longest;
        }
    }
}


/*
    public int LengthOfLongestSubstring(string s) {
        int longest = 0;
        Char[] chars = s.ToCharArray(); 

        for(int i=0; i<chars.Length; i++){
            for(int j=i+1; j<chars.Length; j++){
                Char[] subChars = s.Substring(i, j-i).ToCharArray();
                if(subChars.Distinct().ToArray().Length == subChars.Length && subChars.Length > longest){
                    longest = subChars.Length;
                }
            }
        }

        return longest;
    }
*/
