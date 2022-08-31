namespace basic_core_program
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please select the option which program");
            Console.WriteLine("option 1 : Flip the coin");
            Console.WriteLine("option 2 : QuotientReminder");
            int option = Convert.ToInt32(Console.ReadLine());
            LeapYear.CalculateLeapYear();
            PowerOfTwo.CalculatePwowerOfTwo();
            HarmonicNumber.DisplayHarmonicNumber();
            PrimeFactors.CalculatePrimeFactros();
            SwapTwoNumbers.Swapped();
            EvenOdd.CheckEvenOdd();
            VowelOrconsonant.CheckVowelOrconsonant();
            LargestNumber.CheckLargestNumber();

            switch (option)
            {
                case 1:
                    FlipCoin.CalculatePercentage();
                    break;
                case 2:
                    QuotientReminder.CalculateQuotietAndRemainder();
                    break;
                default:
                    Console.WriteLine("please enter the correct option");
                    break;
            }

        }

    }

}