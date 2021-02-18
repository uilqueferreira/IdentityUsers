using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ForumTest3.Areas.Identity.Data
{
    public class Topic
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //[ForeignKey("User")]
        public string Creator { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;

        public ApplicationUsers User { get; set; }

    }
}
