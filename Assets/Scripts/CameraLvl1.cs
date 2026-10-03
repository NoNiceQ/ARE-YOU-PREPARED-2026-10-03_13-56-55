using UnityEngine;

public class CameraLvl1 : MonoBehaviour
{
    public Transform player;       // Przeciągnij tutaj swoją postać w Unity
    public float smoothSpeed = 5f; // Im wyższa wartość, tym kamera szybsza i sztywniejsza
    public Vector3 offset = new Vector3(0f, 0f, -10f); // Dystans kamery (Z musi być ujemne!)

    // Granice, poza które kamera nie wyjedzie (dopasuj do wielkości swojego domku/planszy)
    public float minX = -5f;
    public float maxX = 5f;

    void LateUpdate()
    {
        if (player == null) return;

        // Docelowa pozycja X gracza z uwzględnieniem offsetu
        float targetX = player.position.x + offset.x;

        // Ograniczamy pozycję X kamery do ustalonego zakresu (minX i maxX)
        targetX = Mathf.Clamp(targetX, minX, maxX);

        // Tworzymy docelowy punkt dla kamery (zachowując Y i Z bez zmian)
        Vector3 targetPosition = new Vector3(targetX, transform.position.y, offset.z);

        // Płynne przejście kamery (Lerp) do docelowej pozycji
        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);
    }
}
