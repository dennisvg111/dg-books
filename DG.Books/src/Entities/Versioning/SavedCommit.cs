using DG.Common;
using System;

namespace DG.Books.Entities.Versioning
{
    public class SavedCommit : Commit
    {
        public Uulsid Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
