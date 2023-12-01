namespace CapeAcademy.SolidPrinciples.Entities;

public class StandardStudent : LimitedStudent
{
    public StandardStudent(string emailAddress, Guid universityId)
        : base(emailAddress, universityId)
    {
        MonthlyEbookAllowance = StandardAllowance;
    }

    public override void AddBonusAllowance()
    {
        MonthlyEbookAllowance += 5;
    }
}