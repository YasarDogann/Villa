using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa_Businesss.Abstract;
using Villa_Dto.Dtos.ContactDtos;
using Villa_Dto.Dtos.CounterDtos;

namespace Villa_WebUI.ViewComponents.Default_Index
{
    public class _DefaultCounter : ViewComponent
    {
        private readonly ICounterService _counterService;
        private readonly IMapper _mapper;

        public _DefaultCounter(ICounterService counterService, IMapper mapper)
        {
            _counterService = counterService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _counterService.TGetListAsync();
            var counterList = _mapper.Map<List<ResultCounterDto>>(values);
            return View(counterList);
        }
    }
}
