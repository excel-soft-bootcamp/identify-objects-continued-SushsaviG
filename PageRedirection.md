Concept of redirecting users in ASP.NET:
          In the implementation of web application it is required to redirect a user from one page to another page.
*Ways to Redirect the user from one page to another page
     1)Response.Redirect
     2)Server.Transfer
     3)Server.Execute
     
1)Response.Redirect:
       *we can redirect the users from one page to another page using Response.Redirect.
       *Response.Redirect allows absolute URL as well as relative URL.
       *The code present after Response.Redirect will not be executed.
       *In Response.Redirect source and destination pages can be present in same website or different website.
 For Example:
FirstPage.aspx.cs:
       namespace Asp.netRedirectingApp
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Secondpage.aspx");
            Response.Write("Hello");
        }
    }
}

SecondPage.aspx.cs:
namespace Asp.netRedirectingApp
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to SecondPage");
        }
    }
}

Output: Welcome to SecondPage

2)Server.Transfer:
             *Server.Transfer allows only relative URL.
             *The code present after Server.Transfer will not be executed.
             *In Server.Transfer source and destination pages must be present in same website .
For Example:

FirstPage.aspx.cs:
       namespace Asp.netRedirectingApp
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Secondpage.aspx");
            Response.Write("Hello");
        }
    }
}

SecondPage.aspx.cs:
namespace Asp.netRedirectingApp
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to SecondPage");
        }
    }
}

Output:  Welcome to SecondPage

3)Server.Execute:
             *Server.Execute allows only relative URL.
             *The code present after Server.Execute will  be executed.
             *In Server.Execute source and destination pages must be present in same website .
             
For Example:

FirstPage.aspx.cs:
       namespace Asp.netRedirectingApp
{
    public partial class FirstPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Server.Execute("Secondpage.aspx");
            Response.Write("Hello");
        }
    }
}

SecondPage.aspx.cs:
namespace Asp.netRedirectingApp
{
    public partial class SecondPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Welcome to SecondPage");
        }
    }
}

Output:  Welcome to SecondPage
         Hello
