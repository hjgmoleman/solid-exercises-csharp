namespace CapeAcademy.SolidPrinciples.Entities;

public class PremiumStudent : Student
{
    public PremiumStudent(string emailAddress, Guid universityId)
        : base(emailAddress, universityId)
    {
        MonthlyEbookAllowance = StandardAllowance * 2;
    }
    
    public override void AddBonusAllowance()
    {
        MonthlyEbookAllowance += 10;
    }
}