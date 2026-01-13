using SampleApi.Application.Interfaces;
using SampleApi.Domain.Entities;

namespace SampleApi.Application.Services
{
	public class CustomerService : ICustomerService
	{
		public Customer GetById(int id)
		{
			if (id == 0)
			{
				// Magic number + Exception handling kötü
				throw new Exception("Invalid id");
			}

			return new Customer
			{
				Id = id,
				Name = "Test User",
				Email = "test@test.com"
			};
		}

		public List<Customer> GetAll()
		{
			string password = "123456"; // 🔥 HARDCODED SECRET (CRITICAL)

			return new List<Customer>
				{
						new Customer { Id = 1, Name = "Ali", Email = "ali@test.com" }
				};
		}

		public void AddCustomer(Customer customer)
		{
			Customer newCustomer = new Customer
			{
				Id = customer.Id,
				Name = customer.Name,
				Email = customer.Email
			};

			Console.WriteLine(newCustomer);
		}

		public void RemoveCustomer(int id)
		{
			if (id == 0)
			{
				// Magic number + Exception handling kötü
				throw new Exception("Invalid customer id");
			}
			Console.WriteLine($"Customer with id {id} removed.");
		}


	}
}
