namespace HireYoungTalents.Portal.DAL.Entities;

public class SpecializationEntity
{
	public int Id { get; init; }
	public bool IsTechnical { get; init; }
	public bool IsSecondary { get; init; }
	public string Name { get; init; } = default!;
	public bool HasApplicants { get; set; }
}
