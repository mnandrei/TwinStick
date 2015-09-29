using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

    const string MasterVolumeKey = "master_volume";
    const string DifficultyKey = "difficulty";
    const string LevelKey = "level_unlocked_";

    public static void SetMasterVolume(float volume)
    {
        PlayerPrefs.SetFloat(MasterVolumeKey, Mathf.Clamp(volume, 0.0f, 1.0f));
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MasterVolumeKey);
    }

    public static void UnlockLevel(int level)
    {
        if (level <= Application.levelCount -1 )
            PlayerPrefs.SetInt(LevelKey + level, 1); // Use 1 for true
        else
            Debug.LogError("Trying to unlock level not in build.");
    }

    public static bool IsLevelUnlocked(int level)
    {
        if (level > Application.levelCount - 1)
        {
            Debug.LogError("Checking for a level not in build.");
            return false;
        }

        return PlayerPrefs.GetInt(LevelKey + level) == 1 ? true : false;
    }

    public static void SetDifficulty(float difficultyLevel)
    {
        PlayerPrefs.SetFloat(DifficultyKey, Mathf.Clamp(difficultyLevel, 1, 3));
    }

    public static float GetDifficultyLevel()
    {
        return PlayerPrefs.GetFloat(DifficultyKey);
    }
}
