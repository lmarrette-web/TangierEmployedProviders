// Created By:           Lee Marrette
//           Date:           07/07/2020
//     Solution:           TangierEmployedProviders
//       Project:           TangierEmployedProviders

using System.ComponentModel.DataAnnotations;

namespace TangierEmployedProviders.Models
{
    /// <summary>
    /// List of states with their state tax code
    /// </summary>
    public class StateTaxLegend
    {
        [Key]
        public string StateAbbreviation { get; set; }

        public string StateName { get; set; }
        public string StateTaxCode { get; set; }
    }
}