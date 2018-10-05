using Unity.Engine;
using Unity.Editor;
using System.Collections;

public class MeshClassForRiverMesh : MonoBehavior { 
    public MeshXVector Vector3;
    public MeshYVector Vector3;
    public MeshZVector Vector3;
    public int[] Verticies;
    public int[] Polygons;
    public int[] newUVMap;
    public float MeshSizeControl = 1000f;
    public int MaximumMeshSizeHeight = 1000;
    public int MaximumMeshSizeWidth = 1000;

    void Start()
    {
        addingtheMesh();
        MeshStartingXVector Vector3 = new Vector3(MeshXVector(100f, 0.0f, 0.0f));
        MeshStartingYVector Vector3 = new Vector3(MeshYVector(0.0f, 100f, 0.0f));
        MeshStartingXVector Vector3 = new Vector3(MeshZVector(0.0f, 0.0f, 100f));

    }

    void Update()
    {
        float VerticeChange = 1000f;
        while (addingtheMesh()) 
        {
            int[]Polygons = new int[MeshStartingXVector * MeshStartingYVector * MeshStartingZVector];
            int AllMeshVectors = MeshXVector * MeshYVector, MeshZVector;
            game.
        }

        
    }

    void MeshFunction()
    {
        MeshXVector = new Vector3(100f, 0.0f, 0.0f);
        MeshYVector = new Vector3(0.0f, 100f, 0.0f);
        MeshZVector = new Vector3(0.0f, 0.0f, 100f);
        MeshFindingFunction = GetComponent<RiverMesh>;
        Vector3 MeshXSize;
        Vector3 MeshYSize;
        Vector3 MeshZSize;

        MeshXSize = new Vector3(MeshSizeControl / 100f, 0.0f, 0.0f);
        MeshYSize = new Vector3(0.0f, MeshSizeControl / 100f, 0.0f);
        MeshZSize = new Vector3(0.0f, 0.0f, MeshSizeControl / 100f);

        if (MeshXSize < MeshSizeControl)
        {
            MeshXSize = new Vector3(MeshSizeControl / 1000f, 0.0f, 0.0f);
        }
        if (MeshYSize < MeshSizeControl)
        {
            MeshYSize = new Vector3(0.0f, MeshSizeControl / 1000f, 0.0f);
        }
        if (MeshZSize < MeshSizeControl)
        {
            MeshZSize = new Vector3(0.0f, 0.0f, MeshSizeControl / 1000f);
        }
    }

    void MeshRefine()
    {
        RiverMesh mesh = new RiverMesh();

    }

    void addingtheMesh()
    {
        gameObject.AddComponent<MeshFilter>;
        gameObject.AddComponent<MeshRenderer>;
        RiverMesh = GetComponent<MeshFilter>.mesh();
        mesh.clear();
    }
}

