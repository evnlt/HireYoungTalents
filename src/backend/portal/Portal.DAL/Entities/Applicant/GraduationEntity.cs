using HireYoungTalents.Portal.DAL.Enums;

namespace HireYoungTalents.Portal.DAL.Entities.Applicant;

public class GraduationEntity
{
	public int Id { get; init; }
	public string University { get; set; } = default!;
	public string Specialization { get; set; } = default!;
	public GraduationLevel Graduation { get; set; } = default!;
}
