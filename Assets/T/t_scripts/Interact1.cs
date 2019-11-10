using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Interact1 : MonoBehaviour
{
    public Animation gunani;
        public Animator ani; 
    public GameObject player;
    public GameObject Cam;
    public Transform bullets;
    public Transform projectile;
    public float fireforce;
    public GameObject Gun;
    public Rigidbody prigd;
    public LineRenderer laserLineRenderer;
    public float laserWidth = 0.1f;
    public float laserMaxLength = 5f;
    // public Transform bullet;


    public Text texty;
    public  int scorecount = 0;


    private void Awake()
    {
       // texty = GetComponent<Text>();
      //ani = gameObject.GetComponent<Animator>();
        // Cursor.visible = false;
    }
    //  void OnDrawGizmosSelected()
    // {
    //   if (Input.GetButtonDown("Fire1"))
    //     
    //      Gizmos.color = Color.red;
    //    Vector3 direction = transform.TransformDirection(Vector3.forward) * 5000;
    //    Gizmos.DrawRay(transform.position, direction);
    // }
    public void Update()
    {
       
        if (Input.GetButtonDown("Fire1"))
        {
           
            Ray shoot;
          //  ani.SetBool("newBool", false);
            //this ray is shooting out from the main cameras screen point center of screen
            shoot = Camera.main.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
            //create hit info
            RaycastHit hitInfo;

            //  Instantiate (projectile, Cam.transform.position, Cam.transform.forward);
            // Destroy(projectile); 
            // bullets = Instantiate(projectile, transform.position, transform.rotation);
            // bullets.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            //var bulletclone = bullets; 
            //Destroy((bullets as Transform).gameObject, 2f);

            // Add force to the cloned object in the object's forward direction
            //bullet.rigidbody.AddForce(bullet.transform.forward * fireforce);
            // Set the missiles timeout destructor to 5
            // clone.timeoutDestructor = 5;

            //if this physics raycast hits something within 10 units
            if (Physics.Raycast(shoot, out hitInfo, 100000))
           
            if (hitInfo.collider.CompareTag("enm"))
            {
                    // laserLineRenderer.transform.TransformDirection(Vector3.forward);
                    //    laserLineRenderer.SetPosition(0, Gun.transform.position);
                    //   laserLineRenderer.SetPosition(1, hitInfo.point);
                  //  firetgr 
                    scorecount += 1;
                    Debug.Log("enm");
                    //Destroy(GameObject.FindWithTag("enm"));
                    Destroy(hitInfo.collider.gameObject);
                    texty.text = "Score:  " + scorecount;
                  //  ani.SetTrigger("firetgr");
                    //ani.SetBool("newBool", true);
                }

            //#endregion
            //#region Item
            //and that hits info is tagged Item
            //  if (hitInfo.collider.CompareTag("Item"))
            // {

            //Debug that we hit an Item
            //    Debug.Log("item");
            // }





         
        }
        }
    }









