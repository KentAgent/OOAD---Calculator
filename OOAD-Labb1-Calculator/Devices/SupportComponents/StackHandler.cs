using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OOADLabb1Calculator
{
    class StackHandler<T>
    {
        private Stack<IUndoRedo<T>> _undoStack;
        private Stack<IUndoRedo<T>> _redoStack;

        public int UndoCount
        {
            get { return _undoStack.Count(); }
        }
        public int RedoCount
        {
            get { return _redoStack.Count(); }
        }
        public void Reset()
        {
            _undoStack = new Stack<IUndoRedo<T>>();
            _redoStack = new Stack<IUndoRedo<T>>();
        }

        public StackHandler()
        {
            Reset();
        }

        public T Do(IUndoRedo<T> command, T input)
        {
            T output = command.Do(input);
            _undoStack.Push(command);
            _redoStack.Clear();
            return output;
        }

        public T Undo(T input)
        {
            if (_undoStack.Count > 0)
            {
                IUndoRedo<T> command = _undoStack.Pop();
                T output = command.Undo(input);
                _redoStack.Push(command);
                return output;
            } else
            {
                return input;
            }
        }

        public T Redo(T input)
        {
            if (_redoStack.Count > 0)
            {
                IUndoRedo<T> command = _redoStack.Pop();
                T output = command.Do(input);
                _undoStack.Push(command);
                return output;
            } else
            {
                return input;
            }
        }
    }
}
