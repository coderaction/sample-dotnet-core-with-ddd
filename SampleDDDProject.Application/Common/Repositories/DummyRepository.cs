using System.Threading.Tasks;

namespace SampleDDDProject.Application.Common.Repositories
{
    public interface IDummyRepository
    {
        public IDummyQueryRepository Query { get; }
        public IDummyCommandRepository Command { get; }
    }
    
    public interface IDummyQueryRepository
    {
        Task<int> GetAsync(int id);
    }

    public interface IDummyCommandRepository
    {
     // insert, update, delete transactions
    }
}