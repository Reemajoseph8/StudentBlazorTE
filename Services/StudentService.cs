using StudentBlazorTE.Models;

namespace StudentBlazorTE.Services
{
    public class StudentService : IStudentService
    {
        private readonly DatabaseContext _ctx;
        public StudentService(DatabaseContext ctx)
        {
            _ctx = ctx;
        }
        public bool AddUpdate(Student student)
        {
            try
            {
                if(student.Id == 0)
                   _ctx.Student.Add(student);
                else
                   _ctx.Student.Update(student);
                _ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false; 
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var student = FindById(id);
                if (student == null)
                    return false;
                _ctx.Student.Remove(student);
                _ctx.SaveChanges() ;
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public Student FindById(int id)
        {
            return _ctx.Student.Find(id);
        }

        public List<Student> GetAll()
        {
            return _ctx.Student.ToList();
        }
    }
}
