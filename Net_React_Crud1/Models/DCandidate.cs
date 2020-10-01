using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Net_React_Crud1.Models
{
    public class DCandidate
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string fullName { get; set; }

       
        public string email { get; set; }
         
        public int age { get; set; }

        
        public string bloodGroup { get; set; }

        public string address { get; set; }
    }
}
