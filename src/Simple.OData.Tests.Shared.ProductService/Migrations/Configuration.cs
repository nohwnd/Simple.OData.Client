using System.Data.Entity.Migrations;
using Simple.OData.Tests.Shared.ProductService.Models;

namespace Simple.OData.Tests.Shared.ProductService.Migrations;

internal sealed class Configuration : DbMigrationsConfiguration<ProductServiceContext>
{
	public Configuration()
	{
		AutomaticMigrationsEnabled = false;
	}

	protected override void Seed(global::Simple.OData.Tests.Shared.ProductService.Models.ProductServiceContext context)
	{
		// New code 
		context.Products.AddOrUpdate([
				new Product() { ID = 1, Name = "Hat", Price = 15, Category = "Apparel" },
				new Product() { ID = 2, Name = "Socks", Price = 5, Category = "Apparel" },
				new Product() { ID = 3, Name = "Scarf", Price = 12, Category = "Apparel" },
				new Product() { ID = 4, Name = "Yo-yo", Price = 4.95M, Category = "Toys" },
				new Product() { ID = 5, Name = "Puzzle", Price = 8, Category = "Toys" },
			]);

		context.WorkTaskModels.AddOrUpdate(
		[
				new WorkTaskModel()
				{
					Id = Guid.NewGuid(),
					Code = "TaskCode",
					StartDate = DateTime.Now.AddDays(-1),
					EndDate = DateTime.Now.AddDays(-1),
					Location = new GeoLocationModel() { Longitude = 1, Latitude = 2 },
					Attachments = [],
					WorkActivityReports = [],
				}
		]);
	}
}
