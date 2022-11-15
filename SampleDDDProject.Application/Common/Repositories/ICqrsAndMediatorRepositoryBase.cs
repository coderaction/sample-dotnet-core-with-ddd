namespace SampleDDDProject.Application.Common.Repositories
{
    public interface ICqrsAndMediatorRepositoryBase
    {
        IDummyRepository DummyRepository { get; set; }
    }
}