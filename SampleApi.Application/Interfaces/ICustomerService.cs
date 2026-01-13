using SampleApi.Domain.Entities;

namespace SampleApi.Application.Interfaces
{
	public interface ICustomerService
	{
		Customer GetById(int id);
		List<Customer> GetAll();
	}
}
