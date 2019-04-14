using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundEffect;

   public void PlaySoundOnPosition(Vector3 position)
    {
        AudioSource.PlayClipAtPoint(soundEffect.clip, position, 1f);
    }
}
