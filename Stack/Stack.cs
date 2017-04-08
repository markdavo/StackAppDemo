using System;
using System.Collections;

namespace StackApp
{
    public class Stack : Object
    {
        private object object1;
        private readonly ArrayList list = new ArrayList();

        public void Push(object obj)
        {
            if (obj != null)
            {
                list.Add(obj); 
            }
            else
            {
                throw new InvalidOperationException("You can not push nothing to the Stack"); 
            }
        }

        public object Pop()
        {
            if (list.Count != 0)
            {
                object1 = list[list.Count - 1];
                list.Remove(object1); 
            } else
            {
                throw new InvalidOperationException("Stack is already empty. Nothing to remove. ");
            }
            return object1; 
        }

        public void Clear()
        {
            if (list.Count != 0)
            {
                list.Clear(); 
            }
            else
            {
                throw new InvalidOperationException("Stack is already cleared");
            }
        }
    }
}
