using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Services;

public interface IStudentQueryService
{
    List<Student> GetStudentsByUniversity(Guid universityId);
    Student? GetStudentByEmailAddress(string emailAddress);
}