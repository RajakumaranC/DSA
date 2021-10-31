using System.Text;

namespace Algorithms
{
    public class Generate_Parenthesis 
    {
    
        public static IList<string> Generate(int n) 
        {
            IList<string> result = new List<string>();
        
            if(n == 0) return result;
            
            Generate(result, new StringBuilder(), n, 0);
            
            return result;
        }
        
        public static void Generate(IList<string> result, StringBuilder sb, int open, int close)
        {
            if(open == 0 && close == 0)
            {
                result.Add(sb.ToString()); 
            }
            else if(close == 0)
            {
                sb.Append('(');
                Generate(result, sb, open - 1, close + 1);
                sb.Remove(sb.Length - 1, 1);
                
            }
            else if(open == 0)
            {
                sb.Append(')');
                Generate(result, sb, open, close - 1);
                sb.Remove(sb.Length - 1, 1);
            }
            else
            {   
                sb.Append('(');
                Generate(result, sb, open - 1, close + 1);
                sb.Remove(sb.Length - 1, 1);
                sb.Append(')');
                Generate(result, sb, open, close - 1);
                sb.Remove(sb.Length - 1, 1);
            }
            
        }
    }

}