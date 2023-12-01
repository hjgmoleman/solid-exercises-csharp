using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Services;

public interface IStudentFactory
{
    Student CreateStudent(string emailAddress, University university);
}