namespace ObjectApp;

class Solution
{
    public int[] CyclicRotation(int[] arrayElements, int numOfRotation) 
    {
        int arrayLength = arrayElements.Length;

        if(arrayLength > 0 && numOfRotation % arrayLength != 0)
        {
            for (int j = 0; j < numOfRotation; j++)
            {
                int globalTemp = arrayElements[0];

                for (int i = 0; i < arrayLength; i++)
                {
                    if(i == 0)
                    {
                        arrayElements[0] = arrayElements[arrayLength-1]; 
                    }

                    else
                    {
                        int temp = arrayElements[i];
                        arrayElements[i] = globalTemp;
                        globalTemp = temp;
                    }
                }
            }
        }

        return arrayElements;
    }
}