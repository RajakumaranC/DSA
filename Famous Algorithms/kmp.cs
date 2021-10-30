namespace Famous_Algorithms
{
    /// <summary>
    /// Knuth-Morris-Pratt Substring matching class 
    /// This is an extension method for the System.String (alias: string) type
    /// O(N + M) Time | O(M) Space -- where N is the current string length and M is substring length
    /// </summary>
    public static class KMP
    {
        public static bool Substring_KMP(this string str, string substring)
        {
            if(substring.Length > str.Length) return false;

            int[] pattern = BuildPattern(substring); // O(M) time | O(M) space

            return FindMatch(str, substring, pattern); // 
        }

        private static bool FindMatch(string str, string substring, int[] pattern)
        {
            int i = 0; 
            int j = 0;
            while(i + substring.Length - j <= str.Length)
            {
                if(str[i] == substring[j])
                {
                    if(j == substring.Length - 1) return true;
                    i++; j++;
                }
                else if(j > 0)
                {
                    j = pattern[j - 1] + 1;
                }
                else
                {
                    i++;
                }
            }

            return false;
        }

        private static int[] BuildPattern(string substring)
        {
            int[] pattern = new int[substring.Length];
            Array.Fill(pattern, -1);

            int i = 0; 
            int j = 1;

            while(j < substring.Length)
            {
                if(substring[j] == substring[i])
                {
                    pattern[j] = i;
                    j++; i++;
                }
                else if(i > 0)
                {
                    i = pattern[i - 1] + 1;
                }
                else
                {
                    j++;
                }
            }

            return pattern;
        }


    }
}