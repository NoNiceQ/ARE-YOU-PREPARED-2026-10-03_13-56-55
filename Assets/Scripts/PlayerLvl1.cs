using UnityEngine;

public class PlayerLvl1 : MonoBehaviour
{
public float speed = 5f; // Prędkość poruszania się

    void Update()
    {
        // Pobiera wejście z klawiatury (A/D lub Strzałki w lewo/prawo)
        float moveInput = Input.GetAxisRaw("Horizontal");

        // Tworzy wektor ruchu tylko w osi X
        Vector3 move = new Vector3(moveInput, 0f, 0f);

        // Przesuwa obiekt w czasie
        transform.position += move * speed * Time.deltaTime;
    }
}
