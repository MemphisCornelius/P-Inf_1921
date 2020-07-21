using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss_Damagedealt : MonoBehaviour
{
    public Rigidbody2D Damage_Bar;
    public Vector2 movement;
    public bool PointReached = false;
    public int DMG;
    public bool Playerstopped = false;
    //public int BossHealth = 100;
    public Text BossHealthText;
    public float Countdown = 0.5f;
    public bool startboss = false;
    public GameObject[] DefeatImage;
    public int BossCountdown = 80;
    public int SceneCountdown = 9;
    public bool ButtonPress = true;

    void FixedUpdate()
    {
        if (!Playerstopped)
        {
            movement.x = Time.fixedDeltaTime * 5;
            if (Damage_Bar.position.x <= -6 || !PointReached)
            {
                PointReached = false;
                Damage_Bar.MovePosition(Damage_Bar.position + movement);
            }
            if (Damage_Bar.position.x >= 6 || PointReached)
            {
                PointReached = true;
                Damage_Bar.MovePosition(Damage_Bar.position - movement);
            }
        }
        BossHealthText.text = PlayerPrefs.GetInt("BossHealth").ToString();
        if (Playerstopped)
        {
            Countdown = Countdown - Time.deltaTime;
            if (PlayerPrefs.GetInt("BossHealth") >= 80 && Countdown <= 0)
            {
                SceneManager.LoadScene(8);
            }
            if (PlayerPrefs.GetInt("BossHealth") >= 60 && PlayerPrefs.GetInt("BossHealth") < 80 && Countdown <= 0)
            {
                SceneManager.LoadScene(9);
            }
            if (PlayerPrefs.GetInt("BossHealth") >= 40 && PlayerPrefs.GetInt("BossHealth") < 60 && Countdown <= 0)
            {
                SceneManager.LoadScene(10);
            }
            if (PlayerPrefs.GetInt("BossHealth") >= 20 && PlayerPrefs.GetInt("BossHealth") < 40 && Countdown <= 0)
            {
                SceneManager.LoadScene(11);
            }
            if (PlayerPrefs.GetInt("BossHealth") > 0 && PlayerPrefs.GetInt("BossHealth") < 20 && Countdown <= 0)
            {
                SceneManager.LoadScene(12);
            }
            if (PlayerPrefs.GetInt("BossHealth") <= 0)
            {
                Debug.Log("Won");
            }
        }
        if (PlayerPrefs.GetInt("BossLost") > 0 && startboss)
        {
            DefeatImage[0].SetActive(true);
            if (PlayerPrefs.GetInt("BossLost") > 1)
            {
                DefeatImage[1].SetActive(true);
                if (PlayerPrefs.GetInt("BossLost") > 2)
                {
                    DefeatImage[2].SetActive(true);
                }
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Zone1")
        {
            DMG = 20;
        }
        if (collision.tag == "Zone2")
        {
            DMG = 35;
        }
        if (collision.tag == "Zone3")
        {
            DMG = 50;
        }
    }

    public void StopPlayer()
    {
        if (!Playerstopped)
        {
            Playerstopped = true;
            PlayerPrefs.SetInt("BossHealth", PlayerPrefs.GetInt("BossHealth") - DMG);
        }
    }
    public void StartBoss()
    {
        SceneManager.LoadScene(7);
        Debug.Log(PlayerPrefs.GetInt("BossLost"));
    }
    public void ResetPlayerPrefs()
    {
        PlayerPrefs.SetInt("BossLost", 0);
        PlayerPrefs.SetInt("BossHealth", 100);
    }
}
