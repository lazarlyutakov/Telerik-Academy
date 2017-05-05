using ProjectManager.Models;
using ProjectManager.Models.Contracts;
using System.Collections.Generic;

namespace ProjectManager.Data
{
    /// <summary>
    /// Interface for the database, the projects are being kept.
    /// </summary>
    public interface IDatabase
    {
        IList<IProject> Projects { get; }
    }
}
