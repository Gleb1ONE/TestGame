using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InclinePlatformInput : MonoBehaviour
{
    public float sensivityIncline = 0.1f;   //При увеличении скорости при резком изменении угла в крайних положениях шар проваливается сквозь коллайдер, пока не решил
    public float maxIncline = 10.0f;
    public float minIncline = -10.0f;

    private float _rotationX = 0;
    private float _rotationZ = 0;

    void Update()
    {
        _rotationX -= Input.GetAxis("Vertical") * sensivityIncline * -1;
        _rotationX = Mathf.Clamp(_rotationX, minIncline, maxIncline);


        _rotationZ -= Input.GetAxis("Horizontal") * sensivityIncline;
        _rotationZ = Mathf.Clamp(_rotationZ, minIncline, maxIncline);

        transform.localEulerAngles = new Vector3(_rotationX, 0, _rotationZ);

    }
}
