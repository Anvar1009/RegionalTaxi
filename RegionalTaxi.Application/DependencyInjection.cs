using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace RegionalTaxi.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationRegisterService(this IServiceCollection services)
        {

            return services;
        }
    }
}
