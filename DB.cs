using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;

namespace FEAManager
{

    // TODO: INCLUDE STUDENT/ADMIN/FORM... CLASS RETRIEVAL
    class DB
    {
        private OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = FEAManager_DB.accdb");

        public List<Dictionary<string, string>> selectQuery(string strTable, int attributesLength, string strConditional, Dictionary<string, string> dictAttributes)
        {
            int affectedRows;
            string sqlSelect;
            OleDbCommand command;
            OleDbDataReader reader;
            Type dataType;

            List <Dictionary<string, string>> resultSet = new List<Dictionary<string, string>>();
            Dictionary<string, string> tempDictionary;
            sqlSelect = "SELECT * FROM " + strTable + " " + strConditional;

            command = formCommand(sqlSelect, dictAttributes);

            con.Open();
            MessageBox.Show(command.CommandText);
            reader = command.ExecuteReader();
            
            // read result
            while (reader.Read())
            {

                tempDictionary = new Dictionary<string, string>();

                for (int columnDex = 0; columnDex < attributesLength; ++columnDex)
                {
                    dataType = reader.GetFieldType(columnDex);

                    if (dataType == typeof(String))
                    {
                        tempDictionary.Add(reader.GetName(columnDex), reader.GetString(columnDex));
                    }
                    else if (dataType == typeof(DateTime))
                    {
                        tempDictionary.Add(reader.GetName(columnDex), reader.GetDateTime(columnDex).ToString());
                    }
                    else if (dataType == typeof(Int32))
                    {
                        tempDictionary.Add(reader.GetName(columnDex), reader.GetInt32(columnDex).ToString());
                    }
                }

                resultSet.Add(tempDictionary);
            }

            return resultSet;
        }
        /**
         * Inserts a record into the prescribed database
         */
        public void insertQuery(string strTable, string strParams, Dictionary<string, string> dictAttributes)
        {
            int affectedRows;
            string sqlIinsert;
            

            sqlIinsert = "INSERT INTO " + strTable + " VALUES " + strParams;

            affectedRows = executeSQL(sqlIinsert, dictAttributes);

            MessageBox.Show("INSERT COMPLETE! Affected rows: " + affectedRows);
        }


        public void updateQuery(string strTable, string strParams, string strConditional, Dictionary<string, string> dictAttributes)
        {
            int affectedRows;
            string sqlUpdate;

            sqlUpdate = "UPDATE " + strTable + " SET " + strParams + " " + strConditional;

            affectedRows = executeSQL(sqlUpdate, dictAttributes);

            MessageBox.Show("UPDATE COMPLETE! Affected rows: " + affectedRows);
        }

        public void deleteQuery(string strTable, string strConditional, Dictionary<string, string> dictAttributes)
        {
            int affectedRows;
            string sqlUpdate;

            sqlUpdate = "DELETE FROM " + strTable + " " + strConditional;

            affectedRows = executeSQL(sqlUpdate, dictAttributes);

            MessageBox.Show("DELETE COMPLETE! Affected rows: " + affectedRows);
        }

        /**
         * Executes the given SQL statement
         */
        private int executeSQL(string sqlQuery, Dictionary<string, string> dictAttributes)
        {
            int affectedRows;
            OleDbCommand cmd;

            cmd = formCommand(sqlQuery, dictAttributes);

            con.Open();

            //
            MessageBox.Show(cmd.CommandText);

            affectedRows = cmd.ExecuteNonQuery();

            con.Close();

            return affectedRows;
        }

        /**
         * Forms the sqlQuery to be executed
         */
        private OleDbCommand formCommand(string sqlString, Dictionary<string, string> dictAttributes)
        {
            OleDbCommand command = new OleDbCommand(sqlString, con);

            foreach (KeyValuePair<string, string> attribute in dictAttributes)
            {
                command.Parameters.AddWithValue(attribute.Key, attribute.Value);
            }

            return command;
        }
    }
}
