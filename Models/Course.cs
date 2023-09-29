using Microsoft.CodeAnalysis.Options;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace DemoVrijdag.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        /// <summary>
        /// Method to calculate the number of students
        /// </summary>
        [NotMapped, DisplayName("Number of students")]
        public int NumberOfStudents { 
            get { return Students != null ? Students.Count : 0 ; }
        }

        /// <summary>
        /// Currency in type decimal. Decoreren met Currency attribuut
        /// </summary>
        [DataType(DataType.Currency)] 
        public decimal? Price { get; set; }


        public virtual ICollection<Student>? Students { get; set; }
    }
}
