using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitAttributes : MonoBehaviour
{//Editable Units
    protected string type {get;set;} 
    protected int hp { get; set; }
    protected int damage { get; set; }
    protected string state { get; set; }
    protected float mvmntSpd { get; set; }
    protected float atkSpd { get; set; }

    //Build Variables
    [HideInInspector]
    public int unitCost;
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
        GameObject[] targets = GameObject.FindGameObjectsWithTag("NonplayerUnit");
        state = "Normal";
        hp = 0;
        damage = 0;
        mvmntSpd = 0.0f;
        atkSpd = 0.0f;

        unitCost = 0;
        unitBuildTime = 0;
        //Move to update script as well
        Vector3 position = gameObject.transform.position;
        voice = gameObject.GetComponent<unitVoiceLines>();
    }

   void SetStats(int unitHealth, int unitDamage, float move, float attack)
    {
        //When the unit is created its Stats get placed into here
        hp = unitHealth;
        nHP = unitHealth;

        damage = unitDamage;
        nDmg = unitDamage;

        mvmntSpd = move;
        nMv = move;

        atkSpd = attack;
        nAtk = attack;

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

    void TakeDamage(int damageTaken)
    {
        // When the unit takes damage its hp is altered here
        hp -= damageTaken;

        number = Random.Range(1, 10);

        voice.PlayAttackAudio(number);


        if(hp<=0)
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

    void Normal()
    {
        //Resets the units stats to base
        damage = nDmg;
        mvmntSpd = nMv;
        atkSpd = nAtk;

    }
    void Retreat ()
    {
        //When a units HP is below a certain amount then this fuction is called which makes the unit move the opposite direction of the enemy
        if (hp < 50)
        {
            Vector3 dis = transform.position - mainTarget.transform.position;
            transform.Translate(dis * mvmntSpd * Time.deltaTime);
        }
    }

    void Cautious ()
    {
        //When a unit is surrounded by lots of cover and they are by themselves then their movement speed is lowered
        mvmntSpd /= 1.5f;
    }

    void Hyped ()

    {
        state = "Hyped";
        mvmntSpd *= 1.5f;
    }

    void DealDamage()
    {
        //gameObject is a place holder, it will be replaced by the nearest enemy object
        gameObject.SendMessage("TakeDamage",damage);

        number = Random.Range(1, 10);
        voice.PlayInjuredAudio(number);
    }

    void Die ()
    {
        Destroy(gameObject);
    }

    void UpgradeHealth(int healthUpgrade)
    {
        //Call on function when upgrading a unit
        hp += healthUpgrade;
    }

    void UpgradeDamage(int damageUpgrade)
    {
        damage += damageUpgrade;
    }


}
