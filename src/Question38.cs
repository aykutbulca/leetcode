using System;

namespace LeetCode.Problems
{
    public class Question38
    {
        public string CountAndSay(int n) {
            int index = n;
            string lastSeqNumber = "1";
            
            while(index > 1) { 
                Char[] chars = lastSeqNumber.ToCharArray();
                string newSeqNumber = "";
                int counter = 0, lastIndex = 0;

                for(int i=0; i<chars.Length; i++) {
                    if(Convert.ToInt32(Char.GetNumericValue(chars[lastIndex])) == Convert.ToInt32(Char.GetNumericValue(chars[i]))) {
                        counter++;
                    } else {
                        newSeqNumber += counter.ToString() + chars[lastIndex].ToString();
                        counter = 1;
                        lastIndex = i;
                    }   

                    if(i+1 == chars.Length) {
                        newSeqNumber += counter.ToString() + chars[i].ToString();
                    }          
                }
                
                lastSeqNumber = newSeqNumber;

                index--;
            }

            return lastSeqNumber;
        }
    }
}
