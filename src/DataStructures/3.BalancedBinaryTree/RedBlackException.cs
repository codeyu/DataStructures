///<summary>
/// The RedBlackException class distinguishes read black tree exceptions from .NET
/// exceptions. 
///</summary>
using System;

namespace DataStructures._3.BalancedBinaryTree
{
	public class RedBlackException : Exception
	{
		public RedBlackException()
        {
    	}
			
		public RedBlackException(string msg) : base(msg) 
        {
		}			
	}
}
