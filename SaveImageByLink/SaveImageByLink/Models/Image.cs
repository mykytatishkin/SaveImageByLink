using System;
using System.ComponentModel.DataAnnotations;
namespace SaveImageByLink.Models
{
	public class Image
	{
		public int Id { get; set; }
		public string Name { get; set; }
		[MaxLength]		
		public string Link { get; set; }
	}
}

