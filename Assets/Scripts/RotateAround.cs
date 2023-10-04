using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class RotateAround : MonoBehaviour
    {
        public Transform target;

        public float speed;
        public Vector2 axis;

        // Start is called before the first frame update
        void Start()
        {
            if (target != null) return;
            target = gameObject.transform;
            Debug.Log(message:"Alvo não definidos");
        }

        // Update is called once per frame
        void Update()
        {
            transform.RotateAround(target.position, axis,speed * Time.deltaTime);
        }
    }
}
