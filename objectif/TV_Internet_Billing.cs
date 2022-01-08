using System;


namespace tv_internet_billing
{
    public class TV_Internet_Billing
    {
        public static int Calculate_daysLeft(int balance, int day_pay)
        {
            int daysLEFT = 0;

            if (day_pay != 0)
            {
                daysLEFT = balance / day_pay;
                return daysLEFT;
            }
            else
            {
                return 0;
            }

        }

        public static int increase_Client_BALANCE(int current, int additional_sum)
        {
            int itog = 0;

            itog = current + additional_sum;

            return itog;
        }
    }
}
