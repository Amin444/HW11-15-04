using System;
using System.Data;
using System.Data.SqlClient;

namespace conecting_with_C_
{
    class Program
    {
        static void Main()
        {
            System.Console.WriteLine("Введите: 1-'Insert', 3-' Select All', 4-'Select by id', 5-'Update', 6-'Delete'   ");
           int count=int.Parse(Console.ReadLine());
            const string constring = @"data sourse=localhost; initial catalog=Person; integrated security=true";
            SqlConnection connetion = new SqlConnection(constring);
            connetion.Open();
            if (count==1)
            {
                Select();
            }
        }
            static void Select(SqlConnection conn)
            {
                conn.Open();
                SqlCommand Sel=new SqlCommand();
                sel=$"Select *from Person";
                SqlDataReader reader=conn.ExecuteReader();
                 while (reader.Read())
            {
                System.Console.WriteLine($"ID:{reader.GetValue(0)},Name:{reader.GetValue(1)},SurName:{reader.GetValue(2)},MiddleName:{reader.GetValue(3)},BirthDate:{reader.GetValue(4)}");
            }
            conn.Close();
        }
      
    }

 }
         
          


