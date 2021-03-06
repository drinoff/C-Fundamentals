﻿using System;
using System.IO;

namespace zuehlkeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "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";
			
			var result = LongestRepeatedSubstring(str);
			Console.WriteLine(result);

        }

		public static string LongestRepeatedSubstring(string str)
		{
			if (string.IsNullOrEmpty(str))
				return null;

			int N = str.Length;
			string[] substrings = new string[N];

			for (int i = 0; i < N; i++)
			{
				substrings[i] = str.Substring(i);
			}

			Array.Sort(substrings);

			string result = "";

			for (int i = 0; i < N - 1; i++)
			{
				string lcs = LongestCommonString(substrings[i], substrings[i + 1]);

				if (lcs.Length > result.Length)
				{
					result = lcs;
				}
			}

			return result;
		}

		private static string LongestCommonString(string a, string b)
		{
			int n = Math.Min(a.Length, b.Length);
			string result = "";

			for (int i = 0; i < n; i++)
			{
				if (a[i] == b[i])
					result = result + a[i];
				else
					break;
			}

			return result;
		}
	}
}
