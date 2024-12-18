using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa_Businesss.Abstract;
using Villa_Dto.Dtos.ContactDtos;

namespace Villa_WebUI.ViewComponents.Default_Index
{
    public class _DefaultContact : ViewComponent
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public _DefaultContact(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _contactService.TGetListAsync();
            var contacts = _mapper.Map<List<ResultContactDto>>(values);
            return View(contacts);
        }
    }
}
