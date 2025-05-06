using System;
using System.Collections.Generic;
using ERP_Pro.Domain.Common.Primitives;
using ERP_Pro.Domain.Common.ValueObjects;

using ERP_Pro.Domain.ERP.HumanResources.ValueObjects;
namespace ERP_Pro.Domain.ERP.HumanResources.Entities
{
/// <summary>
/// EmployeeFamily Entity
/// </summary>
public class EmployeeFamily : Entity<EmployeeFamilyId>
{

    private EmployeeFamily() { }

    public EmployeeFamily(EmployeeFamilyId id, decimal? personNumber)
    {
        Id = id;
        PersonNumber = personNumber;
    }

    /// <summary>
    /// The unique identifier for the EmployeeFamily
    /// المعرف الفريد لـ EmployeeFamily
    /// </summary>
    public EmployeeFamilyId Id { get; private set; }

    /// <summary>
    /// PersonNumber of the EmployeeFamily
    /// PersonNumber الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? PersonNumber { get; private set; }

    /// <summary>
    /// PersonLastName of the EmployeeFamily
    /// PersonLastName الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonLastName { get; private set; }

    /// <summary>
    /// PersonFirstName of the EmployeeFamily
    /// PersonFirstName الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonFirstName { get; private set; }

    /// <summary>
    /// PersonParentLastName of the EmployeeFamily
    /// PersonParentLastName الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonParentLastName { get; private set; }

    /// <summary>
    /// PersonParentFirstName of the EmployeeFamily
    /// PersonParentFirstName الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonParentFirstName { get; private set; }

    /// <summary>
    /// PersonGrandLastName of the EmployeeFamily
    /// PersonGrandLastName الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonGrandLastName { get; private set; }

    /// <summary>
    /// PersonGrandFirstName of the EmployeeFamily
    /// PersonGrandFirstName الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonGrandFirstName { get; private set; }

    /// <summary>
    /// PersonFamilyLastName of the EmployeeFamily
    /// PersonFamilyLastName الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonFamilyLastName { get; private set; }

    /// <summary>
    /// PersonFamilyFirstName of the EmployeeFamily
    /// PersonFamilyFirstName الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonFamilyFirstName { get; private set; }

    /// <summary>
    /// NationalityNumber of the EmployeeFamily
    /// NationalityNumber الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? NationalityNumber { get; private set; }

    /// <summary>
    /// ReligionNumber of the EmployeeFamily
    /// ReligionNumber الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? ReligionNumber { get; private set; }

    /// <summary>
    /// BirthPlace of the EmployeeFamily
    /// BirthPlace الخاص بـ EmployeeFamily
    /// </summary>
    public string BirthPlace { get; private set; }

    /// <summary>
    /// BirthDate of the EmployeeFamily
    /// BirthDate الخاص بـ EmployeeFamily
    /// </summary>
    public DateTime? BirthDate { get; private set; }

    /// <summary>
    /// RelationshipNumber of the EmployeeFamily
    /// RelationshipNumber الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? RelationshipNumber { get; private set; }

    /// <summary>
    /// Gender of the EmployeeFamily
    /// Gender الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? Gender { get; private set; }

    /// <summary>
    /// MedicalFlag of the EmployeeFamily
    /// MedicalFlag الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? MedicalFlag { get; private set; }

    /// <summary>
    /// PersonMedicalCategory of the EmployeeFamily
    /// PersonMedicalCategory الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? PersonMedicalCategory { get; private set; }

    /// <summary>
    /// PersonMedicalStartDate of the EmployeeFamily
    /// PersonMedicalStartDate الخاص بـ EmployeeFamily
    /// </summary>
    public DateTime? PersonMedicalStartDate { get; private set; }

    /// <summary>
    /// PersonMedicalEndDate of the EmployeeFamily
    /// PersonMedicalEndDate الخاص بـ EmployeeFamily
    /// </summary>
    public DateTime? PersonMedicalEndDate { get; private set; }

    /// <summary>
    /// PersonMedicalAmount of the EmployeeFamily
    /// PersonMedicalAmount الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? PersonMedicalAmount { get; private set; }

    /// <summary>
    /// PersonMedicalMembership of the EmployeeFamily
    /// PersonMedicalMembership الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonMedicalMembership { get; private set; }

    /// <summary>
    /// EmpMdclRto of the EmployeeFamily
    /// EmpMdclRto الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? EmpMdclRto { get; private set; }

    /// <summary>
    /// BuildingType of the EmployeeFamily
    /// BuildingType الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? BuildingType { get; private set; }

    /// <summary>
    /// PersonImage of the EmployeeFamily
    /// PersonImage الخاص بـ EmployeeFamily
    /// </summary>
    public string PersonImage { get; private set; }

    /// <summary>
    /// PersonMedicalDeservedAge of the EmployeeFamily
    /// PersonMedicalDeservedAge الخاص بـ EmployeeFamily
    /// </summary>
    public decimal? PersonMedicalDeservedAge { get; private set; }

    #region Navigation Properties
    /// <summary>
    /// Reference relationship: ManyToOne
    /// </summary>
    public Employee Employee { get; private set; }
    #endregion

    #region Methods
    // Add domain logic methods here
    #endregion
}
}

