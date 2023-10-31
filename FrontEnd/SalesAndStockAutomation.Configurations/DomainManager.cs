using Microsoft.Extensions.Configuration;

namespace SalesAndStockAutomation.Configurations;

public class DomainManager : IDomainService
{
    private IConfiguration _configuration;

    public DomainManager(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public string Domain()
    {
        string host = _configuration.GetSection("Host").Value;
        return host;
    }
}
