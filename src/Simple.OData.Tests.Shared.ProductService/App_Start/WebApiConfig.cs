﻿using System.Web.Http;
using System.Web.Http.OData.Builder;
using System.Web.Http.OData.Extensions;
using Simple.OData.Tests.Shared.ProductService.Models;

namespace Simple.OData.Tests.Shared.ProductService.App_Start;

public static class WebApiConfig
{
	public static void Register(HttpConfiguration config)
	{
		var builder = new ODataConventionModelBuilder();
		builder.EntitySet<Product>("Products");
		builder.EntitySet<WorkTaskModel>("WorkTaskModels");
		builder.EntitySet<WorkTaskAttachmentModel>("WorkTaskAttachmentModels");
		builder.EntitySet<WorkActivityReportModel>("WorkActivityReportModels");
		var model = builder.GetEdmModel();

		config.Routes.MapODataServiceRoute("odata", "odata/open", model);
		config.Routes.MapODataServiceRoute("odatas", "odata/secure", model);
	}
}
