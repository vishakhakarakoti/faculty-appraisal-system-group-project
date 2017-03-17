using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AppraisalHome : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            String log = Session["user"].ToString();
            Logins l = new Logins();
            l.GetDetails(log);
            lblnam.Text = l.UserName;
            lbldep.Text = l.UserDepartment;
            lbltyp.Text = l.UserType;
            DataTable dt = CourseDetail.Courses(1,log);
            int i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (i == 0)
                {
                    FillCourse(c1, dr);

                }
                if (i == 1)
                {
                    FillCourse(c2, dr);
                }
                if (i == 2)
                {
                    FillCourse(c3, dr);

                }
                if (i == 3)
                {
                    FillCourse(c4, dr);

                }
                i++;

            }
            dt = null;
            dt = CourseDetail.Courses(2, log);
            i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (i == 0)
                {
                    FillCourse(c5, dr);

                }
                if (i == 1)
                {
                    FillCourse(c6, dr);
                }
                if (i == 2)
                {
                    FillCourse(c7, dr);

                }
                if (i == 3)
                {
                    FillCourse(c8, dr);

                }
                i++;

            }
            dt = CourseDetail.Courses(3, log);
            i = 0;
            foreach (DataRow dr in dt.Rows)
            {
                if (i == 0)
                {
                    FillCourse(c9, dr);

                }
                if (i == 1)
                {
                    FillCourse(c10, dr);
                }
                if (i == 2)
                {
                    FillCourse(c11, dr);

                }
                if (i == 3)
                {
                    FillCourse(c12, dr);

                }
                i++;

            }
            
          
        }
    }
    private void FillCourse(coursedet cd,DataRow dr)
    {
        cd.CourseID = dr["CourseID"].ToString();
        cd.CourseL = dr["CL"].ToString();
        cd.CourseT = dr["CT"].ToString();
        cd.CourseP = dr["CP"].ToString();
        cd.CourseLTP = dr["CLTP"].ToString();
        cd.CourseNof= dr["Cnof"].ToString();
        cd.CourseCoa = dr["Ca"].ToString();
        cd.CourseCob = dr["Cb"].ToString();
        cd.CourseCc1 = dr["Cc1"].ToString();
        cd.CourseCc2 = dr["Cc2"].ToString();
        cd.CourseCc2 = dr["Cc2"].ToString();
        cd.CourseRst = dr["Cres"].ToString();
        cd.CourseLpt = dr["Ccd"].ToString();



    }
    protected void AddAppr(object sender, EventArgs e)
    { String disp = "";
    disp += AddAppCourse(c1);
    disp += AddAppCourse(c2);
    disp += AddAppCourse(c3);
    disp += AddAppCourse(c4);

        lblmes.Text = disp;
    }
    private String AddAppCourse(coursedet c1)
    {
        String mess = "";
        
        try
        {
        if (c1.IsEdit() == true)
        {
            CourseDetail c = new CourseDetail();
            c.Login = Session["user"].ToString();
            c.CourseTerm = int.Parse(c1.Term);
            c.CourseID = c1.CourseID;
            if (c.IsEntered() == "yes")
            {
                mess += "Term " + c.CourseTerm.ToString() + "(" + c.CourseID + ") is already Entered";
            }
            else
            {
                c.CourseL = decimal.Parse(c1.CourseL);
                c.CourseT = decimal.Parse(c1.CourseT);
                c.CourseP = decimal.Parse(c1.CourseP);
                c.CourseLTP = decimal.Parse(c1.CourseLTP);
                c.CourseA = decimal.Parse(c1.CourseCoa);
                c.CourseB = decimal.Parse(c1.CourseCob);
                c.CourseD = decimal.Parse(c1.CourseLpt);
                c.CourseNOF = int.Parse(c1.CourseNof);
                c.CourseRst = c1.CourseRst;
                c.CourseCc1 = c1.CourseCc1;
                c.CourseCc2 = c1.CourseCc2;


                if (c.NewCourseD() == false)
                {
                    mess += c.Error;
                }
                else
                {
                    mess += "Saved Term" + c.CourseTerm.ToString()  + "(" + c.CourseID + ")";
                }
            }
        }
        }
        catch (Exception e1)
       {
            mess += e1.Message;
        }
        return mess;
        

    }

protected void  AddAppr2(object sender, EventArgs e)
{
    String disp = "";
    disp += AddAppCourse(c5);
    disp += AddAppCourse(c6);
    disp += AddAppCourse(c7);
    disp += AddAppCourse(c8);

    lblmess2.Text = disp;
}
protected void AddAppr3(object sender, EventArgs e)
{
    String disp = "";
    disp += AddAppCourse(c9);
    disp += AddAppCourse(c10);
    disp += AddAppCourse(c11);
    disp += AddAppCourse(c12);

    lblmess3.Text = disp;
}
}