using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Algorithms
{
    public static class ArrayAndStrings
    {
        public static bool IsUnique(string str)
        {
            if(str.Length == 0) return false;

            // algorithm
            HashSet<char> map = new HashSet<char>();

            foreach(char c in str)
            {
                if(map.Contains(c)) 
                {
                    return false;
                }

                map.Add(c);
            }

            return true;
        }

        public static bool IsUnique2(string str)
        {
            if(str.Length == 0) return false;

            // O(N)
            char[] str_sorted = str.ToArray();

            // O(N*LogN)
            Array.Sort(str_sorted);

            // O(N)
            for(int i = 1; i < str_sorted.Length - 1; i++)
            {
                if(str_sorted[i] == str_sorted[i-1])
                    return false;
            }
            return true;
        }
        public static void IsUniqueTest()
        {
            WriteLine("O(n) Time | O(n) Space --- using HashSet* looping through once");
            WriteLine(IsUnique("")); // false;
            WriteLine(IsUnique(" ")); //true;
            WriteLine(IsUnique("abcdefah")); // false;
            WriteLine(IsUnique("abcdefgh")); //true;

            WriteLine("O(n*logn) Time | O(1) Space --- Sorting the string as char array then loop");    
            WriteLine(IsUnique2("")); // false;
            WriteLine(IsUnique2(" ")); //true;
            WriteLine(IsUnique2("abcdefah")); // false;
            WriteLine(IsUnique2("abcdefgh")); //true;
        }
    
        public static void CheckPermutationTest()
        {
            WriteLine("O(N) time | O(N) Space");
            WriteLine(CheckPermuation("","")); // false
            WriteLine(CheckPermuation(" "," ")); // true
            WriteLine(CheckPermuation("abcdef","acdbfe")); //true
            WriteLine(CheckPermuation("abcdabcd","aabdbdcc")); //true
            WriteLine(CheckPermuation("abcdabcd","aabdbdcf")); //false

            WriteLine("O(NlogN) time | O(N) Space");
            WriteLine(CheckPermuation2("","")); // false
            WriteLine(CheckPermuation2(" "," ")); // true
            WriteLine(CheckPermuation2("abcdef","acdbfe")); //true
            WriteLine(CheckPermuation2("abcdabcd","aabdbdcc")); //true
            WriteLine(CheckPermuation2("abcdabcd","aabdbdcf")); //false
        }

        public static bool CheckPermuation(string source, string target)
        {
            //start - guard
            if(source.Length == 0 || target.Length == 0) return false;
            if(source.Length != target.Length) return false;
            //end - guard

            Dictionary<char, int> map = BuildFrequencyMap(target); // todo

            for(int idx = 0; idx < source.Length; idx ++)
            {
                if(!map.ContainsKey(source[idx]) || map[source[idx]] == 0)
                    return false;
                
                map[source[idx]] -= 1;
            }

            return true;
        }

        public static bool CheckPermuation2(string source, string target)
        {
            if(source.Length == 0 || target.Length == 0 ) return false;
            if(source.Length != target.Length) return false;


            var source1 = source.ToArray();
            var target1 = target.ToArray();
            Array.Sort(source1); // O(nlogn)
            Array.Sort(target1); // O(nlogn)

            for(int idx = 0; idx < source1.Length; idx++)
            {
                if(source1[idx] != target1[idx])
                    return false;
            }

            return true;
        }
        

        public static void URLify_Test()
        {
            WriteLine(URLify("", 0)); // return "";
            WriteLine(URLify("", 1)); // return "";
            WriteLine(URLify("abc", 0)); // return "";
            WriteLine(URLify("Mr John Smith      ", 13)); //Mr%20John%20Smith;
            WriteLine(URLify("MrJohnSmith", 11)); //MrJohnSmith;
            WriteLine(URLify(" Mr John Smith         ",14)); //%20Mr%20John%20Smith;
        }

        public static string URLify(String str, int trueLength)
        {
            if(str.Length == 0 || trueLength == 0) return "";

            int spaceCount = str.Length - trueLength;
            if(spaceCount == 0) return str;

            
            StringBuilder url = new StringBuilder();
            int j = 0;
            for(int idx = 0;  idx < trueLength; idx++, j++)
            {
                if(str[idx] == ' ')
                {
                    url.Append("%20");

                    
                }
                else
                {
                    url.Append(str[idx]); 
                }
            }
            
            
            return url.ToString();
        }
        
        
        public static void StringCompression_Test()
        {
            WriteLine(StringCompression("")); // "" -- Empty
            WriteLine(StringCompression("aabbcc")); //aabbcc
            WriteLine(StringCompression("aabbbcccc")); // a2b3c4
            WriteLine(StringCompression("abbbbccd")); // ab4c2d
            WriteLine(StringCompression("abcdef")); // abcdef
        }

        public static string StringCompression(string source)
        {
            if(source.Length < 3) return source;

            int countChar = 1;
            char currentChar = source[0];
            var target = new StringBuilder();
            for(int i = 1; i < source.Length; i++)
            {
                if(source[i] == currentChar)
                {
                    countChar++;
                    continue;
                }

                target.Append(currentChar);
                currentChar = source[i];

                if(countChar > 1)
                {
                    target.Append(countChar);
                    countChar = 1;
                }
            }
            target.Append(currentChar);
            if(countChar > 1)
                target.Append(countChar);

            if(target.Length == source.Length) return source;

            return target.ToString();
        }
        
        private static Dictionary<char, int> BuildFrequencyMap(string target)
        {
            var map = new Dictionary<char,int>();

            for(int idx = 0; idx < target.Length; idx++)
            {
                if(map.ContainsKey(target[idx]))
                {
                    map[target[idx]] += 1;
                }
                else
                {
                    map.Add(target[idx], 1);
                }
            }

            return map;
        }


    }   
}