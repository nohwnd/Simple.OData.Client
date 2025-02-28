﻿using System.Data.Entity;

namespace Simple.OData.Tests.Shared.ProductService.Models;

public class ProductServiceContext : DbContext
{
	// You can add custom code to this file. Changes will not be overwritten.
	// 
	// If you want Entity Framework to drop and regenerate your database
	// automatically whenever you change your model schema, please use data migrations.
	// For more information refer to the documentation:
	// http://msdn.microsoft.com/en-us/data/jj591621.aspx

	public ProductServiceContext()
		: base("name=DefaultConnection")
	{
	}

	public System.Data.Entity.DbSet<Product> Products { get; set; }
	public System.Data.Entity.DbSet<WorkTaskModel> WorkTaskModels { get; set; }
	public System.Data.Entity.DbSet<WorkTaskAttachmentModel> WorkTaskAttachmentModels { get; set; }
	public System.Data.Entity.DbSet<WorkActivityReportModel> WorkActivityReportModels { get; set; }

}
