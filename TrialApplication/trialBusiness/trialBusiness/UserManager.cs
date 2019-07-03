using System;
using System.Collections.Generic;
using System.Text;
using trialData;

namespace trialBusiness
{
    public class UserManager : IUserManager
    {
        private readonly IDataManager _datamanager;
        public UserManager(IDataManager dataManager)
        {
            _datamanager = dataManager;
        }

        public ExampleModel GetExampleModel()
        {
            return _datamanager.GetExampleModel();
        }
    }
}