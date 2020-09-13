namespace Mini_Udemy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            Courses = new HashSet<Course>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int St_Id { get; set; }

        [StringLength(50)]
        public string St_Fname { get; set; }

        [StringLength(50)]
        public string St_Lname { get; set; }

        [StringLength(1)]
        public string St_gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? St_BD { get; set; }

        public int? St_Age { get; set; }

        [StringLength(50)]
        public string St_Email { get; set; }

        [StringLength(50)]
        public string St_Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}
