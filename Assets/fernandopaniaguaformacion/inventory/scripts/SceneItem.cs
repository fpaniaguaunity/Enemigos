using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace FPFInventory
{
    public class SceneItem : MonoBehaviour
    {
        [Header("Nombrel del �tem")]
        public string itemName;
        [Header("N�mero de unidades del �tem que se recogen")]
        public int itemsCounter;
        [Header("Imagen que se muestra en la UI")]
        public Sprite imageUI;
        [Header("�tem del juego")]
        public GameObject itemGO;
        [Header("Objeto a spawnear cuando se recoge el �tem (opcional)")]
        public GameObject collectGO;
    }
}
