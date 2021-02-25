using UnityEngine;

public class GCWin : MonoBehaviour {
    public GameController gameController;
  
   // public bool WinCon = false;


	//void OnCollisionaEnter(Collider collider)
   // {
      //  if collision.gameObject.tag == "Coin")
       // {
        //    Destroy(collision.gameObject);
        //    WinCon = true
        //}


    void OnTriggerEnter(Collider other) 
  
        { gameController.Win(); }
    


}
