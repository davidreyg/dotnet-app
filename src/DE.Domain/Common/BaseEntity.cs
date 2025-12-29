namespace DE.Domain.Common
{
    public abstract class BaseEntity
    {
        public long Id { get; set; }
        public Guid GuidCode { get; set; }
        public int Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}
