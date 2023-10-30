using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using SalesAndStockAutomation.Base.DB.Helper;
using System.Reflection;

namespace SalesAndStockAutomation.Repositories.Helpers;

public class DbHelper : NHibernateHelper
{
    private IConfiguration _configuration;
    public DbHelper(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    protected override ISessionFactory InitializeFactory()
    {
        ISessionFactory build = Fluently
            .Configure()
            .Database(PostgreSQLConfiguration.PostgreSQL82.ConnectionString(_configuration.GetConnectionString("PostgreSQL")))
            .Mappings(p => p.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
            .ExposeConfiguration(TreatConfiguraiton).BuildSessionFactory();
        return build;
    }

    private static void TreatConfiguraiton(Configuration configuration)
    {
        SchemaUpdate update = new SchemaUpdate(configuration);
        update.Execute(false, true);
    }
}
