namespace infass_Jimenez_A1.Models
{
    public class Crud
    {
        public string Insert(string tblName, string[] fld, object[] val)
        {
            //INSERT INTO User (Name, Age, Gender) VALUES ('Hazzel', 21, 'Female');

            // Dynamic Table Name
            string sql = $"INSERT INTO {tblName} ("; 

            // Dynamic Table Fields
            for (int i = 0; i < fld.Length; i++)
            {
                sql += fld[i]; // Inserting Table Fields

                if (i < fld.Length - 1) // Preventing adding comma (,) after sa end sa field
                {
                    sql += ", "; // Adding commas after each table fields
                }
            }

            sql += ") \nVALUES (";

            // Dynamic Table Values
            for(int j = 0; j < val.Length; j++)
            {
                if (val[j] is string || val[j] is char)
                {
                    sql += $"\'{val[j]}\'"; // Adding quotations ("") is the value is string or character
                }
                else
                {
                    sql += val[j]; // No quotation ("") if the value is int, float, etc.
                }
                if(j < val.Length - 1) // Preventing adding comma (,) after sa end sa value
                {
                    sql += ", ";
                }
            }

            sql += ");";


            return sql;
        }

        public string SelectAll(string tblName)
        {
            // SELECT * FROM User

            string sql = $"SELECT * FROM {tblName}"; // Dynamic Table Name

            return sql;
        }
    }
}
