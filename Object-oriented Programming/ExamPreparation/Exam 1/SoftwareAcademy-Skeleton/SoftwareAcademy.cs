using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public class Teacher : ITeacher
    {
        // fields
        private string name;
        private IList<ICourse> courses;

        // constructors
        public Teacher(string inputName)
        {
            this.Name = inputName;
            this.courses = new List<ICourse>();
        }

        // properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the teacher cannot be null!");
                }

                this.name = value;
            }
        }

        public IList<ICourse> Courses // can I leave it IEnumerable<ICourse> here
        {
            get { return new List<ICourse>(this.courses); }
        }

        // methods
        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder teachersInfo = new StringBuilder();

            teachersInfo.Append(string.Format("Teacher: Name={0}", this.Name)); // Append or AppendLine

            if (this.courses.Count != 0)
            {
                string coursesToStr = string.Join(", ", this.courses.Select(c => c.Name));
                teachersInfo.Append(string.Format("; Courses=[{0}]", coursesToStr));
            }

            return teachersInfo.ToString();
        }
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public abstract class Course : ICourse
    {
        // fields
        private string name;
        private ITeacher teacher;
        private IList<string> topics;

        // constructors
        protected Course(string coursesName, ITeacher inputTeacher = null)
        {
            this.Name = coursesName;
            this.Teacher = inputTeacher;
            this.topics = new List<string>();
        }

        // properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name of the course cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get { return this.teacher; }
            set
            {
                this.teacher = value;
            }
        }

        public IList<string> Topics
        {
            get { return new List<string>(this.topics); }
        }

        // methods
        public void AddTopic(string topic)
        {
            if (string.IsNullOrEmpty(topic))
            {
                throw new ArgumentNullException("The topic cannot be null or empty!");
            }

            this.topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder coursesInfo = new StringBuilder();

            coursesInfo.Append(string.Format("Name={0}", this.Name));
            if (this.Teacher != null)
            {
                coursesInfo.Append(string.Format("; Teacher={0}", this.Teacher.Name));
            }
            if (this.topics.Count != 0)
            {
                string topicsToStr = string.Join(", ", this.topics);
                coursesInfo.Append(string.Format("; Topics=[{0}]", topicsToStr));
            }

            return coursesInfo.ToString();
        }
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public class LocalCourse : Course, ILocalCourse
    {
        // fields
        private string lab;

        // constructors
        public LocalCourse(string coursesName, string coursesLab)
            : base(coursesName)
        {
            this.Lab = coursesLab;
        }

        public LocalCourse(string coursesName, ITeacher coursesTeacher, string coursesLab)
            : base(coursesName, coursesTeacher)
        {
            this.Lab = coursesLab;
        }

        // properties
        public string Lab
        {
            get { return this.lab; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The value we set for the lab cannot be null or empty!");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder coursesInfo = new StringBuilder();

            coursesInfo.Append(string.Format("{0}: ", this.GetType().Name)); // or just Local
            coursesInfo.Append(base.ToString());
            coursesInfo.AppendLine(string.Format("; Lab={0}", this.Lab));

            return coursesInfo.ToString();
        }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        // fields
        private string town;

        // constructors
        public OffsiteCourse(string coursesName, string coursesTown)
            : base(coursesName)
        {
            this.Town = coursesTown;
        }

        public OffsiteCourse(string coursesName, ITeacher coursesTeacher, string coursesTown)
            : base(coursesName, coursesTeacher)
        {
            this.Town = coursesTown;
        }

        // properties
        public string Town
        {
            get { return this.town; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The value we set for town cannot be null or empty!");
                }

                this.town = value;
            }
        }

        // methods
        public override string ToString()
        {
            StringBuilder coursesInfo = new StringBuilder();

            coursesInfo.Append(string.Format("{0}: ", this.GetType().Name));
            coursesInfo.Append(base.ToString());
            coursesInfo.AppendLine(string.Format("; Town={0}", this.Town));

            return coursesInfo.ToString();
        }
    }
    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            return new LocalCourse(name, teacher, lab);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            return new OffsiteCourse(name, teacher, town);
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
