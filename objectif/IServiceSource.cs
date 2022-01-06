using System;
using Services;
using System.Collections.Generic;

namespace ServiceListSource
{
    public interface IServiceSource
    {
        List<Service> GetServices();
    }
}
