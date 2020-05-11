/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.1.2
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// See Account Types
    /// </summary>
    /// <value>See Account Types</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccountType
    {
        /// <summary>
        /// Enum BANK for value: BANK
        /// </summary>
        [EnumMember(Value = "BANK")]
        BANK = 1,

        /// <summary>
        /// Enum CURRENT for value: CURRENT
        /// </summary>
        [EnumMember(Value = "CURRENT")]
        CURRENT = 2,

        /// <summary>
        /// Enum CURRLIAB for value: CURRLIAB
        /// </summary>
        [EnumMember(Value = "CURRLIAB")]
        CURRLIAB = 3,

        /// <summary>
        /// Enum DEPRECIATN for value: DEPRECIATN
        /// </summary>
        [EnumMember(Value = "DEPRECIATN")]
        DEPRECIATN = 4,

        /// <summary>
        /// Enum DIRECTCOSTS for value: DIRECTCOSTS
        /// </summary>
        [EnumMember(Value = "DIRECTCOSTS")]
        DIRECTCOSTS = 5,

        /// <summary>
        /// Enum EQUITY for value: EQUITY
        /// </summary>
        [EnumMember(Value = "EQUITY")]
        EQUITY = 6,

        /// <summary>
        /// Enum EXPENSE for value: EXPENSE
        /// </summary>
        [EnumMember(Value = "EXPENSE")]
        EXPENSE = 7,

        /// <summary>
        /// Enum FIXED for value: FIXED
        /// </summary>
        [EnumMember(Value = "FIXED")]
        FIXED = 8,

        /// <summary>
        /// Enum INVENTORY for value: INVENTORY
        /// </summary>
        [EnumMember(Value = "INVENTORY")]
        INVENTORY = 9,

        /// <summary>
        /// Enum LIABILITY for value: LIABILITY
        /// </summary>
        [EnumMember(Value = "LIABILITY")]
        LIABILITY = 10,

        /// <summary>
        /// Enum NONCURRENT for value: NONCURRENT
        /// </summary>
        [EnumMember(Value = "NONCURRENT")]
        NONCURRENT = 11,

        /// <summary>
        /// Enum OTHERINCOME for value: OTHERINCOME
        /// </summary>
        [EnumMember(Value = "OTHERINCOME")]
        OTHERINCOME = 12,

        /// <summary>
        /// Enum OVERHEADS for value: OVERHEADS
        /// </summary>
        [EnumMember(Value = "OVERHEADS")]
        OVERHEADS = 13,

        /// <summary>
        /// Enum PREPAYMENT for value: PREPAYMENT
        /// </summary>
        [EnumMember(Value = "PREPAYMENT")]
        PREPAYMENT = 14,

        /// <summary>
        /// Enum REVENUE for value: REVENUE
        /// </summary>
        [EnumMember(Value = "REVENUE")]
        REVENUE = 15,

        /// <summary>
        /// Enum SALES for value: SALES
        /// </summary>
        [EnumMember(Value = "SALES")]
        SALES = 16,

        /// <summary>
        /// Enum TERMLIAB for value: TERMLIAB
        /// </summary>
        [EnumMember(Value = "TERMLIAB")]
        TERMLIAB = 17,

        /// <summary>
        /// Enum PAYGLIABILITY for value: PAYGLIABILITY
        /// </summary>
        [EnumMember(Value = "PAYGLIABILITY")]
        PAYGLIABILITY = 18,

        /// <summary>
        /// Enum PAYG for value: PAYG
        /// </summary>
        [EnumMember(Value = "PAYG")]
        PAYG = 19,

        /// <summary>
        /// Enum SUPERANNUATIONEXPENSE for value: SUPERANNUATIONEXPENSE
        /// </summary>
        [EnumMember(Value = "SUPERANNUATIONEXPENSE")]
        SUPERANNUATIONEXPENSE = 20,

        /// <summary>
        /// Enum SUPERANNUATIONLIABILITY for value: SUPERANNUATIONLIABILITY
        /// </summary>
        [EnumMember(Value = "SUPERANNUATIONLIABILITY")]
        SUPERANNUATIONLIABILITY = 21,

        /// <summary>
        /// Enum WAGESEXPENSE for value: WAGESEXPENSE
        /// </summary>
        [EnumMember(Value = "WAGESEXPENSE")]
        WAGESEXPENSE = 22

    }

}
