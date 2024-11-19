using AB205AcademyManagementEFProject.Models;

namespace AB205AcademyManagementEFProject.Services.Abstractions;

public interface IStudentService
{
    void CreateStudent(Student student);
    Student GetStudentById(int id);
    List<Student> GetStudentsByName(string name);
    List<Student> GetAllStudents();
    List<Student> GetAllActiveStudents(); //=> IsDeleted false olan tələbələri gətirir.
    List<Student> GetStudensByEnrollmentDate(int days); //=> son neçə gündə qeydiyyatdan keçən tələbələri gətirir.
    void UpdateStudent(int id, Student student);
    void SoftDeleteStudent(int id); //=> IsDeleted true olur.
    void HardDeleteStudent(int id); // Database-dən silir.

}
