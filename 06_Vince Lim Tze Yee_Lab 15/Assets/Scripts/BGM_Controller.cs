using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Controller : MonoBehaviour
{

    private AudioSource audioSource;
    public AudioClip[] AudioClipBGM;
    private float volumeChangeSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Selects a random BGM in the array
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            audioSource.Stop();
            int rand = Random.Range(0, AudioClipBGM.Length);
            audioSource.PlayOneShot(AudioClipBGM[rand]);
        }
        //Increase volume
        if(Input.GetKey(KeyCode.UpArrow))
        {
            audioSource.volume += Time.deltaTime * volumeChangeSpeed;
        }
        //Reduce volume
        if(Input.GetKey(KeyCode.DownArrow))
        {
            audioSource.volume -= Time.deltaTime * volumeChangeSpeed;
        }
    }

}
