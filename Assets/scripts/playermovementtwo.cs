using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

namespace S4
{

    public class playermovement : MonoBehaviour
    {
        static public playermovement localPlayer;
        public Rigidbody rb;
        public Vector3 v3;
        public float inputangle = 30f;
        public float inputforce = 125f;
        private NetworkStartPosition[] spawnpoints;

        // Start is called before the first frame update
        [System.Obsolete]


        // Update is called once per frame
        void FixedUpdate()
        {

    //        if (isLocalPlayer)
            {


                //  rb.AddForce(forwardforce * Time.deltaTime, 0, forwardforce * Time.deltaTime, ForceMode.VelocityChange);
                if (Input.GetKey("vk_right"))
                {
                    rb.AddForce(inputforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                if (Input.GetKey("vk_left"))
                {
                    rb.AddForce(-inputforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                }
                if (Input.GetKey("vk_up"))
                {
                    rb.AddForce(0, 0, inputforce * Time.deltaTime, ForceMode.VelocityChange);
                }
                if (Input.GetKey("vk_down"))
                {
                    rb.AddForce(0, 0, -inputforce * Time.deltaTime, ForceMode.VelocityChange);
                }
                if (rb.position.y < -3)
                {
                    transform.position = new Vector3(Random.Range(-30, 30), 3, Random.Range(-30, 30));
                    rb.velocity = new Vector3Int(0, 0, 0);

                }

            }
        }
       /*   public override void OnStartLocalPlayer()
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }*/
    }
}