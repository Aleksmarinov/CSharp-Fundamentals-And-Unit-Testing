using System.ComponentModel;

int MathPower(int basePowerNum,int powerNum)
{
    int output = basePowerNum;
    for (int i = 0; i < powerNum - 1; i++)
    {
        output *= basePowerNum;
    }
    return output;
}

int basePowerNum = int.Parse(Console.ReadLine());
int powerNum = int.Parse(Console.ReadLine());

int result = MathPower(basePowerNum, powerNum);
Console.WriteLine(result);