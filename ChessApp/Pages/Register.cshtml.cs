using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChessApp.Pages
{
    public class RegisterModell : PageModel
    {
        public string Name = " ";
        public string Password = " ";
        public string Passagain = " ";
        public string DisplayError = " ";

        public void OnPostRegister(string name, string password, string passagain)
        {
            if (name is null || password is null || passagain is null)
            {
                DisplayError = "Fill out every Textbox!";               
            }
            else if (!password.Equals(passagain) || SQLCommunication.LoginUser(name, password, true) == 0)
            {               
                DisplayError = "Check your given Passwords!";
            }
            else
            {               
                SQLCommunication.CreateUser(name, password);
                RedirectToPage("Chessboard");
            }
            SQLCommunication.conn.Close();
        }
    }
}