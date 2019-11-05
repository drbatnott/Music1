using UnityEngine;
using System.Collections;
using Tobii.Gaming;

public class GetGaze : MonoBehaviour {
    Tobii.Gaming.GazePoint gp;
    Transform t;
    float left = -9;
    float right = 9;
    float up = 4;
    float down = -4;
    public Vector2 gazePoint;
    public Camera cam;
	// Use this for initialization
	void Start () {
         
        t = GetComponent<Transform>();
        TobiiAPI.SetCurrentUserViewPointCamera(cam);
	}
	
	// Update is called once per frame
	void Update () {
        gp = TobiiAPI.GetGazePoint();
        Vector3 p = t.position;
        float z = p.z;
        gazePoint = gp.Viewport;
        float x = gazePoint.x * 18f + left;
        float y = gazePoint.y * 8f + down;
        t.position = new Vector3(x, y, z);
	}
}
