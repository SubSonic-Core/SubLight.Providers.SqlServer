namespace SubLight.Sql.SqlServer
{
    internal class SqlServerDialect
        : ISqlDialect
    {
        public string FormatParameterName(string name, int index) => $"@{name}_{index}";

        public string GetLimitOffsetClause(int? offset, int? limit) =>
            $"OFFSET {offset ?? 0} ROWS FETCH NEXT {limit ?? int.MaxValue} ROWS ONLY";

        public string QouteIdentifier(string identifier) => $"[{identifier}]";
    }
}
