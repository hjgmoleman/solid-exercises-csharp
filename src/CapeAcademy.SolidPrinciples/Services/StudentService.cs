using CapeAcademy.SolidPrinciples.Entities;
using CapeAcademy.SolidPrinciples.Repositories;

namespace CapeAcademy.SolidPrinciples.Services;

public class StudentService : IStudentQueryService, IStudentPersistService, IStudentAllowanceService
{
    private readonly IStudentRepository _studentRepository;
    private readonly IUniversityReadRepository _universityRepository;
    private readonly IStudentFactory _studentFactory;
    private readonly ILogger _logger;

    public StudentService(
        IStudentRepository studentRepository,
        IUniversityReadRepository universityRepository,
        IStudentFactory studentFactory, 
        ILogger logger)
    {
        _studentRepository = studentRepository;
        _universityRepository = universityRepository;
        _studentFactory = studentFactory;
        _logger = logger;
    }
    
    public bool Add(string? emailAddress, Guid universityId)
    {
        _logger.LogMessage("Log: Start add student with email '{0}'", emailAddress);

        if ("".Equals(emailAddress) || emailAddress == null)
        {
            return false;
        }
        
        if (_studentRepository.Exists(emailAddress))
        {
            return false;
        }
        
        var university = _universityRepository.GetById(universityId);
        var student = _studentFactory.CreateStudent(emailAddress, university);
         
        _studentRepository.Add(student);
 
        _logger.LogMessage("Log: End add student with email '{0}'", emailAddress);
 
        return true;
    }
    
    public void AddBonusAllowances(University university)
    {
        var students = GetStudentsByUniversity(university.Id);
        foreach (var student in students)
        {
            if (student is IBonusAllowable bonusAllowable)
            {
                bonusAllowable.AddBonusAllowance();
            }
        }
    }
   
    public List<Student> GetStudentsByUniversity(Guid universityId)
    {
        return new();
    }
 
    public Student? GetStudentByEmailAddress(string emailAddress)
    {
        return default;
    }
}