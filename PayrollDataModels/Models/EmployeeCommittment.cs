// Created By:           Lee Marrette
//           Date:           07/07/2020
//     Solution:           TangierEmployedProviders
//       Project:           TangierEmployedProviders

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TangierEmployedProviders.Models
{
    /// <summary>
    /// Class to store committed hours and legacy flag
    /// for employed providers.  Used in the pay calculation
    /// for full time mid-level employed providers
    /// </summary>
    public class EmployeeCommittment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Workday employee number
        /// </summary>
        public string EmployeeId { get; set; }
        /// <summary>
        /// Provider Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Committed hours stored in Workday.  Affects pay calculation
        /// </summary>
        public string CommittedHours { get; set; }
        /// <summary>
        /// WorkShift is the field used for committed hours
        /// </summary>
        public string WorkshiftDescription { get; set; }
        /// <summary>
        /// Job profile
        /// </summary>
        public string JobProfile { get; set; }
        /// <summary>
        /// Is the provider considered legacy or not.  Affects pay calcuation
        /// </summary>
        public bool IsLegacy { get; set; }
        /// <summary>
        /// Providers global id 
        /// </summary>
        public string GlobalId { get; set; }
        public DateTime DateLoaded { get; set; }

    }
}