namespace CapeAcademy.SolidPrinciples.Entities;

public class UnlimitedStudent : Student
{
    public UnlimitedStudent(string emailAddress, Guid universityId)
        : base(emailAddress, universityId)
    {
        MonthlyEbookAllowance = 0;
    }
    
    public override void AddBonusAllowance()
    {
        throw new InvalidOperationException("A bonus on the monthly allowance is not applicable to an unlimited student.");
    }
}