using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer2;
using EntityLayer2;
using DataAccessLayer;

namespace ChatApplication
{
    public partial class Chat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            LoadMessage.LoadMes();

            foreach (string item in LoadMessage.LoadMes())
            {
                ListBox1.Items.Add(item);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityChat ent = new EntityChat();
            string Username = Request.QueryString["Username"];

            ent.Username = Username;
            ent.Chat = ent.Username+" :"+TextBox1.Text;
            ent.GroupName = "A";


            BLLmessage.AddMessageBLLL(ent);
            Response.Redirect(Request.RawUrl);
        }
    }
}