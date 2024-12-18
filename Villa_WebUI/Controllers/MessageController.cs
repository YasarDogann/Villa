﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa_Businesss.Abstract;
using Villa_Dto.Dtos.MessageDtos;
using Villa_Entity.Entities;

namespace Villa_WebUI.Controllers
{
	public class MessageController : Controller
	{
		private readonly IMessageService _messageService;
		private readonly IMapper _mapper;

		public MessageController(IMessageService messageService, IMapper mapper)
		{
			_messageService = messageService;
			_mapper = mapper;
		}

		public async Task<IActionResult> Index()
		{
			var values = await _messageService.TGetListAsync();
			var valueList = _mapper.Map<List<ResultMessageDto>>(values);
			return View(valueList);
		}

		public async Task<IActionResult> DeleteMessage(ObjectId id)
		{
			await _messageService.TDeleteAsync(id);
			return RedirectToAction("Index");
		}

		public IActionResult CreateMessage()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateMessage(CreateMessageDto createMessageDto)
		{
			var newValue = _mapper.Map<Message>(createMessageDto);
			await _messageService.TCreateAsync(newValue);
			return RedirectToAction("Index");
		}

		public async Task<IActionResult> MessageDetails(ObjectId id) // id'ye göre geti GET
		{
			var value = await _messageService.TGetByIdAsync(id);
			var messageValue = _mapper.Map<ResultMessageDto>(value);
			return View(messageValue);
		}
	}
}
