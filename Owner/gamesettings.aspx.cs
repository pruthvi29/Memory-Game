using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label1.Text = "";
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            string path = "C:\\MemoryGame_VVGB\\images\\" + FileUpload1.FileName;
            FileUpload1.SaveAs(path);
            Label1.Text = "File Has been Sucessfully Uploaded";
        }
    }
}