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
    
    public partial class Attendance
    {
        public int RecordId { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public System.DateTime Date { get; set; }
        public string Attendance1 { get; set; }
        public string Batch { get; set; }
        public string Semester { get; set; }
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
    
        public virtual Cdetail Cdetail { get; set; }
        public virtual StudentRegistry StudentRegistry { get; set; }
    }
}
