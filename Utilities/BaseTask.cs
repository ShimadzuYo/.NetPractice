using System;

namespace Utilities
{
    public abstract class BaseTask
    {
        private const string Separator = "##########";

        public virtual void Start()
        {
            var currentType = GetType();
            Console.WriteLine(Separator);
            Console.WriteLine($"{currentType.Namespace}. {currentType.Name}");
            Console.WriteLine(Separator);
        }
    }
}