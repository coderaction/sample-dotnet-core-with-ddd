using CQRSAndMediator.Domain.Common;

namespace CQRSAndMediator.Domain.Entities
{
    public class Test: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}