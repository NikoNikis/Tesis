using UnityEngine;

public class SFXcontroller : MonoBehaviour
{
    private AudioSource AudioSource;
    public AudioClip[] correct_incorrect;
    public AudioClip level_complete;

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }
    public void bien()
    {
        AudioSource.clip = correct_incorrect[0];
        AudioSource.Play();
    }
    public void mal()
    {
        AudioSource.clip = correct_incorrect[1];
        AudioSource.Play();
    }

    public void completado()
    {
        AudioSource.clip = level_complete;
        AudioSource.Play();
    }
}
