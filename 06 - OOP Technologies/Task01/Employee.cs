using System;
using Task1;

namespace Task01
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-22 12:22:57</DateOfCreation>
    /// <summary>
    /// Describes an employee. Work experience is calculated automatically.
    /// </summary>
    public class Employee : User
    {
        private int workExperience;
        private DateTime dateOfHire;
        // Cвойства с точки зрения использования класса в будущем:
        // public double Wages{get; set;} - зарплата
        // public string DateOfRetirement{get; set;} -дата выхода на пенсию
        // public string DateOfDismissal{get; set;} - дата увольнения
        // public string DateOfPromotion{get; set;} - дата повышения в должности
        // public string Department{get; set;} - отдел
        // public string NumberOfSubordinates{get; set;} -число подчиненных

        public Employee() : base()
        {
            Position = PropertiesSetter.SetPosition();
            DateOfHire = PropertiesSetter.SetHiringDate();
        }
        public string Position { get; set; }

        public DateTime DateOfHire
        {
            get
            {
                return dateOfHire;
            }
            set
            {
                dateOfHire = PropertiesSetter.GetHiringDate(value, DateOfBirth);
            }
        }

        public int WorkExperience
        {
            get
            {
                workExperience = PropertiesSetter.GetWorkExperience(DateOfHire);
                return workExperience;
            }
        }
    }
}
