using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_3
{
    public class Authentification
    {
        
        public static void AuthentifyUser(Person currentPerson)

        {
            Person testPerson = new Person("toto", "1234");
            Console.WriteLine("Please enter a user name");

            currentPerson.Name = Console.ReadLine();
            Console.WriteLine("Please enter a password");
            currentPerson.Password = PromptPassword();
            
            if (currentPerson.Name == testPerson.Name)
            {
                Console.WriteLine("the user exist in DB");

                if (currentPerson.Password == testPerson.Password)
                {
                    //renvoyer à la page après connexion (page d'accueil)

                    Console.WriteLine("Authentification succeded");
                }
                else
                {
                    
                    Console.WriteLine("The password is not corresponding to the user", "Authentification failed !");
                }
            }
            else
            {
                
                Console.WriteLine("The user doesn't exist or was miswritten");
                
            }



            /* on affecte les cases d'infos entrées 
            currentPerson.Name = TextBox1.Text;
            currentPerson.Password = PromptPassword();
            currentPerson.Password = Sha256Tools.GetHash(TextBox2.Text);
            

            //on cherche si le nom de la person existe en base de donnée
            if (DatabaseServices.IsPersonExisting(currentPerson.Name))
            {
                if (DatabaseServices.IsPasswordCorresponding(currentPerson.Password, currentPerson.Name)
                {
                    //renvoyer à la page après connexion (page d'accueil)

                    Logger.DisplaySucceedMessage("Authentification succeded");
                }
                else 
                {
                    TextBox1.Empty();
                    TextBox2.Empty();
                    MessageBox.Show("The password is not corresponding to the user", "Authentification failed !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Logger.DisplayErrorMessage("Authentification failed, the password was not corresponding to the user");
                }
            }
            else
            {
                TextBox1.Empty();
                TextBox2.Empty();
                MessageBox.Show("The user doesn't exist or was miswritten", "User issue!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Logger.DisplayErrorMessage("The user doesn't exist or was miswritten");
            }
            */
        }

        public static string PromptPassword()
        {
            {
                string password = "";
                ConsoleKeyInfo info = Console.ReadKey(true);
                while (info.Key != ConsoleKey.Enter)
                {
                    if (info.Key != ConsoleKey.Backspace)
                    {
                        Console.Write("*");
                        password += info.KeyChar;
                    }
                    else if (info.Key == ConsoleKey.Backspace)
                    {
                        if (!string.IsNullOrEmpty(password))
                        {
                            // remove one character from the list of password characters
                            password = password.Substring(0, password.Length - 1);
                            // get the location of the cursor
                            int pos = Console.CursorLeft;
                            // move the cursor to the left by one character
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                            // replace it with space
                            Console.Write(" ");
                            // move the cursor to the left by one character again
                            Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        }
                    }
                    info = Console.ReadKey(true);
                }
                // add a new line because user pressed enter at the end of their password
                Console.WriteLine();
                return password;
            }
        }
    }
}