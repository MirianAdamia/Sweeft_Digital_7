using System;
using System.Collections.Generic;

#nullable disable

namespace Sweeft_Digital_7.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Pupils = new HashSet<Pupil>();
            Teachers = new HashSet<Teacher>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Pupil> Pupils { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}
