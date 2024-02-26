using BusinessLayer2;
using EntityLayer2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer2;
using EntityLayer2;

namespace ChatApplication
{
    public partial class LogIn1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            UserEntity ent = new UserEntity();
            ent.Username = TextBox1.Text;
            ent.Password = TextBox2.Text;

            BLLlogin.UserLog(ent);
            Response.Redirect("Chat.aspx?Username="+ent.Username);
        }
    }
}
