using CapeAcademy.SolidPrinciples.Entities;

namespace CapeAcademy.SolidPrinciples.Repositories;

public interface IUniversityReadRepository
{
    University GetById(Guid universityId);
}