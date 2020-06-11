﻿namespace eShopOnBlazorWasm.Features.Catalogs
{
  using eShopOnBlazorWasm.Features.Bases;
  using MediatR;

  public class GetCatalogTypesRequest : BaseApiRequest, IRequest<GetCatalogTypesResponse>
  {
    public const string Route = "api/CatalogTypes";

    internal override string RouteFactory => $"{Route}?{nameof(Id)}={Id}";
  }
}