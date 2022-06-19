using MusicTaxApp.Models;

namespace MusicTaxApp.Repositories
{
    public interface ITestRepository
    {
        Task<IEnumerable<Test>> Get();
        Task<Test> Create(Test test);
    }
}

