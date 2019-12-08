using UnityEngine;

public class Explosion : MonoBehaviour {

    private ParticleSystem _ps;

	void Start () {
		_ps = GetComponent<ParticleSystem>();
        GetComponent<AudioSource>().Play();
    }
	
	void Update () {
        if (_ps.isStopped)
        {
            Destroy(_ps.gameObject);
        }
    }
}
