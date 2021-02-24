using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Specialized;
using System.Collections.ObjectModel;

namespace LPLab10
{
    static class ChangeReaction
    {
        public static void Reaction(object sender, NotifyCollectionChangedEventArgs changes)
        {
            switch (changes.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Collection was changed. New items:");
                    foreach (Car el in changes.NewItems)
                    {
                        Console.WriteLine(el.ToString());
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Collection was changed. Deleted items:");
                    foreach (Car el in changes.OldItems)
                    {
                        Console.WriteLine(el.ToString());
                    }
                    break;
            }
            return;
        }
    }
}
