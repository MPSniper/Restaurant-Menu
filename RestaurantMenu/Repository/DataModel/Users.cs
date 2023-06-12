﻿using Service.DTO;
//using UI.ViewModels;

namespace Repository.DataModel
{
    public class Users
    {
        UsersDTO dto = new UsersDTO();

        string userName, userFamily, userNation, userAddress, password;
        public Users()
        {
           // UserCartViewModel userViewModel
        }
        public Users(string userName, string userFamily, string userNation, string userAddress, string password)
        {
            this.userName = userName;
            this.userFamily = userFamily;
            this.userNation = userNation;
            this.userAddress = userAddress;
            this.password = password;
        }
        public int BtnSignUp()
        {
            return dto.BtnSignUp(userName, userFamily, userNation, userAddress, password);
        }
        public int Login(string nationalCode, string password)
        {
            return dto.Login(nationalCode, password);
        }
    }
}
