using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class coursedet : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void add(object sender, EventArgs e)
    {
        int n1, n2, n3, s;
        n1 = int.Parse(txtcol.Text);
        n2 = int.Parse(txtcot.Text);
        n3 = int.Parse(txtcop.Text);
        s = n1 + n2 + n3;
        txtltp.Text = s.ToString();
        int strength = int.Parse(txtnof.Text);
        if (strength > 40)
        {
            txtcoa.Text = "1.1";
        }
        else
        {
            txtcoa.Text = "1";
        }
    }
    public String CourseID
    {
        get
        {
            return txtcod.Text;
        }

        set
        {
            txtcod.Text = value;
        }
    }
    public String CourseL
    {
        get
        {
            return txtcol.Text;
        }

        set
        {
            txtcol.Text = value;
        }
    }
    public String CourseT
    {
        get
        {
            return txtcot.Text;
        }

        set
        {
            txtcot.Text = value;
        }
    }
    public String CourseP
    {
        get
        {
            return txtcop.Text;
        }

        set
        {
            txtcop.Text = value;
        }
    }
    public String CourseLTP
    {
        get
        {
            return txtltp.Text;
        }

        set
        {
            txtltp.Text = value;
        }
    }
    public String CourseNof
    {
        get
        {
            return txtnof.Text;
        }

        set
        {
            txtnof.Text = value;
        }
    }
     public String CourseCoa
    {
        get
        {
            return txtcoa.Text;
        }

        set
        {
            txtcoa.Text = value;
        }
    }
     public String CourseCob
    {
        get
        {
            return txtcob.Text;
        }

        set
        {
            txtcob.Text = value;
        }
    }
    
    public String CourseCc1
    {
        get
        {
            return txtcc1.Text;
        }

        set
        {
            txtcc1.Text = value;
        }
    }
    public String CourseCc2
    {
        get
        {
            return txtcc2.Text;
        }

        set
        {
            txtcc2.Text = value;
        }
    }
        
    public String CourseRst
    {
        get
        {
            return txtrst.Text;
        }

        set
        {
            txtrst.Text = value;
        }
    }
public String CourseLpt
    {
        get
        {
            return txtlpt.Text;
        }

        set
        {
            txtlpt.Text = value;
        }
    }

public string Term
{
    get
    {
        return term.Value;
    }
    set
    {
        term.Value = value;
    }

}
public bool IsEdit()
{
    bool res;
    if (txtcod.Text.Length == 0 && txtcol.Text == "0" && txtcot.Text == "0" && txtcop.Text == "0" )
        res = false;
    else
        res = true;

    return res;
}
}