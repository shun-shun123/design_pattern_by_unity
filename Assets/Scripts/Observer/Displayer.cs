using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

namespace Design.Observer
{
    public class Displayer : MonoBehaviour, Observer
    {
        [SerializeField] private Ball ball;
        [SerializeField] private Text messageText;

        private Subject subject;

        private bool isSubscribing;

        private void Start()
        {
            subject = ball;
        }

        private void Display(string message)
        {
            messageText.text = message;
        }

        public void Update(string message)
        {
            Display(message);
        }

        public void OnClick()
        {
            if (isSubscribing)
            {
                Unsubscribe();
            }
            else
            {
                Subscribe();
            }
            isSubscribing = !isSubscribing;
        }

        private void Subscribe()
        {
            subject.RegisterObserver(this);
        }

        private void Unsubscribe()
        {
            subject.RemoveRegister(this);
        }
    }
}