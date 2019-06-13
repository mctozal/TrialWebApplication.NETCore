using System;
using System.Collections.Generic;

namespace trialBusiness
{
    public interface IUserManagement
    {

        List<UserModel> GetSystemUserList(bool isActive = false);

    }
}
