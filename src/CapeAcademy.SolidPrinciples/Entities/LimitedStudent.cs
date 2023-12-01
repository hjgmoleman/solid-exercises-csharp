namespace CapeAcademy.SolidPrinciples.Entities;

public abstract class LimitedStudent : Student
{
    protected LimitedStudent(string emailAddress, Guid universityId)
        : base(emailAddress, universityId)
    {
    }
    
    public abstract void AddBonusAllowance();
}