using System.ComponentModel.DataAnnotations;

namespace AmpAuth.Repository.Entities
{
	public class PolicyEntity
	{
		[Key]
		public long Id { get; set; }
		
		public string Name { get; set; }

		public string Description { get; set; }
	}
}
