using State.Abstract;
using State.State;
using UnityEngine;

namespace State
{

    public class GumBallMachine
    {
        public AbstractState SoldOutState { get; private set; }
        public AbstractState NoQuarterState { get; private set; }
        public AbstractState HasQuarterState { get; private set; }
        public AbstractState SoldState { get; private set; }
        
        public AbstractState WinnerState { get; private set; }

        private AbstractState _state;
        public int GumCount { get; private set; }

        public GumBallMachine(int numOfGums)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            GumCount = numOfGums;
            if (GumCount > 0)
            {
                _state = NoQuarterState;
            }
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void SetState(AbstractState state)
        {
            _state = state;
        }

        public void ReleaseBall()
        {
            Debug.Log("ガムがスロットから出てきます...");
            if (GumCount > 0)
            {
                GumCount--;
                Debug.Log("ガムが出てきました");
            }
            else
            {
                Debug.Log("ガムの残りがありません");
            }
        }
    }
}