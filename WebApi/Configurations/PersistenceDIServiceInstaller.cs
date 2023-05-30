using System;
using Application.Services;
using Domain.Repositories.BranchRepository;
using Domain.Repositories.CarBranchRepository;
using Domain.Repositories.CarPhotoRepository;
using Domain.Repositories.CarRepository;
using Domain.Repositories.CarRequestRepository;
using Domain.Repositories.CompanyRepository;
using Domain.Repositories.KLogRepository;
using Domain.Repositories.NavigationItemRepository;
using Domain.Repositories.NavigationItemRoleRepository;
using Domain.Repositories.QuestionRepository;
using Domain.Repositories.SurveyQuestionRepository;
using Domain.Repositories.SurveyRepository;
using Domain.Repositories.UserRoleRepository;
using Domain.UnitOfWork;
using Persistence.Repositories.BranchRepository;
using Persistence.Repositories.CarBrancRepository;
using Persistence.Repositories.CarPhotoRepository;
using Persistence.Repositories.CarRepository;
using Persistence.Repositories.CarRequestRepository;
using Persistence.Repositories.CompanyRepository;
using Persistence.Repositories.KLogRepository;
using Persistence.Repositories.NavigationItemRepository;
using Persistence.Repositories.NavigationItemRoleRepository;
using Persistence.Repositories.QuestionRepository;
using Persistence.Repositories.SurveyQuestionRepository;
using Persistence.Repositories.SurveyRepository;
using Persistence.Repositories.UserRoleRepository;
using Persistence.Services;
using Persistence.UnitOfWork;

namespace WebApi.Configurations
{
    public class PersistenceDIServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAppUnitOfWork, AppUnitOfWork>();

            #region Services
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IBranchService, BranchService>();
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<ICarBranchService, CarBranchService>();
            services.AddScoped<ICarPhotoService, CarPhotoService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IKLogService, KLogService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IQuestionService, QuestionService>();
            services.AddScoped<ISurveyQuestionService, SurveyQuestionService>();
            services.AddScoped<ISurveyService, SurveyService>();
            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<ICarRequestService, CarRequestService>();
            services.AddScoped<INavigationItemService, NavigationItemService>();
            services.AddScoped<INavigationItemRoleService, NavigationItemRoleService>();


            #region Repository
            services.AddScoped<IBranchCommandRepository, BranchCommandRepository>();
            services.AddScoped<IBranchQueryRepository, BranchQueryRepository>();
            services.AddScoped<ICarCommandRepository, CarCommandRepository>();
            services.AddScoped<ICarQueryRepository, CarQueryRepository>();
            services.AddScoped<ICarBranchCommandRepository, CarBranchCommandRepository>();
            services.AddScoped<ICarBranchQueryRepository, CarBranchQueryRepository>();
            services.AddScoped<ICarPhotoCommandRepository, CarPhotoCommandRepository>();
            services.AddScoped<ICarPhotoQueryRepository, CarPhotoQueryRepository>();
            services.AddScoped<ICompanyCommandRepository, CompanyCommandRepository>();
            services.AddScoped<ICompanyQueryRepository, CompanyQueryRepository>();
            services.AddScoped<IKLogCommandRepository, KLogCommandRepository>();
            services.AddScoped<IKLogQueryRepository, KLogQueryRepository>();
            services.AddScoped<IQuestionCommandRepository, QuestionCommandRepository>();
            services.AddScoped<IQuestionQueryRepository, QuestionQueryRepository>();
            services.AddScoped<ISurveyQuestionCommandRepository, SurveyQuestionCommandRepository>();
            services.AddScoped<ISurveyQuestionQueryRepository, SurveyQuestionQueryRepository>();
            services.AddScoped<ISurveyCommandRepository, SurveyCommandRepository>();
            services.AddScoped<ISurveyQueryRepository, SurveyQueryRepository>();
            services.AddScoped<IUserRoleCommandRepository, UserRoleCommandRepository>();
            services.AddScoped<ICarRequestCommandRepository, CarRequestCommandRepository>();
            services.AddScoped<ICarRequestQueryRepository, CarRequestQueryRepository>();
            services.AddScoped<INavigationItemCommandRepository, NavigationItemCommandRepository>();
            services.AddScoped<NavigationItemQueryRepository, NavigationItemQueryRepository>();
            services.AddScoped<INavigationItemRoleCommandRepository, NavigationItemRoleCommandRepository>();
            services.AddScoped<INavigationItemRoleQueryRepository, NavigationItemRoleQueryRepository>();
            #endregion
            #endregion
        }
    }
}

