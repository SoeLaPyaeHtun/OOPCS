﻿using System;
namespace Polymorphism
{
    public class CurrentAccount : Account
    {

        public static double interestR = 0.25;

        public CurrentAccount(string number, string id, double bal) :
            base(number, id, bal) { }
        


        public override double CalculateInterest()
        {
            return balance * (interestR / 100);
        }



        public double CreditInterest()
        {
            return balance += CalculateInterest();
        }



        public override Boolean Withdraw(double amount)
        {
            if (amount < balance)
                return base.Withdraw(amount);
            else
                return false;
        }



        public override string ToString()
        {
            return "(CurrentAccout) Account: " + base.ToString();
        }
    }
}
