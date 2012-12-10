using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ExamProgLibrary
{
    public class RecipientsInfo
    {
        private int _recipientID=0;
        private string _recipientName = "";
    
        public int RecipientID
        {
            get
            {
                return _recipientID;
            }
            set
            {
                _recipientID = value;
            }
        }
        public string RecipientName
        {
            get
            {
                return _recipientName;
            }
            set
            {
                _recipientName = value;
            }
        }

        public void InsertNewRecipient()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "InsertRecipients";

            cm.Parameters.Add(new SqlParameter("@RecipientName", _recipientName));

            cm.ExecuteNonQuery();
        }
        public void DeleteRecipient()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "DeleteRecipients";

            cm.Parameters.Add(new SqlParameter("@RecipientID", _recipientID));

            cm.ExecuteNonQuery();
        }
        public void UpdateRecipient()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "UpdateRecipients";

            cm.Parameters.Add(new SqlParameter("@RecipientID", _recipientID));
            cm.Parameters.Add(new SqlParameter("@RecipientName", _recipientName));

            cm.ExecuteNonQuery();
        }
        public void GetRecipient(int recipientID)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
            cn.Open();

            SqlCommand cm = cn.CreateCommand();
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "SelectOneRecipient";

            cm.Parameters.Add(new SqlParameter("@RecipientID", recipientID));

            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                _recipientName = dr["RecipientName"].ToString();
            }
        }
    }
}
