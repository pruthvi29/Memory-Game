using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
public partial class Default3 : System.Web.UI.Page
{

    static List<int> x = new List<int>() { 11, 15, 17, 19, 21, 23, 25, 27, 29,31,33,35,37,39,41,43 };
    static int k, count1, count2, count3, count4,count5,
        set = 0, clicks = 0, hit1, hit2, hit3, hit4, hit5, hit6, hit7, hit8, hit9, hit10,hit11,hit12,hit13,hit14,hit15,hit16;
    static int v1, v2, v3, v4, v5, v6, v7, v8, v9,v10, v11,v12,v13,v14,v15,v16;
    int id, g;

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        if (!IsPostBack)
        {
            string[] level2values = (String[])Session["L2"];
            Label1.Text = level2values[0];
            Label2.Text = level2values[1];
            clicks = Convert.ToInt16(Label2.Text);
          //  Label3.Text = level2values[2];
           // set = Convert.ToInt16(Label3.Text);
             Label4.Text = level2values[3];
              g= Convert.ToInt16(Label4.Text);
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit1++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit1 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v1 = Convert.ToInt16(ViewState["b1"]);
        
            x.RemoveAt(id);
            if (a == 11 || a == 15 || a == 17 || a== 19)
            {

                ImageButton1.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (a == 21 || a == 23 || a == 25 || a==27 )
            {
                ImageButton1.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (a == 29 || a == 31 || a == 33 || a == 35 )
            {
                ImageButton1.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton1.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton1.Enabled = false;
        }

        if (hit1 > 1)
        {

            if (v1 == 11 || v1 == 15 || v1 == 17 || v1 == 19)
            {

                ImageButton1.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v1 == 21 || v1 == 23 || v1 == 25 || v1==27)
            {
                ImageButton1.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v1 == 29 || v1 == 31 || v1 == 33 || v1 == 35)
            {
                ImageButton1.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton1.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }

        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton1.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton1.Enabled = false;
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit2++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit2 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int b = x[id];
            ViewState["b2"] = b;
            v2 = Convert.ToInt16(ViewState["b2"]);
            x.RemoveAt(id);

            if (b == 11 || b == 15 || b == 17 || b==19)
            {

                ImageButton2.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (b == 21 || b == 23 || b == 25 || b==27)
            {
                ImageButton2.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (b == 29 || b == 31 || b == 33 || b == 35)
            {
                ImageButton2.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton2.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton2.Enabled = false;
        }

        if (hit2 > 1)
        {
            // Label1.Text += v1.ToString();
            if (v2 == 11 || v2 == 15 || v2 == 17 || v2==19)
            {

                ImageButton2.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v2 == 21 || v2 == 23 || v2 == 25 || v2==27)
            {
                ImageButton2.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v2 == 29 || v2 == 31 || v2 == 33 || v2 == 35)
            {
                ImageButton2.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton2.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }


        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 ==4)
        {
            set++;
            ImageButton2.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton2.Enabled = false;
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        count4++;
        hit3++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit3 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int c = x[id];
            ViewState["b3"] = c;
            v3 = Convert.ToInt16(ViewState["b3"]);
            x.RemoveAt(id);
            if (c == 11 || c == 15 || c == 17 || c==19)
            {

                ImageButton3.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (c == 21 || c == 23 || c == 25 || c== 27)
            {
                ImageButton3.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (c == 29 || c == 31 || c == 33 || c == 35)
            {
                ImageButton3.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton3.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton3.Enabled = false;
        }

        if (hit3 > 1)
        {
            // Label1.Text += v1.ToString();
            if (v3 == 11 || v3 == 15 || v3 == 17 || v3==19)
            {

                ImageButton3.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v3 == 21 || v3 == 23 || v3 == 25 || v3==27)
            {
                ImageButton3.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v3 == 29 || v3 == 31 || v3 == 33 || v3 == 35)
            {
                ImageButton3.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton3.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }


        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count4 == 4 || count3 ==4)
        {
            set++;
            ImageButton3.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton3.Enabled = false;
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit4++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit4 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int d = x[id];
            ViewState["b4"] = d;
            v4 = Convert.ToInt16(ViewState["b4"]);
            x.RemoveAt(id);

            if (d == 11 || d == 15 || d == 17 || d == 19)
            {

                ImageButton4.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (d == 21 || d == 23 || d == 25 || d == 27)
            {
                ImageButton4.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (d == 29 || d == 31 || d == 33 || d == 35)
            {
                ImageButton4.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton4.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton4.Enabled = false;
        }

        if (hit4 > 1)
        {
            // Label1.Text += v1.ToString();
            if (v4 == 11 || v4 == 15 || v4 == 17 || v4 == 19)
            {

                ImageButton4.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v4 == 21 || v4 == 23 || v4 == 25 || v4 == 27)
            {
                ImageButton4.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v4 == 29 || v4 == 31 || v4 == 33 || v4 == 35)
            {
                ImageButton4.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton4.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }


        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton4.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton4.Enabled = false;
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        k++;

        if (k % 2 == 0)

            Label2.Text = (Convert.ToInt16(Label2.Text) + 1).ToString();

        int sec1 = Convert.ToInt16(Label2.Text);

        validate();
         g = (100 * 9 - sec1 - 10 * clicks) * set;
        //  Response.Redirect("~/Default2.aspx?score=" + g);
        Label4.Text = g.ToString();
    }
    public void addtolist()
    {
        x.Add(11);
        x.Add(15);
        x.Add(17);
        x.Add(19);
        x.Add(21);
        x.Add(23);
        x.Add(25);
        x.Add(27);
        x.Add(29);
        x.Add(31);
        x.Add(33);
        x.Add(35);
        x.Add(37);
        x.Add(39);
        x.Add(41);
        x.Add(43);
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit5++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit5 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int f = x[id];
            ViewState["b5"] = f;
            v5 = Convert.ToInt16(ViewState["b5"]);
            x.RemoveAt(id);

            if (f == 11 || f == 15 || f == 17 || f==19)
            {

                ImageButton5.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (f == 21 || f == 23 || f == 25 || f== 27)
            {
                ImageButton5.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (f == 29 || f == 31 || f == 33 || f == 35)
            {
                ImageButton5.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton5.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton5.Enabled = false;
        }

        if (hit5 > 1)
        {
            // Label1.Text += v1.ToString();
            if (v5 == 11 || v5 == 15 || v5 == 17 || v5 ==19)
            {

                ImageButton5.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v5 == 21 || v5 == 23 || v5 == 25 || v5 ==27)
            {
                ImageButton5.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v5 == 29 || v5 == 31 || v5 == 33 || v5 == 35)
            {
                ImageButton5.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton5.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }
        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 ==4)
        {
            set++;
            ImageButton5.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton5.Enabled = false;
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit6++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit6 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int g = x[id];
            ViewState["b6"] = g;
            v6 = Convert.ToInt16(ViewState["b6"]);
            x.RemoveAt(id);

            if (g == 11 || g == 15 || g == 17 || g==19)
            {

                ImageButton6.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (g == 21 || g == 23 || g == 25 ||g==27)
            {
                ImageButton6.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (g == 29 || g == 31 || g == 33 || g == 35)
            {
                ImageButton6.ImageUrl = "http://localhost:46795/images/s.png";
                count2++;
            }
            else
            {
                ImageButton6.ImageUrl = "http://localhost:46795/images/d.png";
                count3++;
            }
            ImageButton6.Enabled = false;
        }

        if (hit6 > 1)
        {
            // Label1.Text += v1.ToString();
            if (v6 == 11 || v6 == 15 || v6 == 17 || v6==19)
            {

                ImageButton6.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v6 == 21 || v6 == 23 || v6 == 25 || v6 == 27)
            {
                ImageButton6.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v6 == 29 || v6 == 31 || v6 == 33 || v6 == 35)
            {
                ImageButton6.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton6.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }
        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton6.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton6.Enabled = false;
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit7++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit7 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int h = x[id];
            ViewState["b8"] = h;
            v7 = Convert.ToInt16(ViewState["b8"]);
            x.RemoveAt(id);

            if (h == 11 || h == 15 || h == 17 || h==19)
            {

                ImageButton7.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (h == 21 || h == 23 || h == 25 || h==27)
            {
                ImageButton7.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (h == 29 || h == 31 || h == 33 || h == 35)
            {
                ImageButton7.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton7.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton7.Enabled = false;
        }

        if (hit7 > 1)
        {
            // Label1.Text += v1.ToString();
            if (v7 == 11 || v7 == 15 || v7 == 17 || v7 ==19)
            {

                ImageButton7.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v7 == 21 || v7 == 23 || v7 == 25 || v7== 27)
            {
                ImageButton7.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v7 == 29 || v7 == 31 || v7 == 33 || v7 == 35)
            {
                ImageButton7.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton7.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton7.Enabled = false;
        }
        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 ==4)
        {
            set++;
            ImageButton7.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton7.Enabled = false;
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit8++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit8 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int g = x[id];
            ViewState["b6"] = g;
            v8 = Convert.ToInt16(ViewState["b6"]);
            x.RemoveAt(id);

            if (g == 11 || g == 15 || g == 17 || g==19)
            {

                ImageButton8.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (g == 21 || g == 23 || g == 25 || g==27)
            {
                ImageButton8.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (g == 29 || g == 31 || g == 33 || g == 35)
            {
                ImageButton8.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton8.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton8.Enabled = false;
        }

        if (hit8 > 1)
        {
            // Label1.Text += v1.ToString();
            if (v8 == 11 || v8 == 15 || v8 == 17 || v8==19)
            {

                ImageButton8.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v8 == 21 || v8 == 23 || v8 == 25 || v8==27)
            {
                ImageButton8.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v8 == 29 || v8 == 31 || v8 == 33 || v8 == 35)
            {
                ImageButton8.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton8.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }
        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 ==4)
        {
            set++;
            ImageButton8.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton8.Enabled = false;
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit9++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit9 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int g = x[id];
            ViewState["b9"] = g;
            v9 = Convert.ToInt16(ViewState["b9"]);
            x.RemoveAt(id);

            if (g == 11 || g == 15 || g == 17 || g== 19)
            {

                ImageButton9.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (g == 21 || g == 23 || g == 25 || g==27)
            {
                ImageButton9.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (g == 29 || g == 31 || g == 33 || g == 35)
            {
                ImageButton9.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton9.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton9.Enabled = false;
        }

        if (hit9 > 1)
        {
            // Label1.Text += v1.ToString();
            if (v9 == 11 || v9 == 15 || v9 == 17 || v9==19)
            {

                ImageButton9.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v9 == 21 || v9 == 23 || v9 == 25 || v9 == 27)
            {
                ImageButton9.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v9 == 29 || v9 == 31 || v9 == 33 || v9 == 35)
            {
                ImageButton9.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton9.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }
        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 ==4)
        {
            set++;
            ImageButton9.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton9.Enabled = false;
    }
    public void flip()
    {

        ImageButton1.ImageUrl = "";
        ImageButton2.ImageUrl = "";
        ImageButton3.ImageUrl = "";
        ImageButton4.ImageUrl = "";
        ImageButton5.ImageUrl = "";
        ImageButton6.ImageUrl = "";
        ImageButton7.ImageUrl = "";
        ImageButton8.ImageUrl = "";
        ImageButton9.ImageUrl = "";
        ImageButton10.ImageUrl = "";
        ImageButton11.ImageUrl = "";
        ImageButton12.ImageUrl = "";
        ImageButton13.ImageUrl = "";
        ImageButton14.ImageUrl = "";
        ImageButton15.ImageUrl = "";
        ImageButton16.ImageUrl = "";
        ImageButton1.Enabled = true;
        ImageButton2.Enabled = true;
        ImageButton3.Enabled = true;
        ImageButton4.Enabled = true;
        ImageButton5.Enabled = true;
        ImageButton6.Enabled = true;
        ImageButton7.Enabled = true;
        ImageButton8.Enabled = true;
        ImageButton9.Enabled = true;
        ImageButton10.Enabled = true;
        ImageButton11.Enabled = true;
        ImageButton12.Enabled = true;
        ImageButton13.Enabled = true;
        ImageButton14.Enabled = true;
        ImageButton15.Enabled = true;
        ImageButton16.Enabled = true;
        count4 = 0;
        count1 = 0;
        count2 = 0;
        count3 = 0;
        count5 = 0;

    }

    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit10++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit10 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v10 = Convert.ToInt16(ViewState["b1"]);

            x.RemoveAt(id);
            if (a == 11 || a == 15 || a == 17 || a == 19)
            {

                ImageButton10.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (a == 21 || a == 23 || a == 25 || a == 27)
            {
                ImageButton10.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (a == 29 || a == 31 || a == 33 || a == 35)
            {
                ImageButton10.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton10.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton10.Enabled = false;
        }

        if (hit10 > 1)
        {

            if (v10 == 11 || v10 == 15 || v10 == 17 || v10 == 19)
            {

                ImageButton10.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v10 == 21 || v10 == 23 || v10 == 25 || v10 == 27)
            {
                ImageButton10.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v10 == 29 || v10 == 31 || v10 == 33 || v10 == 35)
            {
                ImageButton10.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton10.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }

        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton10.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton1.Enabled = false;
    }
    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit11++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit11 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v11 = Convert.ToInt16(ViewState["b1"]);

            x.RemoveAt(id);
            if (a == 11 || a == 15 || a == 17 || a == 19)
            {

                ImageButton11.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (a == 21 || a == 23 || a == 25 || a == 27)
            {
                ImageButton11.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (a == 29 || a == 31 || a == 33 || a == 35)
            {
                ImageButton11.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton11.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton11.Enabled = false;
        }

        if (hit11 > 1)
        {

            if (v11 == 11 || v11 == 15 || v11 == 17 || v11 == 19)
            {

                ImageButton11.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v11 == 21 || v11 == 23 || v11 == 25 || v11 == 27)
            {
                ImageButton11.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v11 == 29 || v11 == 31 || v11 == 33 || v11 == 35)
            {
                ImageButton11.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton11.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }

        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton11.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton11.Enabled = false;
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit12++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit12 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v12 = Convert.ToInt16(ViewState["b1"]);

            x.RemoveAt(id);
            if (a == 11 || a == 15 || a == 17 || a == 19)
            {

                ImageButton12.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (a == 21 || a == 23 || a == 25 || a == 27)
            {
                ImageButton12.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (a == 29 || a == 31 || a == 33 || a == 35)
            {
                ImageButton12.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton12.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton12.Enabled = false;
        }

        if (hit12 > 1)
        {

            if (v12 == 11 || v12 == 15 || v12 == 17 || v12 == 19)
            {

                ImageButton12.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v12 == 21 || v12 == 23 || v12 == 25 || v12 == 27)
            {
                ImageButton12.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v12 == 29 || v12 == 31 || v12 == 33 || v12 == 35)
            {
                ImageButton12.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton12.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }

        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton12.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton12.Enabled = false;
    }
    protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit13++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit13 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v13 = Convert.ToInt16(ViewState["b1"]);

            x.RemoveAt(id);
            if (a == 11 || a == 15 || a == 17 || a == 19)
            {

                ImageButton13.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (a == 21 || a == 23 || a == 25 || a == 27)
            {
                ImageButton13.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (a == 29 || a == 31 || a == 33 || a == 35)
            {
                ImageButton13.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton13.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton13.Enabled = false;
        }

        if (hit13 > 1)
        {

            if (v13 == 11 || v13 == 15 || v13 == 17 || v13 == 19)
            {

                ImageButton13.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v13 == 21 || v13 == 23 || v13 == 25 || v13 == 27)
            {
                ImageButton13.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v13 == 29 || v13 == 31 || v13 == 33 || v13 == 35)
            {
                ImageButton13.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton13.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }

        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton13.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton13.Enabled = false;
    }
    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit14++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit14 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v14 = Convert.ToInt16(ViewState["b1"]);

            x.RemoveAt(id);
            if (a == 11 || a == 15 || a == 17 || a == 19)
            {

                ImageButton14.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (a == 21 || a == 23 || a == 25 || a == 27)
            {
                ImageButton14.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (a == 29 || a == 31 || a == 33 || a == 35)
            {
                ImageButton14.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton14.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton14.Enabled = false;
        }

        if (hit14 > 1)
        {

            if (v14 == 11 || v14 == 15 || v14 == 17 || v14 == 19)
            {

                ImageButton14.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v14 == 21 || v14 == 23 || v14 == 25 || v14 == 27)
            {
                ImageButton14.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v14 == 29 || v14 == 31 || v14 == 33 || v14 == 35)
            {
                ImageButton14.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton14.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }

        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton14.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton14.Enabled = false;
    }
    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit15++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit15 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v15 = Convert.ToInt16(ViewState["b1"]);

            x.RemoveAt(id);
            if (a == 11 || a == 15 || a == 17 || a == 19)
            {

                ImageButton15.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (a == 21 || a == 23 || a == 25 || a == 27)
            {
                ImageButton15.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (a == 29 || a == 31 || a == 33 || a == 35)
            {
                ImageButton15.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton15.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton15.Enabled = false;
        }

        if (hit15 > 1)
        {

            if (v15 == 11 || v15 == 15 || v15 == 17 || v15 == 19)
            {

                ImageButton15.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v15 == 21 || v15 == 23 || v15 == 25 || v15 == 27)
            {
                ImageButton15.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v15 == 29 || v15 == 31 || v15 == 33 || v15 == 35)
            {
                ImageButton15.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton15.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }

        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton15.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton15.Enabled = false;
    }
    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    {
        count5++;
        hit16++;
        clicks++;
        if (x.Count == 0)
            addtolist();
        if (hit16 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v16 = Convert.ToInt16(ViewState["b1"]);

            x.RemoveAt(id);
            if (a == 11 || a == 15 || a == 17 || a == 19)
            {

                ImageButton16.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (a == 21 || a == 23 || a == 25 || a == 27)
            {
                ImageButton16.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (a == 29 || a == 31 || a == 33 || a == 35)
            {
                ImageButton16.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton16.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }
            ImageButton16.Enabled = false;
        }

        if (hit16 > 1)
        {

            if (v16 == 11 || v16 == 15 || v16 == 17 || v16 == 19)
            {

                ImageButton16.ImageUrl = "http://localhost:46795/images/r.png";
                count1++;
            }
            else if (v16 == 21 || v16 == 23 || v16 == 25 || v16 == 27)
            {
                ImageButton16.ImageUrl = "http://localhost:46795/images/p.png";
                count2++;
            }
            else if (v16 == 29 || v16 == 31 || v16 == 33 || v16 == 35)
            {
                ImageButton16.ImageUrl = "http://localhost:46795/images/s.png";
                count3++;
            }
            else
            {
                ImageButton16.ImageUrl = "http://localhost:46795/images/d.png";
                count4++;
            }

        }

        Label1.Text = clicks.ToString();
        if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
        {
            set++;
            ImageButton16.Enabled = false;

        }
        Label3.Text = set.ToString();
        ImageButton16.Enabled = false;
    }
    public void validate()
    {

        if (count5 == 2)
        {
            if (count1 > 1 || count2 > 1 || count3 > 1 || count4 > 1)
            {
                
            }
            else
            {
                flip();
            }
        }
        else if (count5 == 3)
        {
            if (count1 > 2 || count2 > 2 || count3 > 2 || count4 > 2)
            {
              
            }
            else
            {
                flip();
            }
         
        }
        else if (count5 == 4)
        {
            if (count1 == 4 || count2 == 4 || count3 == 4 || count4 == 4)
            {
                count1 = 0;
                count2 = 0;
                count3 = 0;
                count4 = 0;
                count5 = 0;
            }
            else
            {
                flip();
            }
        }
        
    }
}