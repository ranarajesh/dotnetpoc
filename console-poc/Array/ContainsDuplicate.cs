namespace console_poc;
public class ContainsDuplicate
{
    public static bool containDuplicate(int[] arr){
        bool isDuplicate = false;
        var seen = new HashSet<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            var item = arr[i];
            if(!seen.Add(item)){
                return true;
            }
        }
        return isDuplicate;
    }
}
