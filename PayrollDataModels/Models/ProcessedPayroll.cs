// Created By:           Lee Marrette
//           Date:           04/14/2020
//     Solution:           TangierICPay
//       Project:           TangierICPay

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollDataModels.Models
{
    /// <summary>
    /// Table to show recent payroll loads and their status
    /// </summary>
    public class ProcessedPayroll
    {
        public int Id { get; set; }
        /// <summary>
        /// Date the data was loaded.
        /// </summary>
        [Column(TypeName="datetime2")]
        public DateTime DateLoaded { get; set; }
        /// <summary>
        /// Earliest shift date
        /// </summary>
        [Column(TypeName="datetime2")]
        public DateTime FromDate { get; set; }
        /// <summary>
        /// Ending shift date
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime ThruDate { get; set; }
        /// <summary>
        /// Total dollar amount of the load
        /// </summary>
        public string TotalAmount { get; set; }
        /// <summary>
        /// Number of rows loaded
        /// </summary>
        public int RowCount { get; set; }
        /// <summary>
        /// Status of the data load
        /// </summary>
        public string Status { get; set; }
    }
}