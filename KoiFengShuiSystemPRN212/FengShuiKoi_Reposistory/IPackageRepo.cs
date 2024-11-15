﻿using FengShuiKoi_BO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FengShuiKoi_Repository
{
    public interface IPackageRepo
    {
        Task<Package> GetPackageByRank(string rank);
        Task<List<Package>> GetPackages();
        Task<bool> AddPackage(Package package);
        Task<bool> DeletePackage(string rank);
        Task<bool> UpdatePackage(Package package);
    }
}