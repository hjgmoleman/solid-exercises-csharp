using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Repositories;

public class StudentRepository : IStudentReadRepository, IStudentWriteRepository
{
    public void Add(Student student)
    {
    }

    public bool Exists(string emailAddress)
    {
        return false;
    }
}