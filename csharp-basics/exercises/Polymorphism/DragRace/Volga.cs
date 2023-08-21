using System;
namespace DragRace;

public class Volga: ICar
{
    private int _currentSpeed = 0;

    public void SpeedUp() 
    {
        _currentSpeed++;
    }

    public void SlowDown() 
    {
        _currentSpeed--;
    }

    public int GetCurrentSpeed()
    {
        return _currentSpeed;
    }


    public string ShowCurrentSpeed() 
    {
        return _currentSpeed.ToString();
    }

    public void StartEngine() 
    {
        Console.WriteLine("Dr Dr Dr Dr Dr Dr.....");
    } 
} 