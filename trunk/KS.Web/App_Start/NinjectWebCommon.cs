[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(KS.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(KS.Web.App_Start.NinjectWebCommon), "Stop")]

namespace KS.Web.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    using KS.Core.Model;
    using KS.Core.Interface.Data;
    using KS.Core.Interface.Service;

    using KS.Service.Admin;
    using KS.Service.Base;
    using KS.Service.Quanli;

    using KS.Data;
    using KS.Data.Interface;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InRequestScope();
            kernel.Bind<IDatabaseFactory>().To<DatabaseFactory>().InRequestScope();

            kernel.Bind<IRepository<CHITIETPHIEUDP>>().To<Repository<CHITIETPHIEUDP>>().InRequestScope();
            kernel.Bind<IRepository<DICHVU>>().To<Repository<DICHVU>>().InRequestScope();
            kernel.Bind<IRepository<DOANKHACH>>().To<Repository<DOANKHACH>>().InRequestScope();
            kernel.Bind<IRepository<KHACH>>().To<Repository<KHACH>>().InRequestScope();
            kernel.Bind<IRepository<KHACHCUNGPHONG>>().To<Repository<KHACHCUNGPHONG>>().InRequestScope();
            kernel.Bind<IRepository<LOAIPHONG>>().To<Repository<LOAIPHONG>>().InRequestScope();
            kernel.Bind<IRepository<NHANVIEN>>().To<Repository<NHANVIEN>>().InRequestScope();
            kernel.Bind<IRepository<PHIEUDATPHONG>>().To<Repository<PHIEUDATPHONG>>().InRequestScope();
            kernel.Bind<IRepository<PHIEUDICHVU>>().To<Repository<PHIEUDICHVU>>().InRequestScope();
            kernel.Bind<IRepository<PHIEUTHUETRA>>().To<Repository<PHIEUTHUETRA>>().InRequestScope();
            kernel.Bind<IRepository<PHONG>>().To<Repository<PHONG>>().InRequestScope();
            kernel.Bind<IRepository<USER>>().To<Repository<USER>>().InRequestScope();

            kernel.Bind<IAdminRepository<CHITIETPHIEUDP>>().To<AdminRepository<CHITIETPHIEUDP>>().InRequestScope();
            kernel.Bind<IAdminRepository<DICHVU>>().To<AdminRepository<DICHVU>>().InRequestScope();
            kernel.Bind<IAdminRepository<DOANKHACH>>().To<AdminRepository<DOANKHACH>>().InRequestScope();
            kernel.Bind<IAdminRepository<KHACH>>().To<AdminRepository<KHACH>>().InRequestScope();
            kernel.Bind<IAdminRepository<KHACHCUNGPHONG>>().To<AdminRepository<KHACHCUNGPHONG>>().InRequestScope();
            kernel.Bind<IAdminRepository<LOAIPHONG>>().To<AdminRepository<LOAIPHONG>>().InRequestScope();
            kernel.Bind<IAdminRepository<NHANVIEN>>().To<AdminRepository<NHANVIEN>>().InRequestScope();
            kernel.Bind<IAdminRepository<PHIEUDATPHONG>>().To<AdminRepository<PHIEUDATPHONG>>().InRequestScope();
            kernel.Bind<IAdminRepository<PHIEUDICHVU>>().To<AdminRepository<PHIEUDICHVU>>().InRequestScope();
            kernel.Bind<IAdminRepository<PHIEUTHUETRA>>().To<AdminRepository<PHIEUTHUETRA>>().InRequestScope();
            kernel.Bind<IAdminRepository<PHONG>>().To<AdminRepository<PHONG>>().InRequestScope();
            kernel.Bind<IAdminRepository<USER>>().To<AdminRepository<USER>>().InRequestScope();

            kernel.Bind<IQuanliRepository<CHITIETPHIEUDP>>().To<QuanliRepository<CHITIETPHIEUDP>>().InRequestScope();
            kernel.Bind<IQuanliRepository<DICHVU>>().To<QuanliRepository<DICHVU>>().InRequestScope();
            kernel.Bind<IQuanliRepository<DOANKHACH>>().To<QuanliRepository<DOANKHACH>>().InRequestScope();
            kernel.Bind<IQuanliRepository<KHACH>>().To<QuanliRepository<KHACH>>().InRequestScope();
            kernel.Bind<IQuanliRepository<KHACHCUNGPHONG>>().To<QuanliRepository<KHACHCUNGPHONG>>().InRequestScope();
            kernel.Bind<IQuanliRepository<LOAIPHONG>>().To<QuanliRepository<LOAIPHONG>>().InRequestScope();
            kernel.Bind<IQuanliRepository<NHANVIEN>>().To<QuanliRepository<NHANVIEN>>().InRequestScope();
            kernel.Bind<IQuanliRepository<PHIEUDATPHONG>>().To<QuanliRepository<PHIEUDATPHONG>>().InRequestScope();
            kernel.Bind<IQuanliRepository<PHIEUDICHVU>>().To<QuanliRepository<PHIEUDICHVU>>().InRequestScope();
            kernel.Bind<IQuanliRepository<PHIEUTHUETRA>>().To<QuanliRepository<PHIEUTHUETRA>>().InRequestScope();
            kernel.Bind<IQuanliRepository<PHONG>>().To<QuanliRepository<PHONG>>().InRequestScope();
            kernel.Bind<IQuanliRepository<USER>>().To<QuanliRepository<USER>>().InRequestScope();

            kernel.Bind<ICHITIETPHIEUDPService>().To<CHITIETPHIEUDPService>().InRequestScope();
            kernel.Bind<IDICHVUService>().To<DICHVUService>().InRequestScope();
            kernel.Bind<IDOANKHACHService>().To<DOANKHACHService>().InRequestScope();
            kernel.Bind<IKHACHCUNGPHONGService>().To<KHACHCUNGPHONGService>().InRequestScope();
            kernel.Bind<IKHACHService>().To<KHACHService>().InRequestScope();
            kernel.Bind<ILOAIPHONGService>().To<LOAIPHONGService>().InRequestScope();
            kernel.Bind<INHANVIENService>().To<NHANVIENService>().InRequestScope();
            kernel.Bind<IPHIEUDATPHONGService>().To<PHIEUDATPHONGService>().InRequestScope();
            kernel.Bind<IPHIEUDICHVUService>().To<PHIEUDICHVUService>().InRequestScope();
            kernel.Bind<IPHIEUTHUETRAService>().To<PHIEUTHUETRAService>().InRequestScope();
            kernel.Bind<IPHONGService>().To<PHONGSevice>().InRequestScope();
            kernel.Bind<IUSERService>().To<USERService>().InRequestScope();

            kernel.Bind<IAdminCHITIETPHIEUDPService>().To<AdminCHITIETPHIEUDPService>().InRequestScope();
            kernel.Bind<IAdminDICHVUService>().To<AdminDICHVUService>().InRequestScope();
            kernel.Bind<IAdminDOANKHACHService>().To<AdminDOANKHACHService>().InRequestScope();
            kernel.Bind<IAdminKHACHCUNGPHONGService>().To<AdminKHACHCUNGPHONGService>().InRequestScope();
            kernel.Bind<IAdminKHACHService>().To<AdminKHACHService>().InRequestScope();
            kernel.Bind<IAdminLOAIPHONGService>().To<AdminLOAIPHONGService>().InRequestScope();
            kernel.Bind<IAdminNHANVIENService>().To<AdminNHANVIENService>().InRequestScope();
            kernel.Bind<IAdminPHIEUDATPHONGService>().To<AdminPHIEUDATPHONGService>().InRequestScope();
            kernel.Bind<IAdminPHIEUDICHVUService>().To<AdminPHIEUDICHVUService>().InRequestScope();
            kernel.Bind<IAdminPHIEUTHUETRAService>().To<AdminPHIEUTHUETRAService>().InRequestScope();
            kernel.Bind<IAdminPHONGService>().To<AdminPHONGService>().InRequestScope();
            kernel.Bind<IAdminUSERSevice>().To<AdminUSERService>().InRequestScope();

            kernel.Bind<IQuanliCHITIETPHIEUDICHVUService>().To<QuanliCHITIETPHIEUDPService>().InRequestScope();
            kernel.Bind<IQuanliDICHVUService>().To<QuanliDICHVUService>().InRequestScope();
            kernel.Bind<IQuanliDOANKHACHService>().To<QuanliDOANKHACHService>().InRequestScope();
            kernel.Bind<IQuanliKHACHCUNGPHONGService>().To<QuanliKHACHCUNGPHONGService>().InRequestScope();
            kernel.Bind<IQuanliKHACHService>().To<QuanliKHACHService>().InRequestScope();
            kernel.Bind<IQuanliLOAIPHONGService>().To<QuanliLOAIPHONGService>().InRequestScope();
            kernel.Bind<IQuanliNHANVIENService>().To<QuanliNHANVIENService>().InRequestScope();
            kernel.Bind<IQuanliPHIEUDATPHONGService>().To<QuanliPHIEUDATPHONGService>().InRequestScope();
            kernel.Bind<IQuanliPHIEUDICHVUService>().To<QuanliPHIEUDICHVUService>().InRequestScope();
            kernel.Bind<IQuanliPHIEUTHUETRAService>().To<QuanliPHIEUTHUETRAService>().InRequestScope();
            kernel.Bind<IQuanliPHONGService>().To<QuanliPHONGService>().InRequestScope();
            kernel.Bind<IQuanliUSERService>().To<QuanliUSERService>().InRequestScope();
        }        
    }
}
