using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.U1_W1_D4.OOP_III
{
    internal class Authentication
    {
        private string _email;
        public string Email { get { return _email; } set {
                if (value.Contains("@")) _email = value;
                else { Console.WriteLine("Email non valida"); }

        } }
        private string _password;
        public string Password { get { return _password;} }
        public void MenuOperazioni() 
        {
            Console.WriteLine("============OPERAZIONI===========");
            Console.WriteLine("Scegli l'operazione da effettuare:");
            Console.WriteLine("0. Esci");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Logout");
            Console.WriteLine("3. Verifica ora e data di Login");
            Console.WriteLine("4. Lista degli accessi");
            string scelta = Console.ReadLine();
            switch (scelta)
            {
                case "0": Environment.Exit(0); break;
                case "1": Console.WriteLine("email:"); 
                          Email = Console.ReadLine();
                    break;
                case "2": break;
                case "3": break;
                case "4": break;
                case "5": break;
                default: Console.WriteLine("Operazione non valida\n\n"); MenuOperazioni(); break;
            }
            MenuOperazioni();
        }
    }
}
