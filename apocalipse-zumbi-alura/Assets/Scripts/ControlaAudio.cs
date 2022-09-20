using UnityEngine;

public class ControlaAudio : MonoBehaviour
{
    private AudioSource MeuAudioSource;
    public static AudioSource instancia;
    // Start is called before the first frame update
    void Awake()
    {
        MeuAudioSource = GetComponent<AudioSource>();
        instancia = MeuAudioSource;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
