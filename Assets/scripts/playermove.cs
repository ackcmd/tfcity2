
//using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//--------------------------------------------------

namespace NesScripts.Controls.PathFind
{

    public class playermove : MonoBehaviour
    {
        private int step;
        Vector3 nextPosition;
        Vector3 currentPosition;
        public float speed;
        public float rotateSpeed;
        public bool isMoving;
        //public bool isTurning;
        public MapData mapdata;
        //public float[,] tilesmap;
        public PathFind.Grid grid;
        public List<PathFind.Point> path;
        // Use this for initialization
        void Start()
        {

            currentPosition = transform.position;
            nextPosition = transform.position;
            //isTurning = false;
            speed = 10f;
            rotateSpeed = 3000f;
            isMoving = false;
            mapdata = FindObjectOfType(typeof(MapData)) as MapData;
            //tilesmap = new float[10, 10];
            //tilesmap = GenerateTiles(10, 10);
            grid = new PathFind.Grid(this.mapdata.mapdata);
            path = PathFind.Pathfinding.FindPath(grid, new PathFind.Point(Mathf.FloorToInt(transform.position.x), Mathf.FloorToInt(transform.position.z)), new PathFind.Point(Mathf.FloorToInt(transform.position.x), Mathf.FloorToInt(transform.position.z)));
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetMouseButtonDown(0) && !isMoving && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            {
                
                PathFind.Point _from = new PathFind.Point(Mathf.FloorToInt(transform.position.x), Mathf.FloorToInt(transform.position.z));
                //PathFind.Point _to = new PathFind.Point(10, 10);
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {
                    PathFind.Point _to = new PathFind.Point(Mathf.FloorToInt(hit.point.x), Mathf.FloorToInt(hit.point.z));
                    path = PathFind.Pathfinding.FindPath(grid, _from, _to);
                    //nextPosition = new Vector3(Mathf.Floor(hit.point.x) + 0.5f, 0, Mathf.Floor(hit.point.z) + 0.5f);
                    step = 0;
                    isMoving = true;
                    //Debug.Log(mapdata.Name[Mathf.FloorToInt(hit.point.x), Mathf.FloorToInt(hit.point.z)]);
                    //Debug.Log(path.Count);
                    //Debug.Log(Mathf.FloorToInt(hit.point.x)+ "   " + Mathf.FloorToInt(hit.point.z));
                }
            }
            if (path != null && step < path.Count)
            {
                nextPosition = new Vector3(path[step].x + 0.5f, 0, path[step].y + 0.5f);
                //Debug.Log(nextPosition);
                if (transform.position != nextPosition && isMoving)
                {
                    /* isMoving = true;
                     if (Quaternion.Angle(transform.rotation, Quaternion.LookRotation(nextPosition - transform.position)) != 0)
                     {
                         transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(nextPosition - transform.position), rotateSpeed * Time.deltaTime);
                     }
                     else
                     {*/
                    transform.LookAt(nextPosition);
                    transform.position = Vector3.MoveTowards(transform.position, nextPosition, Time.deltaTime * speed);
                    //}
                }
                else step++;
                //else { isMoving = false; }
                //path.RemoveAt(0);
            }
            else isMoving = false;
        }
        /*
        public float[,] GenerateTiles(int sizex, int sizey)
        {
            tilesmap = new float[sizex, sizey];
            for (int xx = 0; xx < sizex; xx++)
            {
                for (int yy = 0; yy < sizey; yy++)
                {
                    tilesmap[xx, yy] = 5f;
                }
            }

            for (int xx = 0; xx < 2; xx++)
            {
                for (int yy = 0; yy < 5; yy++)
                {
                    tilesmap[xx, yy] = 20f;
                }
            }

            for (int xx = 8; xx < 10; xx++)
            {
                for (int yy = 0; yy < 5; yy++)
                {
                    tilesmap[xx, yy] = 20f;
                }
            }

            for (int xx = 2; xx < 8; xx++)
            {
                for (int yy = 3; yy < 5; yy++)
                {
                    tilesmap[xx, yy] = 20f;
                }
            }

            for (int xx = 0; xx < 10; xx++)
            {
                for (int yy = 6; yy < 10; yy++)
                {
                    tilesmap[xx, yy] = 20f;
                }
            }

            tilesmap[5, 3] = 5f;
            tilesmap[5, 4] = 5f;
            tilesmap[3, 6] = 5f;
            tilesmap[3, 7] = 5f;
            tilesmap[3, 8] = 5f;
            tilesmap[3, 9] = 5f;
            tilesmap[6, 6] = 5f;
            tilesmap[6, 7] = 5f;
            tilesmap[6, 8] = 5f;
            tilesmap[6, 9] = 5f;
            return tilesmap;
        }*/
    }
}


