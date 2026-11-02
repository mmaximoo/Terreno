using UnityEngine;

public class CentroAudio : MonoBehaviour
{
    public Transform jugador1;
    public Transform jugador2;

    void Update()
    {
        if (jugador1 != null && jugador2 != null)
        {
            // Calcula matemáticamente el punto medio exacto entre ambos jugadores
            transform.position = (jugador1.position + jugador2.position) / 2f;
        }
    }
}