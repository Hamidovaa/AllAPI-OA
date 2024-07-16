using AllAPI.Application.DTO;
using AllAPI.Application.Interfacee.AutoMapper;
using AllAPI.Application.Interfacee.UnitOfWorks;
using AllAPI.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAPI.Application.Features.Products.Queries.GetAllProducts
{
    internal class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;
        private IMapper mapper;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) 
        {
            this.unitOfWork = unitOfWork;
            this.mapper =mapper;
        }
        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync(include: x=>x.Include(b=>b.Brand));

            var brand= mapper.Map<BrandDto, Brand>(new Brand());
            //List<GetAllProductsQueryResponse> response = new();
            //foreach(var product in products)
            //    response.Add(new GetAllProductsQueryResponse
            //    {
            //        Title = product.Title,
            //        Description = product.Description,
            //        Discount = product.Discount,
            //        Price = product.Price - (product.Price* product.Discount/100),
            //    });  


            var map=mapper.Map<GetAllProductsQueryResponse, Product>(products);
            foreach(var item in map)
                item.Price -= (item.Price * item.Discount / 100);
            //return map;
            throw new Exception("hata mesaji");
        }
    }
}
