using System;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium;
using SpecFlowDemo.PageObjects;
using TechTalk.SpecFlow;
using NUnit.Framework;
//using System.Data.SqlClient;
//using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SpecFlowDemo
{
    [Binding]
    public class LinksFromTheLoginPageStepDefinitions
    {
        MySql.Data.MySqlClient.MySqlConnection conn1;
        MySql.Data.MySqlClient.MySqlConnection conn2;
        List<List<String>> firstDataResults = new List<List<String>>();
        List<List<String>> secondDataResults = new List<List<String>>();


        [Given(@"I connect to DB")]
        public void GivenIConnectToDB()
        {

            //MySql.Data.MySqlClient.MySqlConnection conn1;
     
            //String vConnectionString1 = "server=sql8.freemysqlhosting.net;uid=sql8508962;pwd=BnQYM4eJGN;database=sql8508962";

           
            //try
            //{
            //    conn = new MySql.Data.MySqlClient.MySqlConnection();
            //    conn.ConnectionString = vConnectionString1;
            //    conn.Open();
            //    string sql = "SELECT * FROM Users";
            //    MySqlCommand cmd = new MySqlCommand(sql, conn);
            //    MySqlDataReader rdr = cmd.ExecuteReader();

            //    var ll = new List<List<String>>(); 

            //    while (rdr.Read())
            //    {
            //        var l = new List<String>();
            //        l.Add(rdr[0].ToString());
            //        l.Add(rdr[1].ToString());
            //        l.Add(rdr[2].ToString());
            //        l.Add(rdr[3].ToString());

            //        //Console.WriteLine(rdr[0] + " -- " + rdr[1]);
            //        ll.Add(l);
            //    }
            //    Console.WriteLine(ll);
            //    rdr.Close();
            //}
            //catch (MySql.Data.MySqlClient.MySqlException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}



   

        }

        [Given(@"I connect to First DB")]
        public void GivenIConnectToFirstDB()
        {
            
            String vConnectionString1 = "server=sql8.freemysqlhosting.net;uid=sql8508962;pwd=BnQYM4eJGN;database=sql8508962";
            try
            {
                conn1 = new MySql.Data.MySqlClient.MySqlConnection();
                conn1.ConnectionString = vConnectionString1;
                conn1.Open();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        [When(@"I fetch first results and save")]
        public void WhenIFetchFirstResultsAndSave()
        {
            string sql = "SELECT * FROM Users";
            MySqlCommand cmd = new MySqlCommand(sql, conn1);
            MySqlDataReader rdr = cmd.ExecuteReader();

            firstDataResults = new List<List<String>>();

            while (rdr.Read())
            {
                var l = new List<String>();
                l.Add(rdr[0].ToString());
                l.Add(rdr[1].ToString() +" "+ rdr[2].ToString());
                l.Add(rdr[3].ToString());
                l.Add(rdr[4].ToString());
                firstDataResults.Add(l);
            }
            
            rdr.Close();

        }

        [When(@"I connect to Second DB")]
        public void WhenIConnectToSecondDB()
        {
            String vConnectionString2 = "server=sql8.freemysqlhosting.net;uid=sql8508979;pwd=ribsJ62Nxd;database=sql8508979";
            try
            {
                conn2 = new MySql.Data.MySqlClient.MySqlConnection();
                conn2.ConnectionString = vConnectionString2;
                conn2.Open();

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        [When(@"I fetch second results and save")]
        public void WhenIFetchSecondResultsAndSave()
        {
            string sql = "SELECT * FROM Users";
            MySqlCommand cmd = new MySqlCommand(sql, conn2);
            MySqlDataReader rdr = cmd.ExecuteReader();

            secondDataResults = new List<List<String>>();

            while (rdr.Read())
            {
                var l = new List<String>();
                l.Add(rdr[0].ToString());
                l.Add(rdr[1].ToString());
                l.Add(rdr[2].ToString());
                l.Add(rdr[3].ToString());
               

                //Console.WriteLine(rdr[0] + " -- " + rdr[1]);
               secondDataResults.Add(l);
            }
   
            rdr.Close();
        }

        [Then(@"compare boths results")]
        public void ThenCompareBothsResults()
        {
            //compare count
            Assert.AreEqual(firstDataResults.Count, secondDataResults.Count);
            //using for loop
            for (int i = 0; i < firstDataResults.Count; i++)
            {
                
                for (int j = 0; j < firstDataResults[i].Count; j++)
                {
                    Console.WriteLine("Comparing "+firstDataResults[i][j]+" and "+secondDataResults[i][j]);
                    Assert.AreEqual(firstDataResults[i][j], secondDataResults[i][j]);
                }
            }
        
        }


    }
}
