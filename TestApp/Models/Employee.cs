using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class Employee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.Browsable(false)]
        public int Id { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "Имя максимум 25 символов")]
        public string Name { get; set; }

        [Required]
        [MaxLength(25, ErrorMessage = "Фамилия максимум 25 символов")]
        public string Surname { get; set; }

        [Required]
        public string Position { get; set; }

        [Range(1940, 2023, ErrorMessage = "Год рождения должен быть в диапазоне 1940-2023")]
        public int YearOfBirth { get; set; }

        [Range(0, 1000000, ErrorMessage = "Зарплата должна быть от 0 до 1000000")]
        public int Salary { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name, string surname, string position, int yearOfBirth, int salary)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Position = position;
            YearOfBirth = yearOfBirth;
            Salary = salary;
        }
    }
}
