using CapeAcademy.SolidPrinciples.Entities;
using CapeAcademy.SolidPrinciples.Repositories;

namespace CapeAcademy.SolidPrinciples.Services;

public class StudentService
{
    public bool Add(string? emailAddress, Guid universityId)
    {       
        Console.WriteLine("Log: Start add student with email '{0}'", emailAddress);

        if ("".Equals(emailAddress) || emailAddress == null)
        {
            return false;
        }
 
        var studentRepository = new StudentRepository();
        if (studentRepository.Exists(emailAddress))
        {
            return false;
        }
 
        var universityRepository = new UniversityRepository();
        var university = universityRepository.GetById(universityId);
 
        var student = new Student(emailAddress, universityId);
         
        if (university.UniversityPackage == UniversityPackage.Standard)
        {
            student.MonthlyEbookAllowance = 10;
        }
        else if (university.UniversityPackage == UniversityPackage.Premium)
        {
            student.MonthlyEbookAllowance = 10 * 2;
        }                           
         
        studentRepository.Add(student);
 
        Console.WriteLine("Log: End add student with email '{0}'", emailAddress);
 
        return true;
    }
     
    public List<Student> GetStudentsByUniversity(Guid universityId)
    {
        return new();
    }
 
    public Student? GetStudentByEmailAddress(string emailAddress)
    {
        return default;
    }
}