using System;
using System.Configuration;
using System.Web;
using DevExpress.ExpressApp.Web;
using WinWebSolution.Module;

namespace WinWebSolution.Web {
    public class Global : System.Web.HttpApplication {
        public Global() {
            InitializeComponent();
        }
        protected void Application_Start(Object sender, EventArgs e) {
            WebApplication.OldStyleLayout = false;
            CodeCentralExampleInMemoryDataStoreProvider.Register();
        }
        protected void Session_Start(Object sender, EventArgs e) {
            WebApplication.SetInstance(Session, new WinWebSolutionAspNetApplication());

            WebApplication.Instance.ConnectionString = CodeCentralExampleInMemoryDataStoreProvider.ConnectionString;

            if (ConfigurationManager.ConnectionStrings["ConnectionString"] != null) {
                WebApplication.Instance.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
DevExpress.ExpressApp.InMemoryDataStoreProvider.Register();
            WebApplication.Instance.ConnectionString = DevExpress.ExpressApp.InMemoryDataStoreProvider.ConnectionString;
            WebApplication.Instance.Setup();
            WebApplication.Instance.Start();
        }
        protected void Application_BeginRequest(Object sender, EventArgs e) {
            string filePath = HttpContext.Current.Request.PhysicalPath;
            if (!string.IsNullOrEmpty(filePath)
                && (filePath.IndexOf("Images") >= 0) && !System.IO.File.Exists(filePath)) {
                HttpContext.Current.Response.End();
            }
        }
        protected void Application_EndRequest(Object sender, EventArgs e) {
        }
        protected void Application_AuthenticateRequest(Object sender, EventArgs e) {
        }
        protected void Application_Error(Object sender, EventArgs e) {
            ErrorHandling.Instance.ProcessApplicationError();
        }
        protected void Session_End(Object sender, EventArgs e) {
            WebApplication.DisposeInstance(Session);
        }
        protected void Application_End(Object sender, EventArgs e) {
        }
        #region Web Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
        }
        #endregion
    }
}
