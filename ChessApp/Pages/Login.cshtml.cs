using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChessApp.Pages
{
    public class Login : PageModel
    {
        public string Name = " ";
        public string Password = " ";
        public string DisplayProblem = " ";

        public void OnPostLogin(string name, string password)
        {          
            if (name is null || password is null)
            {
                DisplayProblem = "Fill out every TextBox!";
            }

            else if (SQLCommunication.LoginUser(name, password, false) != 1)
            {
                DisplayProblem = "Check your input!";
            }

            else
            {
                DisplayProblem = "Success";
                RedirectToPage("Chessboard");
            }

            SQLCommunication.conn.Close();
        }
    }
}