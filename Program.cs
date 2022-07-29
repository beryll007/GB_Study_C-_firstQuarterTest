string [] stringArray = {"Russia", "Denmark", "Kazan"};
int stringLength = 3;

int FindFinalArrayLength (string [] StringArray, int stringLength)
{   
    int count = 0;
    for (int i = 0; i < StringArray.Length; i++)
    {
        if (StringArray[i].Length <= stringLength)
        {
            count = count + 1;
        }
    }
    return count;
}
















