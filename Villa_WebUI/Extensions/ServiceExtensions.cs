using Villa_Businesss.Abstract;
using Villa_Businesss.Concrete;
using Villa_DataAccess.Abstract;
using Villa_DataAccess.EntityFramework;
using Villa_DataAccess.Repositories;

namespace Villa_WebUI.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServiceExtensions(this IServiceCollection Services)
        {
            Services.AddScoped<IBannerDal, EfBannerDal>(); //IbannerDal gördüğü yerde efbannerdal'dan  örnekle
            Services.AddScoped<IBannerService, BannerManager>();

            Services.AddScoped<IContactDal, EfContactDal>();
            Services.AddScoped<IContactService, ContactManager>();

            Services.AddScoped<ICounterDal, EfCounterDal>();
            Services.AddScoped<ICounterService, CounterManager>();

            Services.AddScoped<IDealDal, EfDealDal>();
            Services.AddScoped<IDealService, DealManager>();

            Services.AddScoped<IFeatureDal, EfFeatureDal>();
            Services.AddScoped<IFeatureService, FeatureManager>();

            Services.AddScoped<IMessageDal, EfMessageDal>();
            Services.AddScoped<IMessageService, MessageManager>();

            Services.AddScoped<IProductDal, EfProductDal>();
            Services.AddScoped<IProductService, ProductManager>();

            Services.AddScoped<IQuestDal, EfQuestDal>();
            Services.AddScoped<IQuestService, QuestManager>();

            Services.AddScoped<IVideoDal, EfVideoDal>();
            Services.AddScoped<IVideoService, VideoManager>();

            Services.AddScoped<ISubHeaderDal, EfSubHeaderDal>();
            Services.AddScoped<ISubHeaderService, SubHeaderManager>();

            Services.AddScoped(typeof(IGenericDal<>), typeof(GenericRepository<>));
            Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

        }
    }
}
