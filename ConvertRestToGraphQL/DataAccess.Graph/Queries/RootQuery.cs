using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Types;

namespace DataAccess.Graph.Queries
{
    public class RootQuery : ObjectGraphType
    {
        public RootQuery()
        {
            this.Field<TelemetryQuery>("telemetryQuery", resolve: _ => new { });
        }
    }
}
