namespace App_13_2
{
    interface IDataService
    {
        void Save(string data);
    }

    class AnotherClass
    {
        private IDataService _dataService;

        public AnotherClass(IDataService dataService)
        {
            _dataService = dataService;
        }

        public void DoSomething()
        {
            _dataService.Save("DATA");
        }
    }
}
