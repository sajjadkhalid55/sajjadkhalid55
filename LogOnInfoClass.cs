using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.IO;


namespace POS
{
    class LogOnInfoClass
    {

        String str = POS.Properties.Settings.Default.connectionString;




        public static void setLogonInfo(ReportDocument c)
        {
            foreach (Table t in c.Database.Tables)
            {
                TableLogOnInfo tloi = new TableLogOnInfo(t.LogOnInfo);
                LogOnInfoClass obj=new LogOnInfoClass();


                tloi.ConnectionInfo.ServerName = ".\\SQLEXPRESS";
                tloi.ConnectionInfo.DatabaseName = "MSF";



                // tloi.ConnectionInfo.IntegratedSecurity = true;


                //tloi.ConnectionIUserID = "sa";
                //tloi.ConnectionInfo.Password = "1234";


                t.ApplyLogOnInfo(tloi);

            }
            //foreach (ReportDocument sub in c.Subreports)
            //{
            //    setLogonInfo(sub);
            //}
             }



        internal static void setLogonInfo(CrystalDecisions.ReportAppServer.ReportDefModel.ReportDocument rd)
        {
            throw new NotImplementedException();
        }
    }
}
