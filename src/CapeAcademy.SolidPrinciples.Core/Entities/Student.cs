namespace CapeAcademy.SolidPrinciples.Entities;

public abstract class Student
{
    protected const int StandardAllowance = 10;
    
    protected Student(string emailAddress, Guid universityId)
    {
        EmailAddress = emailAddress;
        UniversityId = universityId;
    }
    
    public string EmailAddress { get; private set; }
    public Guid UniversityId { get; private set; }
    
    public int CurrentlyBorrowedEbooks { get; private set; } = 0;
}