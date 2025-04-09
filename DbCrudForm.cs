using Microsoft.Data.SqlClient;

namespace CSHARP25040903;

public partial class DbCrudForm : Form
{
    private const string ConStr = 
        "server=(localdb)\\MSSQLLocalDB;" +
        "database=peopledb;";

    public DbCrudForm()
    {
        InitializeComponent();
        this.Load += DbCrudForm_Load;
    }

    private void DbCrudForm_Load(object? sender, EventArgs e)
    {
        FillDgv();
    }

    private void FillDgv()
    {
        using SqlConnection conn = new(ConStr);
        conn.Open();

        SqlCommand cmd = new("SELECT * FROM people;", conn);
        SqlDataReader rdr = cmd.ExecuteReader();

        while(rdr.Read())
        {
            dgvPeople.Rows.Add(
                (int)rdr["id"],
                (string)rdr["name"],
                $"{(DateTime)rdr["birth"]:yyyy. MMMM dd.}",
                (bool)rdr["sex"] ? "male" : "female");
        }
    }
}
