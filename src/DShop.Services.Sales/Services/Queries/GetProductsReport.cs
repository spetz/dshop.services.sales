using System;
using DShop.Common.Types;
using DShop.Services.Sales.Services.Dto;

namespace DShop.Services.Sales.Services.Queries
{
    public class GetProductsReport : IQuery<ProductsReportDto>
    {
        public Guid Id { get; set; }
    }
}