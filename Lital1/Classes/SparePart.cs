using System.ComponentModel.DataAnnotations;

namespace Lital1.Classes
{
    public class SparePart
    {
        [Key]                     // ← להוסיף את זה
        public int Id { get; set; }
        public string PartCode { get; set; }
        public string PartName { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
