using System;
using System.Collections;
using System.Collections.Generic;
using Design.Observer;
using UnityEngine;

public class Ball : MonoBehaviour, Subject
{
    /// <summary>
    /// 購読しているオブジェクト群
    /// </summary>
    private List<Observer> observers = new List<Observer>();

    /// <summary>
    /// 通知する際に送信するメッセージ
    /// </summary>
    private string message;

    private void SetMessage()
    {
        message = $"{DateTime.Now.ToString("HH:mm:ss")} hit!";
    }

    public void NotifyObservers()
    {
        SetMessage();
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }

    public void RegisterObserver(Observer o)
    {
        observers.Add(o);
    }

    public void RemoveRegister(Observer o)
    {
        int index = observers.IndexOf(o);
        int notFound = -1;
        if (index != notFound)
        {
            observers.RemoveAt(index);
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("NotifyWall"))
        {
            NotifyObservers();
        }
    }
}
