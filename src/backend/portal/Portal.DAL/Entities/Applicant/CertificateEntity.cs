namespace HireYoungTalents.Portal.DAL.Entities.Applicant;

public class CertificateEntity
{
	public int Id { get; init; }
	//public Guid FileId { get; set; }
	public int Points { get; set; }
	public string Name { get; set; } = default!;

	public int ApplicantProfileId { get; set; }

	public ApplicantProfileEntity ApplicantProfile { get; set; } = default!;
}
