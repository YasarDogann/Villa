using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa_Businesss.Abstract;
using Villa_Dto.Dtos.ProductDtos;

namespace Villa_WebUI.ViewComponents.Default_Index
{
    public class _DefaultProduct : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public _DefaultProduct(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var results = await _productService.TGetListAsync();
            var productList = _mapper.Map<List<ResultProductDto>>(results);
            return View(productList);
        }
    }
}
