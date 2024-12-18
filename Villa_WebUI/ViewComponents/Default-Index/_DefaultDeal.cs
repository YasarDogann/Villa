using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa_Businesss.Abstract;
using Villa_Dto.Dtos.DealsDtos;

namespace Villa_WebUI.ViewComponents.Default_Index
{
    public class _DefaultDeal : ViewComponent
    {
        private readonly IDealService _dealService;
        private readonly IMapper _mapper;

        public _DefaultDeal(IDealService dealService, IMapper mapper)
        {
            _dealService = dealService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _dealService.TGetListAsync();
            var dealList = _mapper.Map<List<ResultDealDto>>(values);
            return View(dealList);
        }
    }
}
