using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
	public class SignUpDataModel
	{
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		[Required]
		public string EmailAddress { get; set; }
		[Required]
		public string Password { get; set; }
	}
}
