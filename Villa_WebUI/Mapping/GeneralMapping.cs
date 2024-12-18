using AutoMapper;
using Villa.Dto.Dtos.SubHeaderDtos;
using Villa.Entity.Entities;
using Villa_Dto.Dtos.BannerDtos;
using Villa_Dto.Dtos.ContactDtos;
using Villa_Dto.Dtos.CounterDtos;
using Villa_Dto.Dtos.DealsDtos;
using Villa_Dto.Dtos.FeatureDtos;
using Villa_Dto.Dtos.MessageDtos;
using Villa_Dto.Dtos.ProductDtos;
using Villa_Dto.Dtos.QuestDtos;
using Villa_Dto.Dtos.VideoDtos;
using Villa_Entity.Entities;

namespace Villa_WebUI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<ResultBannerDto, Banner>().ReverseMap(); // birbirine map'ledik
            CreateMap<UpdateBannerDto, Banner>().ReverseMap();
            CreateMap<CreateBannerDto, Banner>().ReverseMap();

            CreateMap<CreateContactDto, Contact>().ReverseMap();
            CreateMap<UpdateContactDto, Contact>().ReverseMap();
            CreateMap<ResultContactDto, Contact>().ReverseMap();

            CreateMap<ResultCounterDto, Counter>().ReverseMap();
            CreateMap<UpdateCounterDto, Counter>().ReverseMap();
            CreateMap<CreateCounterDto, Counter>().ReverseMap();

            CreateMap<CreateDealDto, Deal>().ReverseMap();
            CreateMap<UpdateDealDto, Deal>().ReverseMap();
            CreateMap<ResultDealDto, Deal>().ReverseMap();

            CreateMap<CreateFeatureDto, Feature>().ReverseMap();
            CreateMap<UpdateFeatureDto, Feature>().ReverseMap();
            CreateMap<ResultFeatureDto, Feature>().ReverseMap();

            CreateMap<CreateMessageDto, Message>().ReverseMap();
            CreateMap<UpdateMessageDto, Message>().ReverseMap();
            CreateMap<ResultMessageDto, Message>().ReverseMap();

            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();
            CreateMap<ResultProductDto, Product>().ReverseMap();

            CreateMap<CreateQuestDto, Quest>().ReverseMap();
            CreateMap<UpdateQuestDto, Quest>().ReverseMap();
            CreateMap<ResultQuestDto, Quest>().ReverseMap();

            CreateMap<CreateVideoDto, Video>().ReverseMap();
            CreateMap<UpdateVideoDto, Video>().ReverseMap();
            CreateMap<ResultVideoDto, Video>().ReverseMap();

            CreateMap<CreateSubHeaderDto, SubHeader>().ReverseMap();
            CreateMap<ResultSubHeaderDto, SubHeader>().ReverseMap();
            CreateMap<UpdateSubHeaderDto, SubHeader>().ReverseMap();


        }
    }
}
