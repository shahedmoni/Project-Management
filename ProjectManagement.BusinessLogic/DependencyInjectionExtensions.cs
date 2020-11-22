﻿using Microsoft.Extensions.DependencyInjection;
using ProjectManagement.Repository;

namespace ProjectManagement.BusinessLogic
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IDonorCore, DonorCore>();
            //services.AddTransient<IProjectCore, ProjectCore>();
            services.AddTransient<IProjectBeneficiaryTypeCore, ProjectBeneficiaryTypeCore>();
            services.AddTransient<IProjectSectorCore, ProjectSectorCore>();
            services.AddTransient<IProjectStatusCore, ProjectStatusCore>();
            services.AddTransient<ILocationCore, LocationCore>();
            services.AddTransient<IReportTypeCore, ReportTypeCore>();

            return services;
        }
    }
}