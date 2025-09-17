using HireYoungTalents.Portal.DAL.Entities.Applicant;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HireYoungTalents.Portal.DAL.EntityConfigurations.Applicant;

public class CertificateConfiguration : IEntityTypeConfiguration<CertificateEntity>
{
	public void Configure(EntityTypeBuilder<CertificateEntity> builder)
	{
		builder.HasKey(m => m.Id);

		builder.HasOne(_ => _.ApplicantProfile)
			.WithMany(_ => _.Certificates)
			.HasForeignKey(_ => _.ApplicantProfileId);
	}
}

