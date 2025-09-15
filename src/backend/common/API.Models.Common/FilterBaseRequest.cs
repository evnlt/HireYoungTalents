using HireYoungTalents.Constants.Enums;

namespace HireYoungTalents.API.Models.Common;

public class FilterBaseRequest<TOrderBy>: PagedBaseRequest
{
	public TOrderBy OrderBy { get; set; }

	public OrderDirection OrderDirection { get; set; }
}
