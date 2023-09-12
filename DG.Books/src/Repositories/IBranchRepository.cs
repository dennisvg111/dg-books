using DG.Books.Entities.Versioning;
using DG.Common;
using System.Collections.Generic;

namespace DG.Books.Repositories
{
    public interface IBranchRepository
    {
        List<Branch> GetBranches();

        void UpdateSelected(string branchName, bool isSelected);
        Branch GetSelectedBranch();

        void AddBranchIfNotExists(string branchName);
        void RemoveBranch(string branchName);

        bool TryGetCommit(Uulsid id, out SavedCommit commit);
        void AddCommitToBranch(string branchName, SavedCommit commit);
        SavedCommit GetLastCommitFromBranch(string branchName);
    }
}
