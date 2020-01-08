using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemyHub : MonoBehaviour
{

    public int hp;



    void TakeDamage(int damageTaken)
    {
        // When the unit takes damage its hp is altered here
        hp -= damageTaken;

        //number = Random.Range(1, 10);

        //voice.PlayAttackAudio(number);


        if (hp <= 0)
        {
            Die();

            //gameObject will be replaced with the nearest enemy
            //This give the unit a boost, like their morale was increased due to a victory
            //gameObject.SendMessage("Hyped");
        }
    }


    public void Die()
    {
        Destroy(gameObject);
        LoadA();
    }

    void LoadA()
    {
        Debug.Log("sceneName to load: 0");
        SceneManager.LoadScene(0);
    }



}
