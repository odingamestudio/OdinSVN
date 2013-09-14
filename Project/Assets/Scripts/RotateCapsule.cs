using UnityEngine;
using System.Collections;

public class RotateCapsule : MonoBehaviour 
{

    public float speed = 35;

    // ############################################################################################ // #UNITY FUNCTION
	void Start ()
    {
	    // TEste de fork agora
	}
    // ############################################################################################ // #UNITY FUNCTION
	void Update ()
    {
        transform.Rotate((Vector3.right * speed) * Time.deltaTime, Space.World);
	}
    // ############################################################################################ // 
}
