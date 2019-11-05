using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {
    AudioSource source;
    public AudioClip clip;
    float timeon = 0;
	// Use this for initialization
	void Start () {
        source = GetComponent<AudioSource>();
        source.clip = clip;
	}
	
    public void OnCollisionStay2D(Collision2D col){
        timeon += Time.deltaTime;
        if (timeon > 0.5f)
        {
            timeon = 0;
            if (!source.isPlaying)
            {
                source.Play();
            }
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        timeon = 0;
        if (source.isPlaying)
        {
            source.Stop();
        }
    }
}
