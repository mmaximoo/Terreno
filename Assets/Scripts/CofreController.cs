using UnityEngine;

public class CofreController : MonoBehaviour
{
    [Header("Modelos 3D del Cofre")]
    public GameObject cofreCerrado;
    public GameObject cofreAbierto;

    [Header("Objeto de Recompensa")]
    public GameObject objetoDentro;

    [Header("Controlador de Puertas")]
    public PuertasController puertasController; // <--- NUEVA REFERENCIA

    [Header("Efectos de Sonido")]
    public AudioSource sonidoAbrir;

    private bool estaCerca = false;
    private bool estaAbierto = false;
    private bool objetoRecogido = false;

    void Start()
    {
        if (cofreCerrado != null) cofreCerrado.SetActive(true);
        if (cofreAbierto != null) cofreAbierto.SetActive(false);
        if (objetoDentro != null) objetoDentro.SetActive(false);
    }

    void Update()
    {
        if (!estaCerca) return;

        if (!estaAbierto && Input.GetKeyDown(KeyCode.E))
        {
            AbrirCofre();
        }
        else if (estaAbierto && !objetoRecogido && Input.GetKeyDown(KeyCode.E))
        {
            RecogerObjeto();
        }
    }

    void AbrirCofre()
    {
        estaAbierto = true;
        cofreCerrado.SetActive(false);
        cofreAbierto.SetActive(true);

        if (objetoDentro != null)
        {
            objetoDentro.SetActive(true);
        }
        // <-- REPRODUCIR EL SONIDO AQUÍ
        if (sonidoAbrir != null)
        {
            sonidoAbrir.Play();
        }
        Debug.Log("¡Cofre abierto!");
    }

    void RecogerObjeto()
    {
        objetoRecogido = true;

        if (objetoDentro != null)
        {
            objetoDentro.SetActive(false);
        }

        if (puertasController != null)
        {
            puertasController.RegistrarObjetoRecogido();
        }

        Debug.Log("¡Objeto recogido!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            estaCerca = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            estaCerca = false;
        }
    }
}