using System;
using System.Runtime.Serialization;

namespace ConsoleUI
{
	[DataContract]
	public class PersonModel
	{
		public string Id { get; set; }
		[DataMember(Name = "name")]
		public string FullName { get; set; }
		[DataMember]
		public string height { get; set; }
		[DataMember]
		public string mass { get; set; }
		[DataMember]
		public string hair_color { get; set; }
		[DataMember]
		public string skin_color { get; set; }
		[DataMember]
		public string eye_color { get; set; }
		[DataMember]
		public string birth_year { get; set; }
		[DataMember(Name = "gender")]
		public string Gender { get; set; }
		[DataMember]
		public string homeworld { get; set; }
		[DataMember]
		public string[] films { get; set; }
		[DataMember]
		public string[] species { get; set; }
		[DataMember]
		public string[] vechicles { get; set; }
		[DataMember]
		public string[] starships { get; set; }
		[DataMember]
		public DateTime created { get; set; }
		[DataMember]
		public DateTime edited { get; set; }
		[DataMember]
		public string url { get; set; }
	}
}
