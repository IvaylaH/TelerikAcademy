using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Problems_1To3
{
    public class Student : ICloneable, IComparable<Student>
    {
        // fields
        private string firstName;
        private string middleName;
        private string lastName;
        private string sSN;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private int course;
        private Specialties specialty;
        private Faculties faculty;
        private Universities university;

        // constructors
        public Student(string fName, string mName, string lName, string currentStSSN, string stAddress, string phoneNum, string stEmail, int inputCourse, Specialties specialtyName, Faculties facultyName, Universities universityName)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = currentStSSN;
            this.PermanentAddress = stAddress;
            this.MobilePhone = phoneNum;
            this.Email = stEmail;
            this.Course = inputCourse;
            this.specialty = specialtyName; // do I need to validate the input data for fields
            this.faculty = facultyName;
            this.university = universityName;
        }

        #region Properties
        public string FirstName
        {
            get { return this.firstName; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the student cannot be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the student cannot be null or empty!");
                }

                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the student cannot be null or empty!");
                }

                this.lastName = value;
            }
        }

        public string SSN
        {
            get { return this.sSN; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The social security number of our student cannot be null or empty!");
                }

                if (value.Length < 9)
                {
                    throw new ArgumentException("The social security number of the student must have 9 digits");
                }

                this.sSN = value;
            }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the student cannot be null or empty!");
                }

                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the student cannot be null or empty!");
                }

                if (value.Length < 10)
                {
                    throw new ArgumentException("The mobile phone of the student must consist 10 digits!");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the student cannot be null or empty!");
                }

                this.email = value;
            }
        }

        public int Course
        {
            get { return this.course; }  // wondering if it should have a setter
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The course of the student cannot be a negative number!");
                }

                this.course = value;
            }
        }

        // the properties for specialty, faculty and university have only getters so they can be accessed from outside the class Student, but have no setters, the fields are initialized in the constructor
        public Specialties Specialty
        {
            get { return this.specialty; }
        }

        public Faculties Faculty
        {
            get { return this.faculty; }
        }

        public Universities University
        {
            get { return this.university; }
        }
        #endregion

        #region Methods

        // Problem 3
        public int CompareTo(Student other)
        {

            if (this.FirstName != other.FirstName)
            {
                return (this.FirstName.CompareTo(other.FirstName));
            }

            if (this.MiddleName != other.MiddleName)
            {
                return (this.MiddleName.CompareTo(other.MiddleName));
            }

            if (this.LastName != other.LastName)
            {
                return (string.Compare(this.LastName, other.LastName));
            }

            if (this.SSN != other.SSN)
            {
                return (string.Compare(this.SSN, other.SSN));
            }

            return 0;
        }

        // Problem 2
       /* public object Clone() 
        // performs shallow cloning of the object; in this case it would still work properly because we have only value type variables
        {
            var newStudent = this.MemberwiseClone() as Student;

            return newStudent;
        }*/

        // performs deep cloning of the object
        public Student Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhone, this.Email, this.Course, this.Specialty, this.Faculty, this.University);
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Cannot compare an instance of the class Student and null!");
            }

            if (!(obj is Student))
            {
                return false;
            }

            Student currentStudent = obj as Student;

            // 2 students are equal if they have the same name and social security number
            if (this.FirstName == currentStudent.FirstName && this.MiddleName == currentStudent.MiddleName && this.LastName == currentStudent.LastName && this.SSN == currentStudent.SSN)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student firstSt, Student secondSt)
        {
            return firstSt.Equals(secondSt);
        }

        public static bool operator !=(Student firstSt, Student secondSt)
        {
            return !(firstSt.Equals(secondSt));
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("Student's Info: ");
            result.AppendLine(string.Format("Full name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            result.AppendLine(string.Format("Social security number: {0}", this.SSN));
            result.AppendLine(string.Format("Permanent address: {0}", this.PermanentAddress));
            result.AppendLine(string.Format("Mobile phone number: {0}", this.MobilePhone));
            result.AppendLine(string.Format("E-mail: {0}", this.Email));
            result.AppendLine(string.Format("Course: {0}", this.Course));
            result.AppendLine(string.Format("Specialty: {0}", this.Specialty));
            result.AppendLine(string.Format("Faculty: {0}", this.Faculty));
            result.AppendLine(string.Format("University: {0}", this.University));

            return result.ToString();
        }
        #endregion
    }
}
