using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMapper.Extensions.Converters
{
	public class UriToStringTypeConverter : ITypeConverter<Uri, string>
	{
		public string Convert(Uri source, string destination, ResolutionContext context)
		{
			return source?.ToString();
		}
	}
}
