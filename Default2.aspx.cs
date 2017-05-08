using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Data.SqlClient;
using System.Media;
public partial class Default2 : System.Web.UI.Page
{
    
    static List<int> x = new List<int>() { 11, 15, 17, 19, 21, 23,25,27,29 };
    static int k, count1,count2,count3,count4, set = 0, clicks = 0, hit1, hit2, hit3, hit4, hit5, hit6, hit7,hit8,hit9;
    static int v1, v2, v3, v4, v5, v6, v7, v8, v9;
    int id, g;
    static List<string> y = new List<string>{"ImageButton1", "ImageButton2", "ImageButton3", "ImageButton4",
        "ImageButton5", "ImageButton6", "ImageButton7"
, "ImageButton8", "ImageButton9"};
    static List<string> clicked = new List<string>();
    SoundPlayer music = new SoundPlayer();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        
        //UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
        //music.SoundLocation =@"C:\6303\MemoryGame_VVGB\music\music1.wav";
        //music.Play();
        //music.PlayLooping();
        if (!IsPostBack)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            music.SoundLocation = @"C:\6303\MemoryGame_VVGB\music\music1.wav";
            music.Play();
            music.PlayLooping();
        }
        //    string[] level1values = (String[])Session["L1"];
        //    Label5.Text = level1values[0];
        //    Label6.Text = level1values[1];
        //    clicks = Convert.ToInt16(Label6.Text);
        //  //  Label7.Text = level1values[2];
        //   // set = Convert.ToInt16(Label7.Text);
        //    Label8.Text = level1values[3];
        //     g= Convert.ToInt16(Label8.Text);
        //}
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        clicked.Add("ImageButton1");
        count4++;
        hit1++; 
        clicks++;
        if(x.Count ==0)
        addtolist();
        if (hit1 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int a = x[id];
            ViewState["b1"] = a;
            v1 = Convert.ToInt16(ViewState["b1"]);
  
            x.RemoveAt(id);
            if (a == 11 || a == 15 || a==17)
            {

                ImageButton1.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (a == 19 || a == 21 || a == 23)
            {
                ImageButton1.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton1.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton1.Enabled = false;
        }

        if (hit1 > 1)
        {
            
            if (v1 == 11 || v1 == 15 || v1 == 17)
            {

                ImageButton1.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (v1 == 19 || v1 == 21 || v1 == 23)
            {
                ImageButton1.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton1.ImageUrl = @"~\images\d.png";
                count3++;
            }

        }

        Label5.Text = clicks.ToString();
        if (count1 == 3 || count2 == 3 || count3 == 3)
        {
            set++;
          //  y.Remove("ImageButton1");
            //ImageButton1.Enabled = false;
           
        }
        Label7.Text = set.ToString();
        ImageButton1.Enabled = false;
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        clicked.Add("ImageButton2");
        count4++;
        hit2++;
        clicks++;
        if(x.Count==0)
        addtolist();
        if (hit2 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int b = x[id];
            ViewState["b2"] = b;
            v2 = Convert.ToInt16(ViewState["b2"]);
            x.RemoveAt(id);

            if (b == 11 || b == 15 || b== 17)
            {

                ImageButton2.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (b == 19 || b == 21 || b == 23)
            {
                ImageButton2.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton2.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton2.Enabled = false;
        }

        if (hit2 > 1)
        {
            // Label5.Text += v1.ToString();
            if (v2 == 11 || v2 == 15 || v2 == 17)
            {

                ImageButton2.ImageUrl = @"~\images\r.png"; ;
                count1++;
            }
            else if (v2 == 19 || v2 == 21 || v2 == 23)
            {
                ImageButton2.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton2.ImageUrl = @"~\images\d.png";
                count3++;
            }

        }

  
        Label5.Text = clicks.ToString();
        if (count1 == 3 || count2 == 3 || count3 == 3)
        {
            set++;
           // y.Remove("ImageButton2");
            //ImageButton2.Enabled = false;

        }
        Label7.Text = set.ToString();
        ImageButton2.Enabled = false;
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        clicked.Add("ImageButton3");
        count4++;
        hit3++;
        clicks++;
        if(x.Count==0)
        addtolist();
        if (hit3 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int c = x[id];
            ViewState["b3"] = c;
            v3 = Convert.ToInt16(ViewState["b3"]);
            x.RemoveAt(id);
            if (c == 11 || c == 15 || c == 17)
            {

                ImageButton3.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (c == 19 || c == 21 || c == 23)
            {
                ImageButton3.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton3.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton3.Enabled = false;
        }

        if (hit3 > 1)
        {
            // Label5.Text += v1.ToString();
            if (v3 == 11 || v3 == 15 || v3 == 17)
            {

                ImageButton3.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (v3 == 19 || v3 == 21 || v3 == 23)
            {
                ImageButton3.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton3.ImageUrl = @"~\images\d.png";
                count3++;
            }

        }

      
        Label5.Text = clicks.ToString();
        if (count1 == 3 || count2 == 3 || count3 == 3)
        {
            set++;
          //  y.Remove("ImageButton3");
           // ImageButton3.Enabled = false;

        }
        Label7.Text = set.ToString();
        ImageButton3.Enabled = false;
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        clicked.Add("ImageButton4");
        count4++;
        hit4++;
        clicks++;
        if(x.Count==0)
        addtolist();
        if (hit4 == 1)
        {
            Random r = new Random();
            id = r.Next(0, x.Count);
            int d = x[id];
            ViewState["b4"] = d;
            v4 = Convert.ToInt16(ViewState["b4"]);
            x.RemoveAt(id);

            if (d == 11 || d == 15 || d == 17)
            {

                ImageButton4.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (d == 19 || d == 21 || d == 23)
            {
                ImageButton4.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton4.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton4.Enabled = false;
        }

        if (hit4 > 1)
        {
            // Label5.Text += v1.ToString();
            if (v4 == 11 || v4 == 15 || v4 == 17)
            {

                ImageButton4.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (v4 == 19 || v4 == 21 || v4 == 23)
            {
                ImageButton4.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton4.ImageUrl = @"~\images\d.png";
                count3++;
            }

        }


        Label5.Text = clicks.ToString();
        if (count1 == 3 || count2 == 3 || count3 == 3)
        {
            set++;
          //  y.Remove("ImageButton4");

           // ImageButton4.Enabled = false;

        }
        Label7.Text = set.ToString();
        ImageButton4.Enabled = false;
    }
    public void validate()
    {

        if (count4 == 2)
        {
            if (count1 > 1 || count2 > 1 || count3 > 1)
            {
                //flip();
            }
            else
            {
                flip();
            }
        }
        if (count4 >= 3)
        {
            if (count1 > 1 || count2 > 1 || count3 > 1)
            {
                flip();
            }
            //else
            //{
            //    foreach (string rem in y)
            //    {
            //        switch (rem)
            //        {
            //            case "Imagebutton1":
            //                ImageButton1.Enabled = false;

            //                break;
            //            case "Imagebutton2":
            //                ImageButton2.Enabled = false;

            //                break;
            //            case "Imagebutton3":
            //                ImageButton3.Enabled = false;

            //                break;
            //            case "Imagebutton4":
            //                ImageButton4.Enabled = false;

            //                break;
            //            case "Imagebutton5":
            //                ImageButton5.Enabled = false;

            //                break;
            //            case "Imagebutton6":
            //                ImageButton6.Enabled = false;

            //                break;
            //            case "Imagebutton7":
            //                ImageButton7.Enabled = false;

            //                break;
            //            case "Imagebutton8":
            //                ImageButton8.Enabled = false;

            //                break;
            //            case "Imagebutton9":
            //                ImageButton9.Enabled = false;

            //                break;
            //        }
            //    }
                //count1 = 0;
                //count2 = 0;
                //count3 = 0;
                //count4 = 0;
            //}
            if (count1 == 3 || count2 == 3 || count3 == 3)
            {
                var three = clicked.Take(3);
                foreach (string btn in three)
                {
                   
                    switch (btn)
                    {
                        case "Imagebutton1":
                            y.Remove("Imagebutton1");
                            ImageButton1.Enabled = false;
                            break;
                        case "Imagebutton2":
                            y.Remove("Imagebutton2");
                            ImageButton2.Enabled = false;
                            break;
                        case "Imagebutton3":
                            y.Remove("Imagebutton3");
                            ImageButton3.Enabled = false; 
                            break;
                        case "Imagebutton4":
                            y.Remove("Imagebutton4");
                            ImageButton4.Enabled = false;  
                            break;
                        case "Imagebutton5":
                            y.Remove("Imagebutton5");
                            ImageButton5.Enabled = false;
                            break;
                        case "Imagebutton6":
                            y.Remove("Imagebutton6");
                            ImageButton6.Enabled = false;
                            break;
                        case "Imagebutton7":
                            y.Remove("Imagebutton7");
                            ImageButton7.Enabled = false;
                            break;
                        case "Imagebutton8":
                            y.Remove("Imagebutton8");
                            ImageButton8.Enabled = false;
                            break;
                        case "Imagebutton9":
                            y.Remove("Imagebutton9");
                            ImageButton9.Enabled = true;
                            break;
                    }
                }
                foreach (string rem in y)
                {
                    switch (rem)
                    {
                        case "Imagebutton1":
                            ImageButton1.Enabled = true;

                            break;
                        case "Imagebutton2":
                            ImageButton2.Enabled = true;

                            break;
                        case "Imagebutton3":
                            ImageButton3.Enabled = true;

                            break;
                        case "Imagebutton4":
                            ImageButton4.Enabled = true;

                            break;
                        case "Imagebutton5":
                            ImageButton5.Enabled = true;

                            break;
                        case "Imagebutton6":
                            ImageButton6.Enabled = true;

                            break;
                        case "Imagebutton7":
                            ImageButton7.Enabled = true;

                            break;
                        case "Imagebutton8":
                            ImageButton8.Enabled = true;

                            break;
                        case "Imagebutton9":
                            ImageButton9.Enabled = true;

                            break;
                    }
                }
                count1 = 0;
                count2 = 0;
                count3 = 0;
               // count4 = 0;

            }
            else
            {
               // flip();
               
            }
        }
    }
 
        
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        k++;

        if (k % 2 == 0)

            Label6.Text = (Convert.ToInt16(Label6.Text) + 1).ToString();

        int sec1 = Convert.ToInt16(Label6.Text);

        validate();
         g = (100 * 4 - sec1 - 10 * clicks) * set;
        //  Response.Redirect("~/Default2.aspx?score=" + g);
        Label8.Text = g.ToString();
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
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        clicked.Add("ImageButton5");
        count4++;
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

            if (f == 11 || f == 15 || f == 17)
            {

                ImageButton5.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (f == 19 || f == 21 || f == 23)
            {
                ImageButton5.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton5.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton5.Enabled = false;
        }

        if (hit5 > 1)
        {
            // Label5.Text += v1.ToString();
            if (v5 == 11 || v5 == 15 || v5 == 17)
            {

                ImageButton5.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (v5 == 19 || v5 == 21 || v5 == 23)
            {
                ImageButton5.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton5.ImageUrl = @"~\images\d.png";
                count3++;
            }

        }
        Label5.Text = clicks.ToString();
        if (count1 == 3 || count2 == 3 || count3 == 3)
        {
            set++;
          //  y.Remove("ImageButton5");
          //  ImageButton5.Enabled = false;

        }
        Label7.Text = set.ToString();
        ImageButton5.Enabled = false;
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        clicked.Add("ImageButton6");
        count4++;
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

            if (g == 11 || g == 15 || g == 17)
            {

                ImageButton6.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (g == 19 || g == 21 || g == 23)
            {
                ImageButton6.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton6.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton6.Enabled = false;
        }

        if (hit6 > 1)
        {
            // Label5.Text += v1.ToString();
            if (v6 == 11 || v6 == 15 || v6 == 17)
            {

                ImageButton6.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (v6 == 19 || v6 == 21 || v6 == 23)
            {
                ImageButton6.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton6.ImageUrl = @"~\images\d.png";
                count3++;
            }

        }
        Label5.Text = clicks.ToString();
        if (count1 == 3 || count2 == 3 || count3 == 3)
        {
            set++;
          //  y.Remove("ImageButton6");
           // ImageButton6.Enabled = false;

        }
        Label7.Text = set.ToString();
        ImageButton6.Enabled = false;
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        clicked.Add("ImageButton7");
        count4++;
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

            if (h == 11 || h == 15 || h== 17)
            {

                ImageButton7.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (h == 19 || h== 21 || h == 23)
            {
                ImageButton7.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton7.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton7.Enabled = false;
        }

        if (hit7 > 1)
        {
            // Label5.Text += v1.ToString();
            if (v7 == 11 || v7 == 15 || v7 == 17)
            {

                ImageButton7.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (v7 == 19 || v7 == 21 || v7 == 23)
            {
                ImageButton7.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton7.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton7.Enabled = false;
        }
        Label5.Text = clicks.ToString();
        if (count1 == 3 || count2 == 3 || count3 == 3)
        {
            set++;
            //y.Remove("ImageButton7");
            //ImageButton7.Enabled = false;

        }
        Label7.Text = set.ToString();
        ImageButton7.Enabled = false;
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        clicked.Add("ImageButton8");
        count4++;
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

            if (g == 11 || g == 15 || g == 17)
            {

                ImageButton8.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (g == 19 || g == 21 || g == 23)
            {
                ImageButton8.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton8.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton8.Enabled = false;
        }

        if (hit8 > 1)
        {
            // Label5.Text += v1.ToString();
            if (v8 == 11 || v8 == 15 || v8 == 17)
            {

                ImageButton8.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (v8 == 19 || v8 == 21 || v8 == 23)
            {
                ImageButton8.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton8.ImageUrl = @"~\images\d.png";
                count3++;
            }

        }
        Label5.Text = clicks.ToString();
        if (count1 == 3 || count2 == 3 || count3 == 3)
        {
            set++;
           // y.Remove("ImageButton8");
           // ImageButton8.Enabled = false;

        }
        Label7.Text = set.ToString();
        ImageButton8.Enabled = false;
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        clicked.Add("ImageButton9");
        count4++;
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

            if (g == 11 || g == 15 || g == 17)
            {

                ImageButton9.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (g == 19 || g == 21 || g == 23)
            {
                ImageButton9.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton9.ImageUrl = @"~\images\d.png";
                count3++;
            }
            ImageButton9.Enabled = false;
        }

        if (hit9 > 1)
        {
            // Label5.Text += v1.ToString();
            if (v9 == 11 || v9 == 15 || v9 == 17)
            {

                ImageButton9.ImageUrl = @"~\images\r.png";
                count1++;
            }
            else if (v9 == 19 || v9 == 21 || v9 == 23)
            {
                ImageButton9.ImageUrl = @"~\images\p.png";
                count2++;
            }
            else
            {
                ImageButton9.ImageUrl = @"~\images\d.png";
                count3++;
            }

        }
        Label5.Text = clicks.ToString();
        if (count1 == 3 || count2 == 3 || count3 == 3)
        {
            set++;
          //  y.Remove("ImageButton9");
           // ImageButton9.Enabled = false;

        }
        Label7.Text = set.ToString();
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
        ImageButton1.Enabled = true;
          ImageButton2.Enabled = true;
         ImageButton3.Enabled = true;
            ImageButton4.Enabled = true;
            ImageButton5.Enabled = true;
            ImageButton6.Enabled = true;
            ImageButton7.Enabled = true;
            ImageButton8.Enabled = true;
           ImageButton9.Enabled = true;
            count4 = 0;
            count1 = 0;
            count2 = 0;
            count3 = 0;
        
    }

    protected void Quit_Click(object sender, EventArgs e)
    {
        string username = LoginName1.Page.User.Identity.Name;
        if (username == null)
        {
            // Server.Transfer("http://localhost:46795/Default.aspx");
        }
        else
        {
            int l = 2;
            string date = DateTime.Now.ToString();
            int lc = 1;
            if (Label7.Text == "")
                Label7.Text = "0";
            else if (Label7.Text == "3")
                lc = 2;
            string a = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\MemoryGame.mdf;Integrated Security=True";
            SqlConnection x = new SqlConnection(a);
            SqlCommand b = new SqlCommand("insert into scores values('" + username + "','" + date + "','" + lc + "','" + l + "','" + Label7.Text + "','" + Label8.Text + "')", x);
            x.Open();
            b.ExecuteNonQuery();
            Label5.Text = "0";
            clicks = 0;
            set = 0;
            Label8.Text = "";
        }
    }
    protected void nextlevel_Click(object sender, EventArgs e)
    {
        music.Stop();
        if (x.Count == 0)
        {
           
            Timer1.Enabled = false;
            string[] level2 = new string[4];
            //level1[0] = username;
            level2[0] = Label5.Text;
            level2[1] = Label6.Text;
            level2[2] = Label7.Text;
            level2[3] = Label8.Text;
            Session["L2"] = level2;
            Response.Redirect("http://localhost:46795/Default3.aspx");
        }
        else
        {
            return;
        }
    }
}