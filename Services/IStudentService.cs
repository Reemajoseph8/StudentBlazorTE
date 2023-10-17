using StudentBlazorTE.Models;

namespace StudentBlazorTE.Services
{
    public interface IStudentService
    {
        bool AddUpdate(Student student);
        bool Delete(int id);
        Student FindById(int id);
        List<Student> GetAll();
    }
}
