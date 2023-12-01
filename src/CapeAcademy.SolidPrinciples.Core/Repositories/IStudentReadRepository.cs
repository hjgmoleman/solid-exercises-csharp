namespace CapeAcademy.SolidPrinciples.Repositories;

public interface IStudentReadRepository
{
    bool Exists(string emailAddress);
}