using Fusion;
using UnityEngine;

public class BallBehaviour : NetworkBehaviour
{
    [Networked] public Vector3 Position { get; set; }

    public override void FixedUpdateNetwork()
    {
        Ball ballScript = GetComponent<Ball>();

        if (ballScript.IsInGoal)
        {
            Debug.Log("ballScript.IsInGoal is entered!");

            if (ballScript.GoalTeam == 1)
            {
                Debug.Log("allScript.GoalTeam == 1 is entered!");
                GameManagerBehaviour.Instance.ScoreTeam1 += 1;
            }
            else if (ballScript.GoalTeam == 2)
            {
                Debug.Log("allScript.GoalTeam == 2 is entered!");
                GameManagerBehaviour.Instance.ScoreTeam2 += 1;
            }

            // Reset the ball position and state after a goal
            Position = Vector3.zero;
            ballScript.ResetBall();
        }
    }
}
