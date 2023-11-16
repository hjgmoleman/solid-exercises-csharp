using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Services;

public interface IStudentService
{
    bool Add(string? emailAddress, Guid universityId);
    List<Student> GetStudentsByUniversity(Guid universityId);
    Student? GetStudentByEmailAddress(string emailAddress);
}