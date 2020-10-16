using Castle.DynamicProxy;
using Core.Utilities.Interceptors.Autofac;
using Core.Utilities.Ioc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
namespace Core.Aspects.Autofac.Performance
{
    public class PerformanceAspect:MethodInterception
    {
        int _interval;
        Stopwatch _watch;
        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _watch = ServiceTool.serviceProvider.GetService<Stopwatch>();
        }
        public override void OnBefore(IInvocation invocation)
        {
            _watch.Start();
        }
        public override void OnAfter(IInvocation invocation)
        {
            if (_watch.Elapsed.TotalSeconds>_interval)
            {
                Debug.WriteLine($"Performance : {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name} --> {_watch.Elapsed.TotalSeconds}");

            }
            _watch.Reset();
        }
    }
}
