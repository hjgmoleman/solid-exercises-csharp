namespace CapeAcademy.SolidPrinciples.Services;

public interface IStudentPersistService
{
    bool Add(string? emailAddress, Guid universityId);
}