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

string[] CreateFillFinArray (string [] initArray, int finArrayLength, int stringLength)
{
    string [] finArray = new string [finArrayLength];
    
    int index = 0;

    for (int i = 0; i < initArray.Length; i++)
    {
        if(initArray[i].Length <= stringLength)
        {
            finArray[index] = initArray[i];
            index = index + 1;
        }   
    }
    return finArray;
}














