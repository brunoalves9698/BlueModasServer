using BlueModas.Domain.Commands.Core;

namespace BlueModas.Domain.Handlers.Core
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
