﻿using CTW_FIA.Models.DatabaseModels;
using CTW_FIA.Models.Dto;

namespace CTW_FIA.Interface
{
    public interface IUser
    {
        public UserDto Login(string userName, string Password);
        public string GetLocalIPAddress();
        public string GetLocalMacAddress();
    }
}
