using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using _31github;

namespace _31github;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder res = new StringBuilder();
        int i = 0, j = 0;
        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
            {
                res.Append(word1[i]);
                i++;
            }

            if (j < word2.Length)
            {
                res.Append(word2[j]);
                j++;
            }
        }
        return res.ToString();
    }


}