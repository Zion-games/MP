using UnityEngine;

public class Ball : MonoBehaviour
{
    public bool IsInGoal { get; private set; }
    public int GoalTeam { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter is entered!");
        if (other.CompareTag("GoalTeam1"))
        {
            IsInGoal = true;
            GoalTeam = 1;
        }
        else if (other.CompareTag("GoalTeam2"))
        {
            IsInGoal = true;
            GoalTeam = 2;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("GoalTeam1") || other.CompareTag("GoalTeam2"))
        {
            IsInGoal = false;
            GoalTeam = 0;
        }
    }

    public void ResetBall()
    {
        IsInGoal = false;
        GoalTeam = 0;
    }
}
