class Account
{
	public int id {get;set;}
	public string name {get;set;}
	public double balance {get;set}
	
	public void Dsposit(double amount)
	{
		balance = amount+=balance;
		
	}
	
	public void Withdraw(double amount)
	{
		balance = amount -= balance;
	}
	
	
}

class SavingAccount : Account
{
	public float interestRate {get;set;}
	public double balance {get;set:}
	
	public void InterestRate()
	{
		balance = balance * ( 1 * interestRate);
	}
	
}