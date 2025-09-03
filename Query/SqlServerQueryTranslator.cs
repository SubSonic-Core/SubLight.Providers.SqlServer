using SubLight.Query;

namespace SubLight.SqlServer.Query
{
    public class SqlServerQueryTranslator
        : SqlQueryTranslatorBase
    {
        public SqlServerQueryTranslator()
            : base(new SqlServerDialect())
        {
        }
    }
}
