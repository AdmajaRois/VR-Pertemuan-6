using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HalamanUtama : MonoBehaviour
{
    public Text textHalaman;
   public void pindahHalaman(string halaman)
   {
       if (halaman == "SceneTiga")
       {
           textHalaman.text = "Rois memasuki Game minggu ke-3";
       }else if (halaman == "SceneEmpat")
       {
            textHalaman.text = "Rois memasuki Game minggu ke-4";
       }else
       {
           textHalaman.text = "Rois memasuki Game minggu ke-5";
       }
       SceneManager.LoadScene(halaman);
   }

   public void keluarAplikasi()
   {
       Application.Quit();
   }
}
