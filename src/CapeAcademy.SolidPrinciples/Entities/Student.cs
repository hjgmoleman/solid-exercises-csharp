namespace CapeAcademy.SolidPrinciples.Entities;

public class Student
{
    private const int StandardAllowance = 10;
    
    public Student(string emailAddress, Guid universityId)
    {
        EmailAddress = emailAddress;
        UniversityId = universityId;
    }
    
    public string EmailAddress { get; private set; }
    public Guid UniversityId { get; private set; }
    public int MonthlyEbookAllowance { get; set; } = 0;
    public int CurrentlyBorrowedEbooks { get; private set; } = 0;
    
    public void AddBonusAllowance(UniversityPackage package)
    {
        if (package == UniversityPackage.Standard)
        {
            MonthlyEbookAllowance += 5;
        }
        else if (package == UniversityPackage.Premium)
        {
            MonthlyEbookAllowance += 10;
        }
    }
}