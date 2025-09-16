namespace HireYoungTalents.Portal.DAL.Entities.Applicant;

public class InternshipEntity
{
	public int Id { get; init; }
	public string CompanyName { get; set; } = default!;
	public int LengthInMonths { get; set; }
}
