﻿// ReSharper disable CheckNamespace
namespace Simple.OData.Tests.Shared.ProductService.Models;

public class WorkTaskModel : BaseModel
{
	public WorkTaskModel()
	{
		Attachments = [];
		WorkActivityReports = [];
	}

	public string Code { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public Guid State { get; set; }
	public GeoLocationModel Location { get; set; }
	public Guid WorkerId { get; set; }
	public Guid CustomerId { get; set; }
	public List<WorkTaskAttachmentModel> Attachments { get; set; }
	public List<WorkActivityReportModel> WorkActivityReports { get; set; }

}
