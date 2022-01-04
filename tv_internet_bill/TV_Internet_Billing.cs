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

        public static int decrease_Client_BALANCE(int balance, int day_pay, DateTime current_date, DateTime date_database)
        {
            int compare_result = DateTime.Compare(current_date.Date, date_database.Date);
            if (compare_result < 0 && balance != 0)
            {
                balance -= day_pay;
                return balance;
            }
            else return balance;
        }

        public static int increase_Client_BALANCE(int current, int additional_sum)
        {
            int itog = 0;

            itog = current + additional_sum;

            return itog;
        }
    }
}
