namespace WPF.SQLite.EF.PerfectSmile
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PatientHistory")]
    public class PatientHistory
    {
        public int Id { get; set; }

        public int PatientId { get; set; }

        [StringLength(8000)]
        public string TreatmentDone { get; set; }

        //[Column(TypeName = "money")]
        public decimal PaymentDone { get; set; }

        //[Column(TypeName = "money")]
        public decimal Balance { get; set; }

        //[Column(TypeName = "date")]
        public DateTime? NextAppointment { get; set; }

        [StringLength(8000)]
        public string AdditionalComment { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        //[Column(TypeName = "date")]
        public DateTime? CreatedAt { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
