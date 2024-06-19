using System;

public class BankAcc {
    public int AccNumber {get; set;}
    public string ?OwnerName {get; set;}
    public decimal Balance {get; set;}

    public void Deposit(decimal amount) {
        Balance += amount;
    }

    public bool Withdraw(decimal amount) {
        if (amount <= Balance)
        {
            Balance -= amount;
            return true;
        }else {
            return false;
        }
    }
}