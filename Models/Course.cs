using Microsoft.CodeAnalysis.Options;
using System.ComponentModel.DataAnnotations;

namespace DemoVrijdag.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        /// <summary>
        /// Currency in type decimal. Decoreren met Currency attribuut
        /// </summary>
        [DataType(DataType.Currency)] 
        public decimal? Price { get; set; }


        public virtual ICollection<Student>? Students { get; set; }
    }
}
