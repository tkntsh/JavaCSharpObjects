public class bureauDeChange1
{
    //base currency
    private static final double baseCurrency = 1.0;

    //conversion rates for different currencies
    private static final double randToEuro = 0.053;
    private static final double randToDollar = 0.055;
    private static final double randToPound = 0.044;

    //methods converting from rands to different currecnies
    public double convertRandToEuro(double randAmount)
    {
        return randAmount * randToEuro;
    }
    public double convertRandToDollar(double randAmount)
    {
        return randAmount * randToDollar;
    }
    public double convertRandToPound(double randAmount)
    {
        return randAmount * randToPound;
    }

    //main method
    public static void main(String[] args)
    {
        bureauDeChange1 BDC = new bureauDeChange1();
        double randAmount = 100.00;

        //printing out different currency balances using different methods for different currencies
        System.out.println("Your current balance in Rands is: R" + randAmount);
        System.out.println("Your current balance in Pounds is: £" + BDC.convertRandToPound(randAmount));
        System.out.println("Your current balance in Dollars is: $" + BDC.convertRandToDollar(randAmount));
        System.out.println("Your current balance in Euros is: €" + BDC.convertRandToEuro(randAmount));
    }
}
