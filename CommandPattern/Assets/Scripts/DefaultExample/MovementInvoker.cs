using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Invoker
/// </summary>
public class MovementInvoker 
{
    private Stack<ICommand> _commands;

    public MovementInvoker()
    {
        _commands = new Stack<ICommand>();
    }

    public void AddCommand(ICommand newCommand)
    {
        newCommand.Execute();

        _commands.Push(newCommand);
    }

    public void UndoCommand()
    {
        if (_commands.Count > 0)
        {
            ICommand lastCommand = _commands.Pop();
            lastCommand.Undo();
        }
    }
}
