using UnityEngine;

public class PuertasController : MonoBehaviour
{
    [Header("Referencias de las Puertas")]
    public Transform puerta1;
    public Transform puerta2;

    [Header("Configuración de Rotación (Grados Y)")]
    public float gradosPuerta1 = 90f;   // Grados a rotar puerta 1
    public float gradosPuerta2 = -90f;  // Grados a rotar puerta 2 (suelen abrir hacia lados opuestos)
    public float velocidadApertura = 2f;

    [Header("Progreso")]
    public int objetosNecesarios = 3;
    private int objetosRecogidos = 0;

    private bool abriendo = false;
    private Quaternion destinoPuerta1;
    private Quaternion destinoPuerta2;

    void Start()
    {
         if (puerta1 != null) 
            destinoPuerta1 = puerta1.rotation * Quaternion.Euler(0, gradosPuerta1, 0);

        if (puerta2 != null) 
            destinoPuerta2 = puerta2.rotation * Quaternion.Euler(0, gradosPuerta2, 0);
    }

    void Update()
    {
         if (abriendo)
        {
            if (puerta1 != null)
                puerta1.rotation = Quaternion.Slerp(puerta1.rotation, destinoPuerta1, Time.deltaTime * velocidadApertura);

            if (puerta2 != null)
                puerta2.rotation = Quaternion.Slerp(puerta2.rotation, destinoPuerta2, Time.deltaTime * velocidadApertura);
        }
    }

    public void RegistrarObjetoRecogido()
    {
        objetosRecogidos++;
        Debug.Log($"Objetos recogidos: {objetosRecogidos} / {objetosNecesarios}");

        if (objetosRecogidos >= objetosNecesarios)
        {
            abriendo = true;
            Debug.Log("¡Se han recogido los 3 objetos! Abriendo puertas...");
        }
    }
}