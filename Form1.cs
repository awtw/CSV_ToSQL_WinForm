using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Data.SQLite;
using CsvHelper;

namespace CsvToSql
{

    public partial class Form1 : Form
    {
        public string FileName { get; set; }
        public int InesrtInformation { get; set; }

        public List<TemperatureRecord> TemperatureRecords { get; set; }
      
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable ReadCsv(string fileName)
        {
            DataTable dt = new DataTable("Data");
            var connectionString = string.Format(
            @"Provider=Microsoft.Jet.OleDb.4.0; Data Source={0};Extended Properties=""Text;HDR=YES;FMT=Delimited""",
            Path.GetDirectoryName(fileName));

            using (var cn = new OleDbConnection(connectionString))
            {
                var commandString = $"select* from {new FileInfo(fileName).Name}";
                using (var cmd = new OleDbCommand(commandString, cn))
                {
                    cn.Open();
                    using (var adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;

        }

        private void Open_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (var ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                   
                    if (ofd.ShowDialog() == DialogResult.OK)
                        dataGridView1.DataSource = ReadCsv(ofd.FileName);
                        FileName = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var temp = new TemperatureRecord();
            temp.DateTime = DateTime.Now;

            dynamic obj = GetObject();
            var time = obj.LastDateTime;

            var records = new List<dynamic>();
            var temp1 = records[0].時間;
        }

        private object GetObject()
        {
            return new TemperatureRecord();
        }

        private void Inesrt_Click(object sender, EventArgs e)
        {
            Database databaseObject = new Database();
            var query = "INSERT INTO temperature (`time`, `first`, `second`, `third`, `fourth`, `fifth`, `sixth`) VALUES (@time, @first, @second, @third, @fourth, @fifth, @sixth)";
            var myCommand = new SQLiteCommand(query, databaseObject.myConnection);
            databaseObject.OpenConnection();
            var csvPath = FileName;
            var file = new System.IO.StreamReader(csvPath);
            var cutFirstLine = file.ReadLine();
            string line;
            while ((line = file.ReadLine()) != null)
            {
                var content = line.Split(',');
                try
                {
                    myCommand.Parameters.AddWithValue("@time", content[0]);
                    myCommand.Parameters.AddWithValue("@first", content[1]);
                    myCommand.Parameters.AddWithValue("@second", content[2]);
                    myCommand.Parameters.AddWithValue("@third", content[3]);
                    myCommand.Parameters.AddWithValue("@fourth", content[4]);
                    myCommand.Parameters.AddWithValue("@fifth", content[5]);
                    myCommand.Parameters.AddWithValue("@sixth", content[6]);
                    var result = myCommand.ExecuteNonQuery();
                    InesrtInformation = result;

                }
                catch 
                {
                    //MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
           if(InesrtInformation != 1)
             MessageBox.Show("Something Wrong", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Insert Complete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            databaseObject.CloseConnection();
        }

        private void database_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.ClearSelection();
            Database databaseObject = new Database();
            var seletQuery = "select * from temperature";
            var myCommand = new SQLiteCommand(seletQuery, databaseObject.myConnection);
            var myAdapter = new SQLiteDataAdapter(myCommand);
            databaseObject.OpenConnection();
            myAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

           
     
           
            databaseObject.CloseConnection();
        }
    }
}
