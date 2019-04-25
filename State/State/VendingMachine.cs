using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class VendingMachine
    {
        public NoCoinState NoCoinState { get; set; }
        public HasCoinState HasCoinState { get; set; }
        public SoldOutState SoldOutState { get; set; }
        public SoldState SoldState { get; set; }

        private int capacity;
        private State state;

        public VendingMachine()
        {
            NoCoinState = new NoCoinState();
            HasCoinState = new HasCoinState();
            SoldState = new SoldState();
            SoldOutState = new SoldOutState();
            capacity = 10;
        }

        public void UpdateState(EUserOption option)
        {
            switch (option) {
                case EUserOption.InsertCoin:
                    if (InsertCoin()) {
                        state = HasCoinState;
                    }
                    break;
                case EUserOption.EjectCoin:
                    if (EjectCoin()) {
                        state = NoCoinState;
                    }
                    break;
                case EUserOption.BuyProduct:
                    if (BuyProduct()) {
                        capacity--;
                        state = SoldState;
                    }
                    break;
                case EUserOption.FillMachine: {
                        ReFill();
                        state = NoCoinState;
                    }                    
                    break;
                case EUserOption.InspectMachine:
                    Inspect();
                    break;
                case EUserOption.Exit:
                    break;
                default:
                    break;
            }
        }

        private void ReFill()
        {
            capacity = 10;
        }

        private bool InsertCoin()
        {
            return state.InsertCoin();
        }

        private bool EjectCoin()
        {
            return state.EjectCoin();
        }

        private bool BuyProduct()
        {
            return state.BuyProduct();
        }

        private void Inspect()
        {
            Console.WriteLine(state+" capacity: "+capacity);
        }

        public bool IsEmpty()
        {
            return capacity == 0;
        }

        public void SetMachineState(State state)
        {
            this.state = state;
        }
    }
}
