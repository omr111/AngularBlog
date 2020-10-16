using Castle.DynamicProxy;
using Castle.DynamicProxy.Contributors;
using Core.Utilities.Interceptors.Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Core.Aspects.Autofac.Transaction
{
   public class TransactionAspect:MethodInterception
    {
        public override void Intercept(IInvocation invocation)
        {
            using (var transaction =new TransactionScope())
            {
                try
                {
                    invocation.Proceed();
                    transaction.Complete();
                }
                catch (System.Exception)
                {
                    transaction.Dispose();
                    throw;
                }

            }
        }
    }
}
