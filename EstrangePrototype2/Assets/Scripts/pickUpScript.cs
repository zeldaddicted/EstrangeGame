using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pickUpScript : MonoBehaviour {

    public int picturePieces = 0;

    public Image Journal;

    RaycastHit hit;

    public GameObject[] picturePiece;

    public Transform[] spawnPlaces1;
    public Transform[] spawnPlaces2;
    public Transform[] spawnPlaces3;

    public AudioClip paperCrumble;

    AudioSource source;

    

	// Use this for initialization
	void Start () {

        Instantiate(picturePiece[0], new Vector3(0f, 1f, 0f), Quaternion.identity);
        Instantiate(picturePiece[1], new Vector3(3f, 1f, 0f), Quaternion.identity);
        Instantiate(picturePiece[2], new Vector3(-3f, 1f, 0f), Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {

        Ray pickUp = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 50f);

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(pickUp, out hit, 20f))
            {
                if (hit.collider.gameObject.CompareTag("PictureOne"))
                {
                    hit.collider.gameObject.SetActive(false);
                    GetComponent<AudioSource>().PlayOneShot(paperCrumble, 1f);
                    picturePieces = picturePieces + 1;
                }
                if (hit.collider.gameObject.CompareTag("PictureTwo"))
                {
                    GetComponent<AudioSource>().PlayOneShot(paperCrumble, 1f);
                    hit.collider.gameObject.SetActive(false);
                    picturePieces = picturePieces + 1;
                }
                if (hit.collider.gameObject.CompareTag("PictureThree"))
                {
                    GetComponent<AudioSource>().PlayOneShot(paperCrumble, 1f);
                    hit.collider.gameObject.SetActive(false);
                    picturePieces = picturePieces + 1;
                }
                if (hit.collider.gameObject.CompareTag("labDoor"))
                {
                    if (picturePieces == 3)
                    {
                        Application.LoadLevel("lab");
                    }
                }
            }
        }
    }
}
