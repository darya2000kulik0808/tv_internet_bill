using System;
using Services;
using System.Collections.Generic;
using Clients;

namespace ServiceListSource
{
    public interface IServiceSource
    {
        List<Service> GetServices();
    }

    public interface IClient_List
    {
        List<Client> GetClients();
    }
}
