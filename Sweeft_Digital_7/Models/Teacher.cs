using System;
using System.Collections.Generic;

#nullable disable

namespace Sweeft_Digital_7.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeacherPupils = new HashSet<TeacherPupil>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int GenderId { get; set; }
        public string Subject { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual ICollection<TeacherPupil> TeacherPupils { get; set; }
    }
}
