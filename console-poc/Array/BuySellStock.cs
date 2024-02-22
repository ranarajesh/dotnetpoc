using System;
namespace Array
{
    public class BuySellStock{
        
        public static int sellStockProfit(int[] arr){
            //   int[] arr = new int[]{1, 2, 4, 2, 5, 7, 2, 4, 9, 0, 9};
            int buy = arr[0];
            int profit =0;
            for (int i = 1; i < arr.Length; i++)
            {
                int item = arr[i];
                if(item < buy){
                    buy = item;
                }else if(item - buy > profit){
                    profit = item -buy;
                }
            }
            return profit;
        }
    }
}