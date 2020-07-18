// Created By:           Lee Marrette
//           Date:           07/07/2020
//     Solution:           TangierEmployedProviders
//       Project:           TangierEmployedProviders

using System.ComponentModel.DataAnnotations;

namespace TangierEmployedProviders.Models
{
    /// <summary>
    /// Class to hold the few columns from Account needed for payroll
    /// </summary>
    public class SalesForceData
    {
        /// <summary>
        /// Salesforce global facility id
        /// </summary>
        [Key]
        public string GlobalFacilityId  { get; set; }
        public string FacilityName      { get; set; }
        /// <summary>
        /// Workday cost center
        /// </summary>
        public string CostCenter        { get; set; }      
        /// <summary>
        /// Line company facility is associated with
        /// </summary>
        public string LineCompany       { get; set; }
        /// <summary>
        /// SalesForce key
        /// </summary>
        public string CorporateEntities { get; set; }
    }
}