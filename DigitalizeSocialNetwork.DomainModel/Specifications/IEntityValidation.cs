using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalizeSocialNetwork.DomainModel.Specifications
{
    public interface IEntityValidation
    {
        bool IsValid();
    }
}
