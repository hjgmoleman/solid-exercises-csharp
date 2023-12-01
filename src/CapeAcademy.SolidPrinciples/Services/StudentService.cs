using CapeAcademy.SolidPrinciples.Entities;
using CapeAcademy.SolidPrinciples.Repositories;

namespace CapeAcademy.SolidPrinciples.Services;

public class StudentService : IStudentQueryService, IStudentPersistService, IStudentAllowanceService
{
    public bool Add(string? emailAddress, Guid universityId)
    {
        var logger = new Logger();
        logger.LogMessage("Log: Start add student with email '{0}'", emailAddress);

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

        var studentFactory = new StudentFactory();
        var student = studentFactory.CreateStudent(emailAddress, university);
         
        studentRepository.Add(student);
 
        logger.LogMessage("Log: End add student with email '{0}'", emailAddress);
 
        return true;
    }
    
    public void AddBonusAllowances(University university)
    {
        var students = GetStudentsByUniversity(university.Id);
        foreach (var student in students)
        {
            if (student is LimitedStudent limitedStudent)
            {
                limitedStudent.AddBonusAllowance();
            }
        }
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