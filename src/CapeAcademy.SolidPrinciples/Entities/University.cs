namespace CapeAcademy.SolidPrinciples.Entities;

public class University
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Name { get; private set; } = string.Empty;

    public UniversityPackage UniversityPackage { get; private set; } = UniversityPackage.Standard;
}