using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject winPanel;     // Panel con el mensaje
    public AudioClip winSound;      // Clip de audio de victoria
    private AudioSource audioSource;
    void Start()
    {
        audioSource = Camera.main.GetComponent<AudioSource>(); // Usamos el audio source de la cámara principal
        winPanel.SetActive(false); // Ocultamos el panel al inicio
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = 0f; // Pausa el juego
            winPanel.SetActive(true); // Muestra mensaje de victoria
            if (winSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(winSound); // Reproduce música de victoria
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
