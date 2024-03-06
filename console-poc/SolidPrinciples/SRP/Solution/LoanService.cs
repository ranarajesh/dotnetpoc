namespace console_poc.SolidPrinciples.SRP.Solution;
public class LoanService
{
     public void LoanServiceType(string loanType){
        if (loanType.Equals("homeLoan")) {
            //do some job
        }
        if (loanType.Equals("personalLoan")) {
            //do some job
        }
        if (loanType.Equals("car")) {
            //do some job
        }
    }
}
