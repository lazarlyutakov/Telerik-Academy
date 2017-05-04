using ProjectManager.Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ProjectManager.Common.Providers
{

    public class Validator
    {

        public void Validate<T>(T obj) where T : class
        {
            var err = this.GetValidationErrors(obj); if (!(err.Count() == 0))
            {
                throw new UserValidationException(err.First());
            }
        }

        public IEnumerable<string> GetValidationErrors(object obj)
        {
            Type typeOfObject = obj.GetType();
            PropertyInfo[] propertiesOfObject = typeOfObject.GetProperties();
            Type attrType = typeof(ValidationAttribute);

            foreach (var propertyInfo in propertiesOfObject)
            {
                object[] customAttributes = propertyInfo.GetCustomAttributes(attrType, inherit: true);
                foreach (var customAttribute in customAttributes)
                {
                    var validationAttribute = (ValidationAttribute)customAttribute;
                    bool valid = validationAttribute.IsValid(propertyInfo.GetValue(obj, BindingFlags.GetProperty, null, null, null));
                    if (!valid)
                    {
                        yield return validationAttribute.ErrorMessage;
                    }
                }

            }
        }
    }
}