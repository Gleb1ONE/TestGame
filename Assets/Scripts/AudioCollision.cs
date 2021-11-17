using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioCollision : MonoBehaviour
{
    public AudioClip clip;
    public AudioClip clipMeme;
    public AudioClip clipYeah;
    public AudioSource audioSource;
    private bool boyyy = true;
    public Text textButton;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (boyyy)
            {
                audioSource.PlayOneShot(clip);     //«вук при ударе
            }
            else
            {
                audioSource.PlayOneShot(clipMeme);     //«вук при ударе
            }            
        }
    }

    public void Boy()
    {
        if (boyyy)
        {
            audioSource.volume = 0.2f;
            audioSource.PlayOneShot(clipYeah);
            boyyy = false;
            textButton.gameObject.SetActive(true);
        }
        else
        {
            audioSource.volume = 0.5f;
            boyyy = true;
            textButton.gameObject.SetActive(false);
        }   
    }
}
