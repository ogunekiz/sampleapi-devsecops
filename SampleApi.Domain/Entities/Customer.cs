namespace SampleApi.Domain.Entities
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }   // Null check yok (Sonar uyarısı)
		public string Email { get; set; }  // Validation yok
	}
}
