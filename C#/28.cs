/*
    28. Implement strStr

    Explanation:
    Iterate with Substring

    Medium

*/

public class Solution28 {
    public int StrStr(string haystack, string needle) {
        int m = needle.Length;
        if(m == 0)
            return 0;
        if(m == haystack.Length)
            return haystack == needle? 0 : -1;
            
        for(int i = 0; i<=haystack.Length - m; i++){
            Console.WriteLine(i);
            if(needle == haystack.Substring(i, m))
                return i;
        }
        
        return -1;
    }
}