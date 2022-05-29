using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Graph.Queries;
using GraphQL.Types;

namespace DataAccess.Graph.Schemas
{
    public class TelemetrySchema : Schema
    {
        public TelemetrySchema(TelemetryQuery query)
        {
            this.Query = query;
        }
    }
}
