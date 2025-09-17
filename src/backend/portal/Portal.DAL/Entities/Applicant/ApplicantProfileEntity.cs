using System;
using System.Collections.Generic;

using HireYoungTalents.Portal.DAL.Entities.Location;
using HireYoungTalents.Portal.DAL.Enums;

namespace HireYoungTalents.Portal.DAL.Entities.Applicant;

public class ApplicantProfileEntity
{
	public int Id { get; init; }
	public bool IsEnabled { get; set; }
    //public Guid UserId { get; init; }
    //public ApplicationUser User { get; set; } = default!;
    public string Code { get; init; } = default!;
    public DateTime CreatedDate { get; init; }
    public DateTime UpdatedDate { get; set; }
	public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string AnonymousName { get; set; } = default!;

    public string CitizenshipCountryName { get; set; } = default!;
    public string ResidenceCountryName { get; set; } = default!;
    public string ResidenceCityName { get; set; } = default!;
    public string SpecializationName { get; set; } = default!;
    public EnglishLevel SpeakingLevel { get; set; }
    public EnglishLevel ReadingLevel { get; set; }
    public string? CvLink { get; set; }
    public int? PetProjectsComplexity { get; set; }
    public bool OfficeAcceptable { get; set; }
    public bool PartTimeAcceptable { get; set; }
    public bool RemoteAcceptable { get; set; }
    public bool RelocationAcceptable { get; set; }
    public bool HasBlueCard { get; set; }
    public bool HasWorkPermit { get; set; }
    public int? SalaryExpectation { get; set; }
    public string? CoverLetter { get; set; }

    public int CitizenshipCountryId { get; set; }
    public int ResidenceCountryId { get; set; }
    public int ResidenceCityId { get; set; }
    public int SpecializationId { get; set; }
    //public Guid? CvFileId { get; set; }

    public CountryEntity CitizenshipCountry { get; set; } = default!;
    public CountryEntity ResidenceCountry { get; set; } = default!;
    public CityEntity ResidenceCity { get; set; } = default!;
    public SpecializationEntity Specialization { get; set; } = default!;
    public ICollection<TagEntity> Tags { get; set; } = default!;
    public ICollection<CertificateEntity> Certificates { get; set; } = default!;
    public ICollection<GraduationEntity> Graduations { get; set; } = default!;
    public ICollection<ExpertiseEntity> Expertises { get; set; } = default!;
    public ICollection<InternshipEntity> Internships { get; set; } = default!;
    public ICollection<VolunteerExperienceEntity> VolunteerExperiences { get; set; } = default!;
    public ICollection<WorkExperienceEntity> WorkExperiences { get; set; } = default!;
    public ICollection<PetProjectEntity> PetProjects { get; set; } = default!;



}
