using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AssignmentsManager
{
    public class DBManager
    {
        //connection to sql server
        private SqlConnection bitdevConnection;
        private ListBox output;

        public DBManager(ListBox output)
        {
            this.output = output;

            //settings to connect to bitdev server
            bitdevConnection = new SqlConnection();
            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = IN700001_201601_PAFFJJ1;" +
                                                "User ID = paffjj1;" +
                                                "Password =  JPa_913F;";
            CreateTables();
            PopulateTables();
        }

        public void CreateTables(){

            bitdevConnection.Open();

            //creates tables
            String createQuery = "IF OBJECT_ID('tblAssignment') IS NOT NULL DROP TABLE tblAssignment; " +
                                 "IF OBJECT_ID('tblPaper') IS NOT NULL DROP TABLE tblPaper; " +
                                 "IF OBJECT_ID('tblTutor') IS NOT NULL DROP TABLE tblTutor; " + 

                                 "CREATE TABLE tblTutor (" +
                                 "tutorID	int			IDENTITY," +
	                             "name	    char(30)	NOT NULL," +
	                             "email	    char(40)	NULL," +
	                             "CONSTRAINT PK_tblTutor PRIMARY KEY(tutorID))" +
                                 "CREATE TABLE tblPaper (" +
	                             "paperID		int		IDENTITY," +
	                             "tutorID		int		NOT NULL," +
	                             "name	    char(30)	NOT NULL," +
	                             "CONSTRAINT PK_tblPaper PRIMARY KEY(paperID)," +
                                 "CONSTRAINT FK_Tutor_Paper	FOREIGN KEY(tutorID) REFERENCES tblTutor(tutorID))" +
                                 "CREATE TABLE tblAssignment (" +
	                             "assignmentID    int		IDENTITY," +
	                             "paperID		int		    NOT NULL," +
	                             "name	    char(30)	NOT NULL," +
                                 "mark	    int	        NULL," +
	                             "dueDate	    date	    NOT NULL," +
	                             "CONSTRAINT PK_tblAssignment PRIMARY KEY(assignmentID)," +
	                             "CONSTRAINT FK_Paper_Assignment	FOREIGN KEY(paperID) REFERENCES tblPaper(paperID))";

            
            //runs commands   
            SqlCommand createTables = new SqlCommand(createQuery, bitdevConnection);
            createTables.ExecuteNonQuery();  
            bitdevConnection.Close();
        }

        public void PopulateTables(){

            bitdevConnection.Open();

             //populates tables with data
            String insertQuery = "INSERT INTO tblTutor VALUES('Patricia haden','example@bit.nz');" +
                                 "INSERT INTO tblTutor VALUES('Tom Clark','example2@bit.nz');" +
                                 "INSERT INTO tblPaper VALUES(1,'OOSD');" +
                                 "INSERT INTO tblPaper VALUES(1,'Mobile');" +
                                 "INSERT INTO tblPaper VALUES(2,'Security');" +
                                 "INSERT INTO tblPaper VALUES(2,'Project');" +
                                 "INSERT INTO tblAssignment VALUES(1, 'Gray Scott Simulation', 99, '20160505');" +
                                 "INSERT INTO tblAssignment VALUES(1, 'Assignment2', NULL, '20160605');" +
                                 "INSERT INTO tblAssignment VALUES(2, 'Assignment1', NULL, '20160605');" +
                                 "INSERT INTO tblAssignment VALUES(2, 'Assignment2', NULL, '20160616');" +
                                 "INSERT INTO tblAssignment VALUES(3, 'Hack the Pentagon', 99, '20160406');" +
                                 "INSERT INTO tblAssignment VALUES(4, 'Sprint3', NULL, '20160513');";

            //runs command
            SqlCommand populateTables = new SqlCommand(insertQuery, bitdevConnection);
            populateTables.ExecuteNonQuery();
            bitdevConnection.Close();
        }


        public void QueryDatabase()
        {
            output.Items.Clear();
            bitdevConnection.Open();

            String query = "";
            SqlCommand createTables = new SqlCommand(query, bitdevConnection);
            SqlDataReader reader = createTables.ExecuteReader();

            while (reader.Read())
            {
                output.Items.Add(reader["id"].ToString());
            }

            reader.Close();
            bitdevConnection.Close();

        }

        public void ShowPapers()
        {
            output.Items.Clear();
            bitdevConnection.Open();

            //query gets paper name, tutor name and tutor email
            String query = "SELECT p.name, t.name as tname, t.email " +
                           "FROM dbo.tblPaper p, dbo.tblTutor t " +
                           "WHERE p.tutorID = t.tutorID";

            SqlCommand allPapers = new SqlCommand(query, bitdevConnection);
            SqlDataReader reader = allPapers.ExecuteReader();

            while (reader.Read())
            {
                String name = reader["name"].ToString();
                String tname = reader["tname"].ToString();
                String email = reader["email"].ToString();
                output.Items.Add(name + "\t" + tname + "\t" + email);               
            }

            reader.Close();
            bitdevConnection.Close();

        }

        public void ShowAssignments()
        {
            output.Items.Clear();

            bitdevConnection.Open();

            //query gets assn name, paper name and due date
            String query = "SELECT a.name, a.dueDate, p.name as paper " +
                           "FROM dbo.tblAssignment a, dbo.tblPaper p " +
                           "WHERE a.dueDate > getdate() and a.dueDate < dateadd(day,14,getdate()) and a.paperID = p.paperID";

            SqlCommand allPapers = new SqlCommand(query, bitdevConnection);
            SqlDataReader reader = allPapers.ExecuteReader();

            while (reader.Read())
            {
                String name = reader["name"].ToString();
                String paper = reader["paper"].ToString();
                String date = reader["dueDate"].ToString();
                output.Items.Add(name + "\t" + paper + "\t" + date);
            }

            reader.Close();
            bitdevConnection.Close();

        }

        public void ShowAverageMark()
        {
            output.Items.Clear();

            bitdevConnection.Open();

            //query gets assn name, paper name and due date
            String query = "SELECT a.name, a.mark, a.dueDate, p.name as paper " +
                           "FROM dbo.tblAssignment a, dbo.tblPaper p " +
                           "WHERE a.dueDate < getdate() and a.paperID = p.paperID";

            SqlCommand allPapers = new SqlCommand(query, bitdevConnection);
            SqlDataReader reader = allPapers.ExecuteReader();

            while (reader.Read())
            {
                String name = reader["name"].ToString();
                String paper = reader["paper"].ToString();
                String date = reader["dueDate"].ToString();
                String mark = reader["mark"].ToString();
                output.Items.Add(name + "\t" + paper + "\t" + mark + "\t" + date);
            }

            reader.Close();
            bitdevConnection.Close();

        }
    }
}
