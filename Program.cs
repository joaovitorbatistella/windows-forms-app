using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            User user1 = new User("Admin", "admin@admin.com", "admin");
            User user2 = new User("Moderator", "mod@mod.com", "moderator");
            User user3 = new User("User One", "one@user.com", "userone");
            User user4 = new User("User Two", "two@user.com", "usertwo");
            User user5 = new User("User Three", "three@user.com", "userthree");

            List<User> users = new List<User> { user1, user2, user3, user4, user5, };

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginForm(users));
        }
    }
}
