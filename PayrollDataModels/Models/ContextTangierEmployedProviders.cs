// Created By:           Lee Marrette
//           Date:           07/20/2020
//     Solution:           TangierEmployedProviders
//       Project:           PayrollDataModels

using System.Data.Entity;
using TangierEmployedProviders.Models;

namespace PayrollDataModels.Models
{
    public class ContextTangierEmployedProviders : DbContext
    {
        public DbSet<EmployeeAdditionalJob> EmployeeAdditionalJobs { get; set; }
        public DbSet<EmployeeCommittment> EmployeeCommittments { get; set; }
        public DbSet<EmployeeMaster> EmployeeMasters { get; set; }
        public DbSet<GlobalIdMap> GlobalIdMaps { get; set; }
        public DbSet<ProcessedPayroll> ProcessedPayrolls { get; set; }
        public DbSet<SalesForceData> SalesForceDatas { get; set; }
        public DbSet<StateTaxLegend> StateTaxLegends { get; set; }
    }
}