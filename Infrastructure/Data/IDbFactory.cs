namespace Infrastructure.Data
{
    public interface IDbFactory
    {
        HrmsDatabaseContext Get();
    }
}