using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGameStore.Models
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilPictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }
    }
}