using System.Collections.Generic;

using HireYoungTalents.Portal.DAL.Entities.Applicant;

namespace HireYoungTalents.Portal.DAL.Entities.Location;

public class CityEntity
{
	public int Id { get; init; }
	public string Name { get; init; } = default!;

	public int CountryId { get; init; }

	public CountryEntity Country { get; init; } = default!;
	public ICollection<ApplicantProfileEntity> ApplicantProfiles { get; set; } = default!;
}
