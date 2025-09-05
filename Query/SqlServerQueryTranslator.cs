using SubLight.Sql.Query;

namespace SubLight.Sql.SqlServer.Query
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
