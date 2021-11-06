using Utilities;
using System;

namespace Task8
{
    public class SubTask1 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var firstTv = new Tv(1, 10);
            firstTv.GoNext();
            firstTv.GoBack();
            firstTv.GoTo(10);
        }
    }
}