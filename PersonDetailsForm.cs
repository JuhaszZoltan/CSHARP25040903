using Microsoft.Data.SqlClient;

namespace CSHARP25040903;

public partial class PersonDetailsForm : Form
{
    private int Id { get; set; }

    public PersonDetailsForm(int id = 0)
    {
        Id = id;
        InitializeComponent();
        this.Load += PersonDetailsForm_Load;
        btnCommit.Click += BtnCommit_Click;
        btnDeletePerson.Click += BtnDeletePerson_Click;
    }

    private void BtnDeletePerson_Click(object? sender, EventArgs e)
    {
        using SqlConnection conn = new(Program.ConnectionString);
        conn.Open();

        SqlDataAdapter adapter = new()
        {
            DeleteCommand = new($"DELETE FROM people WHERE id = {Id}", conn)
        };

        if (IsConfirmed())
        {
            adapter.DeleteCommand.ExecuteNonQuery();
            this.Close();
        }
    }

    private void BtnCommit_Click(object? sender, EventArgs e)
    {
        using SqlConnection conn = new(Program.ConnectionString);
        conn.Open();

        SqlDataAdapter adapter = new();

        if (Id == 0)
        {
            adapter.InsertCommand = new(
                "INSERT INTO people VALUES " +
                $"('{txtName.Text}', '{dtpBirth.Value:yyyy-MM-dd}', {(rdoMale.Checked ? 1 : 0)});",
                conn);
        }
        else
        {
            adapter.UpdateCommand = new(
                "UPDATE people SET " +
                $"name = '{txtName.Text}', " +
                $"birth = '{dtpBirth.Value:yyyy-MM-dd}', " +
                $"sex = {(rdoMale.Checked ? 1 : 0)} " +
                $"WHERE id = {Id};", conn);
        }

        if (IsConfirmed())
        {
            adapter.InsertCommand?.ExecuteNonQuery();
            adapter.UpdateCommand?.ExecuteNonQuery();

            this.Close();
        }
    }

    private bool IsConfirmed()
    {
        DialogResult result = MessageBox.Show(
            caption: "confirmation",
            text: "are you sure?", 
            icon: MessageBoxIcon.Warning,
            buttons: MessageBoxButtons.YesNo);

        return result == DialogResult.Yes;
    }

    private void PersonDetailsForm_Load(object? sender, EventArgs e) =>
        FillPersonDetails();

    private void FillPersonDetails()
    {
        if (Id == 0)
        {
            lblId.Text = string.Empty;
            btnCommit.Text = "add new people";
            return;
        }

        btnDeletePerson.Visible = true;

        using SqlConnection conn = new(Program.ConnectionString);
        conn.Open();

        string cmdStr = $"SELECT * FROM people WHERE id = {Id}";
        SqlCommand cmd = new(cmdStr, conn);
        SqlDataReader rdr = cmd.ExecuteReader();

        if (!rdr.Read())
        {
            MessageBox.Show(
                caption: "EROOR!",
                text: $"id {Id} do not exist in the database!",
                icon: MessageBoxIcon.Error,
                buttons: MessageBoxButtons.OK);
            this.Close();
        }
        else
        {
            btnCommit.Text = "save changes";

            lblId.Text = $"{Id}";
            txtName.Text = (string)rdr["name"];
            dtpBirth.Value = (DateTime)rdr["birth"];
            rdoMale.Checked = (bool)rdr["sex"];
            rdoFemale.Checked = !rdoMale.Checked;
        }
    }
}
