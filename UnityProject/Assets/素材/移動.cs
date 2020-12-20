using UnityEngine;
using System.Collections;

public class 移動 : MonoBehaviour
{
  [Header("移動速度"),Range(1f,50f)]
    public float speed = 20f;

    public Rigidbody2D Rig;
    private float thrust = 10.0f;

    public SpriteRenderer Sr;

    private void Start()
    {
        Rig = gameObject.AddComponent<Rigidbody2D>();
        transform.position = new Vector3(0.0f, -2.0f, 0.0f);

        
    }

    void FixedUpdate()
    {
        Rig.AddForce(transform.up * thrust);
    }
    #region  方法

    private void Move()
    {

    }
    void Update()
    {
        float speed = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        transform.Rotate(0, speed, 0);
    }


 
    #endregion

}
