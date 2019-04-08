using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class Cashier
    {
        private CashRegisterCard _cardRegister;
        private CashRegisterPaper _paperRegister;
        private CashRegisterCoin _coinRegister;

        public Cashier()
        {
            _cardRegister = new CashRegisterCard();
            _paperRegister = new CashRegisterPaper();
            _coinRegister = new CashRegisterCoin();
        }

        public void CashIn(double value,EMoneyType type)
        {
            switch (type) {
                case EMoneyType.Coin:
                    _coinRegister.CashIn(value);
                    break;
                case EMoneyType.Paper:
                    _paperRegister.CashIn(value);
                    break;
                case EMoneyType.Card:
                    _cardRegister.CashIn(value);
                    break;
                default:
                    break;
            }

        }

        public void CashOut(double value,EMoneyType type)
        {
            switch (type) {
                case EMoneyType.Coin:
                    _coinRegister.CashOut(value);
                    break;
                case EMoneyType.Paper:
                    _paperRegister.CashOut(value);
                    break;
                case EMoneyType.Card:
                    _cardRegister.CashOut(value);
                    break;
                default:
                    break;
            }
        }

        public double GetTotalCash()
        {
            double total = 0;
            total += _cardRegister.GetTotalCash();
            total += _coinRegister.GetTotalCash();
            total += _paperRegister.GetTotalCash();
            return total;
        }
    }
}
