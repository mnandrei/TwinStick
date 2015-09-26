using UnityEngine;

public class ReplaySystem : MonoBehaviour {

    private const int BufferFrames = 100;
    private MyKeyframe[] _keyFrames = new MyKeyframe[BufferFrames];

    private Rigidbody _rigidBody;

	void Start ()
    {
        _rigidBody = GetComponent<Rigidbody>();
	}
	
	void Update ()
    {
        if (GameManager.IsRecording)
            Record();
        else
            PlayBack();
    }

    private void PlayBack()
    {
        _rigidBody.isKinematic = true;

        int frame = Time.frameCount % BufferFrames;

        Debug.Log("Reading frame " + frame);

        transform.position = _keyFrames[frame].Position;
        transform.rotation = _keyFrames[frame].Rotation;
    }

    private void Record()
    {
        _rigidBody.isKinematic = false;

        int frame = Time.frameCount % BufferFrames;
        float time = Time.deltaTime;

        Debug.Log("Writing frame " + frame);

        _keyFrames[frame] = new MyKeyframe(time, transform.position, transform.rotation);
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