//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTimKiemSv
{
    using System;
    using System.Collections.Generic;
    
    public partial class KQUA
    {
        public int MASV { get; set; }
        public int MAHP { get; set; }
        public Nullable<double> DIEM { get; set; }
    
        public virtual HPHAN HPHAN { get; set; }
        public virtual SVIEN SVIEN { get; set; }
    }
}
