using DG.Books.Entities.Versioning;
using DG.Common;
using System.Collections.Generic;

namespace DG.Books.Repositories
{
    public interface IBranchRepository
    {
        List<Branch> GetBranches();

        void SetSelectedBranch(string branchName);
        Branch GetSelectedBranch();

        bool TryGetCommit(Uulsid id, out SavedCommit commit);
        void AddCommit(SavedCommit commit);
    }
}
