using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossLeilaProject.Client.Description
{
    public partial class AnnounceDescription : Form
    {
        readonly int id;
        const string cString = @"Data Source=sql5063.site4now.net;Initial Catalog=DB_A50752_programming;Persist Security Info=True;User ID=DB_A50752_programming_admin;Password=code2020_devs";
        public AnnounceDescription()
        {
            InitializeComponent();
        }
        public AnnounceDescription(int Id)
            :this()
        {
            this.id = Id;
        }
        private void AnnounceDescription_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $@"SELECT[Id]
      ,[Number]
      ,[Email]
      ,[Information]
      ,[Requirements]
      ,[startDate]
      ,[FinishDate]
      ,[CreatedDate]
      ,[CreatedUserId]
      ,[UpdatedDate]
      ,[UpdatedUserId]
      ,[DeletedDate]
      ,[DeletedUserId]
      ,[Salary]
      ,[Gender]
      ,[CityId]
      ,[CategoriesId]
      ,[CompaniesId]
      ,[EducationId]
      ,[ExperienceId]
      ,[SubCategryId]
      ,[Education]
      ,[Experience]
      ,[City]
      ,[Company]
      ,[Category]
      ,[Sub Category]
  FROM [BossLeila].[VwAnnounce] WHERE (Id = {id})";

            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
              labelExperience.Text = reader["Experience"].ToString();
                labelCity.Text = reader["City"].ToString();
                labelPhone.Text = reader["Number"].ToString();
               
                labelStart.Text = ((DateTime)(reader["startDate"])).ToString("dd.MM.yyyy");
                labelEnd.Text = ((DateTime)(reader["FinishDate"])).ToString("dd.MM.yyyy");
                labelSalary.Text = $"{reader["Salary"].ToString()} ₼";
                labelCateg.Text = reader["Category"].ToString();
                LabelGender.Text = reader["Gender"].ToString();
                labelEdu.Text= reader["Education"].ToString();
                labelPhone.Text=reader["Number"].ToString();
                labelEmail.Text= reader["Email"].ToString();
                txtAddİnfo.Text= reader["Information"].ToString();
            labelCompany.Text = reader["Company"].ToString(); 
                txtRequirements.Text = reader["Requirements"].ToString();
                subLabel.Text = reader["Sub Category"].ToString();
               

            };
        }
    }
}
