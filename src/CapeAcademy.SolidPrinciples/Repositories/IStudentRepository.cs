using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Repositories;

public interface IStudentRepository
{
    void Add(Student student);
    bool Exists(string emailAddress);
}