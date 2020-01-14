using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unitAttributes : MonoBehaviour
{//Editable Units
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
    //List<GameObject> targets;
    GameObject[] targets;
    GameObject mainTarget = null;
    float maxDistance = 1000000.0f;
    Vector3 position;

    int number; //Used for generating voice lines
    unitVoiceLines voice;

    public string tag;

    // Start is called before the first frame update
    void Start()
    {
        //List<GameObject> targets = new List<GameObject>();
        //targets = GameObject.FindGameObjectsWithTag("CommandBuilding");
        targets = GameObject.FindGameObjectsWithTag("NonplayerUnits");
        state = "Normal";

        FindAll();
        //Move to update script as well
        Vector3 position = gameObject.transform.position;
        voice = gameObject.GetComponent<unitVoiceLines>();
        //gameObject.tag = "Barracks";
        StartCoroutine(Tagging());
        StartCoroutine(PlayThrough());
        Debug.Log(targets[0]);
    }
    void Update()
    {
        //Debug.Log(targets[0]);
    }

    IEnumerator PlayThrough()
    {
        FindNearestEnemy();
        if (mainTarget != null)
        {
            DealDamage();
        }
        yield return new WaitForSecondsRealtime(atkSpd);
        Vector3 position = gameObject.transform.position;
        targets = GameObject.FindGameObjectsWithTag("NonplayerUnits");
        //FindAll();
        Debug.Log(targets);

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
        Debug.Log("Damage is: " + damageTaken);
        hp -= damageTaken;
        Debug.Log(hp);

        Debug.Log("Humvee Taken Damage");
        if(hp<=0)
        {
            Die();

            //gameObject will be replaced with the nearest enemy
            //This give the unit a boost, like their morale was increased due to a victory
            //gameObject.SendMessage("Hyped");
        }
    }
    void FindAll()
    {
        targets = GameObject.FindGameObjectsWithTag("NonplayerUnits");
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
        mainTarget.SendMessage("TakeDamage",damage);
        ResetTargetting();

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


    IEnumerator Tagging()
    {
        yield return new WaitForSecondsRealtime(2);
        //Change To Info Building when needed
        gameObject.tag = tag;
    }
}
