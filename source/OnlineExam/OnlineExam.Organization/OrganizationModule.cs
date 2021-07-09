using Autofac;
using OnlineExam.Organization.Contexts;
using OnlineExam.Organization.Repositories;
using OnlineExam.Organization.Services;
using OnlineExam.Organization.UnitOfWorks;

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

            builder.RegisterType<CourseRepository>().As<ICourseRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<TagRepository>().As<ITagRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseService>().As<ICourseService>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseUnitOfWork>().As<ICourseUnitOfWork>()
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseTagRepository>().As<ICourseTagRepository>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
