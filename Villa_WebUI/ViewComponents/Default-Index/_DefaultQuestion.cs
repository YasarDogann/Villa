using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Villa_Businesss.Abstract;
using Villa_Dto.Dtos.QuestDtos;

namespace Villa_WebUI.ViewComponents.Default_Index
{
	public class _DefaultQuestion : ViewComponent
	{
		private readonly IQuestService _questService;
		private readonly IMapper _mapper;

		public _DefaultQuestion(IQuestService questService, IMapper mapper)
		{
			_questService = questService;
			_mapper = mapper;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _questService.TGetListAsync();
			var questionList = _mapper.Map<List<ResultQuestDto>>(values);
			return View(questionList);

		} 
	}
}
