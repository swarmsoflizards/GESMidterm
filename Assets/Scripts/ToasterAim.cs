using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToasterAim : MonoBehaviour
{
    //Make mouse sensitivity editable in the inspector
    [SerializeField] private float horizontalMouseSensitivity = 0.5f; //Horizontal mouse sensitivity
    [SerializeField] private float verticalMouseSensitivity = 0.5f; //Vertical mouse sensitivity

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //Hide cursor
    }

    void Update()
    {
        //Configure mouse follow
        float deltaMouseHorizontal = Input.GetAxis("Mouse X") * horizontalMouseSensitivity;
        float deltaMouseVertical = Input.GetAxis("Mouse Y") * verticalMouseSensitivity;
        float newCameraRotationY = transform.rotation.eulerAngles.y + deltaMouseHorizontal;
        float newCameraRotationX = transform.rotation.eulerAngles.x - deltaMouseVertical;

        transform.eulerAngles = new Vector3(newCameraRotationX, newCameraRotationY, 0);

        //Unlock cursor with escape key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None; //Show cursor
        }
    }
}
