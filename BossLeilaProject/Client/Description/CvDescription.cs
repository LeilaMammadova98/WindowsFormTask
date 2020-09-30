using BossLeilaProject.AppCode.Data_Source;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BossLeilaProject.Client.Description
{
    public partial class CvDescription : Form
    {
        readonly BossDataSet.VwCvRow cvAdd;
        readonly int id;
        const string cString = @"Data Source=sql5063.site4now.net;Initial Catalog=DB_A50752_programming;Persist Security Info=True;User ID=DB_A50752_programming_admin;Password=code2020_devs";
        public CvDescription()
        {       
            InitializeComponent();

            
        }
        public CvDescription(int id)
            :this()
        {

            this.id = id;


        }

        private void CvDescription_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(cString);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = $@"SELECT [Id]
      ,[Name]
      ,[SurName]
      ,[FatherName]
      ,[Number]
      ,[Email]
      ,[EduInformation]
      ,[ExperienceInformation]
      ,[SkillsInformation]
      ,[AdditionalInformation]
      ,[startDate]
      ,[FinishDate]
      ,[MinSalary]
      ,[CreatedDate]
      ,[CreatedUserId]
      ,[UpdatedDate]
      ,[UpdatedUserId]
      ,[DeletedDate]
      ,[DeletedUserId]
      ,[Gender]
      ,[CityId]
      ,[CategoriesId]
      ,[EducationId]
      ,[ExperienceId]
      ,[SubCategryId]
      ,[Age]
      ,[Education]
      ,[Experience]
      ,[City]
      ,[Category]
      ,[Sub Category],
[Language] FROM BossLeila.VwCv WHERE (Id = {id})";

            cmd.Connection = conn;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                labelNameSurFath.Text = $"{reader["Name"].ToString()} { reader["SurName"].ToString()} { reader["FatherName"].ToString()}";
                labelCity.Text = reader["City"].ToString();
                labelPhone.Text = reader["Number"].ToString();
                labelNameSurname.Text = reader["Name"].ToString() + reader["SurName"].ToString();
                LabelAge.Text = reader["Age"].ToString();
                labelStart.Text = ((DateTime)(reader["startDate"])).ToString("dd.MM.yyyy");
                labelEnd.Text = ((DateTime)(reader["FinishDate"])).ToString("dd.MM.yyyy");
                labelCateg.Text = reader["Category"].ToString();
                LabelGender.Text = reader["Gender"].ToString();
                subLabel.Text=reader["Sub Category"].ToString();
                txtSkills.Text = reader["SkillsInformation"].ToString();
                txtEdu.Text = $"{reader["Education"].ToString()}{Environment.NewLine} {reader["EduInformation"].ToString()}";
                txtExperience.Text = $"{reader["Experience"].ToString()}{Environment.NewLine}{reader["ExperienceInformation"].ToString()}";
                labelEmail.Text= reader["Email"].ToString();
            };
                
                }
    } 
}
