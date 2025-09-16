namespace HireYoungTalents.Portal.DAL.Entities.Location;

public class CountryEntity
{
	public int Id { get; init; }
	public string Name { get; init; } = default!;
	public bool HasApplicants { get; set; }
}
