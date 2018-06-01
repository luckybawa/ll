using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace nsuncarte
{
    #region interfaces

    public interface intcat
    {
        Int32 catcod
        {
            get;
            set;
        }
        string catnam
        {
            get;
            set;
        }
        string catban
        {
            get;
            set;
        }
    }
    public interface intsubcat
    {
        Int32 subcatcod
        {
            get;
            set;
        }
        string subcatnam
        {
            get;
            set;
        }
        Int32 subcatcatcod
        {
            get;
            set;
        }
    }
    public interface intprd
    {
        Int32 prdcod
        {
            get;
            set;
        }
        string prdtit
        {
            get;
            set;
        }
        string prddsc
        {
            get;
            set;
        }
        DateTime prdreldat
        {
            get;
            set;
        }
        Int32 prdsubcatcod
        {
            get;
            set;
        }
        float prdmrkprc
        {
            get;
            set;
        }
        Int32 prdmanpiccod
        {
            get;
            set;
        }

    }
    public interface intprdpic
    {
        Int32 prdpiccod
        {
            get;
            set;
        }
        Int32 prdpicprdcod
        {
            get;
            set;
        }
        string prdpicpic
        {
            get;
            set;
        }
        string prdpicdsc
        {
            get;
            set;
        }
    }
    public interface intprdspc
    {
        Int32 prdspccod
        {
            get;
            set;
        }
        Int32 prdspcprdcod
        {
            get;
            set;
        }
        string prdspctit
        {
            get;
            set;
        }
        string prdspcdsc
        {
            get;
            set;
        }
    }
    public interface intexp
    {
        Int32 expcod
        {
            get;
            set;
        }
        string expnam
        {
            get;
            set;
        }
        string expprf
        {
            get;
            set;
        }
        string exppic
        {
            get;
            set;
        }
        Int32 expcatcod
        {
            get;
            set;
        }
        Int32 expusrcod
        {
            get;
            set;
        }
    }
    public interface intusr
    {
        Int32 usrcod
        {
            get;
            set;
        }
        string usreml
        {
            get;
            set;
        }
        string usrpwd
        {
            get;
            set;
        }
        DateTime usrregdat
        {
            get;
            set;
        }
        char usrrol
        {
            get;
            set;
        }
    }
    public interface intprdrev
    {
        Int32 prdrevcod
        {
            get;
            set;
        }
        Int32 prdrevprdcod
        {
            get;
            set;
        }
        Int32 prdrevexpcod
        {
            get;
            set;
        }
        DateTime prdrevdat
        {
            get;
            set;
        }
        string prdrevtit
        {
            get;
            set;
        }
        string prdrevdsc
        {
            get;
            set;
        }


    }
    public interface intsel
    {
        Int32 selcod
        {
            get;
            set;
        }
        string selnam
        {
            get;
            set;
        }
        string sellog
        {
            get;
            set;
        }
        string seltrm
        {
            get;
            set;
        }
    }
    public interface intselprd
    {
        Int32 selprdcod
        {
            get;
            set;
        }
        Int32 selprdprdcod
        {
            get;
            set;
        }
        Int32 selprdselcod
        {
            get;
            set;
        }
        float selprdprc
        {
            get;
            set;
        }
        string selprdlnk
        {
            get;
            set;
        }

    }
    #endregion



    #region property classes

    public class clscatprp : intcat
    {

        private Int32 pcatcod;
        private string pcatnam,pcatban;

        public int catcod
        {
            get
            {
                return pcatcod;
            }
            set
            {
                pcatcod = value;
            }
        }

        public string catnam
        {
            get
            {
                return pcatnam;
            }
            set
            {
                pcatnam = value;
            }
        }

        public string catban
        {
            get
            {
                return pcatban;
            }
            set
            {
                pcatban = value;
            }
        }
    }
    public class clssubcatprp : intsubcat
    {
       private Int32 psubcatcod, psubcatcatcod;
       private string psubcatnam;

        public int subcatcod
        {
            get
            {
                return psubcatcod;

            }
            set
            {
                psubcatcod = value;
            }
        }

        public string subcatnam
        {
            get
            {
                return psubcatnam;
            }
            set
            {
                psubcatnam = value;
            }
        }

        public int subcatcatcod
        {
            get
            {
                return psubcatcatcod;
            }
            set
            {
                psubcatcatcod = value;
            }
        }
    }
    public class clsprdprp : intprd
    {
        private Int32 pprdcod, pprdsubcatcod, pprdmanpiccod;
        private  string pprdtit, pprddsc;
        private   DateTime pprdreldat;
        private float pprdmrkprc;

        public int prdcod
        {
            get
            {
                return pprdcod;
            }
            set
            {
                pprdcod = value;
            }
        }

        public string prdtit
        {
            get
            {
                return pprdtit;
            }
            set
            {
                pprdtit = value;
            }
        }

        public string prddsc
        {
            get
            {
                return pprddsc;
            }
            set
            {
                pprddsc = value;
            }
        }

        public DateTime prdreldat
        {
            get
            {
                return pprdreldat;
            }
            set
            {
                pprdreldat = value;
            }
        }

        public int prdsubcatcod
        {
            get
            {
                return pprdsubcatcod;
            }
            set
            {
                pprdsubcatcod = value;
            }
        }

        public float prdmrkprc
        {
            get
            {
                return pprdmrkprc;
            }
            set
            {
                pprdmrkprc = value;
            }
        }

        public int prdmanpiccod
        {
            get
            {
                return pprdmanpiccod;
            }
            set
            {
                pprdmanpiccod = value;
            }
        }
    }
    public class clsprdpicprp : intprdpic
    {
        private Int32 pprdpiccod,pprdpicprdcod;
        private string pprdpicpic,pprdpicdsc;

        public int prdpiccod
        {
            get
            {
                return pprdpiccod;
            }
            set
            {
                pprdpiccod = value;
            }
        }

        public int prdpicprdcod
        {
            get
            {
                return pprdpicprdcod;
            }
            set
            {
                pprdpicprdcod = value;
            }
        }

        public string prdpicpic
        {
            get
            {
                return pprdpicpic;
            }
            set
            {
                pprdpicpic = value;
            }
        }

        public string prdpicdsc
        {
            get
            {
                return pprdpicdsc;
            }
            set
            {
                pprdpicdsc = value;
            }
        }
    }
    public class clsprdspcprp : intprdspc
    {
      private  Int32 pprdspccod,pprdspcprdcod;
      private  string pprdspctit,pprdspcdsc;
        public int prdspccod
        {
            get
            {
                return pprdspccod;
            }
            set
            {
                pprdspccod = value;
            }
        }

        public int prdspcprdcod
        {
            get
            {
                return pprdspcprdcod;
            }
            set
            {
                pprdspcprdcod = value;
            }
        }

        public string prdspctit
        {
            get
            {
                return pprdspctit;
            }
            set
            {
                pprdspctit = value;
            }
        }

        public string prdspcdsc
        {
            get
            {
                return pprdspcdsc;
            }
            set
            {
                pprdspcdsc = value;
            }
        }
    }
    public class clsexpprp : intexp
    {
       private Int32 pexpcod, pexpcatcod, pexpusrcod;
       private  string pexpnam, pexpprf, pexppic;
        public int expcod
        {
            get
            {
                return pexpcod;
            }
            set
            {
                pexpcod = value;
            }
        }

        public string expnam
        {
            get
            {
                return pexpnam;
            }
            set
            {
                pexpnam = value;
            }
        }

        public string expprf
        {
            get
            {
                return pexpprf;
            }
            set
            {
                pexpprf = value;
            }
        }

        public string exppic
        {
            get
            {
                return pexppic;
            }
            set
            {
                pexppic = value;
            }
        }

        public int expcatcod
        {
            get
            {
                return pexpcatcod;
            }
            set
            {
                pexpcatcod = value;
            }
        }

        public int expusrcod
        {
            get
            {
                return pexpusrcod;
            }
            set
            {
                pexpusrcod = value;
            }
        }
    }
    public class clsusrprp : intusr
    {
        private Int32 pusrcod;
        private  string pusreml,pusrpwd;
        DateTime pusrregdat;
        private char pusrrol;


        public int usrcod
        {
            get
            {
                return pusrcod;
            }
            set
            {
                pusrcod = value;
            }
        }

        public string usreml
        {
            get
            {
                return pusreml;
            }
            set
            {
                pusreml = value;
            }
        }

        public string usrpwd
        {
            get
            {
                return pusrpwd;
            }
            set
            {
                pusrpwd = value;
            }
        }

        public DateTime usrregdat
        {
            get
            {
                return pusrregdat;
            }
            set
            {
                pusrregdat = value;
            }
        }

        public char usrrol
        {
            get
            {
                return pusrrol;
            }
            set
            {
                pusrrol = value;
            }
        }
    }
    public class clsprdrevprp : intprdrev
    {
       private Int32 pprdrevcod, pprdrevprdcod, pprdrevexpcod;
       private DateTime pprdrevdat;
       private string pprdrevtit,pprdrevdsc;

        public int prdrevcod
        {
            get
            {
                return pprdrevcod;
            }
            set
            {
                pprdrevcod = value;
            }
        }

        public int prdrevprdcod
        {
            get
            {
                return pprdrevprdcod;
            }
            set
            {
                pprdrevprdcod = value;
            }
        }

        public int prdrevexpcod
        {
            get
            {
                return pprdrevexpcod;
            }
            set
            {
                pprdrevexpcod = value;
            }
        }

        public DateTime prdrevdat
        {
            get
            {
                return pprdrevdat;
            }
            set
            {
                pprdrevdat = value;
            }
        }

        public string prdrevtit
        {
            get
            {
                return pprdrevtit;
            }
            set
            {
                pprdrevtit = value;
            }
        }

        public string prdrevdsc
        {
            get
            {
                return pprdrevdsc;
            }
            set
            {
                pprdrevdsc = value;
            }
        }
    }
    public class clsselprp : intsel
    {
       private  Int32 pselcod;
       private string pselnam, psellog, pseltrm;
        public int selcod
        {
            get
            {
                return pselcod;
            }
            set
            {
                pselcod = value;
            }
        }

        public string selnam
        {
            get
            {
                return pselnam;
            }
            set
            {
                pselnam = value;
            }
        }

        public string sellog
        {
            get
            {
                return psellog;
            }
            set
            {
                psellog = value;
            }
        }

        public string seltrm
        {
            get
            {
                return pseltrm;
            }
            set
            {
                pseltrm = value;
            }
        }
    }
    public class clsselprdprp : intselprd
    {
       private Int32 pselprdcod, pselprdprdcod, pselprdselcod;
       private float pselprdprc;
       private string pselprdlnk;
        public int selprdcod
        {
            get
            {
                return pselprdcod;
            }
            set
            {
                pselprdcod = value;
            }
        }

        public int selprdprdcod
        {
            get
            {
                return pselprdprdcod;
            }
            set
            {
                pselprdprdcod = value;
            }
        }

        public int selprdselcod
        {
            get
            {
                return pselprdselcod;
            }
            set
            {
                pselprdselcod = value;
            }
        }

        public float selprdprc
        {
            get
            {
                return pselprdprc;
            }
            set
            {
                pselprdprc = value;
            }
        }

        public string selprdlnk
        {
            get
            {
                return pselprdlnk;
            }
            set
            {
                pselprdlnk = value;
            }
        }
    }

    #endregion
    #region connection class
    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }
    #endregion
    #region main classes
    public class clscat : clscon
    {
        public Int32 save_rec(clscatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inscat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catnam", SqlDbType.VarChar, 100).Value = p.catnam;
            cmd.Parameters.Add("@catban", SqlDbType.VarChar, 100).Value = p.catban;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction =
                ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void upd_rec(clscatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = p.catcod;
            cmd.Parameters.Add("@catnam", SqlDbType.VarChar, 100).Value = p.catnam;
            cmd.Parameters.Add("@catban", SqlDbType.VarChar, 100).Value = p.catban;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clscatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = p.catcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clscatprp> dsp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clscatprp> obj = new List<clscatprp>();
            while (dr.Read())
            {
                clscatprp x = new clscatprp();
                x.catcod = Convert.ToInt32(dr[0]);
                x.catnam = dr[1].ToString();
                x.catban = dr[2].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clscatprp> fnd_rec(Int32 catcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = catcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clscatprp> obj = new List<clscatprp>();
            if(dr.HasRows)
            {
                dr.Read();
                clscatprp x = new clscatprp();
                x.catcod = Convert.ToInt32(dr[0]);
                x.catnam = dr[1].ToString();
                x.catban = dr[2].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clssubcat : clscon
    {
        public void save_rec(clssubcatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("inssubcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subcatnam", SqlDbType.VarChar, 100).Value = p.subcatnam;
            cmd.Parameters.Add("@subcatcatcod", SqlDbType.Int).Value = p.subcatcatcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void upd_rec(clssubcatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updsubcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subcatcod", SqlDbType.Int).Value = p.subcatcod;
            cmd.Parameters.Add("@subcatnam", SqlDbType.VarChar, 100).Value = p.subcatnam;
            cmd.Parameters.Add("@subcatcatcod", SqlDbType.Int).Value = p.subcatcatcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clssubcatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delsubcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subcatcod", SqlDbType.Int).Value = p.subcatcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clssubcatprp> dsp_rec(Int32 catcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspsubcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = catcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clssubcatprp> obj = new List<clssubcatprp>();
            while (dr.Read())
            {
                clssubcatprp x = new clssubcatprp();
                x.subcatcod = Convert.ToInt32(dr[0]);
                x.subcatnam = dr[1].ToString();
                x.subcatcatcod = Convert.ToInt32(dr[2]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clssubcatprp> fnd_rec(Int32 subcatcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndsubcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subcatcod", SqlDbType.Int).Value = subcatcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clssubcatprp> obj = new List<clssubcatprp>();
           if(dr.HasRows)
            {
                dr.Read();
                clssubcatprp x = new clssubcatprp();
                x.subcatcod = Convert.ToInt32(dr[0]);
                x.subcatnam = dr[1].ToString();
                x.subcatcatcod = Convert.ToInt32(dr[2]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsprd : clscon
    {
        public DataSet dspprddet(Int32 pcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dspprddet", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@pcod", SqlDbType.Int)
                .Value = pcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet srcprdbycat(Int32 subcatcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("srcprdbycat", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@subcatcod", SqlDbType.Int)
                .Value = subcatcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet dspprdrev(Int32 pcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dspprdrevdet", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@pcod", SqlDbType.Int)
                .Value = pcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet srcprdbytit(String tit)
        {
            SqlDataAdapter adp = new SqlDataAdapter("srcprdbytit", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@tit", SqlDbType.VarChar,200)
                .Value = tit;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
        public DataSet ltsprd()
        {
            SqlDataAdapter adp = new SqlDataAdapter("ltsprd", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public DataSet dspprdforrev(Int32 expcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dspprdforrev", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
          adp.SelectCommand.Parameters.Add("@expcod", SqlDbType.Int).Value =
                expcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public DataSet srcprd(Int32 subcatcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("srcprd", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@subcatcod", SqlDbType.Int).Value 
                = subcatcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }


        public void updmanpic(clsprdprp p)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("updmanpic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdcod", SqlDbType.Int).Value = p.prdcod;
            cmd.Parameters.Add("@piccod", SqlDbType.Int).Value = p.prdmanpiccod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }


        public Int32 save_rec(clsprdprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdtit", SqlDbType.VarChar, 200).Value = p.prdtit;
            cmd.Parameters.Add("@prddsc", SqlDbType.NVarChar, 2000).Value = p.prddsc;
            cmd.Parameters.Add("@prdreldat", SqlDbType.DateTime).Value = p.prdreldat;
            cmd.Parameters.Add("@prdsubcatcod", SqlDbType.Int).Value = p.prdsubcatcod;
            cmd.Parameters.Add("@prdmrkprc", SqlDbType.Float).Value = p.prdmrkprc;
            //     cmd.Parameters.Add("@prdmanpiccod", SqlDbType.Int).Value = p.prdmanpiccod;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection
                                                .ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void upd_rec(clsprdprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdcod", SqlDbType.Int).Value = p.prdcod;
            cmd.Parameters.Add("@prdtit", SqlDbType.VarChar, 200).Value = p.prdtit;
            cmd.Parameters.Add("@prddsc", SqlDbType.NVarChar, 2000).Value = p.prddsc;
            cmd.Parameters.Add("@prdreldat", SqlDbType.DateTime).Value = p.prdreldat;
            cmd.Parameters.Add("@prdsubcatcod", SqlDbType.Int).Value = p.prdsubcatcod;
            cmd.Parameters.Add("@prdmrkprc", SqlDbType.Float).Value = p.prdmrkprc;
         //   cmd.Parameters.Add("@prdmanpiccod", SqlDbType.Int).Value = p.prdmanpiccod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clsprdprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdcod", SqlDbType.Int).Value = p.prdcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsprdprp> dsp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprdprp> obj = new List<clsprdprp>();
            while (dr.Read())
            {
                clsprdprp x = new clsprdprp();
                x.prdcod = Convert.ToInt32(dr[0]);
                x.prdtit = dr[1].ToString();
                x.prddsc = dr[2].ToString();
                x.prdreldat=Convert.ToDateTime(dr[3]);
                x.prdsubcatcod = Convert.ToInt32(dr[4]);
                x.prdmrkprc = Convert.ToSingle(dr[5]);
                x.prdmanpiccod = Convert.ToInt32(dr[6]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsprdprp> fnd_rec(Int32 prdcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdcod",SqlDbType.Int).Value = prdcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprdprp> obj = new List<clsprdprp>();
            if(dr.HasRows)
            {
                dr.Read();
                clsprdprp x = new clsprdprp();
                x.prdcod = Convert.ToInt32(dr[0]);
                x.prdtit = dr[1].ToString();
                x.prddsc = dr[2].ToString();
                x.prdreldat = Convert.ToDateTime(dr[3]);
                x.prdsubcatcod = Convert.ToInt32(dr[4]);
                x.prdmrkprc = Convert.ToSingle(dr[5]);
                x.prdmanpiccod = Convert.ToInt32(dr[6]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }

    }
    public class clsprdpic : clscon
    {
        public Int32 save_rec(clsprdpicprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insprdpic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdpicprdcod", SqlDbType.Int).Value = p.prdpicprdcod;
            cmd.Parameters.Add("@prdpicpic", SqlDbType.VarChar, 100).Value = p.prdpicpic;
            cmd.Parameters.Add("@prdpicdsc", SqlDbType.VarChar, 1000).Value = p.prdpicdsc;
 cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection
                                              .ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void upd_rec(clsprdpicprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updprdpic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdpiccod", SqlDbType.Int).Value = p.prdpiccod;
            cmd.Parameters.Add("@prdpicprdcod", SqlDbType.Int).Value = p.prdpicprdcod;
            cmd.Parameters.Add("@prdpicpic", SqlDbType.VarChar, 100).Value = p.prdpicpic;
            cmd.Parameters.Add("@prdpicdsc", SqlDbType.VarChar, 1000).Value = p.prdpicdsc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clsprdpicprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delprdpic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdpiccod", SqlDbType.Int).Value = p.prdpiccod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsprdpicprp> dsp_rec(Int32 prdcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspprdpic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdcod", SqlDbType.Int).Value = prdcod;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprdpicprp> obj = new List<clsprdpicprp>();
            while (dr.Read())
            {
                clsprdpicprp x = new clsprdpicprp();
                x.prdpiccod = Convert.ToInt32(dr[0]);
                x.prdpicprdcod = Convert.ToInt32(dr[1]);
                x.prdpicpic = dr[2].ToString();
                x.prdpicdsc = dr[3].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsprdpicprp> fnd_rec(Int32 prdpiccod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndprdpic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdpiccod", SqlDbType.Int).Value = prdpiccod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprdpicprp> obj = new List<clsprdpicprp>();
            if(dr.HasRows)
            {
                dr.Read();
                clsprdpicprp x = new clsprdpicprp();
                x.prdpiccod = Convert.ToInt32(dr[0]);
                x.prdpicprdcod = Convert.ToInt32(dr[1]);
                x.prdpicpic = dr[2].ToString();
                x.prdpicdsc = dr[3].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsprdspc : clscon
    {
        public void save_rec(clsprdspcprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insprdspc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdspcprdcod", SqlDbType.Int).Value = p.prdspcprdcod;
            cmd.Parameters.Add("@prdspctit", SqlDbType.VarChar, 200).Value = p.prdspctit;
            cmd.Parameters.Add("@prdspcdsc", SqlDbType.VarChar, 2000).Value = p.prdspcdsc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void upd_rec(clsprdspcprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updprdspc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdspccod", SqlDbType.Int).Value = p.prdspccod;
            cmd.Parameters.Add("@prdspcprdcod", SqlDbType.Int).Value = p.prdspcprdcod;
            cmd.Parameters.Add("@prdspctit", SqlDbType.VarChar, 200).Value = p.prdspctit;
            cmd.Parameters.Add("@prdspcdsc", SqlDbType.VarChar, 2000).Value = p.prdspcdsc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clsprdspcprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delprdspc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdspccod", SqlDbType.Int).Value = p.prdspccod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsprdspcprp> dsp_rec(Int32 prdcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspprdspc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdcod", SqlDbType.Int).Value = prdcod;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprdspcprp> obj = new List<clsprdspcprp>();
            while (dr.Read())
            {
                clsprdspcprp x = new clsprdspcprp();
                x.prdspccod = Convert.ToInt32(dr[0]);
                x.prdspcprdcod = Convert.ToInt32(dr[1]);
                x.prdspctit = dr[2].ToString();
                x.prdspcdsc = dr[3].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsprdspcprp> fnd_rec(Int32 prdspccod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndprdspc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdspccod", SqlDbType.Int).Value = prdspccod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprdspcprp> obj = new List<clsprdspcprp>();
            if(dr.HasRows)
            {
                dr.Read();
                clsprdspcprp x = new clsprdspcprp();
                x.prdspccod = Convert.ToInt32(dr[0]);
                x.prdspcprdcod = Convert.ToInt32(dr[1]);
                x.prdspctit = dr[2].ToString();
                x.prdspcdsc = dr[3].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsexp : clscon
    {
        public Int32 save_rec(clsexpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insexp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@expnam", SqlDbType.VarChar, 100).Value = p.expnam;
            cmd.Parameters.Add("@expprf", SqlDbType.VarChar, 1000).Value = p.expprf;
            cmd.Parameters.Add("@exppic", SqlDbType.VarChar, 50).Value = p.exppic;
            cmd.Parameters.Add("@expcatcod", SqlDbType.Int).Value = p.expcatcod;
            cmd.Parameters.Add("@expusrcod", SqlDbType.Int).Value = p.expusrcod;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void upd_rec(clsexpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updexp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@expcod", SqlDbType.Int).Value = p.expcod;
            cmd.Parameters.Add("@expnam", SqlDbType.VarChar, 100).Value = p.expnam;
            cmd.Parameters.Add("@expprf", SqlDbType.VarChar, 1000).Value = p.expprf;
            cmd.Parameters.Add("@exppic", SqlDbType.VarChar, 50).Value = p.exppic;
            cmd.Parameters.Add("@expcatcod", SqlDbType.Int).Value = p.expcatcod;
            cmd.Parameters.Add("@expusrcod", SqlDbType.Int).Value = p.expusrcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clsexpprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delexp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@expcod", SqlDbType.Int).Value = p.expcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsexpprp> dsp_rec(Int32 cod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspexp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Value = cod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsexpprp> obj = new List<clsexpprp>();
            while (dr.Read())
            {
                clsexpprp x = new clsexpprp();
                x.expcod = Convert.ToInt32(dr[0]);
                x.expnam = dr[1].ToString();
                x.expprf = dr[2].ToString();
                x.exppic = dr[3].ToString();
                x.expcatcod = Convert.ToInt32(dr[4]);
                x.expusrcod = Convert.ToInt32(dr[5]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsexpprp> fnd_rec(Int32 expcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndexp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@expcod", SqlDbType.Int).Value = expcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsexpprp> obj = new List<clsexpprp>();
            if(dr.HasRows)
            {
                dr.Read();
                clsexpprp x = new clsexpprp();
                x.expcod = Convert.ToInt32(dr[0]);
                x.expnam = dr[1].ToString();
                x.expprf = dr[2].ToString();
                x.exppic = dr[3].ToString();
                x.expcatcod = Convert.ToInt32(dr[4]);
                x.expusrcod = Convert.ToInt32(dr[5]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsusr : clscon
    {
        public Int32 logincheck(String eml,String pwd,out char rol)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("logincheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar, 50).Value = eml;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 50).Value = pwd;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Direction =
                                        ParameterDirection.Output;
            cmd.Parameters.Add("@rol", SqlDbType.Char, 1).Direction =
                                    ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            Int32 cod = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            rol = Convert.ToChar(cmd.Parameters["@rol"].Value);
            cmd.Dispose();
            con.Close();
            return cod;
        }
        public Int32 save_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 100).Value = p.usreml;
            cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 100).Value = p.usrpwd;
            cmd.Parameters.Add("@usrregdat", SqlDbType.DateTime).Value = p.usrregdat;
            cmd.Parameters.Add("@usrrol", SqlDbType.Char,1).Value = p.usrrol;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = 
                                                    ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void upd_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = p.usrcod;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 100).Value = p.usreml;
            cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 100).Value = p.usrpwd;
            cmd.Parameters.Add("@usrregdat", SqlDbType.DateTime).Value = p.usrregdat;
            cmd.Parameters.Add("@usrrol", SqlDbType.Char,1).Value = p.usrrol;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = p.usrcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsusrprp> dsp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsusrprp> obj = new List<clsusrprp>();
            while (dr.Read())
            {
                clsusrprp x = new clsusrprp();
                x.usrcod = Convert.ToInt32(dr[0]);
                x.usreml = dr[1].ToString();
                x.usrpwd = dr[2].ToString();
                x.usrregdat = Convert.ToDateTime(dr[3]);
                x.usrrol = Convert.ToChar(dr[4]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsusrprp> fnd_rec(Int32 usrcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = usrcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsusrprp> obj = new List<clsusrprp>();
            if(dr.HasRows)
            {
                dr.Read();
                clsusrprp x = new clsusrprp();
                x.usrcod = Convert.ToInt32(dr[0]);
                x.usreml = dr[1].ToString();
                x.usrpwd = dr[2].ToString();
                x.usrregdat = Convert.ToDateTime(dr[3]);
                x.usrrol = Convert.ToChar(dr[4]);
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    public class clsprdrev : clscon
    {
        public void save_rec(clsprdrevprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insprdrev", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdrevprdcod", SqlDbType.Int).Value = p.prdrevprdcod;
            cmd.Parameters.Add("@prdrevexpcod", SqlDbType.Int).Value = p.prdrevexpcod;
            cmd.Parameters.Add("@prdrevdat", SqlDbType.DateTime).Value = p.prdrevdat;
            cmd.Parameters.Add("@prdrevtit", SqlDbType.VarChar, 100).Value = p.prdrevtit;
            cmd.Parameters.Add("@prdrevdsc", SqlDbType.VarChar, 1000).Value = p.prdrevdsc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void upd_rec(clsprdrevprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updprdrev", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdrevcod", SqlDbType.Int).Value = p.prdrevcod;
            cmd.Parameters.Add("@prdrevprdcod", SqlDbType.Int).Value = p.prdrevprdcod;
            cmd.Parameters.Add("@prdrevexpcod", SqlDbType.Int).Value = p.prdrevexpcod;
            cmd.Parameters.Add("@prdrevdat", SqlDbType.DateTime).Value = p.prdrevdat;
            cmd.Parameters.Add("@prdrevtit", SqlDbType.VarChar, 100).Value = p.prdrevtit;
            cmd.Parameters.Add("@prdrevdsc", SqlDbType.VarChar, 1000).Value = p.prdrevdsc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clsprdrevprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delprdrev", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@prdrevcod", SqlDbType.Int).Value = p.prdrevcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsprdrevprp> dsp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspprdrev", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprdrevprp> obj = new List<clsprdrevprp>();
            while (dr.Read())
            {
                clsprdrevprp x = new clsprdrevprp();
                x.prdrevcod = Convert.ToInt32(dr[0]);
                x.prdrevprdcod = Convert.ToInt32(dr[1]);
                x.prdrevexpcod = Convert.ToInt32(dr[2]);
                x.prdrevdat = Convert.ToDateTime(dr[3]);
                x.prdrevtit = dr[4].ToString();
                x.prdrevdsc = dr[5].ToString();
                obj.Add(x);
           }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsprdrevprp> fnd_rec(Int32 prdcod,Int32 expcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndprdrev", con);
            cmd.CommandType = CommandType.StoredProcedure;
  cmd.Parameters.Add("@prdcod", SqlDbType.Int).Value = prdcod;
  cmd.Parameters.Add("@expcod", SqlDbType.Int).Value = expcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsprdrevprp> obj = new List<clsprdrevprp>();
            if(dr.HasRows)
            {
                dr.Read();
                clsprdrevprp x = new clsprdrevprp();
                x.prdrevcod = Convert.ToInt32(dr[0]);
                x.prdrevprdcod = Convert.ToInt32(dr[1]);
                x.prdrevexpcod = Convert.ToInt32(dr[2]);
                x.prdrevdat = Convert.ToDateTime(dr[3]);
                x.prdrevtit = dr[4].ToString();
                x.prdrevdsc = dr[5].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }

    }
    public class clssel : clscon
    {
        
  public DataSet selbyprd(Int32 pcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("selbyprd", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.Add("@pcod", SqlDbType.Int)
                .Value = pcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }

        public Int32 save_rec(clsselprp p)
         {
             if(con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("inssel", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.Add("@selnam", SqlDbType.VarChar, 100).Value = p.selnam;
             cmd.Parameters.Add("@sellog", SqlDbType.VarChar, 100).Value = p.sellog;
             cmd.Parameters.Add("@seltrm", SqlDbType.VarChar, 1000).Value = p.seltrm;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
             cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
             cmd.Dispose();
            con.Close();
            return a;

            
         }
         public void upd_rec(clsselprp p)
         {
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("updsel", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.Add("@selcod", SqlDbType.Int).Value = p.selcod;
             cmd.Parameters.Add("@selnam", SqlDbType.VarChar, 100).Value = p.selnam;
             cmd.Parameters.Add("@sellog", SqlDbType.VarChar, 100).Value = p.sellog;
             cmd.Parameters.Add("@seltrm", SqlDbType.VarChar, 1000).Value = p.seltrm;
             cmd.ExecuteNonQuery();
             cmd.Dispose();
             con.Close();
         }
         public void del_rec(clsselprp p)
         {
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("delsel", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.Add("@selcod", SqlDbType.Int).Value = p.selcod;
             cmd.ExecuteNonQuery();
             cmd.Dispose();
             con.Close();
         }
         public List<clsselprp> dsp_rec()
         {
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("dspsel", con);
             cmd.CommandType = CommandType.StoredProcedure;
             SqlDataReader dr = cmd.ExecuteReader();
             List<clsselprp> obj = new List<clsselprp>();
             while (dr.Read())
             {
                 clsselprp x = new clsselprp();
                 x.selcod = Convert.ToInt32(dr[0]);
                 x.selnam = dr[1].ToString();
                 x.sellog = dr[2].ToString();
                 x.seltrm = dr[3].ToString();
                 obj.Add(x);
             }
             dr.Close();
             cmd.Dispose();
             con.Close();
             return obj;
         }
         public List<clsselprp> fnd_rec(Int32 selcod)
         {
             if (con.State == ConnectionState.Closed)
             {
                 con.Open();
             }
             SqlCommand cmd = new SqlCommand("fndsel", con);
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.Add("@selcod", SqlDbType.Int).Value = selcod;
             SqlDataReader dr = cmd.ExecuteReader();
             List<clsselprp> obj = new List<clsselprp>();
             while (dr.Read())
             {
                 clsselprp x = new clsselprp();
                 x.selcod = Convert.ToInt32(dr[0]);
                 x.selnam = dr[1].ToString();
                 x.sellog = dr[2].ToString();
                 x.seltrm = dr[3].ToString();
                 obj.Add(x);
             }
             dr.Close();
             cmd.Dispose();
             con.Close();
             return obj;
         }
        }
    public class clsselprd : clscon
    {

        public DataSet dspselprd(Int32 selcod)
        {
            SqlDataAdapter adp = new SqlDataAdapter("dspselprd", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
     adp.SelectCommand.Parameters.Add("@selcod", SqlDbType.Int).Value = selcod;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }


        public void save_rec(clsselprdprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("insselprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@selprdprdcod", SqlDbType.Int).Value = p.selprdprdcod;
            cmd.Parameters.Add("@selprdselcod", SqlDbType.Int).Value = p.selprdselcod;
            cmd.Parameters.Add("@selprdprc", SqlDbType.Float).Value = p.selprdprc;
            cmd.Parameters.Add("@selprdlnk", SqlDbType.VarChar, 500).Value = p.selprdlnk;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void upd_rec(clsselprdprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updselprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@selprdcod", SqlDbType.Int).Value = p.selprdcod;
            cmd.Parameters.Add("@selprdprdcod", SqlDbType.Int).Value = p.selprdprdcod;
            cmd.Parameters.Add("@selprdselcod", SqlDbType.Int).Value = p.selprdselcod;
            cmd.Parameters.Add("@selprdprc", SqlDbType.Float).Value = p.selprdprc;
            cmd.Parameters.Add("@selprdlnk", SqlDbType.VarChar, 500).Value = p.selprdlnk;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void del_rec(clsselprdprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delselprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@selprdcod", SqlDbType.Int).Value = p.selprdcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsselprdprp> dsp_rec()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("dspselprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsselprdprp> obj = new List<clsselprdprp>();
            while (dr.Read())
            {
                clsselprdprp x = new clsselprdprp();
                x.selprdcod = Convert.ToInt32(dr[0]);
                x.selprdprdcod = Convert.ToInt32(dr[1]);
                x.selprdselcod = Convert.ToInt32(dr[2]);
                x.selprdprc = Convert.ToSingle(dr[3]);
                x.selprdlnk = dr[4].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
        public List<clsselprdprp> fnd_rec(Int32 selprdcod)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("fndselprd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@selprdcod", SqlDbType.Int).Value = selprdcod;
            SqlDataReader dr = cmd.ExecuteReader();
            List<clsselprdprp> obj = new List<clsselprdprp>();
            if(dr.HasRows)
            {
                dr.Read();
                clsselprdprp x = new clsselprdprp();
                x.selprdcod = Convert.ToInt32(dr[0]);
                x.selprdprdcod = Convert.ToInt32(dr[1]);
                x.selprdselcod = Convert.ToInt32(dr[2]);
                x.selprdprc = Convert.ToSingle(dr[3]);
                x.selprdlnk = dr[4].ToString();
                obj.Add(x);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;
        }
    }
    #endregion
    
}
