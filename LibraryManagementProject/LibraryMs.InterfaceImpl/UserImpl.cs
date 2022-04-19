using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class UserImpl : IUserInterface
    {
        public UserResponseDo signInUser(LoginRequestDo obj)
        {
            UserResponseDo usrRespObj=new UserResponseDo();
            usrRespObj.UserId = 1;
            usrRespObj.UserName = "ram";
            usrRespObj.UserEmail = "ram1234@gmail.com";
            return usrRespObj;
        }

        public UserResponseDo signUpUser(UserRequestDo obj)
        {
            UserResponseDo usrRespObj = new UserResponseDo();

            return usrRespObj;
        }
    }
}
