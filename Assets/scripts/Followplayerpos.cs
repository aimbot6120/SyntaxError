using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace S3 {
    public class Followplayerpos : NetworkBehaviour
    {
        public Transform player;
        public Vector3 offset;
        public Transform LookAt;
        
        void start()
        {
            if (isLocalPlayer)
            {
                
                Camera.main.transform.position = this.transform.position - this.transform.forward * 10 + this.transform.up * 3;
                Camera.main.transform.LookAt(this.transform.position);
                Camera.main.transform.parent = this.transform;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (isLocalPlayer)
            {
             //   transform.position = player.position + offset;
            }
        }
    }
}
