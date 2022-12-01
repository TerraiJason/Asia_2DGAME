using UnityEngine;

public class PlayerFinal : MonoBehaviour
{
   private void OnDestroy()
   {
        FinalManager.instance.GameOver("You Die!!");

   }

   private void OnTriggerEnter2D(Collider2D collision)
   {
        FinalManager.instance.GameOver("You Win!!");

   }


}
