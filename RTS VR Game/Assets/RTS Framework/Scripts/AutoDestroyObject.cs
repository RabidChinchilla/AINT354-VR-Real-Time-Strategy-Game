using UnityEngine;

public class AutoDestroyObject : MonoBehaviour {

    public float Lifetime = 1f;

    private float _timer;

	void Start () {
        _timer = Lifetime;
	}
	
	void Update () {
        _timer -= Time.deltaTime;
        if(_timer < 0)
        {
            GameObject.Destroy(this.gameObject);
        }
	}
}
