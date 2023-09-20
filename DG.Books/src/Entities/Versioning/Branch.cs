using DG.Common;

namespace DG.Books.Entities.Versioning
{
    public class Branch
    {
        public string Name { get; set; }
        public Uulsid CommitId { get; set; }
    }
}
