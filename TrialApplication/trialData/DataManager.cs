using System;

namespace trialData
{
    public class DataManager : IDataManager
    {
        public ExampleModel GetExampleModel()
        {
            return new ExampleModel
            {
                id = 0,
                isComplete = true,
                name = "FirstData"
            };
        }
    }
}
