using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Extensions.Tests.TestClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutoMapper.Extensions.Tests
{
	[TestClass]
	public class AutoMapperExtensionsTests
	{
		static bool initialized = false;

		public AutoMapperExtensionsTests()
		{
			if (!initialized)
			{
				Mapper.Initialize(cfg =>
				{
					cfg.CreateMap<User, UserResponse>();
				});

				initialized = true;
			}
		}

		[TestMethod]
		public async Task CallingMapToAsync_WithRealTask_ShouldReturnValidData()
		{
			var user = new User { Email = "imperugo@gmail.com", Firstname = "Ugo", Lastname = "Lattanzi" };
			var userTask = Task.FromResult(user);

			var response = await userTask.MapToAsync<UserResponse, User>();

			Assert.IsTrue(user.Firstname == response.Firstname);
			Assert.IsTrue(user.Lastname == response.Lastname);
			Assert.IsTrue(user.Email == response.Email);
		}


		[TestMethod]
		[ExpectedException(typeof(ArgumentException), "To map tasks, please use the MapToAsync method.")]
		public void CallingMapTo_WithAsyncTask_ShouldThrowArgumentException()
		{
			var user = new User { Email = "imperugo@gmail.com", Firstname = "Ugo", Lastname = "Lattanzi" };
			var userTask = Task.FromResult(user);

			var response = userTask.MapTo<UserResponse>();
		}


	}
}
