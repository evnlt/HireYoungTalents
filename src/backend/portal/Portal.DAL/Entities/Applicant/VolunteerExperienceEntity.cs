namespace HireYoungTalents.Portal.DAL.Entities.Applicant;

public class VolunteerExperienceEntity
{
	public int Id { get; init; }
	public string Project { get; set; } = default!;
	public int LengthInMonths { get; set; }
}
