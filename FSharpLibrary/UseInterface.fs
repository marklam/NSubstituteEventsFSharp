namespace FSharpLibrary

open System.ComponentModel

type IInterface =
    [<CLIEvent>]
    abstract Cancelable : IEvent<CancelEventHandler, CancelEventArgs>

module UseInterface =
    let hookupCancel (thing : IInterface) =
        thing.Cancelable.Add (fun args -> args.Cancel <- true)
