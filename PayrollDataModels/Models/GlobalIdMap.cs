// Created By:           Lee Marrette
//           Date:           06/29/2020
//     Solution:           TangierEmployedProviders
//       Project:           TangierEmployedProviders

using System.ComponentModel.DataAnnotations;

namespace TangierEmployedProviders.Models
{
    /// <summary>
    /// Class to map provider global ids to Workday employee id
    /// Workday data source is SG_Emplid_GlobalId_Xref
    /// </summary>
    public class GlobalIdMap
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Global Id for the provider
        /// </summary>
        public string GlobalId { get; set; }
        /// <summary>
        /// Workday employee id
        /// </summary>
        public string EmployeeId { get; set; }
        /// <summary>
        /// Employees name
        /// </summary>
        public string Name { get; set; }

    }
}