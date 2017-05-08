using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    static int k;
    string username;
    static List<int> x = new List<int>() { 11, 15, 17, 19 };
    static int count = 0, set = 0;
    static int clicks = 0, l = 1;
    static int hit1 = 0, hit2 = 0, hit3 = 0, hit4 = 0;
    static int v1, v2, v3, v4;
    int id;

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        hit1++;
        clicks++;
        if (x.Count == 0)
        {
            x.Add(11);
            x.Add(15);
            x.Add(17);
            x.Add(19);
        }
        if (hit1 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v1 += Convert.ToInt16(ViewState["b1"]);
            // Label5.Text = v1.ToString();
            x.RemoveAt(id);
            if (a == 11 || a == 15)
            {

                ImageButton1.ImageUrl = "http://localhost:46795/images/r.png";
                count++;
            }
            else
            {
                ImageButton1.ImageUrl = "http://localhost:46795/images/p.png";
                count--;
            }
            ImageButton1.Enabled = false;
        }

        if (hit1 > 1)
        {
            // Label5.Text += v1.ToString();
            if (v1 == 11 || v1 == 15)
            {
                ImageButton1.ImageUrl = "http://localhost:46795/images/r.png";
                count++;
            }
            else
            {
                ImageButton1.ImageUrl = "http://localhost:46795/images/p.png";
                count--;
            }

        }

        if (count == 2 || count == -2)
        {
            // Response.Write("sucess");
            set++;
            count = 0;
        }
        Label1.Text = clicks.ToString();
        Label3.Text = set.ToString();
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        hit2++;
        clicks++;
        if (x.Count == 0)
        {
            x.Add(11);
            x.Add(15);
            x.Add(17);
            x.Add(19);
        }
        if (hit2 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int b = x[id];
            ViewState["b2"] = b;
            v2 = Convert.ToInt16(ViewState["b2"]);
            x.RemoveAt(id);

            if (b == 11 || b == 15)
            {

                ImageButton2.ImageUrl = "http://localhost:46795/images/r.png";
                count++;
            }
            else
            {

                ImageButton2.ImageUrl = "http://localhost:46795/images/p.png";
                count--;

            }
            ImageButton2.Enabled = false;
        }
        if (hit2 > 1)
        {
            //Label5.Text += v2.ToString();
            if (v2 == 11 || v2 == 15)
            {
                ImageButton2.ImageUrl = "http://localhost:46795/images/r.png";
                count++;
            }
            else
            {
                ImageButton2.ImageUrl = "http://localhost:46795/images/p.png";
                count--;
            }

        }
        if (count == 2 || count == -2)
        {
            set++;
            count = 0;
        }
        Label1.Text = clicks.ToString();
        Label3.Text = set.ToString();
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        hit3++;
        clicks++;
        if (x.Count == 0)
        {
            x.Add(11);
            x.Add(15);
            x.Add(17);
            x.Add(19);
        }
        if (hit3 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int c = x[id];
            ViewState["b3"] = c;
            v3 = Convert.ToInt16(ViewState["b3"]);
            x.RemoveAt(id);
            if (c == 11 || c == 15)
            {

                ImageButton3.ImageUrl = "http://localhost:46795/images/r.png";
                count++;
            }
            else
            {

                ImageButton3.ImageUrl = "http://localhost:46795/images/p.png";
                count--;

            }
            ImageButton3.Enabled = false;
        }
        if (hit3 > 1)
        {
            //Label5.Text += v3.ToString();
            if (v3 == 11 || v3 == 15)
            {
                ImageButton3.ImageUrl = "http://localhost:46795/images/r.png";
                count++;
            }
            else
            {
                ImageButton3.ImageUrl = "http://localhost:46795/images/p.png";
                count--;
            }

        }
        if (count == 2 || count == -2)
        {
            set++;
            count = 0;
        }
        Label1.Text = clicks.ToString();
        Label3.Text = set.ToString();
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        hit4++;
        clicks++;
        if (x.Count == 0)
        {
            x.Add(11);
            x.Add(15);
            x.Add(17);
            x.Add(19);
        }

        if (hit4 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int d = x[id];
            ViewState["b4"] = d;
            v4 = Convert.ToInt16(ViewState["b4"]);
            x.RemoveAt(id);

            if (d == 11 || d == 15)
            {

                ImageButton4.ImageUrl = "http://localhost:46795/images/r.png";
                count++;
            }
            else
            {

                ImageButton4.ImageUrl = "http://localhost:46795/images/p.png";
                count--;
            }
            ImageButton4.Enabled = false;
        }
        if (hit4 > 1)
        {
            // Label5.Text += v4.ToString();
            if (v4 == 11 || v4 == 15)
            {
                ImageButton4.ImageUrl = "http://localhost:46795/images/r.png";
                count++;
            }
            else
            {
                ImageButton4.ImageUrl = "http://localhost:46795/images/p.png";
                count--;
            }

        }
        if (count == 2 || count == -2)
        {
            set++;
            count = 0;
        }
        Label1.Text = clicks.ToString();
        Label3.Text = set.ToString();

    }
    public void validate()
    {

        if (count == 0)
        {
            if (set == 0)
            {
                ImageButton1.ImageUrl = "";
                ImageButton2.ImageUrl = "";
                ImageButton3.ImageUrl = "";
                ImageButton4.ImageUrl = "";
                ImageButton1.Enabled = true;
                ImageButton2.Enabled = true;
                ImageButton3.Enabled = true;
                ImageButton4.Enabled = true;
            }

        }
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        k++;

        if (k % 2 == 0)

            Label2.Text = (Convert.ToInt16(Label2.Text) + 1).ToString();

        int sec1 = Convert.ToInt16(Label2.Text);

        validate();
        int g = (100 * l * l - sec1 - 10 * clicks) * set;
        //  Response.Redirect("~/Default2.aspx?score=" + g);
        Label4.Text = g.ToString();
    }
    protected void Quit_Click(object sender, EventArgs e)
    {
        
         username = LoginName1.Page.User.Identity.Name;
        if (username == "" )
        {
            return; // Server.Transfer("http://localhost:46795/Default.aspx");
        }
        else
        {
            string date = DateTime.Now.ToString();
            int lc = l - 1;
            if (Label3.Text == "")
                Label3.Text = "0";
            else if (Label3.Text == "2")
                lc = 1;
            string a = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MemoryGame.mdf;Integrated Security=True";
            SqlConnection x = new SqlConnection(a);        
            SqlCommand b = new SqlCommand("insert into scores values('"+ username + "','" + date + "','" + lc + "','" + l + "','" + Label3.Text + "','" + Label4.Text + "')", x);  
            x.Open();
            b.ExecuteNonQuery();
            Label1.Text = "0";
            clicks = 0;
            set = 0;
            Label4.Text = "";
            }
        }

    protected void nextlevel_Click(object sender, EventArgs e)
    {
        if (set == 2)
        {
            Timer1.Enabled = false;
            string[] level1 = new string[4];
            //level1[0] = username;
            level1[0] = Label1.Text;
            level1[1] = Label2.Text;
            level1[2] = Label3.Text;
            level1[3] = Label4.Text;
            Session["L1"] = level1;
            Response.Redirect("http://localhost:46795/Default2.aspx");
        }
        else
        {
            return;
        }
    }
}
