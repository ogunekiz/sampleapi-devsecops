using SampleApi.Application.Services;

namespace SampleApi.Tests
{
	public class CustomerServiceTests
	{
		[Fact]
		public void GetById_ShouldReturnCustomer()
		{
			var service = new CustomerService();
			var result = service.GetById(1);

			Assert.NotNull(result);
		}
	}
}
