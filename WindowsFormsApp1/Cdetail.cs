//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cdetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cdetail()
        {
            this.Attendances = new HashSet<Attendance>();
            this.makeupSchedules = new HashSet<makeupSchedule>();
        }
    
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public int CreditHours { get; set; }
        public string TimeTable { get; set; }
        public string Batch { get; set; }
        public string Semester { get; set; }
        public int Amount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<makeupSchedule> makeupSchedules { get; set; }
    }
}
