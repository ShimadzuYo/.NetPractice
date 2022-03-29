using System;

namespace DelegatePractice
{
    public class ActionFuncPredicate
    {
        public Func<int, int, int> AdditionFunc;
        public Func<int, int, int> AdditionFuncWArgs = (int arg1, int arg2) => arg1 + arg2;


    }
    
    
    
}