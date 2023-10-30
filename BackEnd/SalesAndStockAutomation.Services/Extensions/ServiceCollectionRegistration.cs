using Microsoft.Extensions.DependencyInjection;
using SalesAndStockAutomation.Base.DB.Helper;
using SalesAndStockAutomation.Repositories.Abstracts;
using SalesAndStockAutomation.Repositories.Concretes;
using SalesAndStockAutomation.Repositories.Helpers;
using SalesAndStockAutomation.Services.Abstracts;
using SalesAndStockAutomation.Services.Concretes;

namespace SalesAndStockAutomation.Services.Extensions;

public static class ServiceCollectionRegistration
{
    public static void LoadMyServices(this IServiceCollection services)
    {
        #region Configurations
        services.AddScoped<NHibernateHelper, DbHelper>();
        #endregion
        #region Repositories
        services.AddScoped<IAuthorityRepository, NHAuthorityRepository>();
        services.AddScoped<ICategoryRepository, NHCategoryRepository>();
        services.AddScoped<ICityRepository, NHCityRepository>();
        services.AddScoped<ICustomerRepository, NHCustomerRepository>();
        services.AddScoped<IEmployeeRepository, NHEmployeeRepository>();
        services.AddScoped<IProductRepository, NHProductRepository>();
        services.AddScoped<ISaleRepository, NHSaleRepository>();
        services.AddScoped<IStockRepository, NHStockRepository>();
        services.AddScoped<IUserAuthorityRepository, NHUserAuthorityRepository>();
        #endregion

        #region Services
        services.AddScoped<IAuthorityService, AuthorityService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICityService, CityService>();
        services.AddScoped<ICustomerService, CustomerService>();
        services.AddScoped<IEmployeeService, EmployeeService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<ISaleService, SaleService>();
        services.AddScoped<IStockService, StockService>();
        services.AddScoped<IUserAuthorityService, UserAuthorityService>();
        #endregion
    }
}
