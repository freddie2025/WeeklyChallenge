using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MongoDB.Library.Models
{
	public class PersonModel
	{
		[BsonId]
		public Guid Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string PhoneNumber { get; set; }

		public override string ToString()
		{
			return $" { FirstName } { LastName }";
		}
	}
}
