using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    /// <summary>
    /// Dagıtıcının verildiği interface. 
    /// </summary>
    public interface ISupplierService
    {
        void GiveMask(Person person);
    }
}
