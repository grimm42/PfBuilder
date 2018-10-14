using System.Configuration;

namespace PfBuilder.Repository
{
    public static class RepositoryUtil
    {
        public static string LoadConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
        }
    }
}