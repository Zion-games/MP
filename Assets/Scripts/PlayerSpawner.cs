using Cinemachine;
using Fusion;
using UnityEngine;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined {
    public GameObject PlayerPrefab;
    public GameObject spawner_point;
    //public GameObject camera;

    public void PlayerJoined(PlayerRef player) 
    {
        if (player == Runner.LocalPlayer) {
            Runner.Spawn(PlayerPrefab, spawner_point.transform.position + new Vector3(0, 1, 0), Quaternion.identity, player);
           // network.gameObject.GetComponent<CinemachineVirtualCamera>().Follow = camera.transform;
        }
    }
}