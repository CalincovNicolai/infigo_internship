namespace ObjectApp;

class Solution
{
    public int BinaryGap(int Number)
    {
        int longest = 0;
        int curCount = 0;
        bool firstFound = false;

        for (int i = 0; i < sizeof(int) * 8; i++)
        {
            int bit = (Number >> i) & 1;

            if (bit == 1)
            {
                firstFound = true;
                
                if (curCount >= longest)
                {
                    longest = curCount;
                    curCount = 0;
                }
                else
                {
                    curCount = 0;
                }
            }
            else
            {
                if (firstFound)
                {
                    curCount++;
                }
            }
        }

        return longest;
    }
}