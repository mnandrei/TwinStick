using UnityEngine;
using System.Collections;

public class MyReplay : MonoBehaviour {

	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

public struct MyKeyframe
{
    private float _frameTime;
    private Vector3 _position;
    private Quaternion _rotation;

    public MyKeyframe(float frameTime, Vector3 position, Quaternion rotation)
    {
        _frameTime = frameTime;
        _position = position;
        _rotation = rotation;
    }

    public float FrameTime
    {
        get
        {
            return _frameTime;
        }

        set
        {
            _frameTime = value;
        }
    }

    public Vector3 Position
    {
        get
        {
            return _position;
        }

        set
        {
            _position = value;
        }
    }

    public Quaternion Rotation
    {
        get
        {
            return _rotation;
        }

        set
        {
            _rotation = value;
        }
    }
}