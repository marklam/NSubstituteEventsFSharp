using NSubstitute;
using FSharpLibrary;
using System.ComponentModel;
using System.Diagnostics;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var thing = Substitute.For<IInterface>();
            var cancelEventArgs = new CancelEventArgs();

            UseInterface.hookupCancel(thing);

            thing.Cancelable += Raise.Event<CancelEventHandler>(null, cancelEventArgs);

            Debug.Assert(cancelEventArgs.Cancel);
        }
    }
}
