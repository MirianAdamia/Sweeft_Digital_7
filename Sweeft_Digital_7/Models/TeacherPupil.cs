using System;
using System.Collections.Generic;

#nullable disable

namespace Sweeft_Digital_7.Models
{
    public partial class TeacherPupil
    {
        public int TeacherId { get; set; }
        public int PupilId { get; set; }

        public virtual Pupil Pupil { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
