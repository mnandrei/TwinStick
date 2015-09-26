using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

    public static bool IsRecording = true;
	
	void Update ()
    {
        if (CrossPlatformInputManager.GetButton("Fire1"))
            IsRecording = false;
        else
            IsRecording = true;
    }
}
