namespace Lecture13.ModelsDB;

public partial class Teacher
{
    public string FullName => Name + " " + Surname;
}
