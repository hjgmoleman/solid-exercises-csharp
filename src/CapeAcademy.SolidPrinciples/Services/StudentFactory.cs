using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Services;

public class StudentFactory
{
    public Student CreateStudent(string emailAddress, University university)
    {
        return new Student(emailAddress, university.Id, university.UniversityPackage);
    }
}