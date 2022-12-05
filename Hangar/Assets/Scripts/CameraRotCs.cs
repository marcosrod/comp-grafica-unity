using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraRotCs : MonoBehaviour
{
    private float velocidadeCamera = -0.5f;
    private float posX;
    private float posY;
    private float inputX;
    private float inputZ;
    private Vector3 valorRotacao;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    

    void Update()
    {
        posX = Input.GetAxis("Mouse X");
        posY = Input.GetAxis("Mouse Y");
        inputX = Input.GetAxis("Horizontal");
        inputZ = Input.GetAxis("Vertical");
        valorRotacao = new Vector3(posY, posX * -1, 0);
        transform.eulerAngles = transform.eulerAngles - valorRotacao;
        transform.eulerAngles += valorRotacao * velocidadeCamera;
        if (inputX != 0)
            rotacionar();
        if (inputZ != 0)
            transladar();
    }

    private void transladar()
    {
        transform.position += transform.forward * inputZ * Time.deltaTime;
    }

    private void rotacionar()
    {
        transform.Rotate(new Vector3(0f, inputX * 5f, 0f));
    }
}