using System.ComponentModel.DataAnnotations;

namespace TaskForceHM_WEBAPI.Models
{
    public class Message
    {
        [Key]
        public int ID { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
    }
}
