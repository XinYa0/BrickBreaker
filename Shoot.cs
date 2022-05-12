using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.Instantiate(bulletPrefab,transform.position,transform.rotation);
        //pt(xyz)rt(角度)

     //根据prefab创建实例 = 实例化prefab = 克隆
    }

    // Update is called once per frame
    void Update()
    {
        //Input
        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = GameObject.Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody rd = bullet.GetComponent<Rigidbody>();
            //rd.AddForce(Vector3.forward*100);
            rd.velocity = Vector3.forward * 30;

        }
    }
}
