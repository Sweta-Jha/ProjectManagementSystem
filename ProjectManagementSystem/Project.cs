using ProjectManagementSystem;

public abstract class Project
{
    //Data members
    private int _projectID;
    public int ProjectID
    {
        get { return _projectID; }
        set { _projectID = value; }
    }

    private int _managerID;
    public int ManagerId
    {
        get { return _managerID; }
        set { _managerID = value; }
    }
    private string _categoryName;
    public string CategoryName
    {
        get { return _categoryName; }
        set { _categoryName = value; }
    }
    private string _projectName;
    public string ProjectName
    {
        get { return _projectName; }
        set { _projectName = value; }
    }
    private string _projectDescription;
    public string ProjectDescription
    {
        get { return _projectDescription; }
        set { _projectDescription = value; }
    }
    private ProjectMembers _projectMember;
    public ProjectMembers ProjectMember
    {
        get { return _projectMember; }
        set { _projectMember = value; }
    }
    private DateTime _startDate;
    public DateTime StartDate
    {
        get { return _startDate; }
        set { _startDate = value; }
    }
    private DateTime _expectedEndDate;
    public DateTime ExpectedEndDate
    {
        get { return _expectedEndDate; }
        set { _expectedEndDate = value; }
    }
    public Project()
    {
        Console.WriteLine("constructor call");
        this.ProjectID = 01;
    }
    public abstract void ProjectDetailInformation();
    // public virtual void ProjectDetail();
    public void display(string ProjectName)
    {
        ProjectName = ProjectName;
        Console.WriteLine("Project name:" + ProjectName);
    }
    public void display(int projectId)
    {
        ProjectID = projectId;
        Console.WriteLine("project Id:" + ProjectID);
    }
}



