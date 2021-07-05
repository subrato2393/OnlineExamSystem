using Autofac;
using OnlineExam.Organization.Contexts;

namespace OnlineExam.Organization
{
    public class OrganizationModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public OrganizationModule(string connectionString,string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OrganizationDbContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
