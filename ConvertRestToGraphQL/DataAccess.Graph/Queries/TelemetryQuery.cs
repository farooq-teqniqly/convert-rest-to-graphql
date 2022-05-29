using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.EFCore;
using DataAccess.Graph.Types;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Graph.Queries
{
    public class TelemetryQuery : ObjectGraphType
    {
        public TelemetryQuery(TelemetryDbContext dbContext)
        {
            this.FieldAsync<ListGraphType<NonNullGraphType<TelemetryType>>>(
                "telemetry",
                resolve: async _ => await dbContext.Telemetries.ToListAsync());
        }
    }
}
