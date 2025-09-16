using HireYoungTalents.Portal.DAL.Enums;

namespace HireYoungTalents.Portal.DAL.Entities.Applicant;

public class ExpertiseEntity
{
	public int Id { get; init; }
	public string NameOrLink { get; set; } = default!;
	public CertificateKind CertificateKind { get; set; } = default!;
	public string? CertificateLink { get; set; }
	//public Guid? UploadedCertificateFileId { get; set; }
}
