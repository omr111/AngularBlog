using Core.Utilities.Ioc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Extensions
{
  public static  class ServicesCollectionExtentions
    {
        public static IServiceCollection addDependencyResolvers(this IServiceCollection services,ICoreModule[] modules)
        {
            foreach (var module in modules)
            {
                module.load(services);
            }
            return ServiceTool.Create(services);
        }
    }
}
