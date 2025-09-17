using System;

using HireYoungTalents.Portal.DAL.Entities.Applicant;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HireYoungTalents.Portal.DAL.EntityConfigurations.Applicant;

public class ApplicantSubmissionConfiguration : IEntityTypeConfiguration<ApplicantSubmissionEntity>
{
	public void Configure(EntityTypeBuilder<ApplicantSubmissionEntity> builder)
	{
		builder.HasKey(x => x.Id);

		builder.Property(x => x.CreatedDate)
			.IsRequired();

		builder.Property(x => x.UpdatedDate)
			.IsRequired();
	}
}
