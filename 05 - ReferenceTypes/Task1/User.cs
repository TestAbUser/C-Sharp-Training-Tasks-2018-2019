using System;

namespace Task1
{
    /// <Author>Rashid Isayev</Author>
    /// <DateOfCreation>2019-04-09 18:14:04</DateOfCreation>
    /// <summary>
    /// Describes a user. Age is calculated automatically.
    /// </summary>
    public class User
    {
        private DateTime birthDate;

        public User()
        {
            FirstName = PropertiesSetter.SetFirstName();
            SecondName = PropertiesSetter.SetSecondName();
            Surname = PropertiesSetter.SetSurname();
            DateOfBirth = PropertiesSetter.SetBirthDate();
        }


        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth
        {
            get { return birthDate; }

            set
            {
                birthDate = PropertiesSetter.GetBirthDate(value);
            }

        }

        public int Age
        {
            get
            {
                return AgeCalculator.CalculateAge(DateOfBirth);
            }
        }
    }
}
