namespace HireYoungTalents.Portal.DAL.Entities.Applicant;

public class WorkExperienceEntity
{
	public int Id { get; init; }
	public string CompanyName { get; set; } = default!;
	public string Description { get; set; } = default!;
	public int LengthInMonths { get; set; }
}
