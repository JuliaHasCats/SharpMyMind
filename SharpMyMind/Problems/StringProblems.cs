using System;
namespace SharpMyMind.Problems
{
    public class StringProblems
    {
        public static int FindFirstIndexOfTargetStringInSource(string source, string target) 
        { 
            if(source == null || target == null) 
            {
                return -1;
            }
            if(target == "") 
            {
                return source == "" ? 0 : -1;
            }
            for (int i = 0; i < source.Length - target.Length + 1; i++) 
            { 
                for(int j = 0; j < target.Length; j++) 
                {
                    if (target[j] != source[i + j]) { break; }// stop the internal loop

                    if(j == target.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
