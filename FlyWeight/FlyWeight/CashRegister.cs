using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public abstract class CashRegister
    {
        private Dictionary<double, Money> _sharedMoneyMap;
        protected Money _unsharedMoney;

        public CashRegister()
        {
            _sharedMoneyMap = new Dictionary<double, Money>();
        }

        protected Money LookUp(double value)
        {            
            if (!_sharedMoneyMap.ContainsKey(value)) {
                _sharedMoneyMap[value] = CreateNewMoney();
            }
            
            return _sharedMoneyMap[value];
        }

        public void CashIn(double value)
        {
            if (IsSharedValue(value)) {
                Money money = LookUp(value);
                money.TotalCashValue += value;
            } else {
                if(_unsharedMoney == null) {
                    _unsharedMoney = CreateNewMoney();
                }
                _unsharedMoney.TotalCashValue += value;
            }           
        }

        public void CashOut(double value)
        {
            if (IsSharedValue(value)) {
                Money money = LookUp(value);
                money.TotalCashValue -= value;
                if (money.TotalCashValue == 0) {
                    _sharedMoneyMap.Remove(value);
                }
            }
        }

        public double GetTotalCash()
        {
            double totalValue = 0.0;

            foreach (KeyValuePair<double, Money> entry in _sharedMoneyMap) {
                totalValue += entry.Value.TotalCashValue;
            }
            
            if (_unsharedMoney != null) {
                totalValue += _unsharedMoney.TotalCashValue;
            }
            
            return totalValue;
        }

        public abstract Money CreateNewMoney();
        public abstract bool IsSharedValue(double value);

    }
}
