using DogWalker.Models;
using System.Collections.Generic;

namespace DogWalker.Repositories
{
    public interface IWalkRepository
    {
        List<Walk> GetAllWalks();
        List<Walk> GetWalksByWalkerId(int id);
    }
}
