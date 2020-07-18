// Created By:           Lee Marrette
//           Date:           06/29/2020
//     Solution:           TangierEmployedProviders
//       Project:           TangierEmployedProviders

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TangierEmployedProviders.Models
{
    /// <summary>
    /// Class to store primary job info for payroll
    /// Workday Data Source - SG Additional Jobs
    /// </summary>
    public class EmployeeMaster
    {
        /// <summary>
        /// Workday Employee Id
        /// </summary>
        [Key]
        public string EmployeeId { get; set; }
        /// <summary>
        /// Employee's legal last name 
        /// </summary>
        public string LastName                   { get; set; }
        /// <summary>
        /// Employee's legal first name
        /// </summary>
        public string FirstName                  { get; set; }
        /// <summary>
        /// Worker's department code
        /// </summary>
        public string CostCenterId               { get; set; }
        /// <summary>
        /// Worker's department name
        /// </summary>
        public string CostCenterName             { get; set; }
        /// <summary>
        /// Worker's primary position
        /// </summary>
        public string PrimaryPosition            { get; set; }
        /// <summary>
        /// Workday reference Id for primary position
        /// </summary>
        public string PrimaryPositionReferenceId { get; set; }
        /// <summary>
        /// Company code for worker's primary position
        /// </summary>
        public string CompanyId                  { get; set; }
        /// <summary>
        /// Company name for worker's primary position
        /// </summary>
        public string CompanyName                { get; set; }
        /// <summary>
        /// Worker's global id
        /// </summary>
        public string GlobalId                   { get; set; }
        /// <summary>
        /// Stores additional jobs if employee has them
        /// </summary>
        public virtual ICollection<EmployeeAdditionalJob> AdditionalJobs { get; set; }
    }
}
