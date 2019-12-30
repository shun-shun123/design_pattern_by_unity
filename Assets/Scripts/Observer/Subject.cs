using System;

namespace Design.Observer
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void RemoveRegister(Observer o);
        void NotifyObservers();
    }
}