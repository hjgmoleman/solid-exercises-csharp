using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Repositories;

public interface IStudentWriteRepository
{
    void Add(Student student);
}