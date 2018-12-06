namespace AutoMapper
{
	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Threading.Tasks;

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

		public static TResult MapPropertiesToInstance<TResult>(this object self, TResult value, Action<IMappingOperationOptions> opts)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			return (TResult)Mapper.Map(self, value, self.GetType(), typeof(TResult), opts);
		}

		public static List<TResult> MapTo<TResult>(this IEnumerable self)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			return (List<TResult>)Mapper.Map(self, self.GetType(), typeof(List<TResult>));
		}

		public static List<TResult> MapTo<TResult>(this IEnumerable self, Action<IMappingOperationOptions> opts)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			return (List<TResult>)Mapper.Map(self, self.GetType(), typeof(List<TResult>), opts);
		}

		public static TResult MapTo<TResult>(this object self)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			if (self is Task)
			{
				throw new ArgumentException("To map tasks, please use the MapToAsync method.");
			}

			return (TResult)Mapper.Map(self, self.GetType(), typeof(TResult));
		}

		public static TResult MapTo<TResult>(this object self, Action<IMappingOperationOptions> opts)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			if (self is Task)
			{
				throw new ArgumentException("To map tasks, please use the MapToAsync method.");
			}

			return (TResult)Mapper.Map(self, self.GetType(), typeof(TResult), opts);
		}

		public static async Task<TResult> MapToAsync<TResult, TSource>(this Task<TSource> self)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			var obj = await self;

			return (TResult)Mapper.Map(obj, obj.GetType(), typeof(TResult));
		}

		public static async Task<TResult> MapToAsync<TResult, TSource>(this Task<TSource> self, Action<IMappingOperationOptions> opts)
		{
			if (self == null)
			{
				throw new ArgumentNullException(nameof(self), "The source instance cannot be null.");
			}

			var obj = await self;

			return (TResult)Mapper.Map(obj, obj.GetType(), typeof(TResult), opts);
		}
	}
}