using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Titile { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Icon { get; set; }
        
        [Column(TypeName = "nvarchar(50)")]
        public string Type { get; set; }
    }
}
