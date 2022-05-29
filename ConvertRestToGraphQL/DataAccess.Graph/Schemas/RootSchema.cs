using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Graph.Queries;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess.Graph.Schemas
{
    public class RootSchema : Schema
    {
        public RootSchema(IServiceProvider serviceProvider)
        {
            this.Query = serviceProvider.GetRequiredService<RootQuery>();
        }
    }
}
