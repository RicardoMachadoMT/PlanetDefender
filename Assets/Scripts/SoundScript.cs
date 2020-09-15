using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SoundScript : MonoBehaviour {

    public static SoundScript Instance;

    public AudioClip BalaSound;
    public AudioClip LaserSound;
    public AudioClip ColocarTorreSound;
    public AudioClip MonstroMorrendoSound;

    void Awake()
    {
        if (Instance != null)
        {
            UnityEngine.Debug.LogError("Existem múltiplas instâncias do script Sound");
        }
        Instance = this;
    }

    public void MakeBalaSound()
    {
        MakeSound(BalaSound);
    }

    public void MakeLaserSound()
    {
        MakeSound(LaserSound);
    }
    public void MakeColocarTorreSound()
    {
        MakeSound(ColocarTorreSound);
    }

    public void MakeMonstroMorrendoSound()
    {
        MakeSound(MonstroMorrendoSound);
    }

    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);  
    }
}
