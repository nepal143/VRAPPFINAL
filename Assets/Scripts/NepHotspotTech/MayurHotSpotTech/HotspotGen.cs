// using UnityEngine;
// using System.IO;

// public class JsonParser : MonoBehaviour
// {
//     [System.Serializable]
//     public class Hotspot
//     {
//         public Position position;
//         public Rotation rotation;
//         public int connectedPanoramaIndex;
//     }

//     [System.Serializable]
//     public class Position
//     {
//         public float x;
//         public float y;
//         public float z;
//     }

//     [System.Serializable]
//     public class Rotation
//     {
//         public float x;
//         public float y;
//         public float z;
//         public float w;
//     }

//     [System.Serializable]
//     public class Hotspots
//     {
//         public Hotspot[] hotspots;
//         public DollHouse dollHouse;
//     }

//     [System.Serializable]
//     public class DollHouse
//     {
//         public Position position;
//         public Rotation rotation;
//     }

//     [System.Serializable]
//     public class RootObject
//     {
//         public Hotspots hotspots;
//     }

//     public GameObject prefab; // Public field for the prefab to be instantiated

//     void Start()
//     {
//         string filePath = @"D:\TP\models\nepal_jodhpuriVilla\info.json";

//         if (File.Exists(filePath))
//         {
//             try
//             {
//                 string jsonText = File.ReadAllText(filePath);
//                 Debug.Log("JSON Text: " + jsonText); // Log the JSON text to see what is being read

//                 RootObject data = JsonUtility.FromJson<RootObject>(jsonText);

//                 if (data != null && data.hotspots != null && data.hotspots.hotspots != null)
//                 {
//                     int numberOfPositions = data.hotspots.hotspots.Length;
//                     Debug.Log("Number of positions: " + numberOfPositions);

//                     foreach (var hotspot in data.hotspots.hotspots)
//                     {
//                         Vector3 position = new Vector3(hotspot.position.x, hotspot.position.y, hotspot.position.z);
//                         Quaternion rotation = new Quaternion(hotspot.rotation.x, hotspot.rotation.y, hotspot.rotation.z, hotspot.rotation.w);
//                         Instantiate(prefab, position, rotation);
//                     }
//                 }
//                 else
//                 {
//                     Debug.LogError("No hotspots found in JSON.");
//                 }
//             }
//             catch (System.Exception e)
//             {
//                 Debug.LogError("Failed to parse JSON: " + e.Message);
//             }
//         }
//         else
//         {
//             Debug.LogError("File not found at: " + filePath);
//         }
//     }
// }
//using UnityEngine;
//using System.IO;

//public class JsonParser : MonoBehaviour
//{
//    [System.Serializable]
//    public class Hotspot
//    {
//        public Position position;
//        public Rotation rotation;
//        public int connectedPanoramaIndex;
//    }

//    [System.Serializable]
//    public class Position
//    {
//        public float x;
//        public float y;
//        public float z;
//    }

//    [System.Serializable]
//    public class Rotation
//    {
//        public float x;
//        public float y;
//        public float z;
//        public float w;
//    }

//    [System.Serializable]
//    public class Hotspots
//    {
//        public Hotspot[] hotspots;
//        public DollHouse dollHouse;
//    }

//    [System.Serializable]
//    public class DollHouse
//    {
//        public Position position;
//        public Rotation rotation;
//    }

//    [System.Serializable]
//    public class RootObject
//    {
//        public Hotspots hotspots;
//    }

//    public GameObject prefab; // Public field for the prefab to be instantiated

//    void Start()
//    {
//        string filePath = @"D:\TP\models\nepal_jodhpuriVilla\info.json";

//        if (File.Exists(filePath))
//        {
//            try
//            {
//                string jsonText = File.ReadAllText(filePath);
//                Debug.Log("JSON Text: " + jsonText); // Log the JSON text to see what is being read

//                RootObject data = JsonUtility.FromJson<RootObject>(jsonText);

//                if (data != null && data.hotspots != null && data.hotspots.hotspots != null)
//                {
//                    int numberOfPositions = data.hotspots.hotspots.Length;
//                    Debug.Log("Number of positions: " + numberOfPositions);

//                    foreach (var hotspot in data.hotspots.hotspots)
//                    {
//                        Vector3 position = new Vector3(hotspot.position.x, hotspot.position.y, hotspot.position.z);
//                        Quaternion rotation = new Quaternion(hotspot.rotation.x, hotspot.rotation.y, hotspot.rotation.z, hotspot.rotation.w);
//                        GameObject sphere = Instantiate(prefab, position, rotation);

//                        SphereClickHandler SphereClickHandler = sphere.GetComponent<SphereClickHandler>();
//                        if (SphereClickHandler != null)
//                        {
//                            SphereClickHandler.index = hotspot.connectedPanoramaIndex; // Assign the connectedPanoramaIndex as the index
//                        }
//                    }
//                }
//                else
//                {
//                    Debug.LogError("No hotspots found in JSON.");
//                }
//            }
//            catch (System.Exception e)
//            {
//                Debug.LogError("Failed to parse JSON: " + e.Message);
//            }
//        }
//        else
//        {
//            Debug.LogError("File not found at: " + filePath);
//        }
//    }
//}

using UnityEngine;
using System.IO;

public class JsonParser : MonoBehaviour
{
    [System.Serializable]
    public class Hotspot
    {
        public Position position;
        public Rotation rotation;
        public int connectedPanoramaIndex;
    }

    [System.Serializable]
    public class Position
    {
        public float x;
        public float y;
        public float z;
    }

    [System.Serializable]
    public class Rotation
    {
        public float x;
        public float y;
        public float z;
        public float w;
    }

    [System.Serializable]
    public class Hotspots
    {
        public Hotspot[] hotspots;
        public DollHouse dollHouse;
    }

    [System.Serializable]
    public class DollHouse
    {
        public Position position;
        public Rotation rotation;
    }

    [System.Serializable]
    public class RootObject
    {
        public Hotspots hotspots;
    }

    public GameObject prefab; // Public field for the prefab to be instantiated

    void Start()
    {
        string filePath = @"D:\TP\123\RamanNivas\NepaliVilla\info.json";

        if (File.Exists(filePath))
        {
            try
            {
                string jsonText = File.ReadAllText(filePath);
                Debug.Log("JSON Text: " + jsonText); // Log the JSON text to see what is being read

                RootObject data = JsonUtility.FromJson<RootObject>(jsonText);

                if (data != null && data.hotspots != null && data.hotspots.hotspots != null)
                {
                    int numberOfPositions = data.hotspots.hotspots.Length;
                    Debug.Log("Number of positions: " + numberOfPositions);

                    foreach (var hotspot in data.hotspots.hotspots)
                    {
                        Vector3 position = new Vector3(hotspot.position.x, hotspot.position.y, hotspot.position.z);
                        Quaternion rotation = new Quaternion(hotspot.rotation.x, hotspot.rotation.y, hotspot.rotation.z, hotspot.rotation.w);
                        GameObject sphere = Instantiate(prefab, position, rotation);

                        SphereClickHandler SphereClickHandler = sphere.GetComponent<SphereClickHandler>();
                        if (SphereClickHandler != null)
                        {
                            SphereClickHandler.index = hotspot.connectedPanoramaIndex; // Assign the connectedPanoramaIndex as the index
                        }
                    }
                }
                else
                {
                    Debug.LogError("No hotspots found in JSON.");
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError("Failed to parse JSON: " + e.Message);
            }
        }
        else
        {
            Debug.LogError("File not found at: " + filePath);
        }
    }
}
