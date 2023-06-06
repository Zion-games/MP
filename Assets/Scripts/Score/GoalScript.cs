// using UnityEngine;

// public class GoalScript : MonoBehaviour
// {
//     public enum GoalTeam { Team1, Team2 }
//     public GoalTeam goalTeam; // Set this in the inspector to specify which team this goal belongs to

//     // Reference to ScoreManager
//     ScoreManager scoreManager;

//     private void Start()
//     {
//         // Find the ScoreManager object in the scene and get its ScoreManager component
//         scoreManager = GameObject.FindObjectOfType<ScoreManager>();
//         if(scoreManager == null)
//         {
//             Debug.LogError("Couldn't find a ScoreManager in the scene!");
//         }
//     }

//     private void OnTriggerEnter(Collider other)
//     {
//         // Check if the object that entered the trigger is the ball
//         // You might need to replace "Ball" with whatever tag you've given your ball
//         if(other.gameObject.tag == "Ball")
//         {
//             // If it is the ball, increment the appropriate team's score
//             if(goalTeam == GoalTeam.Team1)
//             {
//                 scoreManager.AddScoreToTeam2();
//             }
//             else if(goalTeam == GoalTeam.Team2)
//             {
//                 scoreManager.AddScoreToTeam1();
//             }
//         }
//     }
// }
