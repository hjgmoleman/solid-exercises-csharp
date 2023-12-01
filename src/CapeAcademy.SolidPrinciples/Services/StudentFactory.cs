using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Services;

public class StudentFactory
{
    public Student CreateStudent(string emailAddress, University university)
    {
        var package = university.UniversityPackage;
        if (package == UniversityPackage.Premium)
        {
            return new PremiumStudent(emailAddress, university.Id);
        }

        if (package == UniversityPackage.Unlimited)
        {
            return new UnlimitedStudent(emailAddress, university.Id);
        }

        return new StandardStudent(emailAddress, university.Id);
    }
}