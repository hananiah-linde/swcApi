using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Database.Postgre.Constants;
internal static class PostgresExtensions
{
    public const string UUIDGenerator = "uuid-ossp";
    public const string UUIDAlgorithm = "uuid_generate_v4()";
}
