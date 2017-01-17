using System;

namespace LeetCode.Problems
{
    public class Question165
    {
        public int CompareVersion(string version1, string version2) {
            string[] array1 = version1.Split('.');
            string[] array2 = version2.Split('.');
            int maxLength = array1.Length > array2.Length ? array1.Length: array2.Length;
            int index = 0;

            while(index < maxLength) {
                string value1 = array1.Length > index ? array1[index]: "0";
                string value2 = array2.Length > index ? array2[index]: "0";
                
                if(Convert.ToInt32(value1) > Convert.ToInt32(value2)) {
                    return 1;
                } if(Convert.ToInt32(value1) < Convert.ToInt32(value2)) {
                    return -1;
                }          

                index++;
            }

            return 0;
        }
    }
}

