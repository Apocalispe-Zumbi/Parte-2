using UnityEngine;

public class ControlaAudio : MonoBehaviour
{
    private AudioSource meuAudioSource;
    public static AudioSource instancia;
    public AudioClip SomDeDano;
    // Start is called before the first frame update
    void Awake()
    {
        meuAudioSource = GetComponent<AudioSource>();
        instancia = meuAudioSource;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
