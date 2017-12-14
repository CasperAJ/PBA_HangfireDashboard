using Hangfire;
using Hangfire.MySql;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HangfireDashboard
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            string connectionString = System.IO.File.ReadAllText(@"C:\Temp\Connect.txt");
            GlobalConfiguration.Configuration.UseStorage(new MySqlStorage(connectionString));
            app.UseHangfireDashboard();
        }
    }
}