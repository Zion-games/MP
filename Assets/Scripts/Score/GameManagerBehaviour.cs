using Fusion;
using UnityEngine;


public class GameManagerBehaviour : NetworkBehaviour
{
    public static GameManagerBehaviour Instance;

    [Networked] public int ScoreTeam1 { get; set; }
    [Networked] public int ScoreTeam2 { get; set; }

    public TMPro.TextMeshProUGUI scoreTextTeam1;
    public TMPro.TextMeshProUGUI scoreTextTeam2;


    private void Awake()
    {
         Debug.Log("Awake() is entered!");
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        Debug.Log("Update() is entered!");
        Render();
    }

    public void Render()
    {
        Debug.Log("Render() is entered!");

        // Assuming you have UI text objects to display the scores
        scoreTextTeam1.text = ScoreTeam1.ToString();
        scoreTextTeam2.text = ScoreTeam2.ToString();
    }
}
