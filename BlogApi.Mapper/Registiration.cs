using BlogApi.Application.Interfaces.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlogApi.Mapper
{
    public static class Registiration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<ICustomMapper, AutoMapper.Mapper>();
        }
    }
}
