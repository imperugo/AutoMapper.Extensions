using System;

namespace AutoMapper.Extensions.Converters
{
	public class DateTimeTypeConverter : ITypeConverter<DateTimeOffset, DateTime>
	{
		public DateTime Convert(DateTimeOffset source, DateTime destination, ResolutionContext context)
		{
			return source.DateTime;
		}
	}
}
