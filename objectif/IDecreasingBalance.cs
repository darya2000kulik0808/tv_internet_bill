using System;

namespace DecreasingBalance
{
    public interface IDecreasingBalance
    {
        int decreasing(int balance, int day_pay, int limits_client, int price_limit, int compare_date);
    }

}
