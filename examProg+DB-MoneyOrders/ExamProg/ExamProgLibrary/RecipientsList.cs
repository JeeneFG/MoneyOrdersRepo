using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ExamProgLibrary
{
   public class RecipientsList : List<RecipientsInfo>
    {
       public static RecipientsList GetDefaultRecipientsList()
       {
           RecipientsList _recipientsList = new RecipientsList();
           SqlConnection cn = new SqlConnection();
           cn.ConnectionString = DefaultConnectionStringSQL.DefaultConnection();
           cn.Open();

           SqlCommand cm = cn.CreateCommand();
           cm.CommandType = CommandType.StoredProcedure;
           cm.CommandText = "SelectRecipients";

           SqlDataReader dr = cm.ExecuteReader();
           while (dr.Read())
           {
               RecipientsInfo newRecipient = new RecipientsInfo();

               newRecipient.RecipientID = int.Parse(dr["RecipientID"].ToString());
               newRecipient.RecipientName = dr["RecipientName"].ToString();

               _recipientsList.Add(newRecipient);

           }

           return _recipientsList;
       }
    }
}
