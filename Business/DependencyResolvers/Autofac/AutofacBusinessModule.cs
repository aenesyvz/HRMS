using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CityManager>().As<ICityService>();
            builder.RegisterType<EfCityDal>().As<ICityDal>();

            builder.RegisterType<EmployerManager>().As<IEmployerService>();
            builder.RegisterType<EfEmployerDal>().As<IEmployerDal>();

            builder.RegisterType<ExperienceManager>().As<IExperienceService>();
            builder.RegisterType<EfExperiemceDal>().As<IExperienceDal>();

            builder.RegisterType<JobAdvertisementManager>().As<IJobAdvertisementService>();
            builder.RegisterType<EfJobAdvertisementDal>().As<IJobAdvertisementDal>();

            builder.RegisterType<JobSeekerManager>().As<IJobSeekerService>();
            builder.RegisterType<EfJobSeekerDal>().As<IJobSeekerDal>();

            builder.RegisterType<JobPositionManager>().As<IJobPositionService>();
            builder.RegisterType<EfJobPositionDal>().As<IJobPositionDal>();

            builder.RegisterType<LanguageManager>().As<ILanguageService>();
            builder.RegisterType<EfLanguageDal>().As<ILanguageDal>();

            builder.RegisterType<LetterManager>().As<ILetterService>();
            builder.RegisterType<EfLetterDal>().As<ILetterDal>();

            builder.RegisterType<SchoolManager>().As<ISchoolService>();
            builder.RegisterType<EfSchoolDal>().As<ISchoolDal>();

            builder.RegisterType<SocialMediaManager>().As<ISocialMediaService>();
            builder.RegisterType<EfSocialMediaDal>().As<ISocialMediaDal>();

            builder.RegisterType<WorkingTimeManager>().As<IWorkingTimeService>();
            builder.RegisterType<EfWorkingTimeDal>().As<IWorkingTimeDal>();

            builder.RegisterType<WorkingTypeManager>().As<IWorkingTypeService>();
            builder.RegisterType<EfWorkingTypeDal>().As<IWorkingTypeDal>();

            builder.RegisterType<ProgramingLanguageManager>().As<IProgramingLanguageService>();
            builder.RegisterType<EfProgramingLanguageDal>().As<IProgramingLanguageDal>();

            builder.RegisterType<JobApplicationManager>().As<IJobApplicationService>();
            builder.RegisterType<EfJobApplicationDal>().As<IJobApplicationDal>();

            builder.RegisterType<StaffManager>().As<IStaffService>();
            builder.RegisterType<EfStaffDal>().As<IStaffDal>();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();

            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IOperationClaimDal>();

            builder.RegisterType<AuthManager>().As<IAuthService>();
            
            
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces().EnableInterfaceInterceptors(new ProxyGenerationOptions()
            {
                Selector = new AspectInterceptorSelector()
            }).SingleInstance();
        }
    }
}
