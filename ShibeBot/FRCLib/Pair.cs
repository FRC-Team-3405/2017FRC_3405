using System;
using System.Collections.Generic;
namespace ShibeBot
{
	public class Pair<T>
	{
		private T first;
		private T second;
		public Pair(T _first, T _second)
		{
			first = _first;
			second = _second;
		}

		public T GetX() 
		{
			return first;
		}

		public T GetY()
		{
			return second;
		}

		public T GetFirst() 
		{
			return first;
		}

		public T GetSecond()
		{
			return second;
		}



	}
}
