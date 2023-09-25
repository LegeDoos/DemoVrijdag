using System.ComponentModel.DataAnnotations;

namespace DemoVrijdag.Models
{
    public class CourseUpdateViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        /// <summary>
        /// Currency in type decimal. Decoreren met Currency attribuut
        /// </summary>
        [DataType(DataType.Currency)]
        public string? Price { get; set; }
    }
}
