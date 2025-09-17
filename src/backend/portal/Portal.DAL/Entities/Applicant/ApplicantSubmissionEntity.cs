using System;
using System.Collections.Generic;

using HireYoungTalents.Portal.DAL.Enums;

namespace HireYoungTalents.Portal.DAL.Entities.Applicant;

public class ApplicantSubmissionEntity
{
	public int Id { get; init; }
	public DateTime CreatedDate { get; init; }
	public DateTime UpdatedDate { get; set; }
	public ApplicantSubmissionStatus Status { get; set; }
	public ApplicantSubmissionStage Stage { get; set; }

}
