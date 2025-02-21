using UnityEngine;


    public class PlayerMana : MonoBehaviour
    {
        [Header("config")]    
        [SerializeField] private PlayerStats stats;

        public void UseMana(float amout)
        {
            if(stats.Mana >  amout)
            {
                stats.Mana = Mathf.Max(stats.Mana-amout, 0f);
            }
        }
        private void Update()
        {
             if (Input.GetKeyDown(KeyCode.M))
                {
                UseMana(1f);
                }
        }
}
