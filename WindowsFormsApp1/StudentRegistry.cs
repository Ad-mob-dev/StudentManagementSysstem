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
    
    public partial class StudentRegistry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentRegistry()
        {
            this.Attendances = new HashSet<Attendance>();
        }
    
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Semester { get; set; }
        public string Email { get; set; }
        public Nullable<int> ContactNo { get; set; }
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Gpa Gpa { get; set; }
        public virtual TotalCourseMark TotalCourseMark { get; set; }
    }
}