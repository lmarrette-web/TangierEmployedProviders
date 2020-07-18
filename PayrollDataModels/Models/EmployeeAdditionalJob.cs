// Created By:           Lee Marrette
//           Date:           //
//     Solution:           TangierEmployedProviders
//       Project:           TangierEmployedProviders

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TangierEmployedProviders.Models
{
    /// <summary>
    /// Class to store additional jobs for an employee if they are multi job
    /// Workday Data Source - SG Additional Jobs
    /// </summary>
    public class EmployeeAdditionalJob
    {
        /// <summary>
        /// Worker's employee id
        /// </summary>
        [Key]
        [Column(Order = 1)]
        public string EmployeeId { get; set; }
        /// <summary>
        /// Reference id for secondary position id
        /// </summary>
        [Key]
        [Column(Order = 2)]
        public string PositionId { get; set; }
        /// <summary>
        /// Cost center id for additional job
        /// </summary>
        public         string         CostCenterId   { get; set; }
        /// <summary>
        /// Cost center name for additional job
        /// </summary>
        public string         CostCenter     { get; set; }
        /// <summary>
        /// Position description for additional job
        /// </summary>
        public         string         Position       { get; set; }
        /// <summary>
        /// Workday company id for additional job
        /// </summary>
        public         string         CompanyId      { get; set; }
        /// <summary>
        /// Workday company name for additional job
        /// </summary>
        public         string         Company        { get; set; }
        /// <summary>
        /// Reference to employee master
        /// </summary>
        public virtual EmployeeMaster EmployeeMaster { get; set; }
    }
}