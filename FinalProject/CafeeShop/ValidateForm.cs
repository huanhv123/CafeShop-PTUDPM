using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeeShop
{
    public class ValidateForm : IDataErrorInfo
    {
        [Browsable(false)]
        public string this[string property]
        {
            get
            {
                var propertyDes = TypeDescriptor.GetProperties(this)[property];
                if (propertyDes == null)
                    return string.Empty;
                IList<ValidationResult> validationResults = new List<ValidationResult>();
                var rs = Validator.TryValidateProperty(propertyDes.GetValue(this), new ValidationContext(this, null, null) { MemberName = property }, validationResults);
                if (!rs)
                    return validationResults.First().ErrorMessage;
                return string.Empty;
            }
        }
        [Browsable(false)]
        public string Error
        {
            get
            {
                var valResults = new List<ValidationResult>();
                var rs = Validator.TryValidateObject(this,new ValidationContext(this,null,null),valResults,true);
                if (!rs)
                {
                    foreach(var err in valResults)
                    {
                        string.Join(Environment.NewLine, valResults.Select(e => e.ErrorMessage));
                    }
                }
                return null;
            }
        }
        [Browsable(false)]
        public bool IsValid => string.IsNullOrEmpty(Error);
    }
}
