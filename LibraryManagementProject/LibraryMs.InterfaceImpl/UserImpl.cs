using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class UserImpl : IUserInterface
    {
        public List<UserRequestDo> getUserList()
        {
            List<UserRequestDo> userDoList = new List<UserRequestDo>();
            string path = @"C:\Users\Bhawna Rathor\Desktop\UserData.csv";
            string[] line = System.IO.File.ReadAllLines(path);
            foreach (string row in line)
            {
                string[] parts = row.Split(",");
                UserRequestDo userDoObj = new UserRequestDo();
                userDoObj.UserId = Convert.ToInt32(parts[0]);
                userDoObj.UserName = parts[1];
                userDoObj.UserEmail = parts[2];
                userDoObj.UserPassWord = parts[3];
                userDoList.Add(userDoObj);
            }
            return userDoList;
        }
        public Boolean signInUser(LoginRequestDo obj)
        {
            Boolean result = false;
            List<UserRequestDo> userDoList = getUserList();
            foreach (UserRequestDo u in userDoList) {
                if (obj.UserName.Equals(u.UserName))
                {
                    if (obj.UserPassword.Equals(u.UserPassWord))
                        result = true;
                    else
                        result = false;
                }
                else
                     result=false;
        
            }
            return result;
        }
    
        public Boolean signUpUser(UserRequestDo obj)
        {
            string path = @"C:\Users\Bhawna Rathor\Desktop\UserData.csv";
            List<UserRequestDo> list=getUserList();
            int id = list.Count + 1;
            string addline = obj.UserId+ "," + obj.UserName + "," + obj.UserEmail + "," + obj.UserPassWord;
            File.AppendAllText(path, addline);
            return true;
        }
    }
}
