using UnityEngine;

namespace ChooseStartingLocation
{
    public class Location
    {
        internal readonly string spawnPointName;
        public string name;
        public string scene;
        public Region region;
        public bool indoors = false;
        public bool teleport = true;
        public Vector3 position = Vector3.zero;
        public Quaternion rotation = Quaternion.identity;

        public Location()
        {
        }
        public Location(string name, string scene, Region region, bool indoors, bool teleport)
        {
            this.name = name;
            this.scene = scene;
            this.region = region;
            this.indoors = indoors;
            this.teleport = teleport;
        }
        public Location(string name, Region region, float vectorX, float vectorY, float vectorZ)
        {
            this.name = name;
            this.scene = region.ToString();
            this.region = region;
            this.position = new Vector3(vectorX, vectorY, vectorZ);
        }
        public Location(string name, Region region, float positionX, float positionY, float positionZ, float rotationX, float rotationY)
        {
            this.name = name;
            this.scene = region.ToString();
            this.region = region;
            this.position = new Vector3(positionX, positionY, positionZ);
            this.rotation.eulerAngles = new Vector3(rotationY, rotationX);
        }
        public Location(string name, string scene, Region region, bool indoors, bool teleport, float positionX, float positionY, float positionZ, float rotationX, float rotationY)
        {
            this.name = name;
            this.scene = scene;
            this.region = region;
            this.indoors = indoors;
            this.teleport = teleport;
            this.position = new Vector3(positionX, positionY, positionZ);
            this.rotation.eulerAngles = new Vector3(rotationY, rotationX);
        }
    }
}