using System;

namespace DelegatePractice

{
    class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            var subscriber = new Subscriber();
            var customSub = new CustomSub(bank);
            bank.RegisterDelegate(OutputMessage);
            
            bank.TakeSomeMoola(100);
            bank.MoneyTaken += subscriber.Notification;
            
            
            bank.TakeSomeMoola(200);
            bank.TakeSomeMoola(300);
            bank.TakeSomeMoola(400);
            Console.WriteLine("---------------------------------------------");
            var act = new ActionFuncPredicate();
            act.AdditionFunc = Addition;
            var result = act.AdditionFunc(10,10);
            Console.WriteLine(result);
            var resultWArgs = act.AdditionFuncWArgs(10, 20);
            Console.WriteLine(resultWArgs);
            
            Action WriteSHit = delegate { Console.WriteLine("WroteShit"); };
            WriteSHit.Invoke();

            Action<string> greet = name =>
            {
                Console.WriteLine($"Hello {name}");
            };
            greet.Invoke("Vasya");

            Action<string> writeshit = OutputMessage;
            var hui = "hui";
            writeshit.Invoke(hui);
            var idi = "idi";
            var nahui = "nahui";
            Console.WriteLine("Idi = {0}, {1}", idi, nahui);
            
            



            void OutputMessage(string message)
            {
                Console.WriteLine(message);
            }
            
            
            int Addition(int p1, int p2)
            {
                return p1 + p2;
            }
            


            // Action<int> doaflip = flip => flip += 10;
            //
            // void PrintShit(Action<int> act)
            // {
            //     Console.WriteLine(act.ToString());
            //     
            // }
            //
            //
            // PrintShit(doaflip);
        }
    }
}