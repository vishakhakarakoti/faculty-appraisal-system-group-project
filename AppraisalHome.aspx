<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AppraisalHome.aspx.cs" Inherits="AppraisalHome" %>
<%@ register Src="~/coursedet.ascx" TagPrefix="app" TagName="course"  %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    #small
    {
        font-size:12px;
    }
    input
    {
        font-size:9px;
        font-weight:bold;
    }
    .border
    {
        border-style:solid;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="small">
    <table width="980" style="border-style:solid;">
    <tr style="border-style:solid;">
    <td colspan="4">Welcome &nbsp;&nbsp;<asp:Label ID="lblnam" runat="server" />&nbsp;&nbsp; |&nbsp;&nbsp; User type&nbsp;&nbsp; <asp:Label ID="lbltyp" runat="server" />|
    &nbsp;&nbsp;&nbsp;Department&nbsp;&nbsp; <asp:Label ID="lbldep" runat="server" />
     </td>
    <td colspan="5" align="center">
    Part I: Teaching Evaluation(Normative Score:100)
    </td>
    <td colspan="2"> <Asp:hyperlink id="AHome" runat="server" NavigateUrl="~/WelcomeApp.aspx" Width="300px" Font-Size=" Medium" >Menu</Asp:hyperlink>
   </td>
    </tr>
    
    <tr>

    
    <td colspan="11" align="left">
    
Part IA: Load points (Note: The shaded areas are not to be filled-in by the Appraise)
</td>
</tr>
 <tr>

    
    <td colspan="10" align="center">
    
Details to be filled in by the Appraisee
</td>
<td></td>
</tr>
<tr align="center">
<td>
Course ID with number of sections taught
</td>
<td>
L
</td>
<td>
T
</td>
<td>

P
</td>
<td>

L+T+P
</td>
<td>

No. of Students
</td>
<td>

Factor "a"
</td>
<td>

Factor "b"
</td>
<td>
<table border="0">
<tr>
<td colspan="2">
Factor "c"
</td>
</tr>
<tr>
<td>
Result 1st time teaching(Y/N) (refer  Note 4)
</td>
<td>
Factor "c" value
</td>
</table>
</td>
<td>

Factor
(d)
*
</td>
<td>
<u>Load points</u><br />
(Hrs x factor "a"  x factor "b"<br /> x factor "c" x factor “d”)
    </td>

    </tr>
     <tr>
    <td colspan="11" align="center">
    1<sup>st</sup> Term during Academic Year
    </td>
    </tr>
    <tr>
    <td colspan="11">
    <app:course ID="c1" runat="server" Term="1" />
    </td>
    </tr>
    <tr>
    <td colspan="11">
    <app:course ID="c2" runat="server" Term="1"/>
    </td>
    </tr>
<tr>
    <td colspan="11">
    <app:course ID="c3" runat="server" Term="1"/>

    </td>
    </tr>
    <tr>
    <td>
    <app:course ID="c4" runat="server" Term="1"/>
    </td>
    </tr>
    

    <tr>
    <td colspan="7"> No. of UG/PG Projects / Dissertations guided of one semester / trimester <br />
duration**
(Please specify the nature of Projects</td>
  <td colspan="3">
  <asp:Button ID="btnadd" runat="server" text="Add info" OnClick="AddAppr" />
    <br />
    <asp:Label ID="lblmes" runat="server" />
  </td>
  <td></td>
    </tr>
      <tr>
    <td colspan="11" align="center">
    2<sup>nd</sup> Term during Academic Year
    </td>
    </tr>
    <tr>
    <td colspan="11">
    <app:course ID="c5" runat="server" Term="2" />

    </td>
    </tr>
    <tr>
    <td colspan="11">
    <app:course ID="c6" runat="server" Term="2"/>

    </td>
    </tr>
<tr>
    <td colspan="11">
    <app:course ID="c7" runat="server" Term="2"/>

    </td>
    </tr>
    <tr>
    <td>
    <app:course ID="c8" runat="server" Term="2"/>

    </td>
    </tr>
    

    <tr>
    <td colspan="7"> No. of UG/PG Projects / Dissertations guided of one semester / trimester 
duration** (Please specify the nature of Projects</td>
  <td colspan="3">
  <asp:Button ID="btnmodify2" runat="server" text="Add info" OnClick="AddAppr2" />
    <br />
    <asp:Label ID="lblmess2" runat="server" />
  </td>
  <td></td>
    </tr>
      <tr>
    <td colspan="11" align="center">
    3<sup>rd</sup>  Term during Academic Year (Where trimester system is applicable)
    </td>
    </tr>
    <tr>
    <td colspan="11">
    <app:course ID="c9" runat="server" Term="3" />

    </td>
    </tr>
    <tr>
    <td colspan="11">
    <app:course ID="c10" runat="server" Term="3"/>

    </td>
    </tr>
<tr>
    <td colspan="11">
    <app:course ID="c11" runat="server" Term="3"/>

    </td>
    </tr>
    <tr>
    <td>
    <app:course ID="c12" runat="server" Term="3"/>

    </td>
    </tr>
    

    <tr>
    <td colspan="7">No. of UG/PG Projects / Dissertations guided of one trimester duration**
(Please specify the nature of Projects)</td>
  <td colspan="3">
  <asp:Button ID="btnmodify3" runat="server" text="Add info" OnClick="AddAppr3" />
    <br />
    <asp:Label ID="lblmess3" runat="server" />
  </td>
  <td></td>
    </tr>
    <tr>
    <td colspan="10">Total Load Points</td>
    <td></td>
    </tr>
    
    
    
    </table>
   
    </div>
    </form>
</body>
</html>
