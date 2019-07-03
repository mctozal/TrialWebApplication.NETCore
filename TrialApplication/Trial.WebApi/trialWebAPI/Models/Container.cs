using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using trialBusiness;
using trialData;

namespace trialWebAPI.Models
{
    public static class Container
    {

        public static void Register(IServiceCollection services, IConfiguration iConfig)
        {
            services.AddSingleton<IUserManager, UserManager>();
            services.AddSingleton<IDataManager, DataManager>();
        }
    }
}
