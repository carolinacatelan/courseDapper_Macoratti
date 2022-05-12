using System.Data;
using Npgsql;

namespace catelanDapper.Data
{
    public class DbSession : IDisposable
    {
        public IDbConnection Connection { get; }

        public DbSession (IConfiguration configuration){
            Connection = new NpgsqlConnection(configuration.GetConnectionString("DefaultConnection"));
            Connection.Open();
        }

        public void Dispose() => Connection?.Dispose();
    
    }
}