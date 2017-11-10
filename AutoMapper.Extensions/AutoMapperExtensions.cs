namespace AutoMapper
{
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public static class AutoMapperExtensions
	{
		public static TResult MapPropertiesToInstance<TResult>(this object self, TResult value)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			return (TResult)Mapper.Map(self, value, self.GetType(), typeof(TResult));
		}

		public static List<TResult> MapTo<TResult>(this IEnumerable self)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			return (List<TResult>)Mapper.Map(self, self.GetType(), typeof(List<TResult>));
		}

		public static TResult MapTo<TResult>(this object self)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			return (TResult)Mapper.Map(self, self.GetType(), typeof(TResult));
		}
	}
}