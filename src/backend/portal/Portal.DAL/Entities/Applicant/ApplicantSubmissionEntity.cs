using System;
using System.Collections.Generic;

using HireYoungTalents.Portal.DAL.Enums;

namespace HireYoungTalents.Portal.DAL.Entities.Applicant;

public class ApplicantSubmissionEntity
{
	public int Id { get; init; }
	public DateTime Created { get; init; }
	public DateTime Updated { get; set; }
	//public Guid UserId { get; init; }
	//public ApplicationUser User { get; set; } = default!;
	public ApplicantSubmissionStatus Status { get; set; }
	public ApplicantSubmissionStage Stage { get; set; }

}
