using UnityEngine;
using UnityEngine.SceneManagement;


namespace CoreNameSpace
{
    class Core : MonoBehaviour
    {

        public static void Move(Rigidbody rb, float SpeedRotation, float ForceUp, GameObject Character)
        {
            if (Input.GetKey(KeyCode.Space))
                FlyingingWithSpace(rb, ForceUp);

            if (Input.GetKey(KeyCode.A))
            {
                Transforms(SpeedRotation, Character);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                Transforms(-SpeedRotation, Character);
            }



        }
        private static void Transforms(float _Directions, GameObject _Character)
        {
            _Character.transform.Rotate(Vector3.forward * _Directions * Time.deltaTime);
        }
        private static void FlyingingWithSpace(Rigidbody _rb, float _ForceUp)
        {
            _rb.AddRelativeForce(Vector3.up * _ForceUp * Time.deltaTime, ForceMode.Impulse);
        }


    }
    class Scene : MonoBehaviour
    {
        public static void ResetTheScene()
        {
            if (Input.GetKey(KeyCode.M))
            {
                string ActualScene = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(ActualScene);
            }
        }
        public static void ResetTheScene(string SceneToLoad)
        {
            if (Input.GetKey(KeyCode.M))
            {
                SceneManager.LoadScene(SceneToLoad);
            }
        }
        public static void ResetTheScene(KeyCode KeyToResetActualScene)
        {
            if (Input.GetKey(KeyToResetActualScene))
            {
                string ActualScene = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene(ActualScene);
            }
        }
        public static void ResetTheScene(string SceneToLoad, KeyCode KeyToReset)
        {
            if (Input.GetKey(KeyToReset))
            {

                SceneManager.LoadScene(SceneToLoad);
            }
        }
        public static void ResetOnlyScene()
        {
            string ActualScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(ActualScene);
        }
        public static void ResetOnlyScene(string SceneToLoad)
        {
            SceneManager.LoadScene(SceneToLoad);
        }

    }
}
