using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Repositories;

public interface IUniversityRepository
{
    University GetById(Guid universityId);
}