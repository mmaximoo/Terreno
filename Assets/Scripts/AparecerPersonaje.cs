using UnityEngine;

public class AparecerPersonaje : MonoBehaviour
{
    // Esta variable será una cajita en Unity donde arrastraremos el modelo 3D
    public GameObject modeloVisual; 
    public ParticleSystem particulasTierra; // Nueva caja para las partículas
    public AudioSource sonidoAparicion;

    void Start()
    {
        // Al darle Play, hace invisible el modelo (lo apaga)
        modeloVisual.SetActive(false);
    }

    // Esta es la "X cosa". Cuando la llames, el personaje aparecerá.
    public void HacerVisible()
    {
        modeloVisual.SetActive(true);
        // Aquí luego podemos ponerle un sonido de aparición o partículas
        if (particulasTierra != null)
        {
            particulasTierra.Play(); 
        }
        if (sonidoAparicion != null)
        {
            sonidoAparicion.Play();
        }
        modeloVisual.GetComponent<Animator>().SetTrigger("Susto");
    }
}