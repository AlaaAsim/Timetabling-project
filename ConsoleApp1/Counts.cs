using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.TimetableDBDataSetTableAdapters;

namespace ConsoleApp1
{
    class Counts
    {

        // Global instance
        private static Counts _instance = new Counts();

        // Parsed Instructors
        private Dictionary<int, Instructor> _Instructors = new Dictionary<int, Instructor>();

        // Parsed student groups
        private Dictionary<int, Curriculum> _curriculum = new Dictionary<int, Curriculum>();

        // Parsed courses
        private Dictionary<int, Course> _courses = new Dictionary<int, Course>();

        // Parsed rooms
        private Dictionary<int, Room> _rooms = new Dictionary<int, Room>();

        // Parsed classes
        private LinkedList<CourseClass> _courseClasses = new LinkedList<CourseClass>();
        // Returns reference to global instance

        TimetableDBDataSet timetableDBDS = new TimetableDBDataSet();
        InstructorsTableAdapter ins = new InstructorsTableAdapter();
        CurriculumTableAdapter cur = new CurriculumTableAdapter();
        RoomsTableAdapter room = new RoomsTableAdapter();
        CourseClassTableAdapter cc = new CourseClassTableAdapter();
        CoursesTableAdapter courses = new CoursesTableAdapter();
        CurriculumDevisionsTableAdapter cd = new CurriculumDevisionsTableAdapter();
        ITTableAdapter it = new ITTableAdapter();
        MathCSTableAdapter mc = new MathCSTableAdapter();
        STATTableAdapter s = new STATTableAdapter();
        MathTableAdapter m = new MathTableAdapter();
        STATCSTableAdapter sc = new STATCSTableAdapter();
        CSTableAdapter cs = new CSTableAdapter();


        public static Counts GetInstance()
        {
            return _instance;
        }


        public int InsertInstructor(string InstructorName)
        {
            int val;
            return val=ins.InsertInstructor(InstructorName);
        }
        public void InsertCourse(string name, int ns, int duration, bool lab, String Instructor,String Course)
        {
            DataTable s=ins.GetId(Instructor);
            int instructorId = Int32.Parse(s.ToString());
            DataTable x = courses.GetId(Instructor);
            int cid = Int32.Parse(x.ToString());
            cc.InsertQuery(name,ns,duration,lab,instructorId,cid);
        }
        public DataTable comboDivision()
        {
            DataTable dt = cd.GetData();
            return dt;
        }
       // public int insertdivisionsize(string division, int year, int size)
        //{
          //  int val;
           //  switch (division.ToLower())

            //    {
             //       case "cs":
              //          { val = cs.Insert(year, size); }
               //         break;
               //     case "math":
                //        { val = m.Insert(year, size); }
                //        break;
                 //   case "mathcs":
                 //       { val = mc.Insert(year, size); }
                 //       break;
                 //   case "it":
                  //      { val = it.Insert(year, size); }
                 //       break;
                 //   case "stat":
                 //       { val = s.Insert(year, size); }
                 //       break;
                //    case "statcs":
                //        { val = sc.Insert(year, size); }
                //        break;
               // }
               
                 
           // return val;
       // }   
      
     
        public DataTable ComboInstructorName()
        {
            DataTable dt =ins.GetDataName();
            return dt;
        }
        public DataTable ComboCourseName()
        {
            //string Query = "Select CourseName from CourseTable where ScheduleRow is null and ScheduleColumn is null";
            //SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
            DataTable dt = cc.GetCoursesNames();
            return dt;
        }
        //public DataTable comboDivision()
        //{
         //   DataTable dt = cc.GetCoursesNames();
         //   return dt;
       // }

        public  DataTable InstructorName(string CourseName)
        {
            DataTable dt = cc.GetClassInstructorName(CourseName);
            return dt;
        }
        //public static DataTable CourseTable()
        //{
        //    string Query = "Select CourseName,InstructorName,ScheduleRow,ScheduleColumn from CourseTable";
        //    SqlCommand sc = new SqlCommand(Query, ConnectionString.GetConnection());
        //    DataTable dt = new DataTable();
        //    SqlDataAdapter sds = new SqlDataAdapter(sc);
        //    sds.Fill(dt);
        //    return dt;
        //}
    


        // Initialize data
        public Counts()
        {
        }

        // Frees used resources




        //Returns pointer to Instructor with specified ID
       // If there is no Instructor with such ID method returns NULL
        public string GetInstructorNameById(int id)
        {
            DataTable name=  ins.GetDataById(id);
            return name.ToString();
        }

        // Returns number of parsed Instructor

        public int GetNumberOfInstructor()
        {
           
            return (int) ins.Count();
        }

        // Returns pointer to student group with specified ID
        // If there is no student group with such ID method returns NULL
        public void GetCurriculumById(int id)
        {
            
        }

        // Returns number of parsed student groups
        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: inline int GetNumberOfStudentGroups() const
        public int GetNumberOfCurriculums()
        {

            return (int)cur.Count();
        }

        // Returns pointer to course with specified ID
        // If there is no course with such ID method returns NULL
        //public Course GetCourseById(int id)
        //{
        //    Dictionary<int, Course*>.iterator it = _courses.find(id);
        //    return it != _courses.end() ? it.second : null;
        //}

        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: inline int GetNumberOfCourses() const
        public int GetNumberOfCourses()
        {
            return (int) cc.Count();
        }

        // Returns pointer to room with specified ID
        // If there is no room with such ID method returns NULL
        //public Room GetRoomById(int id)
        //{
        //    Dictionary<int, Room*>.iterator it = _rooms.find(id);
        //    return it != _rooms.end() ? it.second : null;
        //}

        // Returns number of parsed rooms
        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: inline int GetNumberOfRooms() const
        public int GetNumberOfRooms() { 
            return (int) room.Count();
        }

        // Returns reference to list of parsed classes
        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: inline const ClassicLinkedList<CourseClass*>& GetCourseClasses() const
        public LinkedList<CourseClass> GetCourseClasses()
        {
            return _courseClasses;
        }

        // Returns number of parsed classes
        //C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
        //ORIGINAL LINE: inline int GetNumberOfCourseClasses() const
        public int GetNumberOfCourseClasses()
        {
            return (int)_courseClasses.Count();
        }




        // Removes blank characters from beginning and end of string
    //    private string TrimString(string str)
    //    {
    //        CharEnumerator it = new CharEnumerator();
    //        for (it = str.GetEnumerator(); it.MoveNext() && char.IsWhiteSpace(it.Current);)
    //        {
    //            ;
    //        }
    //        str = str.Remove(str.GetEnumerator(), it);
    //        //string.reverse_iterator; rit= new string.reverse_iterator();

    //        IEnumerable<int> rit = str;
    //        foreach (var x in enumerableThing.Reverse())
    //            for (rit.Reverse(); rit != str.rend() && char.IsWhiteSpace(*rit); rit++)
    //            {
    //                ;
    //            }
    //        str = str.Remove(str.GetEnumerator() + (str.rend() - rit), str.end());

    //        return str;
    //    }

    }
}
