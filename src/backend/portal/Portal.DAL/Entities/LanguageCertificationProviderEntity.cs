using HireYoungTalents.Portal.DAL.Entities.Location;

namespace HireYoungTalents.Portal.DAL.Entities;

public class LanguageCertificationProviderEntity
{
	public int Id { get; init; }
	public string Link { get; init; } = default!;
	public bool IsGlobal { get; set; }

	public int? CountryId { get; set; }

	public CountryEntity? Country { get; set; }
}
