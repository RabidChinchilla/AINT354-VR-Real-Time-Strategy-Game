using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyUnit : MonoBehaviour
{
    protected string type;
    public int hp;
    public int damage;
    public string state;
    public float mvmntSpd;
    public float atkSpd;

    //Build Variables
    [HideInInspector]
    public int unitCost;
    [HideInInspector]
    public int unitBuildTime;

    protected float calmDown = 20.0f;
    //These next values are used when the units state is reset to normal
    //*Note* These values do not change once they are set
    private float nAtk;
    private float nMv;
    private int nDmg;
    private int nHP;

    //Unit Targetting
    GameObject[] targets;
    GameObject mainTarget = null;
    float maxDistance = 500.0f;
    Vector3 position;

    int number; //Used for generating voice lines
    unitVoiceLines voice;

    // Start is called before the first frame update
    void Start()
    {
        targets = GameObject.FindGameObjectsWithTag("SelectableUnit");
        state = "Normal";
        //Move to update script as well
        damage = 2;
        Vector3 position = gameObject.transform.position;
        voice = gameObject.GetComponent<unitVoiceLines>();
        StartCoroutine(PlayThrough());
        //gameObject.tag = "Barracks";

    }


    IEnumerator PlayThrough()
    {
        
        FindNearestEnemy();
        if(mainTarget!= null)
        {
            DealDamage();
        }
        yield return new WaitForSecondsRealtime(atkSpd);
        Vector3 position = gameObject.transform.position;
        targets = GameObject.FindGameObjectsWithTag("SelectableUnit");
        StartCoroutine(PlayThrough());
    }

    void FindNearestEnemy()
    {
        foreach (GameObject enemy in targets)
        {
            Vector3 distance = enemy.transform.position - position;
            float accurateDistance = distance.sqrMagnitude;
            if (accurateDistance < maxDistance)
            {
                mainTarget = enemy;
                maxDistance = accurateDistance;
            }
        }

    }

    public void TakeDamage(int damageTaken)
    {
        // When the unit takes damage its hp is altered here
        hp -= damageTaken;

        //number = Random.Range(1, 10);

        //voice.PlayAttackAudio(number);

        Debug.Log("Enemy Hit");
        if (hp <= 0)
        {
            Die();

            //gameObject will be replaced with the nearest enemy
            //This give the unit a boost, like their morale was increased due to a victory
            //gameObject.SendMessage("Hyped");
        }
    }
    void ResetTargetting()
    {
        mainTarget = null;
        maxDistance = 500.0f;
    }


    void DealDamage()
    {
        //gameObject is a place holder, it will be replaced by the nearest enemy object
        mainTarget.SendMessage("TakeDamage", damage);
        ResetTargetting();
        //number = Random.Range(1, 10);
        //voice.PlayInjuredAudio(number);
    }

    void Die()
    {
        Destroy(gameObject);
    }

    void UpgradeHealth(int healthUpgrade)
    {
        //Call on function when upgrading a unit
        hp += 1;
    }

    void UpgradeDamage(int damageUpgrade)
    {
        damage += 1;
    }


    IEnumerator Tagging()
    {
        yield return new WaitForSecondsRealtime(2);
        //Change To Info Building when needed
        gameObject.tag = "Barracks";
    }
}
