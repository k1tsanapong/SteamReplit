using System;
using System.IO;

namespace Func
{

    public class file_func
    {

        public static string[] PullData(string file_name)
        {

            string path = Path(file_name);

            string[] data_base = File.ReadAllLines(path);
            return data_base;

        }

        public static string Path(string file_name)
        {

            string path = "./data/" + file_name + ".txt";
            return path;
        }

        public static bool ScanData(string check, int column, string[] data_base)
        {

            column--;

            for (int i = 0; i < data_base.Length; i++)
            {
                string[] fields = data_base[i].Split(',');

                if (check == fields[column])
                {
                    //Console.WriteLine("fail");
                    return false;                           //break
                }
            }

            //Console.WriteLine("Suc");
            return true;

        }

    }


    public class user_func
    {

        public static void AddNewUser(string name, string password)
        {
            Console.WriteLine(name + "," + password);
        }


        public static bool CheckUserName(string new_user_name)
        {
            string file_name = "user";
            string path = file_func.Path(file_name);
            string[] user_name = file_func.PullData(file_name);

            return file_func.ScanData(new_user_name, 1, user_name);

        }

        public static string CreateUser()
        {
            string new_user_name;
            int i = 1;

            // user_name condition if(new_user_name) {do something}


            do
            {
                if (i != 1)
                {
                    Console.WriteLine("fail");
                }

                Console.Write("User : ");
                new_user_name = Console.ReadLine();

                i++;

            } while (!CheckUserName(new_user_name));

            Console.WriteLine("Suc");
            return new_user_name;
        }

        public static string CreatePassWord()
        {

            string password;
            string password_confilm;
            do
            {
                Console.Write("Password : ");
                password = Console.ReadLine();

                Console.Write("Confilm Password : ");
                password_confilm = Console.ReadLine();

            } while (password != password_confilm);


            return password;
        }



    }



}