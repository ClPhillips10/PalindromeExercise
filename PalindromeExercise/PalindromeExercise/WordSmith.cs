using System;
using System.Collections.Generic;
namespace PalindromeExercise
	
{
	public class WordSmith
	{
		public WordSmith()
		{
		}
		public bool IsAPalindrome(string str1)
		{
			var reversed = "";
			for (int i = str1.Length -1; i >= 0; i--)
			{
				reversed += str1[i];
			}
			if (reversed.ToLower() == str1.ToLower())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

