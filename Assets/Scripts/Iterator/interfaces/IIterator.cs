using System;

namespace Iterator.Interfaces
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}