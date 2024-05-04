using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCube : MonoBehaviour
{
    public float velocidadRotacion = 50f; // Velocidad de rotación

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Obtén el input del teclado
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Calcula la rotación en los ejes X e Y
        float rotacionX = vertical * velocidadRotacion * Time.deltaTime;
        float rotacionY = -horizontal * velocidadRotacion * Time.deltaTime;

        // Aplica la rotación al Cube
        transform.Rotate(rotacionX, rotacionY, 0f);
    }
}
