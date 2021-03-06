﻿#region License QTec
////---------------------------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="Designation.cs" company="QTec">
//      License under MIT
// </copyright>
// <summary>
//      Represents a class for Designation.
// </summary>
////---------------------------------------------------------------------------------------------------------------------------------------------------------
#endregion

namespace QTec.Hrms.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// The designation.
    /// </summary>
    public class Designation
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        public ICollection<Employee> Employees { get; set; }
    }
}