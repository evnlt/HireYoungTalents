using HireYoungTalents.Portal.DAL.Entities.Applicant;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HireYoungTalents.Portal.DAL.EntityConfigurations.Applicant;

public class ApplicantProfileConfiguration: IEntityTypeConfiguration<ApplicantProfileEntity>
{
	public void Configure(EntityTypeBuilder<ApplicantProfileEntity> builder)
	{
		builder.HasKey(x => x.Id);

		builder.Property(x => x.CreatedDate)
			.IsRequired();

		builder.Property(x => x.UpdatedDate)
			.IsRequired();

		builder.Property(x => x.Code)
			.IsRequired()
			.HasMaxLength(3); // TODO - figure this out

		builder.Property(x => x.FirstName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(x => x.LastName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(x => x.AnonymousName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(x => x.CitizenshipCountryName)
			.IsRequired()
			.HasMaxLength(100); // TODO - same as in country config

		builder.Property(x => x.ResidenceCountryName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(x => x.ResidenceCityName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(x => x.SpecializationName)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(x => x.CvLink)
			.HasMaxLength(2000); // TODO - store as url type?

		builder.Property(x => x.CoverLetter)
			.HasMaxLength(1000);

		builder.HasOne(_ => _.CitizenshipCountry)
			.WithMany(_ => _.ApplicantProfiles)
			.HasForeignKey(x => x.CitizenshipCountryId);

		builder.HasOne(_ => _.ResidenceCountry)
			.WithMany(_ => _.ApplicantProfiles)
			.HasForeignKey(x => x.ResidenceCountryId);

		builder.HasOne(_ => _.ResidenceCity)
			.WithMany(_ => _.ApplicantProfiles)
			.HasForeignKey(x => x.ResidenceCityId);


		builder.HasOne(_ => _.Specialization)
			.WithMany(_ => _.ApplicantProfiles)
			.HasForeignKey(x => x.SpecializationId);
	}
}
