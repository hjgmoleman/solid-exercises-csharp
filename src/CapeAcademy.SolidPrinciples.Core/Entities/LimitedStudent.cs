namespace CapeAcademy.SolidPrinciples.Entities;

public abstract class LimitedStudent : Student, IBonusAllowable
{
    protected LimitedStudent(string emailAddress, Guid universityId)
        : base(emailAddress, universityId)
    {
    }
    
    public int MonthlyEbookAllowance { get; protected set; }
    
    public abstract void AddBonusAllowance();
}