namespace CapeAcademy.SolidPrinciples.Entities;

public class Student(string emailAddress, Guid universityId)
{
    public string EmailAddress { get; private set; } = emailAddress;
    public Guid UniversityId { get; private set; } = universityId;
    public int MonthlyEbookAllowance { get; set; } = 0;
    public int CurrentlyBorrowedEbooks { get; private set; } = 0;
}