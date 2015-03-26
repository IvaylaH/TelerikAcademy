using System;
using System.Collections.Generic;
using System.Text;

namespace Problem1
{
    public class Teacher : Person
    {
        // fields
        private ICollection<Discipline> setOfDisciplines; // using ICollection<T> we ensure higher level of abstraction

        // constructors
        public Teacher(string teachersName)
            : base(teachersName)
        {
            this.setOfDisciplines = new List<Discipline>();
        }

        // properties
        public ICollection<Discipline> SetOfDisciplines
        {
            get { return new List<Discipline>(this.setOfDisciplines); }
        }

        public Discipline Discipline
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        // methods

        // adds new element of type Discipline to the set of disciplines for each teacher
        public void AddDiscipline(Discipline discipline)
        {
            this.setOfDisciplines.Add(discipline);
        }

        public override string ToString()
        {
            StringBuilder teacherSb = new StringBuilder();

            teacherSb.AppendFormat("Teacher's name: {0}; ", this.Name);
            teacherSb.Append(Environment.NewLine);
            teacherSb.Append("Disciplines: ");

            foreach (var item in this.setOfDisciplines)
	        {
                teacherSb.AppendFormat("{0} ", item);
	        }
            teacherSb.Append(Environment.NewLine);
            
            return  teacherSb.ToString();
        }
    }
}
