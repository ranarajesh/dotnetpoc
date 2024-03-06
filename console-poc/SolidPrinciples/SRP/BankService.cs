namespace console_poc.SolidPrinciples.SRP;
public class BankService
{
    public double WithDraw(){
        return 0;
    }
    public double Deposit(long amount, string accountNumber){
        return 0;
    }
    public void LoanService(){

    }
    public void PrintPassBook(string accountNumber){

    }
    public void SendOTP(string medium){
        if(medium == "email"){
            // add email logic to send otp
        }
    }
}
