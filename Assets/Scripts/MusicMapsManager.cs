using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMapsManager : MonoBehaviour
{
    [SerializeField] GameObject[] cubes;
    [SerializeField] Transform[] spawners;
    [SerializeField] AudioSource musicManager;
    [SerializeField] List<AudioClip> audioClips;
    [SerializeField] GameObject[] gameActive;
    [SerializeField] GameObject[] gameOff;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySilentRunning()
    {
        musicManager.clip = audioClips[0];
        foreach(GameObject go in gameActive)
        {
            go.SetActive(true);
        }
        musicManager.Play();
        StartCoroutine("SilentRunningMap");

    }
    IEnumerator SilentRunningMap()
    {   
        yield return new WaitForSeconds(5.0f);
        endSong();
    }
    void endSong()
    {
        foreach(GameObject go in gameActive)
        {
            go.SetActive(false);
        }
    }
    void spawnCube(Transform spawnpoint,float rotation,int color)
    {
        GameObject cube = Instantiate(cubes[color],spawnpoint);
        cube.transform.localPosition = Vector3.zero;
        cube.transform.Rotate(transform.forward,rotation);
    }
}
