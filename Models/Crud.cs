namespace infass_Jimenez_A1.Models
{
    public class Crud
    {
        public string Insert(string tblName, string[] fld, object[] val)
        {
            //INSERT INTO User (Name, Age, Gender) VALUES ('Hazzel', 21, 'Female');

            string sql = $"INSERT INTO {tblName} ("; 

            for (int i = 0; i < fld.Length; i++)
            {
                sql += fld[i];

                if(i < fld.Length - 1)
                {
                    sql += ", ";
                }
            }

            sql += ") \nVALUES (";

            for(int j = 0; j < val.Length; j++)
            {
                if (val[j] is string)
                {
                    sql += $"\'{val[j]}\'";
                }
                else
                {
                    sql += val[j];
                }
                if(j < val.Length - 1)
                {
                    sql += ", ";
                }
            }

            sql += ");";


            return sql;
        }

        public string SelectAll(string tblName)
        {
            string sql = $"SELECT * FROM {tblName}";

            return sql;
        }
    }
}
