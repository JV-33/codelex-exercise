namespace DragRace;

public interface ICar
{
    void SpeedUp();
    void SlowDown();
    string ShowCurrentSpeed();
    int GetCurrentSpeed();
    void StartEngine();
 
}