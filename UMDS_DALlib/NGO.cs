//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMDS_DALlib
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class NGO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGO()
        {
            this.Requests = new HashSet<Request>();
            this.FinalRequests = new HashSet<FinalRequest>();
        }
    
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Enter only alphabets")]
        public string Name { get; set; }
        [Required]
        [RegularExpression("[0-9]{10,10}", ErrorMessage = "Invalid mobile number")]
        [StringLength(10, MinimumLength = 10)]
        public string Mobile { get; set; }
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Enter only alphabets")]
        [StringLength(50, MinimumLength = 3)]
        public string City { get; set; }
        [Required]
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$", ErrorMessage = "Enter only alphabets")]
        [StringLength(50, MinimumLength = 2)]
        public string State { get; set; }
        [Required]
        [RegularExpression("[0-9]{6,6}", ErrorMessage = "Invalid Pin")]
        [StringLength(6, MinimumLength = 6)]
        public string Pin { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [EmailAddress(ErrorMessage = "Invalid email")]
        public string Email { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Password { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Request> Requests { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinalRequest> FinalRequests { get; set; }
    }
}