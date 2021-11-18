using System;
using Utilities;

namespace Task9
{
    public class SubTask1 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var storeTest = new Store();
            storeTest.Inspect(storeTest);
            
            
        }
    }
}

