using Microsoft.Data.SqlClient;

namespace CSHARP25040903;

public partial class DbCrudForm : Form
{
    public DbCrudForm()
    {
        InitializeComponent();
        this.Load += DbCrudForm_Load;
        btnAddPerson.Click += BtnAddPerson_Click;
        txtSearchFilter.TextChanged += TxtSearchFilter_TextChanged;
        dgvPeople.CellClick += DgvPeople_CellClick;
    }

    private void BtnAddPerson_Click(object? sender, EventArgs e)
    {
        _ = new PersonDetailsForm().ShowDialog();
        FillDgv();
    }
        

    private void DgvPeople_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        _ = new PersonDetailsForm((int)dgvPeople[0, e.RowIndex].Value).ShowDialog();
        FillDgv();
    }

    private void TxtSearchFilter_TextChanged(object? sender, EventArgs e) =>
        FillDgv();

    private void DbCrudForm_Load(object? sender, EventArgs e) => 
        FillDgv();

    private void FillDgv()
    {
        dgvPeople.Rows.Clear();

        using SqlConnection conn = new(Program.ConnectionString);
        conn.Open();

        string cmdStr = 
            "SELECT * FROM people " +
            $"WHERE name LIKE '{txtSearchFilter.Text}%';";

        SqlCommand cmd = new(cmdStr, conn);
        SqlDataReader rdr = cmd.ExecuteReader();

        while(rdr.Read())
        {
            dgvPeople.Rows.Add(
                (int)rdr["id"],
                (string)rdr["name"],
                $"{(DateTime)rdr["birth"]:yyyy. MMMM dd.}",
                (bool)rdr["sex"] ? "male" : "female");
        }

        dgvPeople.ClearSelection();
    }
}
