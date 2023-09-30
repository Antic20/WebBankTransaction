using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebBankTransaction.Models
{
    public class Transaction
    {
        internal DateTime Date;

        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName="nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage ="This field is rquired.")]
        [MaxLength(12, ErrorMessage="Maximum 12 Characters only.")]
        public string AccountNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Beneficiary Name")]
        [Required(ErrorMessage = "This field is rquired.")]

        public string BeneficiaryName { get; set; }
       
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is rquired.")]

        public string BankName { get; set; }
        
        [Column(TypeName = "nvarchar(11)")]
        [DisplayName("SWIFT Code")]
        [Required(ErrorMessage = "This field is rquired.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 Characters only.")]

        public string SWIFTCode { get; set; }

        [Required(ErrorMessage = "This field is rquired.")]
        public int Amount { get; set; }

        public DateTime Data  { get; set; }

    }
}
