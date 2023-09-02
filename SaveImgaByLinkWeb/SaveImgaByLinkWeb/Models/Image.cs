using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaveImgaByLinkWeb.Models
{
    public class Image
    {
        [Key]
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Desciption { get; set; }
        [ForeignKey("FK_USER_123")]
        public string Owner { get; set; }
    }

}