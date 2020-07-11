using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Panel_Activation : MonoBehaviour
{
    public GameObject EndGame_Panel;
    public GameObject Defeat_Text;
    public GameObject Victory_Text;
    public GameObject[] RespawnedEnemies;
    public float SpawnTime = 2;
    public bool Respawned = false;
    public int SceneToReturnTo;
    public int MinigameNumber = 0;

    public void Update()
    {
        int Enemycount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        int Playercount = GameObject.FindGameObjectsWithTag("Player").Length;

        if (Enemycount <= 1 && Respawned != true)
        {
            SpawnTime = SpawnTime - Time.deltaTime;
            if (SpawnTime <= 0)
            {
                foreach (GameObject RespawnedEnemy in RespawnedEnemies)
                {
                    RespawnedEnemy.SetActive(true);
                    Respawned = true;
                }
            }
        }
        if (Enemycount <= 0 || Playercount <= 0)
        {
            EndGame_Panel.SetActive(true);
            if (Enemycount <= 0)
            {
                Victory_Text.SetActive(true);
                SceneManager.LoadScene(SceneToReturnTo);
                PlayerPrefs.SetInt("Minigame" + MinigameNumber + "Won", MinigameNumber);
                PlayerPrefs.Save();
                Debug.Log(PlayerPrefs.GetInt("Minigame" + MinigameNumber + "Won"));
            }
            else
            {
                Defeat_Text.SetActive(true);
            }

        }
    }
}
