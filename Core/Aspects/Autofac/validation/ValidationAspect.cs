using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validations.fluent;
using Core.Utilities.Interceptors.Autofac;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.validation
{
    public class ValidationAspect:MethodInterception
    {
        private Type _validationType;
        public ValidationAspect(Type validationType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validationType))
            {
                throw new System.Exception("Wrong Validation Type");
            }
            _validationType = validationType;
        }
        public override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validationType);
            var entityType = _validationType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(x => x.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.validate(validator, entity);
            }
        }
    }
}
